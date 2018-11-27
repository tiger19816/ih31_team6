using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sugukuru.Purchase
{
    public partial class FixedPostProcessing : FormMaster.UserControlMinMST
    {
        // 受注番号
        string orderId;

        // 担当者番号
        string repId;　// .selected.value

        // 支払い状況
        // 1:支払い済み 0:未支払い
        int paymentStatus;

        // 車両登録状況
        // 1:登録ナンバー付き 0:なし
        int vehicleRegistrationStatus;

        // 支払期限
        string paymentDue;

        // 手続内容
        // 1:移転登録 0:抹消登録
        int procedureContent;

        // 報告期限
        string reportDeadline;

        // 報告完了日付
        string reportCompleteDate;

        // オークション会社に伝達完了
        // 1:チェック 0:未チェック
        int procedureFlag;
        string conStr;
        string sql;
        DataSet documentDset;
        MySqlCommand cmd;

        // 登録ナンバー付きの場合に必要な書類が入るリスト
        List<string> list1;
        // 登録ナンバーなしの場合に必要な書類が入るリスト
        List<string> list2;
        // 受領済み書類を入れるリスト
        List<string> list3;
        // 受領していない書類を入れるリスト
        string[] list4;


        public FixedPostProcessing()
        {
            InitializeComponent();
            Utility.ResponsibleList.setSales(comboBox1);
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        // Formロード時の処理
        private void FixedPostProcessing_Load(object sender, EventArgs e)
        {
            list1 = new List<string>();
            list2 = new List<string>();

            // 登録ナンバー付きの場合に必要な書類を取得
            this.sql = "SELECT name FROM `document` WHERE `category` = 0 OR `category`= 1";

            // データをDBへ追加する
            //抽象データ格納データセットを作成
            documentDset = new DataSet("list1");

            // DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            // DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(documentDset, "list1");

            //DB切断
            con.Close();

            for(int i=0;i < documentDset.Tables["list1"].Rows.Count;i++)
            {
                list1.Add(documentDset.Tables["list1"].Rows[i]["name"].ToString());
            }

            // 登録ナンバー付きの場合に必要な書類を取得
            this.sql = "SELECT name FROM `document` WHERE `category` = 0 OR `category`= 2";

            // データをDBへ追加する
            //抽象データ格納データセットを作成
            documentDset = new DataSet("list2");

            // DB接続オブジェクトを作成
            con = new MySqlConnection(this.conStr);

            // DB接続
            con.Open();

            //データアダプターの生成
            mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(documentDset, "list2");

            //DB切断
            con.Close();

            for (int i = 0; i < documentDset.Tables["list2"].Rows.Count; i++)
            {
                list2.Add(documentDset.Tables["list2"].Rows[i]["name"].ToString());
            }

            checkedListBox1.Items.AddRange(list1.ToArray());
        }

        // 受注に対して必要な書類と受領済み書類を返す。
        private void getDocument(string _orderID)
        {
            // 受領済み書類を入れるリスト
            list3 = new List<string>();

            string sql = "SELECT `vehicle_registration_status` FROM `procedure_after_successful_bid` WHERE `order_id` = '"+_orderID+"'";
            Console.WriteLine(sql);

            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("vehicleRegistrationStatus");

            // DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            // DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "vehicleRegistrationStatus");

            //DB切断
            con.Close();

            // 車両のステータスを入れる（登録済みかどうか）
            int status = int.Parse(dset.Tables["vehicleRegistrationStatus"].Rows[0]["vehicle_registration_status"].ToString());

            // 受領済み書類を取得
            sql = "SELECT d.name FROM recieved_document r" +
                " INNER JOIN document d ON d.id = r.document_id" +
                " WHERE r.order_id = '"+_orderID+"'";

            // データをDBへ追加する
            //抽象データ格納データセットを作成
            dset = new DataSet("recievedDocument");

            // DB接続オブジェクトを作成
            con = new MySqlConnection(this.conStr);

            // DB接続
            con.Open();

            //データアダプターの生成
            mAdp = new MySqlDataAdapter(sql, con);

            //データ抽出＆取得
            mAdp.Fill(dset, "recievedDocument");

            //DB切断
            con.Close();

            for (int i = 0; i < dset.Tables["recievedDocument"].Rows.Count; i++)
            {
                list3.Add(dset.Tables["recievedDocument"].Rows[i]["name"].ToString());
            }

            // 車両のステータスを比較（登録済みかどうか）
            if (status == 1)
            {
                // 受領していない書類を入れるリスト
                list4 = list1.Except(list3).ToArray();
            }
            else
            {
                // 受領していない書類を入れるリスト
                list4 = list2.Except(list3).ToArray();
            }
        }

        // 検索ボタンが押された処理
        private void button9_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            OrderSelectForm selectFM = new OrderSelectForm();
            selectFM.ShowDialog();
            selectFM.Dispose();
            this.Show();

            //子フォームで選択ボタンが押された場合の処理
            if (selectFM.SelectFlg)
            {
                //子フォームからの返り値(DataRow)
                DataRow selectRow = selectFM.Order.getDataRow();
                textBox2.Text = selectRow["id"].ToString();

                this.sql = "SELECT * FROM `procedure_after_successful_bid` WHERE `order_id` = '"+textBox2.Text+"'";

                // データをDBへ追加する
                //抽象データ格納データセットを作成
                DataSet dset = new DataSet("FixedPostProcessing");

                // DB接続オブジェクトを作成
                MySqlConnection con = new MySqlConnection(this.conStr);

                // DB接続
                con.Open();

                //データアダプターの生成
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

                ///データ抽出＆取得
                mAdp.Fill(dset, "FixedPostProcessing");

                //DB切断
                con.Close();

                //抽出件数を取得
                int rcnt = dset.Tables["FixedPostProcessing"].Rows.Count;

                this.sql = "SELECT document_id FROM `recieved_document` WHERE `order_id` = '"+textBox2.Text+"'";

                // データをDBへ追加する
                //抽象データ格納データセットを作成
                DataSet recievedDocumentDset = new DataSet("recievedDocument");

                // DB接続オブジェクトを作成
                con = new MySqlConnection(this.conStr);

                // DB接続
                con.Open();

                //データアダプターの生成
                mAdp = new MySqlDataAdapter(sql, con);

                //データ抽出＆取得
                mAdp.Fill(recievedDocumentDset, "recievedDocument");

                //DB切断
                con.Close();

                //行が存在しているかの確認  
                if (rcnt != 0)
                {
                    // 支払いが未払いの場合true
                    if(int.Parse(dset.Tables["FixedPostProcessing"].Rows[0]["payment_status"].ToString()) == 0)
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }

                    // 支払期限をセット
                    dateTimePicker1.Text = dset.Tables["FixedPostProcessing"].Rows[0]["payment_due"].ToString();

                    // 担当者をセット
                    Utility.ResponsibleList.SelectFromValue(comboBox1, dset.Tables["FixedPostProcessing"].Rows[0]["rep_id"].ToString());

                    // 登録ナンバーが付いている場合true
                    if (int.Parse(dset.Tables["FixedPostProcessing"].Rows[0]["vehicle_registration_status"].ToString()) == 1)
                    {
                        // 移転登録にセット
                        radioButton4.Checked = true;

                        //　移転登録の場合true
                        if(int.Parse(dset.Tables["FixedPostProcessing"].Rows[0]["procedure_content"].ToString()) == 1)
                        {
                            radioButton6.Checked = true;
                        }
                        else
                        {
                            radioButton5.Checked = true;
                        }

                        // 報告期限をセット
                        dateTimePicker2.Text = dset.Tables["FixedPostProcessing"].Rows[0]["report_deadline"].ToString();

                        // 報告完了日付をセット
                        dateTimePicker3.Text = dset.Tables["FixedPostProcessing"].Rows[0]["report_complete_date"].ToString();

                        //　移転登録の場合true
                        if (int.Parse(dset.Tables["FixedPostProcessing"].Rows[0]["procedure_flag"].ToString()) == 1)
                        {
                            checkBox1.Checked = true;
                        }
                        else
                        {
                            radioButton5.Checked = false;
                        }

                        getDocument(textBox2.Text);
                        checkedListBox1.Items.AddRange(list4);
                        checkedListBox2.Items.AddRange(list3.ToArray());
                    }
                    else
                    {
                        // ナンバー登録なし
                        radioButton3.Checked = true;
                        getDocument(textBox2.Text);
                        checkedListBox1.Items.AddRange(list4);
                        checkedListBox2.Items.AddRange(list3.ToArray());
                    }
                }
                else
                {
                    radioButton1.Checked = true;
                    radioButton4.Checked = true;
                    radioButton6.Checked = true;
                    checkBox1.Checked = false;
                    dateTimePicker1.Text = "";
                    dateTimePicker2.Text = "";
                    dateTimePicker3.Text = "";
                    checkedListBox1.Items.Clear();
                    checkedListBox2.Items.Clear();
                    for (int i = 0; i < list1.Count; i++)
                    {
                        checkedListBox1.Items.Add(list1[i]);
                    }
                }
            }
        }

        // 車両登録状況の登録ナンバー付にチェックが入ったら手続き内容を入力可にする
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            for (int i = 0; i < list1.Count; i++)
            {
                checkedListBox1.Items.Add(list1[i]);
            }
        }

        // 車両登録状況のなしにチェックが入ったら手続き内容を入力可にする
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            for (int i = 0; i < list2.Count; i++)
            {
                checkedListBox1.Items.Add(list2[i]);
            }
        }

        // 確定ボタンが押された時の処理
        private void button1_Click(object sender, EventArgs e)
        {
            // 受注番号のセット
            orderId = textBox2.Text;
            int documentID = 0;

            this.sql = "SELECT * FROM `procedure_after_successful_bid` WHERE order_id = '"+orderId+"'";

            // データをDBへ追加する
            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("Count");

            // DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            // DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "Count");

            //DB切断
            con.Close();

            //抽出件数を取得
            int rcnt = dset.Tables["Count"].Rows.Count;

            //行が存在している場合はその行削除
            if (rcnt != 0)
            {
                this.sql = "DELETE FROM `procedure_after_successful_bid` WHERE `procedure_after_successful_bid`.`order_id` = '"+orderId+"'";
                
                // DB接続
                con.Open();

                // SQL発行準備
                cmd = new MySqlCommand(sql, con);

                // SQLの実行
                cmd.ExecuteNonQuery();

                // DB切断
                con.Close();
            }

            // 担当者のセット
            repId = comboBox1.SelectedValue.ToString();
            // 支払期限のセット
            paymentDue = dateTimePicker1.Value.ToShortDateString();
           
            // 支払いが済んでいる場合true
            if (radioButton2.Checked)
            {
                // 支払い状況のセット
                paymentStatus = 1;
            }
            else
            {
                // 支払い状況のセット
                paymentStatus = 0;
            }

            // 車両にナンバーが付いている場合true
            if (radioButton4.Checked)
            {
                // ナンバーの登録状況をセット
                vehicleRegistrationStatus = 1;

                // 移転登録の場合true
                if (radioButton6.Checked)
                {
                    // 移転登録のセット
                    procedureContent = 1;
                }
                else
                {
                    // 抹消登録のセット
                    procedureContent = 0;
                }

                // オークション会社に手続伝達が完了しているならtrue
                if (checkBox1.Checked)
                {
                    // 手続伝達完了
                    procedureFlag = 1;
                }
                else
                {
                    // 手続伝達未完了
                    procedureFlag = 0;
                }

                // 報告期限のセット
                reportDeadline = dateTimePicker2.Value.ToShortDateString();
                // 報告完了日付のセット
                reportCompleteDate = dateTimePicker3.Value.ToShortDateString();

                // SQL分を作成し、セットします
                this.sql = "INSERT INTO `procedure_after_successful_bid`(`order_id`, `rep_id`, `payment_status`, `payment_due`, `vehicle_registration_status`, `procedure_content`, `report_deadline`, `procedure_flag`, `report_complete_date`)" +
                           " VALUES('" + orderId + "','" + repId + "'," + paymentStatus + ",'" + paymentDue + "'," + vehicleRegistrationStatus + "," + procedureContent + ",'" + reportDeadline + "'," + procedureFlag + ",'" + reportCompleteDate + "')";
            }
            else
            {
                // ナンバーの登録状況をセット
                vehicleRegistrationStatus = 0;

                // SQL分を作成し、セットします
                this.sql = "INSERT INTO `procedure_after_successful_bid`(`order_id`, `rep_id`, `payment_status`, `payment_due`, `vehicle_registration_status`, `procedure_content`, `report_deadline`, `procedure_flag`, `report_complete_date`)" +
                           " VALUES('" + orderId + "','" + repId + "'," + paymentStatus + ",'" + paymentDue + "'," + vehicleRegistrationStatus + ",null,null,null,null)";
            }

            // DB接続
            con.Open();

            // SQL発行準備
            cmd = new MySqlCommand(sql, con);

            // SQLの実行
            cmd.ExecuteNonQuery();

            // DB切断
            con.Close();

            // 受領済書類を一度削除します。
            this.sql = "DELETE FROM recieved_document WHERE order_id = '"+orderId+"'";

            // DB接続
            con.Open();

            // SQL発行準備
            cmd = new MySqlCommand(sql, con);

            // SQLの実行
            cmd.ExecuteNonQuery();

            // DB切断
            con.Close();

            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, true);
            }
            foreach (string item in checkedListBox2.CheckedItems)
            {
                this.sql = "SELECT id FROM `document` WHERE name = '"+item+"'";

                // データをDBへ追加する
                //抽象データ格納データセットを作成
                dset = new DataSet("documentID");

                // DB接続オブジェクトを作成
                con = new MySqlConnection(this.conStr);

                // DB接続
                con.Open();

                //データアダプターの生成
                mAdp = new MySqlDataAdapter(sql, con);

                ///データ抽出＆取得
                mAdp.Fill(dset, "documentID");

                //DB切断
                con.Close();

                //抽出件数を取得
                rcnt = dset.Tables["documentID"].Rows.Count;

                if (rcnt != 0)
                {
                    documentID = int.Parse(dset.Tables["documentID"].Rows[0]["id"].ToString());
                    
                    this.sql = "INSERT INTO `recieved_document`(`order_id`, `document_id`) VALUES('"+orderId+"',"+documentID+")";

                    // DB接続
                    con.Open();

                    // SQL発行準備
                    cmd = new MySqlCommand(sql, con);

                    // SQLの実行
                    cmd.ExecuteNonQuery();

                    // DB切断
                    con.Close();
                }
            }

            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("処理内容を登録しました。",
            "質問",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            //何が選択されたか調べる
            if (result == DialogResult.OK)
            {
                textBox2.Text = "";
                radioButton1.Checked = true;
                radioButton4.Checked = true;
                radioButton6.Checked = true;
                checkBox1.Checked = false;
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                dateTimePicker3.Text = "";
                checkedListBox1.Items.Clear();
                checkedListBox2.Items.Clear();
                for (int i = 0; i < list1.Count; i++)
                {
                    checkedListBox1.Items.Add(list1[i]);
                }
            }
        }

        // 追加が押された時の処理
        private void button7_Click(object sender, EventArgs e)
        {
            List<string> document = new List<string>();            
            foreach (string item in checkedListBox1.CheckedItems)
            {
                checkedListBox2.Items.Add(item);
                document.Add(item);
            }
            string[] delDocument = document.ToArray();
            for(int i = 0; i < delDocument.Count(); i++)
            {
                checkedListBox1.Items.Remove(delDocument[i]);
            }
        }

        // 削除が押された時の処理
        private void button6_Click(object sender, EventArgs e)
        {
            List<string> document = new List<string>();
            foreach (string item in checkedListBox2.CheckedItems)
            {
                checkedListBox1.Items.Add(item);
                document.Add(item);
            }
            string[] delDocument = document.ToArray();
            for (int i = 0; i < delDocument.Count(); i++)
            {
                checkedListBox2.Items.Remove(delDocument[i]);
            }
        }

        // 一括追加が押された時の処理
        private void button8_Click(object sender, EventArgs e)
        {
            List<string> document = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            foreach (string item in checkedListBox1.CheckedItems)
            {
                checkedListBox2.Items.Add(item);
                document.Add(item);
            }
            string[] delDocument = document.ToArray();
            for (int i = 0; i < delDocument.Count(); i++)
            {
                checkedListBox1.Items.Remove(delDocument[i]);
            }
        }

        // 一括削除が押された時の処理
        private void button5_Click(object sender, EventArgs e)
        {
            List<string> document = new List<string>();
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, true);
            }
            foreach (string item in checkedListBox2.CheckedItems)
            {
                checkedListBox1.Items.Add(item);
                document.Add(item);
            }
            string[] delDocument = document.ToArray();
            for (int i = 0; i < delDocument.Count(); i++)
            {
                checkedListBox2.Items.Remove(delDocument[i]);
            }
        }
    }
}

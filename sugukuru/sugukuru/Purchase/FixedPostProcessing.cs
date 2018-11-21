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

        MySqlCommand cmd;

        public FixedPostProcessing()
        {
            InitializeComponent();
            Utility.ResponsibleList.setSales(comboBox1);
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        // Formロード時の処理
        private void FixedPostProcessing_Load(object sender, EventArgs e)
        {
            
        }

        // 検索ボタンが押された処理
        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "181110001";
            //Boolean flg = true;
            //if (flg)
            //{

            //}
        }

        // 車両登録状況の登録ナンバー付にチェックが入ったら手続き内容を入力可にする
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        // 車両登録状況のなしにチェックが入ったら手続き内容を入力可にする
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
        }

        // 確定ボタンが押された時の処理
        private void button1_Click(object sender, EventArgs e)
        {
            // 受注番号のセット
            orderId = textBox2.Text;

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

            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("処理内容を登録しました。",
                "質問",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //何が選択されたか調べる
            if (result == DialogResult.OK)
            {
                //「はい」が選択された時               
            }
        }
    }
}

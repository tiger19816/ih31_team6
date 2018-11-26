using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sugukuru.ClaimCollection
{
    public partial class BulkReconciliation : FormMaster.UserControlMST
    {
        //DB接続文字列の取得
        string conStr;

        DataTable table;

        public BulkReconciliation()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            // カラムを指定
            dgvReconciliation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReconciliation.RowHeadersVisible = false;
            dgvReconciliation.RowHeadersVisible = false;
            dgvReconciliation.AllowUserToAddRows = false;
            dgvReconciliation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            table = new DataTable();

            // データをつくる
            table.Columns.Add("振込依頼人名");
            table.Columns.Add("勘定日");
            table.Columns.Add("起算日");
            table.Columns.Add("金額", Type.GetType("System.Int32"));

            dgvReconciliation.DataSource = table;

            dgvReconciliation.Columns["金額"].DefaultCellStyle.Format = "c";
            dgvReconciliation.Columns["金額"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btFileOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.csv";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "CSVファイル(*.html;*.htm)|*.csv|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            //ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = ofd.FileName;
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            //入金データを入れるList
            List<Dictionary<string, string>> tbl = new List<Dictionary<string, string>>();

            //CSVファイルを読み込んで、内容を取得、確認
            Encoding enc = Encoding.GetEncoding("utf-8");
            StreamReader sr = new StreamReader(tbFileName.Text, enc);
            String rec = sr.ReadLine();
            string[] rtbl = rec.Split(',');
            while (!"9".Equals(rtbl[0].ToString()))
            {
                switch (rtbl[0].ToString())
                {
                    case "1":
                        break;
                    case "2":
                        Dictionary<string, string> d = new Dictionary<string, string>();
                        d.Add("calculation_date", rtbl[2].ToString());
                        d.Add("starting_date", rtbl[3].ToString());
                        d.Add("price", rtbl[4].ToString());
                        d.Add("name", rtbl[7].ToString());
                        tbl.Add(d);
                        break;
                    case "8":
                        bool checkFlag = true;
                        if(!(int.Parse(rtbl[1]) == tbl.Count))
                        {
                            checkFlag = false;
                        }
                        else
                        {
                            int sumPrice = 0;
                            for (int i = 0; i < tbl.Count; i++)
                            {
                                Dictionary<string, string> dic = tbl[i];
                                sumPrice += int.Parse(dic["price"]);
                            }
                            if(!(int.Parse(rtbl[2]) == sumPrice))
                            {
                                checkFlag = false;
                            }
                        }

                        if(!checkFlag)
                        {
                            MessageBox.Show("入金情報が正しくありません。");
                            sr.Close();
                            return;
                        }
                        break;
                }
                rec = sr.ReadLine();
                rtbl = rec.Split(',');
            }
            sr.Close();

            string sql = "";

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            int tblReadCount = tbl.Count;
            int reconciliationCount = 0;

            //消込処理
            for (int i = tbl.Count - 1; i >= 0; i--)
            {
                Dictionary<string, string> d = tbl[i];
                sql = "SELECT bc.no AS b_no, SUM(bd.quantity * bd.unit_price) AS price "
                    + "FROM billing_clearing bc "
                    + "INNER JOIN bill b ON bc.no = b.invoice_number "
                    + "INNER JOIN client c ON b.customer_id = c.id "
                    + "INNER JOIN billing_detail bd ON b.invoice_number = bd.invoice_number "
                    + "WHERE c.bank_account_holder = '" + d["name"] + "' "
                    + "AND bc.clearing_flag = 0 "
                    + "HAVING price IS NOT NULL";

                Console.WriteLine(sql);

                //抽象データ格納データセットを作成
                DataSet dset = new DataSet("bill");

                //データアダプターの生成
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

                ///データ抽出＆取得
                mAdp.Fill(dset, "bill");

                if (dset.Tables["bill"].Rows.Count != 0)
                {
                    if (Convert.ToInt32(dset.Tables["bill"].Rows[0]["price"]) == Convert.ToInt32(d["price"]))
                    {
                        sql = "UPDATE billing_clearing SET amount = " + d["price"] + ", clearing_flag = 1 WHERE no = '" + dset.Tables["bill"].Rows[0]["b_no"] + "'";

                        //SQL発行準備
                        MySqlCommand cmd = new MySqlCommand(sql, con);

                        ///SQLの実行
                        cmd.ExecuteNonQuery();
                        tbl.RemoveAt(i);
                        reconciliationCount++;
                    }
                }
            }
            //DB接続
            con.Close();

            for (int i = 0; i < tbl.Count; i++)
            {
                Dictionary<string, string> d = tbl[i];
                
                DataRow row = table.NewRow();
                row["振込依頼人名"] = d["name"];
                row["勘定日"] = d["calculation_date"];
                row["起算日"] = d["starting_date"];
                row["金額"] = int.Parse(d["price"]);
                table.Rows.Add(row);
            }

            MessageBox.Show("読込件数："+ tblReadCount +"件\n消込件数：" + reconciliationCount + "件\n未処理件数：" + (tblReadCount - reconciliationCount) + "件");
        }

        private void btAllocation_Click(object sender, EventArgs e)
        {
            AllocationForm form = new AllocationForm();
            form.ShowDialog();
            form.Dispose();
            this.Show();
        }
    }
}

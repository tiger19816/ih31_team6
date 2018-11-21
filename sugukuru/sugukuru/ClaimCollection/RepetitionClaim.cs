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

namespace sugukuru.ClaimCollection
{
    public partial class RepetitionClaim : FormMaster.UserControlMST
    {
        //DB接続文字列の取得
        string conStr;

        public RepetitionClaim()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT bc.no AS b_no, SUM(bd.quantity * bd.unit_price) AS price "
                    + "FROM billing_clearing bc "
                    + "INNER JOIN bill b ON bc.no = b.invoice_number "
                    + "INNER JOIN client c ON b.customer_id = c.id "
                    + "INNER JOIN billing_detail bd ON b.invoice_number = bd.invoice_number "
                    + "WHERE bc.clearing_flag = 2";

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            Console.WriteLine(sql);

            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("bill");

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "bill");
        }
    }
}

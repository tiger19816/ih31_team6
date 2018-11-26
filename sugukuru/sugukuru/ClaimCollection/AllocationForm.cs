using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sugukuru.ClaimCollection
{
    public partial class AllocationForm : FormMaster.OpenFormMST
    {
        //DB接続文字列の取得
        string conStr;

        public AllocationForm()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            string sql = "SELECT bc.no AS b_no, c.id AS c_id, c.formal_name AS name, c.postal_code AS postal, CONCAT(c.prefectures, c.municipality) AS address, c.client_division AS division, c.client_rep AS rep, b.billing_date AS b_date, SUM(bd.quantity * bd.unit_price) AS price, bc.amount AS amount, bc.amount AS amount, (-(bc.amount - SUM(bd.quantity * bd.unit_price))) AS dif "
                    + "FROM billing_clearing bc "
                    + "INNER JOIN bill b ON bc.no = b.invoice_number "
                    + "INNER JOIN client c ON b.customer_id = c.id "
                    + "INNER JOIN billing_detail bd ON b.invoice_number = bd.invoice_number "
                    + "WHERE bc.clearing_flag = 2 "
                    + "GROUP BY b_no";

            Console.WriteLine(sql);

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("bill");

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "bill");

            con.Close();

            dgvAllocation.DataSource = dset.Tables["bill"];
        }
    }
}

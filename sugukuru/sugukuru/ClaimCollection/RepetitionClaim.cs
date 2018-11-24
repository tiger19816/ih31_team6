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

            // カラムを指定
            dgvRepetition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepetition.RowHeadersVisible = false;
            dgvRepetition.RowHeadersVisible = false;
            dgvRepetition.AllowUserToAddRows = false;
            dgvRepetition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRepetition.ReadOnly = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
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

            dgvRepetition.DataSource = dset.Tables["bill"];
        }

        private void dgvRepetition_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btFix.Enabled = true;
            gbClaim.Enabled = true;

            DataRowView aaa = (DataRowView)dgvRepetition.CurrentRow.DataBoundItem;
            DataRow row = (DataRow)aaa.Row;
            lbCustomerName.Text = row["name"].ToString();
            lbPostal.Text = row["postal"].ToString();
            lbAddress.Text = row["address"].ToString();
            lbDivision.Text = row["division"].ToString();
            lbRep.Text = row["rep"].ToString();
            lbBillDate.Text = row["b_date"].ToString();
            lbPrice.Text = row["price"].ToString();
            lbAmount.Text = row["amount"].ToString();
            lbDif.Text = row["dif"].ToString();
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            if(rbDunning.Checked)
            {
                DunningClaimForm form = new DunningClaimForm();
                form.ShowDialog();
                form.Dispose();
                this.Show();
            }
            else
            {
                DataRowView rowView = (DataRowView)dgvRepetition.CurrentRow.DataBoundItem;
                DataRow row = (DataRow)rowView.Row;

                string sql = "INSERT INTO unbilled_data(customer_id, recorded_date, billing_amount, quantity, unit, unit_price) VALUES ("
                    + "'" + row["c_id"].ToString() + "', "
                    + "now(), "
                    + "'" + (Convert.ToDateTime(row["b_date"])).Month + "月請求繰越分', "
                    + "1, "
                    + "'個', "
                    + row["dif"].ToString() + ")";

                //DB接続オブジェクトを作成
                MySqlConnection con = new MySqlConnection(this.conStr);

                //DB接続
                con.Open();

                //SQL発行準備
                MySqlCommand cmd = new MySqlCommand(sql, con);

                ///SQLの実行
                cmd.ExecuteNonQuery();

                lbCustomerName.Text = "";
                lbPostal.Text = "";
                lbAddress.Text = "";
                lbDivision.Text = "";
                lbRep.Text = "";
                lbBillDate.Text = "";
                lbPrice.Text = "";
                lbAmount.Text = "";
                lbDif.Text = "";


                btFix.Enabled = false;
                gbClaim.Enabled = false;
            }
        }
    }
}

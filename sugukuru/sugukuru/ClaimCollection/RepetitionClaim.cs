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

            string sql = "SELECT bc.no AS b_no, c.id AS c_id, c.formal_name AS name, c.postal_code AS postal, CONCAT(c.prefectures, c.municipality) AS address, c.client_division AS division, c.client_rep AS rep, b.billing_date AS b_date, TRUNCATE(SUM(bd.quantity * bd.unit_price * 1.08), 0) AS price, bc.amount AS amount, (-(bc.amount - TRUNCATE(SUM(bd.quantity * bd.unit_price * 1.08), 0))) AS dif, CASE bc.clearing_flag WHEN 1 THEN '請求日前' WHEN 2 THEN '不足' WHEN 3 THEN '未入金' WHEN 4 THEN '督促' WHEN 5 THEN '繰越' ELSE 'その他' END AS bc_flag "
                    + "FROM billing_clearing bc "
                    + "INNER JOIN bill b ON bc.no = b.invoice_number "
                    + "INNER JOIN client c ON b.customer_id = c.id "
                    + "INNER JOIN billing_detail bd ON b.invoice_number = bd.invoice_number "
                    + "WHERE bc.clearing_flag IN(2, 3, 4) "
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

            dgvRepetition.Columns["c_id"].Visible = false;
            dgvRepetition.Columns["postal"].Visible = false;
            dgvRepetition.Columns["address"].Visible = false;
            dgvRepetition.Columns["division"].Visible = false;
            dgvRepetition.Columns["rep"].Visible = false;

            dgvRepetition.Columns["b_no"].HeaderText = "請求書番号";
            dgvRepetition.Columns["name"].HeaderText = "会社名";
            dgvRepetition.Columns["b_date"].HeaderText = "請求日";
            dgvRepetition.Columns["price"].HeaderText = "請求額";
            dgvRepetition.Columns["dif"].HeaderText = "残額";
            dgvRepetition.Columns["amount"].HeaderText = "入金済金額";
            dgvRepetition.Columns["bc_flag"].HeaderText = "状況";


            //データグリッドビュー料金の3桁カンマ区切り
            dgvRepetition.Columns["price"].DefaultCellStyle.Format = "c";
            dgvRepetition.Columns["dif"].DefaultCellStyle.Format = "c";
            dgvRepetition.Columns["amount"].DefaultCellStyle.Format = "c";

            //データグリッドビュー料金の右揃え
            dgvRepetition.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRepetition.Columns["dif"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRepetition.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            lbPrice.Text = Convert.ToInt32(row["price"]).ToString("C");
            lbAmount.Text = Convert.ToInt32(row["amount"]).ToString("C");
            lbDif.Text = Convert.ToInt32(row["dif"]).ToString("C");
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();
                    
            DataRowView rowView = (DataRowView)dgvRepetition.CurrentRow.DataBoundItem;
            DataRow row = (DataRow)rowView.Row;

            if (rbDunning.Checked)
            {

                string sql = "UPDATE billing_clearing SET clearing_flag = 4 WHERE no = '" + row["b_no"].ToString() + "'";

                //SQL発行準備
                MySqlCommand cmd = new MySqlCommand(sql, con);

                ///SQLの実行
                cmd.ExecuteNonQuery();
            }
            else
            {

                string sql = "INSERT INTO unbilled_data(customer_id, recorded_date, billing_amount, quantity, unit, unit_price) VALUES ("
                    + "'" + row["c_id"].ToString() + "', "
                    + "now(), "
                    + "'" + (Convert.ToDateTime(row["b_date"])).Month + "月請求繰越分', "
                    + "1, "
                    + "'個', "
                    + row["dif"].ToString() + ")";

                //SQL発行準備
                MySqlCommand cmd = new MySqlCommand(sql, con);

                ///SQLの実行
                cmd.ExecuteNonQuery();

                sql = "UPDATE billing_clearing SET clearing_flag = 5 WHERE no = '" + row["b_no"].ToString() + "'";

                //SQL発行準備
                cmd = new MySqlCommand(sql, con);

                ///SQLの実行
                cmd.ExecuteNonQuery();
            }

            con.Close();

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

        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }
    }
}

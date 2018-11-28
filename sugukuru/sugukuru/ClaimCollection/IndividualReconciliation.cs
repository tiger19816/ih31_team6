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
    public partial class IndividualReconciliation : FormMaster.UserControlMST
    {
        string conStr;

        public IndividualReconciliation()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            // カラムを指定
            dgvRecon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecon.RowHeadersVisible = false;
            dgvRecon.RowHeadersVisible = false;
            dgvRecon.AllowUserToAddRows = false;
            dgvRecon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecon.ReadOnly = true;
        }

        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Orders.CustomerSelectForm MenuFM = new Orders.CustomerSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();

            //子フォームで追加が押下された場合の処理
            if (MenuFM.SelectFlg)
            {
                //返り値の取得(DataRow)
                DataRow selectRow = MenuFM.Customer.getDataRow();
                //DataRowの中身をフォームの中身に追加していく
                //DataRowからの引数はデータベースのカラム名そのまま
                tbClientId.Text = selectRow["id"].ToString();
                lbName.Text = selectRow["formal_name"].ToString();
                lbPostalCode.Text = selectRow["postal_code"].ToString();
                lbAddress.Text = selectRow["address"].ToString();
                lbClientDivision.Text = selectRow["client_division"].ToString();
                lbClientRep.Text = selectRow["client_rep"].ToString();

                string sql = "SELECT bc.no AS b_no, c.id AS c_id, c.formal_name AS name, c.postal_code AS postal, CONCAT(c.prefectures, c.municipality) AS address, c.client_division AS division, c.client_rep AS rep, b.billing_date AS b_date, TRUNCATE(SUM(bd.quantity * bd.unit_price * 1.08), 0) AS price, bc.amount AS amount, (-(bc.amount - TRUNCATE(SUM(bd.quantity * bd.unit_price * 1.08), 0))) AS dif, CASE bc.clearing_flag WHEN 1 THEN '請求日前' WHEN 2 THEN '不足' WHEN 3 THEN '未入金' WHEN 4 THEN '督促' WHEN 5 THEN '繰越' ELSE 'その他' END AS bc_flag "
                    + "FROM billing_clearing bc "
                    + "INNER JOIN bill b ON bc.no = b.invoice_number "
                    + "INNER JOIN client c ON b.customer_id = c.id "
                    + "INNER JOIN billing_detail bd ON b.invoice_number = bd.invoice_number "
                    + "WHERE bc.clearing_flag IN(0, 2, 3, 4) "
                    + "AND c.id = '" + selectRow["id"].ToString() + "'"
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

                dgvRecon.DataSource = dset.Tables["bill"];

                dgvRecon.Columns["c_id"].Visible = false;
                dgvRecon.Columns["postal"].Visible = false;
                dgvRecon.Columns["address"].Visible = false;
                dgvRecon.Columns["division"].Visible = false;
                dgvRecon.Columns["rep"].Visible = false;

                dgvRecon.Columns["b_no"].HeaderText = "請求書番号";
                dgvRecon.Columns["name"].HeaderText = "会社名";
                dgvRecon.Columns["b_date"].HeaderText = "請求日";
                dgvRecon.Columns["price"].HeaderText = "請求額";
                dgvRecon.Columns["dif"].HeaderText = "残額";
                dgvRecon.Columns["amount"].HeaderText = "入金済金額";
                dgvRecon.Columns["bc_flag"].HeaderText = "状況";


                //データグリッドビュー料金の3桁カンマ区切り
                dgvRecon.Columns["price"].DefaultCellStyle.Format = "c";
                dgvRecon.Columns["dif"].DefaultCellStyle.Format = "c";
                dgvRecon.Columns["amount"].DefaultCellStyle.Format = "c";

                //データグリッドビュー料金の右揃え
                dgvRecon.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRecon.Columns["dif"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRecon.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRowView aaa = (DataRowView)dgvRecon.CurrentRow.DataBoundItem;
            DataRow row = (DataRow)aaa.Row;
            lbClaimNo.Text = row["b_no"].ToString();
            lbClaimDate.Text = DateTime.Parse(row["b_date"].ToString()).ToString("yyyy年MM月dd日");
            lbPrice.Text = Convert.ToInt32(row["price"]).ToString("C");
            lbAmount.Text = Convert.ToInt32(row["amount"]).ToString("C");
            lbDif.Text = Convert.ToInt32(row["dif"]).ToString("C");
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            string sql = "";

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            DataRowView drv = (DataRowView)dgvRecon.CurrentRow.DataBoundItem;
            DataRow row = (DataRow)drv.Row;

            if (Convert.ToInt32(row["dif"]) == Convert.ToInt32(tbPayment.Text))
            {
                sql = "UPDATE billing_clearing SET amount = " + (int.Parse(tbPayment.Text) + Convert.ToInt32(row["amount"])) + ", clearing_flag = 1 WHERE no = '" + row["b_no"].ToString() + "'";
            }
            else if (Convert.ToInt32(row["dif"]) > Convert.ToInt32(tbPayment.Text))
            {
                sql = "UPDATE billing_clearing SET amount = " + (int.Parse(tbPayment.Text) + Convert.ToInt32(row["amount"])) + ", clearing_flag = 2 WHERE no = '" + row["b_no"].ToString() + "'";
            }

            //SQL発行準備
            MySqlCommand cmd = new MySqlCommand(sql, con);

            ///SQLの実行
            cmd.ExecuteNonQuery();

            //DB接続
            con.Close();
            
            tbClientId.Text = "";
            lbName.Text = "";
            lbPostalCode.Text = "";
            lbAddress.Text = "";
            lbClientDivision.Text = "";
            lbClientRep.Text = "";
            lbClaimNo.Text = "";
            lbClaimDate.Text = "";
            lbAddress.Text = "";
            lbPrice.Text = "";
            lbAmount.Text = "";
            lbDif.Text = "";
            tbPayment.Text = "";

            dgvRecon.Columns.Clear();

            comboBox1.SelectedIndex = -1;
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

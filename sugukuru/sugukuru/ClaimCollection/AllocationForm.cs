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
        public bool fixFlag = false;
        private Dictionary<string, string> dictionary;

        public AllocationForm()
        {
            InitializeComponent();
        }

        public AllocationForm(Dictionary<string, string> d)
        {
            InitializeComponent();

            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            // カラムを指定
            dgvAllocation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllocation.RowHeadersVisible = false;
            dgvAllocation.RowHeadersVisible = false;
            dgvAllocation.AllowUserToAddRows = false;
            dgvAllocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllocation.ReadOnly = true;

            dictionary = d;

            lbName.Text = d["name"];
            lbDate1.Text = d["calculation_date"];
            lbDate2.Text = d["starting_date"];
            lbAmount.Text = int.Parse(d["price"]).ToString("C");

            string sql = "SELECT bc.no AS b_no, c.id AS c_id, c.formal_name AS name, b.billing_date AS b_date, TRUNCATE(SUM(bd.quantity * bd.unit_price * 1.08), 0) AS price, bc.amount AS amount, (-(bc.amount - TRUNCATE(SUM(bd.quantity * bd.unit_price * 1.08), 0))) AS dif "
                    + "FROM billing_clearing bc "
                    + "INNER JOIN bill b ON bc.no = b.invoice_number "
                    + "INNER JOIN client c ON b.customer_id = c.id "
                    + "INNER JOIN billing_detail bd ON b.invoice_number = bd.invoice_number "
                    + "WHERE bc.clearing_flag IN(0, 2) "
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

            dgvAllocation.Columns["c_id"].Visible = false;

            dgvAllocation.Columns["b_no"].HeaderText = "請求書番号";
            dgvAllocation.Columns["name"].HeaderText = "会社名";
            dgvAllocation.Columns["b_date"].HeaderText = "請求日";
            dgvAllocation.Columns["price"].HeaderText = "請求額";
            dgvAllocation.Columns["dif"].HeaderText = "残額";
            dgvAllocation.Columns["amount"].HeaderText = "入金済金額";

            //データグリッドビュー料金の3桁カンマ区切り
            dgvAllocation.Columns["price"].DefaultCellStyle.Format = "c";
            dgvAllocation.Columns["dif"].DefaultCellStyle.Format = "c";
            dgvAllocation.Columns["amount"].DefaultCellStyle.Format = "c";

            //データグリッドビュー料金の右揃え
            dgvAllocation.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAllocation.Columns["dif"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAllocation.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            string sql = "";

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            DataRowView drv = (DataRowView)dgvAllocation.CurrentRow.DataBoundItem;
            DataRow row = (DataRow)drv.Row;

            if (Convert.ToInt32(row["dif"]) == Convert.ToInt32(dictionary["price"]))
            {
                sql = "UPDATE billing_clearing SET amount = " + (int.Parse(dictionary["price"]) + Convert.ToInt32(row["amount"])) + ", clearing_flag = 1 WHERE no = '" + row["b_no"].ToString() + "'";
            }
            else if (Convert.ToInt32(row["dif"]) > Convert.ToInt32(dictionary["price"]))
            {
                sql = "UPDATE billing_clearing SET amount = " + (int.Parse(dictionary["price"]) + Convert.ToInt32(row["amount"])) + ", clearing_flag = 2 WHERE no = '" + row["b_no"].ToString() + "'";
            }
            
            //SQL発行準備
            MySqlCommand cmd = new MySqlCommand(sql, con);

            ///SQLの実行
            cmd.ExecuteNonQuery();

            //DB接続
            con.Close();

            fixFlag = true;
            this.Close();
        }

        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }
    }
}

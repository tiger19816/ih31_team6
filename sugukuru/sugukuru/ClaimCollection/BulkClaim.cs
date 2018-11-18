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
    public partial class BulkClaim : FormMaster.UserControlMST
    {
        //DB接続文字列の取得
        string conStr;

        public BulkClaim()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            DateTime date = DateTime.Now;
            //年の設定
            int i = 2018;
            while (i <= date.Year)
            {
                cbYear.Items.Add(i.ToString());
                i++;
            }
            cbYear.SelectedItem = date.Year.ToString();
            //月の設定
            i = 1;
            while (i <= 12)
            {
                cbMonth.Items.Add(i.ToString());
                i++;
            }
            cbMonth.SelectedItem = date.Month.ToString();
        }

        //****************************************************************************
        #region 表示ボタンが押された時の処理
        //****************************************************************************
        private void btDisplay_Click(object sender, EventArgs e)
        {
            dataGridViewDisplay();
        }
        #endregion

        //****************************************************************************
        #region 印刷ボタンが押された時の処理
        //****************************************************************************
        private void btPrint_Click(object sender, EventArgs e)
        {
            string strYear = cbYear.SelectedItem.ToString();
            string strMonth = cbMonth.SelectedItem.ToString();

            for (int i = 0; i < dgvBulk.RowCount; i++)
            {
                if ("True".Equals(dgvBulk.Rows[i].Cells["BooleanCol"].Value.ToString()))
                {
                    string id = dgvBulk.Rows[i].Cells["id"].Value.ToString();
                    string date = dtpBill.Value.ToShortDateString();

                    MessageBox.Show(id + DateTime.Now.ToString("yy") + "0" + cbMonth.SelectedItem.ToString());
                    string no = id + DateTime.Now.ToString("yy") + "0" + cbMonth.SelectedItem.ToString();
                    string payment = "月末締翌月末払";

                    string sql = "INSERT INTO bill (invoice_number,customer_id,billing_date,billing_representative,payment_criteria) VALUES("
                        + "'" + no + "',"
                        + "'" + id + "',"
                        + "'" + date + "',"
                        + "'" + FormMaster.BaseFormMST.ID + "',"
                        + "'" + payment + "');";
                    
                    //DB接続オブジェクトを作成
                    MySqlConnection con = new MySqlConnection(this.conStr);

                    //DB接続
                    con.Open();

                    //SQL発行準備
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    ///SQLの実行
                    cmd.ExecuteNonQuery();

                    sql = "SELECT * FROM unbilled_data "
                        + "WHERE recorded_date LIKE '" + strYear + "-" + strMonth + "%' "
                        + "AND customer_id = '" + id + "'";

                    //抽象データ格納データセットを作成
                    DataSet dset = new DataSet("unbilled");

                    //データアダプターの生成
                    MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

                    ///データ抽出＆取得
                    mAdp.Fill(dset, "unbilled");

                    for (int j = 0; j < dset.Tables["unbilled"].Rows.Count; j++)
                    {
                        sql = "INSERT INTO billing_detail VALUES("
                            + "'" + no + "',"
                            + "'" + (j + 1) + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["order_id"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["billing_amount"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["quantity"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["unit"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["unit_price"].ToString() + "')";

                        //SQL発行準備
                        cmd = new MySqlCommand(sql, con);

                        ///SQLの実行
                        cmd.ExecuteNonQuery();

                        sql = "UPDATE unbilled_data SET comp_flag = 1 WHERE id = " + dset.Tables["unbilled"].Rows[j]["id"].ToString();

                        //SQL発行準備
                        cmd = new MySqlCommand(sql, con);

                        ///SQLの実行
                        cmd.ExecuteNonQuery();
                    }
                    //DB切断
                    con.Close();
                }
            }
            dataGridViewDisplay();
        }
        #endregion

        //****************************************************************************
        #region DataGridViewの表示
        //****************************************************************************
        private void dataGridViewDisplay()
        {
            string strYear = cbYear.SelectedItem.ToString();
            string strMonth = cbMonth.SelectedItem.ToString();

            //SQL文を作成する
            string sql = "SELECT c.id, c.formal_name, d.price "
                + "FROM client c INNER JOIN "
                + "(SELECT customer_id, SUM(unit_price * quantity) AS price "
                + "FROM unbilled_data "
                + "WHERE recorded_date LIKE '" + strYear + "-" + strMonth + "%' "
                + "AND comp_flag = 0 "
                + "GROUP BY customer_id) d "
                + "ON c.id = d.customer_id "
                + "ORDER BY c.formal_name_read;";

            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("bulk");

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "bulk");

            //DB切断
            con.Close();

            dgvBulk.DataSource = dset.Tables["bulk"];

            //データグリッドビュー料金の3桁カンマ区切り
            dgvBulk.Columns["price"].DefaultCellStyle.Format = "c";
            //データグリッドビュー料金の右揃え
            dgvBulk.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataColumn colBoolean = new DataColumn("BooleanCol");
            colBoolean.DataType = Type.GetType("System.Boolean");
            colBoolean.DefaultValue = true;
            DataTable dtbl = (DataTable)dgvBulk.DataSource;
            dtbl.Columns.Add(colBoolean);

            dgvBulk.Columns["BooleanCol"].DisplayIndex = 0;
            dgvBulk.Columns["id"].ReadOnly = true;
            dgvBulk.Columns["formal_name"].ReadOnly = true;
            dgvBulk.Columns["price"].ReadOnly = true;

            dgvBulk.Columns["BooleanCol"].HeaderText = "";
            dgvBulk.Columns["id"].HeaderText = "顧客ID";
            dgvBulk.Columns["formal_name"].HeaderText = "会社名";
            dgvBulk.Columns["price"].HeaderText = "請求金額";
        }
        #endregion
    }
}

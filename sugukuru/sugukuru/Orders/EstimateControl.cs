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

namespace sugukuru.Orders
{
    public partial class EstimateControl : FormMaster.UserControlMST
    {
        DataTable table;
        string conStr;

        public EstimateControl()
        {
            InitializeComponent();
            table = new DataTable();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            Utility.ResponsibleList.setSales(comboBox1);

            textBox10.Text = 0.ToString();
            textBox11.Text = 0.ToString();
            textBox12.Text = 0.ToString();
        }

        private void EstimateControl_Load(object sender, EventArgs e)
        {
            textBox1.Text = "18001";

            string sql = "SELECT formal_name,postal_code,prefectures,municipality,client_division,client_rep,recovery_condition," +
                " (CASE WHEN closing_date >= 30 THEN '月末締め' ELSE CONCAT(closing_date, '日締め') END) as closing_date," +
                " (CASE WHEN collection_month = 1 THEN '当月' WHEN collection_month = 2 THEN '翌月' WHEN collection_month = 2 THEN '翌々月' ELSE '別途相談' END)as collection_month," +
                " collection_date" +
                " FROM client" +
                " WHERE id = "+textBox1.Text;

            // カラムを指定
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // データをつくる
            table.Columns.Add("受注番号");
            table.Columns.Add("品名");
            table.Columns.Add("数量");
            table.Columns.Add("単位");
            table.Columns.Add("単価");
            table.Columns.Add("金額");
            dataGridView1.DataSource = table;
            dataGridView1.Columns["品名"].Width = 250;

            // データを追加
            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("ClientInfo");

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "ClientInfo");

            //DB切断
            con.Close();

            //抽出件数を取得
            int rcnt = dset.Tables["ClientInfo"].Rows.Count;

            //0件の場合はエラー
            if (rcnt != 0)
            {
                // 顧客名をセット
                textBox2.Text = dset.Tables["ClientInfo"].Rows[0]["formal_name"].ToString();

                // 住所〒をセット
                textBox4.Text = dset.Tables["ClientInfo"].Rows[0]["postal_code"].ToString();

                // 所在地をセット
                textBox7.Text = dset.Tables["ClientInfo"].Rows[0]["prefectures"].ToString() + dset.Tables["ClientInfo"].Rows[0]["municipality"].ToString();

                // 取引先部署をセット
                textBox8.Text = dset.Tables["ClientInfo"].Rows[0]["client_division"].ToString();

                // 取引先担当者をセット
                textBox9.Text = dset.Tables["ClientInfo"].Rows[0]["client_rep"].ToString();

                // 支払い条件をセット
                textBox5.Text = dset.Tables["ClientInfo"].Rows[0]["closing_date"].ToString() + "の" + dset.Tables["ClientInfo"].Rows[0]["collection_month"].ToString() + dset.Tables["ClientInfo"].Rows[0]["collection_date"].ToString() +"払い";

                // 納期をセット
                textBox6.Text = "別途相談";

            }
            else
            {
                MessageBox.Show("社員IDかパスワードが誤っています。");
            }
        }

        // 追加を押したときの処理
        private void btEstimateAdd_Click(object sender, EventArgs e)
        {
            EstimateAddForm OpenFM = new EstimateAddForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();

            if(OpenFM.SelectFlg)
            { 
                // 追加した項目をデータグリッドビューへ反映
                DataRow row = table.NewRow();
                row["受注番号"] = OpenFM.Estimate.OrderNumber;
                row["品名"] = OpenFM.Estimate.ProductName;
                row["数量"] = OpenFM.Estimate.Quantity;
                row["単位"] = OpenFM.Estimate.Unit;
                row["単価"] = OpenFM.Estimate.UnitPrice;
                row["金額"] = OpenFM.Estimate.TotalPrice;
                table.Rows.Add(row);

                // 小計を計算し表示
                textBox10.Text = (int.Parse(textBox10.Text) + int.Parse(OpenFM.Estimate.TotalPrice)).ToString();
                // 消費税を計算し表示
                textBox11.Text = (int.Parse(textBox10.Text) / 100 * 8).ToString();
                // 合計金額額を計算し表示
                textBox12.Text = (int.Parse(textBox10.Text) + int.Parse(textBox11.Text)).ToString();
            }
        }

        // 削除を押したときの処理
        private void btEstimateDelete_Click(object sender, EventArgs e)
        {

        }

        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Form OpenFM = new CustomerSelectForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 印刷を押したときの処理
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text
                + " :  "+ textBox2.Text
                + " : " + textBox4.Text
                + " : " + textBox7.Text
                + " : " + textBox8.Text
                + " : " + textBox9.Text
                + " : " + dateTimePicker1.Text
                + " : " + comboBox1.Text
                + " : " + dateTimePicker2.Text
                + " : " + textBox5.Text
                + " : " + textBox6.Text
                + " : " + textBox3.Text
                + " : " + textBox10.Text
                + " : " + textBox11.Text
                + " : " + textBox12.Text
                );
        }
    }
}

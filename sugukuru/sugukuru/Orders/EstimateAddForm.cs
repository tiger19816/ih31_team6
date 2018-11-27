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
using sugukuru.Entites;

namespace sugukuru.Orders
{
    public partial class EstimateAddForm : sugukuru.FormMaster.OpenFormMST
    {
        public int ReturnValue;
        public bool SelectFlg;
        string conStr;
        private Entites.Estimate estimate;
        string clientId;

        public Estimate Estimate { get => estimate; set => estimate = value; }

        public EstimateAddForm()
        {
            InitializeComponent();
        }

        public EstimateAddForm(string _clientId)
        {
            InitializeComponent();
            this.clientId = _clientId;
            SelectFlg = false;
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            estimate = new Entites.Estimate();
        }

        private void EstimateAddForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT orders.id,c.formal_name,e1.family_name,car_model,car_classification,car_model_year,car_color,car_mileage,budget,orders.create_at,e2.family_name " +
                "FROM `orders` " +
                "INNER JOIN client c ON c.id = orders.client_id " +
                "INNER JOIN employee e1 ON e1.id = orders.order_rep " +
                "INNER JOIN employee e2 ON e2.id = orders.create_rep " +
                "WHERE c.id = '"+clientId+"' " +
                "AND cancel_flag = 0 ";          
            
            // カラムの設定
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            // データを追加
            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("Estimate");

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "Estimate");

            //DB切断
            con.Close();

            dataGridView1.DataSource = dset.Tables["Estimate"];

            dataGridView1.Columns["id"].HeaderText = "受注番号";

            dataGridView1.Columns["formal_name"].HeaderText = "顧客名";
            dataGridView1.Columns["formal_name"].Width = 250;

            dataGridView1.Columns["family_name"].HeaderText = "受注担当者";
            dataGridView1.Columns["car_model"].HeaderText = "型式";
            dataGridView1.Columns["car_classification"].HeaderText = "車種";
            dataGridView1.Columns["car_model_year"].HeaderText = "年式";
            dataGridView1.Columns["car_color"].HeaderText = "色";
            dataGridView1.Columns["car_mileage"].HeaderText = "走行距離";
            dataGridView1.Columns["budget"].HeaderText = "予算";

            dataGridView1.Columns["create_at"].HeaderText = "登録日";
            dataGridView1.Columns["create_at"].Width = 250;

            dataGridView1.Columns["family_name1"].HeaderText = "登録担当者";

            dataGridView1.Columns["budget"].DefaultCellStyle.Format = "c";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value) + " " + Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value) + "(" + Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value) + ")";
                textBox2.Text = 1.ToString();
                textBox2.Enabled = false;
                textBox4.Text = "台";
                textBox4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFlg = true;
            estimate.OrderNumber = textBox6.Text;
            estimate.ProductName = textBox1.Text;
            estimate.Unit = textBox4.Text;
            estimate.UnitPrice = textBox3.Text;
            estimate.Quantity = textBox2.Text;
            estimate.TotalPrice = textBox5.Text;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value) + " " + Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value) + "(" + Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value) + ")";
                textBox2.Text = 1.ToString();
                textBox2.Enabled = false;
                textBox4.Text = 1.ToString();
                textBox4.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int price = 0;
            if (int.TryParse(textBox3.Text, out price))
            {
                textBox5.Text = (int.Parse(textBox2.Text) * price).ToString();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}

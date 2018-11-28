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
using sugukuru.Entites;

namespace sugukuru.ClaimCollection
{
    public partial class IndividualSelectForm : sugukuru.FormMaster.OpenFormMST
    {
        public bool SelectFlg;
        string conStr;
        private Entites.Estimate individual;
        string clientId;
        string sql;

        public IndividualSelectForm()
        {
            InitializeComponent();
        }

        public IndividualSelectForm(string _clientId)
        {
            InitializeComponent();
            this.clientId = _clientId;
            SelectFlg = false;
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            individual = new Entites.Estimate();
        }

        public Estimate Individual { get => individual; set => individual = value; }

        private void IndividualSelectForm_Load(object sender, EventArgs e)
        {
            // カラムの設定
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.sql = "SELECT order_id,billing_amount,quantity,unit,unit_price FROM `unbilled_data` WHERE customer_id = '" + clientId+"' AND comp_flag = 0";

            // データを追加
            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("Individual");

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "Individual");

            //DB切断
            con.Close();

            //抽出件数を取得
            int rcnt = dset.Tables["Individual"].Rows.Count;

            //0件の場合はエラー
            if (rcnt != 0)
            {
                dataGridView1.DataSource = dset.Tables["Individual"];
                dataGridView1.Columns["order_id"].HeaderText = "受注番号";
                dataGridView1.Columns["billing_amount"].HeaderText = "商品名";
                dataGridView1.Columns["quantity"].HeaderText = "数量";
                dataGridView1.Columns["unit"].HeaderText = "単位";
                dataGridView1.Columns["unit_price"].HeaderText = "単価";
            }
            else
            {
                MessageBox.Show("請求がありません。");
            }

        }

        // 選択押された
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                textBox1.Enabled = false;
                textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                textBox6.Enabled = false;
                textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                textBox2.Enabled = false;
                textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                textBox4.Enabled = false;
                textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                textBox3.Enabled = false;
            }
            textBox5.Text = (int.Parse(textBox2.Text) * int.Parse(textBox3.Text)).ToString();
            textBox5.Enabled = false;
        }

        // 確定押された
        private void button1_Click(object sender, EventArgs e)
        {
            SelectFlg = true;
            individual.OrderNumber = textBox6.Text;
            individual.ProductName = textBox1.Text;
            individual.Unit = textBox4.Text;
            individual.UnitPrice = textBox3.Text;
            individual.Quantity = textBox2.Text;
            individual.TotalPrice = textBox5.Text;
            this.Close();
        }
    }
}

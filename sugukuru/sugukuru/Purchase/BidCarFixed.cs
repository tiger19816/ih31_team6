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

namespace sugukuru.Purchase
{
    public partial class BidCarFixed : FormMaster.UserControlMinMST
    {

        //DB接続文字列の取得
        string conStr;


        public BidCarFixed()
        {
            InitializeComponent();

           sqlBid();

        }

        private void BidCarFixed_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbAuctionCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbListingNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tbCustomerNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btData_Click(object sender, EventArgs e)
        {
            BidResult b = new BidResult();
            b.Show();
        }

        String id = "";

        //確定ボタンを押すとUPDATE
        private void button1_Click(object sender, EventArgs e)
        {
            id = dataGridView1.SelectedCells[0].Value.ToString();
            int r = dataGridView1.SelectedRows[0].Index;

            if (id == "")
            {
                MessageBox.Show("受注を選択してください。");
            }
            else
            {
                // [はい] [いいえ] ボタンをつける
                ;

                // どのボタンを選択したかを判断する
                if (MessageBox.Show("受注を確定します。よろしいですか？", "受注確定処理", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //SQL文を発行する
                    this.conStr = ConfigurationManager.AppSettings["DbConKey"];

                    DataSet dset = new DataSet("bid");
                    MySqlConnection con = new MySqlConnection(this.conStr);
                    con.Open();

                    String sql = "UPDATE successful_bid_vehicle SET successful_bid_fixing = '1' WHERE successful_bid_vehicle.order_id = '"+id+"';";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("受注を確定しました。");

                    sqlBid();

                }
               
            }
        }

        //******************************************************************************************
        #region 入札した後のID、顧客、担当者の一覧表示SQL
        //******************************************************************************************

        public void sqlBid()
        {
            //sql文
            String sql = "select orders.id,formal_name,CONCAT (family_name, ' ', first_name) AS employee_name,orders.create_at,auction_hall.auction_hall_name,listing_number,bid_price,bid_date " +
"FROM client INNER JOIN orders ON client.id = orders.client_id " +
"INNER JOIN employee ON orders.order_rep = employee.id " +
"INNER JOIN bid ON bid.order_id = orders.id " +
"INNER JOIN auction_hall ON bid.auction_hall_id = auction_hall.id " +
"INNER JOIN successful_bid_vehicle ON successful_bid_vehicle.order_id = bid.order_id " +
"where successful_bid_fixing = 0; ";

            MySqlConnection con = new MySqlConnection(ConfigurationManager.AppSettings["DbConKey"]);

            //SQL文を発行する
            DataSet dset = new DataSet("list");

            con.Open();


            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);
            mAdp.Fill(dset, "list");
            con.Close();

            //データグリッドビューの関連付け
            dataGridView1.DataSource = dset.Tables["list"];

            //表示の設定
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;

            dataGridView1.Columns[0].HeaderText = "受注ID";
            dataGridView1.Columns[1].HeaderText = "顧客名";
            dataGridView1.Columns[2].HeaderText = "受注担当者";
            dataGridView1.Columns[3].HeaderText = "登録日";
            dataGridView1.Columns[4].HeaderText = "オークション会場";
            dataGridView1.Columns[5].HeaderText = "出品番号";
            dataGridView1.Columns[6].HeaderText = "入札金額";
            dataGridView1.Columns[7].HeaderText = "入札日";

            dataGridView1.Columns[6].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            //選択モードを行単位にする
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



        }


        #endregion
    }
}

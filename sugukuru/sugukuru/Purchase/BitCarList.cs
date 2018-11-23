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
    public partial class BitCarList : FormMaster.UserControlMST
    {

        //DB接続文字列の取得
        string conStr;

        public BitCarList()
        {
            InitializeComponent();
            sqlOrder();
//          

        }

        String id = "";


            private void btSelect_Click(object sender, EventArgs e)
        {

           id = dgvBulk.SelectedCells[0].Value.ToString();

            //MessageBox.Show(id);

            if (id == "")
            {
                MessageBox.Show("受注を選択してください。");
            }
            else
            {
                Form BidCar = new BidCarInput(id);
                this.Hide();
                BidCar.ShowDialog();
                BidCar.Dispose();
                this.Show();
            }

        }

public void sqlOrder()
        {
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            //SQL文を発行する
            DataSet dset = new DataSet("list");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //sql文
            String sql = "select orders.id,formal_name,CONCAT(family_name, ' ', first_name) AS employee_name, orders.create_at,auction_hall.auction_hall_name,listing_number,bid_price,bid_date " +
"FROM client INNER JOIN orders ON client.id = orders.client_id " +
"INNER JOIN employee ON orders.order_rep = employee.id " +
"INNER JOIN bid ON bid.order_id = orders.id " +
"INNER JOIN auction_hall ON bid.auction_hall_id = auction_hall.id " +
"WHERE bid_result = 1 AND " +
"NOT EXISTS(select * FROM successful_bid_vehicle where successful_bid_vehicle.order_id = bid.order_id)";


            //MessageBox.Show(sql);

            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);
            mAdp.Fill(dset, "list");
            con.Close();

            //データグリッドビューの関連付け
            dgvBulk.DataSource = dset.Tables["list"];

            //表示の設定
            dgvBulk.Columns[0].Width = 100;
            dgvBulk.Columns[1].Width = 250;
            dgvBulk.Columns[2].Width = 100;
            dgvBulk.Columns[3].Width = 200;
            dgvBulk.Columns[4].Width = 100;
            dgvBulk.Columns[5].Width = 100;
            dgvBulk.Columns[6].Width = 100;
            dgvBulk.Columns[7].Width = 100;

            dgvBulk.Columns[0].HeaderText = "受注ID";
            dgvBulk.Columns[1].HeaderText = "顧客名";
            dgvBulk.Columns[2].HeaderText = "受注担当者";
            dgvBulk.Columns[3].HeaderText = "登録日";
            dgvBulk.Columns[4].HeaderText = "オークション会場";
            dgvBulk.Columns[5].HeaderText = "出品番号";
            dgvBulk.Columns[6].HeaderText = "入札金額";
            dgvBulk.Columns[7].HeaderText = "入札日";

            dgvBulk.Columns[6].DefaultCellStyle.Format = "c";
            dgvBulk.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            //選択モードを行単位にする
            dgvBulk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


    }
}

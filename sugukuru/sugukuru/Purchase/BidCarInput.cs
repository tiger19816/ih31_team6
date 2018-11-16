﻿using System;
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
    public partial class BidCarInput : FormMaster.OpenFormMST
    {

        //DB接続文字列の取得
        string conStr;

        public BidCarInput()
        {
            InitializeComponent();
           

        }

        String order_id = "";
        int sum = 0;


        public BidCarInput(String id)
        {
            InitializeComponent();
            MessageBox.Show(id);
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            //SQL文を発行する
            DataSet dset = new DataSet("list");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //sql文
            String sql = "SELECT order_id,listing_number,auction_hall_name FROM bid INNER JOIN auction_hall ON bid.auction_hall_id = auction_hall.id WHERE order_id = "+id;
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);
            mAdp.Fill(dset, "list");
            con.Close();

            lbPid.Text = dset.Tables["list"].Rows[0]["order_id"].ToString();
            lbAid.Text = dset.Tables["list"].Rows[0]["auction_hall_name"].ToString();
            lbBid.Text = dset.Tables["list"].Rows[0]["listing_number"].ToString();

            order_id = lbPid.Text;
            lbSum.Text = sum.ToString();

        }

        //確定ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {

            int trans = 0;
            if (radioButton1.Checked == true)
            {
                trans = 0;
            }
            else if (radioButton2.Checked == true)
            {
                trans = 1;
            }

            //SQL文を発行する
            DataSet dset = new DataSet("bid");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            String sql = "INSERT INTO successful_bid_vehicle (`order_id`, `car_model`, `car_model_year`, `car_name`, `car_color`, `car_mileage`, `transmission`, `fine_info`, `successful_bid_vehicle_tax`, `contracted_successful_bid_quantity`, `vehicle_tax_equivalent`, `fee`, `successful_bid_fixing`) " +
                "VALUES('"+order_id+"', '"+tbModel.Text+"', '"+tbModelYear.Text+"', '"+tbCarName.Text+"', '"+tbColor.Text+"', '"+tbMile.Text+"', '"+trans+"', '"+tbInfo.Text+"', '"+tbTax.Text+"', '"+tbPrice.Text+"', '"+tbCarTax.Text+"', '"+tbFee.Text+"', '0')";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("登録しました。");
        }

       

        //合計金額を出す

        private void tbTax_TextChanged(object sender, EventArgs e)
        {
            int val = int.Parse(tbTax.Text);
            sum += val;
            lbSum.Text = sum.ToString();
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            int val = int.Parse(tbPrice.Text);
            sum += val;
          
            lbSum.Text = sum.ToString();
        }

        private void tbCarTax_TextChanged(object sender, EventArgs e)
        {
            int val = int.Parse(tbCarTax.Text);
            sum += val;
            lbSum.Text = sum.ToString();
        }

        private void tbFee_TextChanged(object sender, EventArgs e)
        {
            int val = int.Parse(tbFee.Text);
            sum += val;
            lbSum.Text = sum.ToString();
        }
    }
}

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
            
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            //SQL文を発行する
            DataSet dset = new DataSet("list");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //sql文
            String sql = "SELECT order_id,listing_number,auction_hall_name, bid_price FROM bid INNER JOIN auction_hall ON bid.auction_hall_id = auction_hall.id WHERE order_id = "+id;
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);
            mAdp.Fill(dset, "list");
            con.Close();

            lbPid.Text = dset.Tables["list"].Rows[0]["order_id"].ToString();
            lbAid.Text = dset.Tables["list"].Rows[0]["auction_hall_name"].ToString();
            lbBid.Text = dset.Tables["list"].Rows[0]["listing_number"].ToString();
            tbBitPrice.Text = dset.Tables["list"].Rows[0]["bid_price"].ToString();
            lbSum.Text = Convert.ToInt32(dset.Tables["list"].Rows[0]["bid_price"]).ToString("C");

            order_id = lbPid.Text;

            tbPrice.TextAlign = HorizontalAlignment.Right;
            tbCarTax.TextAlign = HorizontalAlignment.Right;
            tbFee.TextAlign = HorizontalAlignment.Right;
            tbTax.TextAlign = HorizontalAlignment.Right;

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

            String sql = "INSERT INTO successful_bid_vehicle (`order_id`, `car_model`, `undercarriage_number`,`car_model_year`, `car_name`, `car_color`, `car_mileage`, `transmission`, `fine_info`, `successful_bid_vehicle_tax`, `contracted_successful_bid_quantity`, `vehicle_tax_equivalent`, `fee`, `successful_bid_fixing`) " +
                "VALUES('"+order_id+"', '"+tbModel.Text+ "', '" + tbNumber.Text + "','" + tbModelYear.Text+"', '"+tbCarName.Text+"', '"+tbColor.Text+"', '"+tbMile.Text+"', '"+trans+"', '"+tbInfo.Text+"', '"+tbTax.Text+"', '"+tbPrice.Text+"', '"+tbCarTax.Text+"', '"+tbFee.Text+"', '0')";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("登録しました。");


            lbAid.Text = "";
            lbBid.Text = "";
            lbPid.Text = "";
            lbSum.Text = "";

            tbCarName.Text = "";
            tbCarTax.Text = "";
            tbColor.Text = "";
            tbFee.Text = "";
            tbInfo.Text = "";
            tbMile.Text = "";
            tbModel.Text = "";
            tbModelYear.Text = "";
            tbNumber.Text = "";
            tbPrice.Text = "";
            tbTax.Text = "";

            this.Close();




        }

       

        //合計金額を出す
        //共通のイベントハンドラ
        private void textBox_Leave(object sender, System.EventArgs e)
        {

            int i = 0;

            //いったん全部読み込む
            String bitPrice = tbBitPrice.Text;
            if (bitPrice != "")
            {
                Boolean result = int.TryParse(bitPrice, out i);
                if (!result)
                {
                    bitPrice = "0";
                }
            }
            else
            {
                bitPrice = "0";
            }


            String tax = tbTax.Text;
            if (tax != "")
            {
                Boolean result = int.TryParse(tax, out i);
                if(!result)
                {
                    tax = "0";
                }
            }
            else
            {
                tax = "0";
            }

          
            String price = tbPrice.Text;
            if (price != "")
            {
                Boolean result = int.TryParse(price, out i);
                if (!result || price == "")
                {
                    price = "0";
                }
            }
            else
            {
                price = "0";
            }

           

            String carTax = tbCarTax.Text;
            if (carTax != "")
            {
                Boolean result = int.TryParse(carTax, out i);
                if (!result || carTax == "")
                {
                    carTax = "0";
                }
            }
            else
            {
                carTax = "0";
            }

          

            String fee = tbFee.Text;
            if (fee != "")
            {
                Boolean result = int.TryParse(fee, out i);
                if (!result || fee == "")
                {
                    fee = "0";
                }
            }
            else
            {
                fee = "0";
            }

        


            sum = int.Parse(bitPrice) + int.Parse(tax) + int.Parse(price) + int.Parse(carTax) + int.Parse(fee);
            
            lbSum.Text = sum.ToString("C");

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }
    }
}

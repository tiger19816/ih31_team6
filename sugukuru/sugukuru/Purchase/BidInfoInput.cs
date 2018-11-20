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
    public partial class BidInfoInput : FormMaster.UserControlMST
    {
        //DB接続文字列の取得
        string conStr;

        public BidInfoInput()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            //登録担当者をコンボボックスにセットする(全社員)
            Utility.ResponsibleList.setAuctionHall(cbAuction);

        }

        //閉じるボタン
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        //確定ボタン
        private void btFixed_Click(object sender, EventArgs e)
        {

            //SQL文を発行する
            DataSet dset = new DataSet("bid");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //入札日付************************************************
            String date = dateTimePicker1.Value.ToShortDateString();
            date.Replace("/", "-");
            //*****************************************************

            //入札結果********************************************
            int result = 0;
            if (rbSatisfied.Checked == true)
            {
                result = 1;
            }else if(rbUnsatisfied.Checked == true)
            {
                result = 0;
            }
            //************************************************

                String sql = "INSERT INTO `sugukuru`.`bid` (`order_id`, `auction_hall_id`, `listing_number`, `bid_date`, `bid_price`, `bid_result`) VALUES ('"+tbOrderId.Text+"', '"+cbAuction.SelectedValue+"', '"+tbListingNumber.Text+"', '"+date+"', '"+tbPrice.Text+"', '"+result+"');";


            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("登録しました。");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Form MenuFM = new OrderSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();
        }
    }
}

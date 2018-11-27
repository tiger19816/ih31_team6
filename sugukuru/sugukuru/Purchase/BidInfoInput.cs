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

            tbListingNumber.Text = "";
            tbOrderId.Text = "";
            tbPrice.Text = "";

            lbBuget.Text = "";
            lbCId.Text = "";
            lbCkana.Text = "";
            lbClass.Text = "";
            lbCname.Text = "";
            lbColor.Text = "";
            lbInfo.Text = "";
            lbMile.Text = "";
            lbModel.Text = "";
            lbRep.Text = "";
            lbType.Text = "";
            lbYear.Text = "";

            cbAuction.SelectedIndex = -1;


        }

        private void btSearch_Click(object sender, EventArgs e)
        {


            //子フォームを開く
            OrderSelectForm selectFM = new OrderSelectForm();
            selectFM.ShowDialog();
            selectFM.Dispose();
            this.Show();

            //子フォームで選択ボタンが押された場合の処理
            if (selectFM.SelectFlg)
            {
                //子フォームからの返り値(DataRow)
                DataRow selectRow = selectFM.Order.getDataRow();
                //DataRowの中身をフォームの中身に追加していく
                //DataRowからの引数はデータベースのカラム名そのまま
                tbOrderId.Text = selectRow["id"].ToString();
                lbCId.Text = selectRow["client_id"].ToString();
                lbBuget.Text = selectRow["budget"].ToString();
                lbClass.Text = selectRow["car_classification"].ToString();
                lbColor.Text = selectRow["car_color"].ToString();
                
                lbInfo.Text = selectRow["fine_info"].ToString();
                lbMile.Text = selectRow["car_mileage"].ToString();
                lbModel.Text = selectRow["car_model"].ToString();
                
                String type = selectRow["order_type"].ToString();
                if(type == "1")
                {
                    lbType.Text = "買注文";
                }
                else
                {
                    lbType.Text = "売注文";
                }

                
                lbYear.Text = selectRow["car_model_year"].ToString();

                //顧客IDから紐づいている顧客データの取得
                DataRow chainRow = Utility.Customer.ChainCustomerId(selectRow["client_id"].ToString());

                //取得確認用メッセージボックス
                String chainData = "";
                for (int i = 0; i < chainRow.ItemArray.Length; i++)
                {
                    chainData += chainRow[i].ToString() + ", ";
                }
                //MessageBox.Show(chainData);

                lbCname.Text = chainRow["formal_name"].ToString();
                lbCkana.Text = chainRow["formal_name_read"].ToString();
                lbRep.Text = chainRow["client_rep"].ToString();
            }
        }
    }
}

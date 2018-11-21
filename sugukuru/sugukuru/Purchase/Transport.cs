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
    public partial class Transport : FormMaster.UserControlMST
    {

        //DB接続文字列の取得
        string conStr;
        public Transport()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            //受注担当者をセットする(営業担当者のみ)
            Utility.ResponsibleList.setSales(cbOrderRep);
            //陸送業者をセットする
            Utility.ResponsibleList.setVender(cbTransport);
            //初期選択を未選択にする
            cbOrderRep.SelectedIndex = -1;

        }

        //登録ボタンが押されたら
        private void btConfirmation_Click(object sender, EventArgs e)
        {

            //入札日付************************************************
            String date = dateTimePicker1.Value.ToShortDateString();
            date.Replace("/", "-");
            //*****************************************************

            //SQL文を発行する
            DataSet dset = new DataSet("data");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();


            //後で変更
            //受注ID
            String sql = "INSERT INTO transportation (`order_id`, `vendor_id`, `starting_postal_code`, `starting_address`, `destination_postal_code`, `destination_address`, `fee`, `order_date`, `slip_number`, `responsible_id`) "+
"VALUES('"+tbOrderId.Text+"', '"+cbTransport.SelectedValue+"', '"+tbDeparture.Text+"', '"+tbDeparturePost.Text+"', '"+tbArrival.Text+"', '"+tbDeparturePost.Text+"', '"+tbPrice.Text+"', '"+date+"', '"+tbSlip.Text+"', '"+cbOrderRep.SelectedValue+"'); ";


            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("登録しました。");
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
                lbCustomerId.Text = selectRow["client_id"].ToString();
           
                //顧客IDから紐づいている顧客データの取得
                DataRow chainRow = Utility.Customer.ChainCustomerId(selectRow["client_id"].ToString());

                //取得確認用メッセージボックス
                String chainData = "";
                for (int i = 0; i < chainRow.ItemArray.Length; i++)
                {
                    chainData += chainRow[i].ToString() + ", ";
                }
                MessageBox.Show(chainData);
            }
        }
    }
}

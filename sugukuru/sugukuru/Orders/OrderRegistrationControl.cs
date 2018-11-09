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
    public partial class OrderRegistrationControl : UserControl
    {
        //DB接続文字列の取得
        string conStr;

        public OrderRegistrationControl()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        //顧客情報のデータテーブル
        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }

        //顧客の検索ボタン
        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Form MenuFM = new CustomerSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();
        }

        //顧客IDはプロトタイプでは固定にする
        String client_id = "18001";
        //受注IDは詳細は後で
        String id = "8873098198";
        //登録者、担当者のセレクトボックスの処理は後で行う
        String order_at = "123";
        String create_at = "456";
        

        //登録ボタン押下
        private void btOrderRegistrarion_Click(object sender, EventArgs e)
        {
            //SQL文を発行する
            DataSet dset = new DataSet("order");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //ラジオボタンのチェック
            int order_type = 0;
            if (radioButton1.Checked == true)
            {
                order_type = 111;
            }else if (radioButton2.Checked == true)
            {
                order_type = 222;
            }

                String sql = "INSERT INTO `sugukuru`.`order` (`id`, `client_id`, `order_type`, `car_model`, `car_classification`, `car_model_year`, `car_color`, `car_mileage`, `budget`, `fine_info`, `order_rep`, `create_rep`,`cancel_flag`)" +
                " VALUES ('" +id+"', '"+tbClientId.Text+"', '"+order_type+"', '"+tbCarModel.Text+"', '"+tbCarClass.Text+"', '"+tbCarYear.Text+"', '"+tbCarColor+"', '"+tbCarMile.Text+"', '"+tbBudget.Text+"', '"+tbInfo.Text+"', '"+order_at+"', '"+create_at+"','0');";


           MessageBox.Show(sql);

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            


        }
    }
}

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
    public partial class OrderListControl : FormMaster.UserControlMST
    {
        //DB接続文字列取得
        String conStr;

        public OrderListControl()
        {
            InitializeComponent();
            //DB接続文字列取得
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        //詳細ボタン
        private void btDetail_Click(object sender, EventArgs e)
        {
            Form OpenFM = new OrderDetailForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        //検索ボタン
        private void btSearch_Click(object sender, EventArgs e)
        {
            //SQL文発行する
            DataSet dset = new DataSet("order");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();
            String sql = "SELECT `id`, `client_id`, `order_type`, `car_model`, `car_classification`, `car_model_year`, `car_color`, `car_mileage`, `budget`, `fine_info` FROM sugukuru.orders where id = '" + tbSearchOrderId.Text+"'";
            MessageBox.Show(sql);
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);
            mAdp.Fill(dset, "order");
            gvOrderList.DataSource = dset.Tables["order"];
            con.Close();
        }
    }
}

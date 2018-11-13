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

            //オークション会場の値書き込み
            int a_id = 12345;

            //入札日付
            String date = dateTimePicker1.Value.ToShortDateString();
            date.Replace("/", "-");



        }



    }
}

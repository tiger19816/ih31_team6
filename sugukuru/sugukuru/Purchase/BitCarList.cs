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
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            //SQL文を発行する
            DataSet dset1 = new DataSet("order");
            DataSet dset2 = new DataSet("bid");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //sql文

        }
    }
}

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

namespace sugukuru.ClaimCollection
{
    public partial class RepetitionClaim : FormMaster.UserControlMST
    {
        //DB接続文字列の取得
        string conStr;

        public RepetitionClaim()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

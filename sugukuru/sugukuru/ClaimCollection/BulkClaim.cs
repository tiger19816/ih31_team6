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
    public partial class BulkClaim : FormMaster.UserControlMST
    {
        //DB接続文字列の取得
        string conStr;

        public BulkClaim()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        //****************************************************************************
        #region 表示ボタンが押された時の処理
        //****************************************************************************
        private void btDisplay_Click(object sender, EventArgs e)
        {
            string strYear = cbYear.SelectedValue.ToString();
            string strMonth = cbMonth.SelectedValue.ToString();

            //SQL文を作成する
            string sql = "SELECT id, CONCAT (family_name, ' ', first_name) AS employee_name, division FROM employee WHERE id = '" + strId + "' AND password = '" + strPasword + "'";

            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("login");

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "login");

            //DB切断
            con.Close();

            //抽出件数を取得
            int rcnt = dset.Tables["login"].Rows.Count;

            //0件の場合はエラー
            if (rcnt != 0)
            {
                Form MenuFM = new MainMenuForm(Convert.ToInt32(dset.Tables["login"].Rows[0]["id"]), dset.Tables["login"].Rows[0]["employee_name"].ToString(), Convert.ToInt32(dset.Tables["login"].Rows[0]["division"]));
                this.Hide();
                MenuFM.ShowDialog();
                MenuFM.Dispose();
                this.Show();
            }
            else
            {
                MessageBox.Show("社員IDかパスワードが誤っています。");
            }
        }
        #endregion
    }
}

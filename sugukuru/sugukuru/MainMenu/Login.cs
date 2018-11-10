using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace sugukuru.MainMenu
{
    public partial class Login : Form
    {
        //DB接続文字列の取得
        string conStr;

        public Login()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        //****************************************************************************
        #region ログインボタンが押された時の処理
        //****************************************************************************
        private void btLogin_Click(object sender, EventArgs e)
        {
            string strId = tbId.Text;
            string strPasword = tbPassword.Text;

            //SQL文を作成する
            string sql = "SELECT id, family_name, first_name, division FROM employee WHERE id = '" + strId + "' AND password = '" + strPasword + "'";

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
                Form MenuFM = new MainMenuForm(Convert.ToInt32(dset.Tables["login"].Rows[0]["id"]), dset.Tables["login"].Rows[0]["family_name"].ToString() + dset.Tables["login"].Rows[0]["first_name"].ToString(), Convert.ToInt32(dset.Tables["login"].Rows[0]["division"]));
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

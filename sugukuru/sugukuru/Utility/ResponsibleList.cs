using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace sugukuru.Utility
{
    class ResponsibleList
    {
        //******************************************************************************************
        #region コンボボックスに全社員の情報をセットする
        //******************************************************************************************
        public static void setResponsible(ComboBox combobox)
        {
            //SQL文を作成する
            string sql = "SELECT id, CONCAT (family_name, ' ', first_name) AS employee_name FROM employee";

            //抽象データ格納データセットを作成
            DataTable dt = new DataTable();

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(ConfigurationManager.AppSettings["DbConKey"]);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dt);

            //DB切断
            con.Close();
            
            //コンボボックスに値をセットする
            combobox.DisplayMember = "employee_name";
            combobox.ValueMember = "id";
            combobox.DataSource = dt;
        }
        #endregion

        //******************************************************************************************
        #region コンボボックスに営業担当者の情報をセットする
        //******************************************************************************************
        public static void setSales(ComboBox combobox)
        {
            //SQL文を作成する
            string sql = "SELECT id, CONCAT (family_name, ' ', first_name) AS employee_name FROM employee WHERE division = 2";

            //抽象データ格納データセットを作成
            DataTable dt = new DataTable();

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(ConfigurationManager.AppSettings["DbConKey"]);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dt);

            //DB切断
            con.Close();

            //コンボボックスに値をセットする
            combobox.DisplayMember = "employee_name";
            combobox.ValueMember = "id";
            combobox.DataSource = dt;
        }
        #endregion

        //******************************************************************************************
        #region Valueが引数2の項目を選択する(引数1:コンボボックス、引数2：社員ID)
        //******************************************************************************************
        public static void SelectFromValue<t>(ComboBox comboBox, t value)
        {
            if (comboBox.Items.Count == 0)
            {
                // データなし
                return;
            }
            // 未選択にしておく
            comboBox.SelectedIndex = -1;

            DataTable dt = (DataTable)comboBox.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                if (row[comboBox.ValueMember] == DBNull.Value)
                {
                    if (value == null)
                    {
                        // NULL同士なので選択して終了
                        comboBox.SelectedIndex = i;
                        break;
                    }
                    else
                    {
                        // 一致しないのでループ続行
                        continue;
                    }
                }

                if (row[comboBox.ValueMember].Equals(value))
                {
                    // 値が一致したので選択して終了
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }
        #endregion

        //******************************************************************************************
        #region コンボボックスにオークション会場の情報をセットする
        //******************************************************************************************
        public static void setAuctionHall(ComboBox combobox)
        {
            //SQL文を作成する
            string sql = "SELECT id, auction_hall_name FROM auction_hall";

            //抽象データ格納データセットを作成
            DataTable dt = new DataTable();

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(ConfigurationManager.AppSettings["DbConKey"]);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dt);

            //DB切断
            con.Close();

            //コンボボックスに値をセットする
            combobox.DisplayMember = "auction_hall_name";
            combobox.ValueMember = "id";
            combobox.DataSource = dt;
        }
        #endregion
    }
}

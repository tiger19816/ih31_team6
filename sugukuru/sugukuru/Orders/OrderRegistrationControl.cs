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

            //登録担当者をコンボボックスにセットする(全社員)
            Utility.ResponsibleList.setResponsible(cbCreateRep);
            //現在ログイン中の社員を選択する
            Utility.ResponsibleList.SelectFromValue(cbCreateRep, FormMaster.BaseFormMST.ID);

            //受注担当者をセットする(営業担当者のみ)
            Utility.ResponsibleList.setSales(cbOrderRep);
            //初期選択を未選択にする
            cbOrderRep.SelectedIndex = -1;
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
            //子フォームを開く
            CustomerSelectForm MenuFM = new CustomerSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();

            //子フォームで追加が押下された場合の処理
            if (MenuFM.SelectFlg)
            {
                //返り値の取得(DataRow)
                DataRow selectRow = MenuFM.Customer.getDataRow();
                //DataRowの中身をフォームの中身に追加していく
                //DataRowからの引数はデータベースのカラム名そのまま
                tbClientId.Text = selectRow["id"].ToString();
                lbName.Text = selectRow["formal_name"].ToString();
                lbNameRead.Text = selectRow["formal_name_read"].ToString();
                lbPostalCode.Text = selectRow["postal_code"].ToString();
                lbAddress.Text = selectRow["address"].ToString();
                lbPhoneNumber.Text = selectRow["phone_number"].ToString();
                lbFax.Text = selectRow["fax"].ToString();
                lbClientDivision.Text = selectRow["client_division"].ToString();
                lbClientRep.Text = selectRow["client_rep"].ToString();
                lbSalesRep.Text = selectRow["family_name"].ToString() + " " + selectRow["first_name"].ToString();
            }
        }
        //登録ボタン押下
        private void btOrderRegistrarion_Click(object sender, EventArgs e)
        {
            string id = "";

            //SQL文を発行する
            DataSet dset = new DataSet("order");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //ラジオボタンのチェック
            String order_type = "0";
            if (radioButton1.Checked == true)
            {
                order_type = "1";
            }else if (radioButton2.Checked == true)
            {
                order_type = "2";
            }

            //受注ID生成
            String year = DateTime.Now.Year.ToString();    //2018
            String mo = DateTime.Now.Month.ToString();     //11

            String sql_id = "SELECT COUNT(*) FROM `order` WHERE create_at LIKE '" + year + "-"+mo+"%';";

            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql_id, con);
            mAdp.Fill(dset, "order");

            String cntStr = dset.Tables["order"].Rows[0]["COUNT(*)"].ToString();     //件数
           
            int cnt = int.Parse(cntStr)+1;

            cntStr = cnt.ToString();     //最新件数
            

            while (cntStr.Length != 4)
            {
                cntStr = "0" + cntStr;
            }

            int y = int.Parse(year);
            y = y % 100;

            year = y.ToString();    //18

            id = year + mo + order_type + cntStr;

            //ここまで


            //日付取得
            String date = dateTimePicker1.Value.ToShortDateString();
            date = date.Replace("/", "-");
            //ここまで


            String sql = "INSERT INTO `sugukuru`.`order` (`id`, `client_id`, `order_type`, `car_model`, `car_classification`, `car_model_year`, `car_color`, `car_mileage`, `budget`, `fine_info`, `order_rep`,`create_at`, `create_rep`,`cancel_flag`)" +
                " VALUES ('" +id+"', '"+tbClientId.Text+"', '"+order_type+"', '"+tbCarModel.Text+"', '"+tbCarClass.Text+"', '"+tbCarYear.Text+"', '"+tbCarColor.Text+"', '"+tbCarMile.Text+"', '"+tbBudget.Text+"', '"+tbInfo.Text+"', '"+cbOrderRep.Text+ "', '" + date + "','" + cbCreateRep.Text+"','0');";


           MessageBox.Show(sql);

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("受注登録しました。");

            tbClientId.Text = "";
            tbCarModel.Text = "";
            tbCarClass.Text = "";
            tbCarYear.Text = "";
            tbCarColor.Text = "";
            tbCarMile.Text = "";
            tbBudget.Text = "";
            tbInfo.Text = "";


        }
    }
}

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

namespace sugukuru.Orders
{
    public partial class OrderChangeForm : FormMaster.OpenFormMST
    {

        //DB接続文字列の取得
        string conStr;

        private Utility.Customer order;

        public OrderChangeForm()
        {
            InitializeComponent();
        }

        String trans = "";

        public OrderChangeForm(Utility.Customer order)
        {
            InitializeComponent();

            this.conStr = ConfigurationManager.AppSettings["DbConKey"];

            //登録担当者をコンボボックスにセットする(全社員)
            Utility.ResponsibleList.setResponsible(cbChengeRep);
            Utility.ResponsibleList.setResponsible(cbOrderRep);


            this.order = order;
            DataRow chainRow = Utility.Customer.ChainCustomerId(order.getDataRow()["client_id"].ToString());

            label19.Text = "［受注番号：" + order.getDataRow()["id"].ToString() + "]";
            if (order.getDataRow()["order_type"].ToString() == "1")
            {
                radioButton1.Checked = true;
            }
            else if (order.getDataRow()["order_type"].ToString() == "2")
            {
                radioButton2.Checked = true;
            }

          

            if (order.getDataRow()["transmission"].ToString() == "0")
            {
                radioButton3.Checked = true;
                trans = "0";
            }
            else if (order.getDataRow()["transmission"].ToString() == "1")
            {
                radioButton4.Checked = true;
                trans = "1";
            }

            DataRow chainEmployeeRow = Utility.Customer.ChainEmployeeId(order.getDataRow()["order_rep"].ToString());
            lbCostomerId.Text = chainRow["id"].ToString();
            lbName.Text = chainRow["formal_name"].ToString();

            lbRead.Text = chainRow["formal_name_read"].ToString();
            lbPost.Text = String.Format("{0:000-0000}", Int32.Parse(chainRow["postal_code"].ToString()));
            lbAddress.Text = chainRow["address"].ToString();
            lbTel.Text = chainRow["phone_number"].ToString();
            lbFax.Text = chainRow["fax"].ToString();
            lbPosition.Text = chainRow["client_division"].ToString();
            lbRep.Text = chainRow["client_rep"].ToString();

            lbDay.Text =  order.getDataRow()["create_at"].ToString();
            lbCreate.Text = chainEmployeeRow["family_name"].ToString() + " " + chainEmployeeRow["first_name"].ToString(); ;

            tbModel.Text = order.getDataRow()["car_model"].ToString();
            tbCarName.Text = order.getDataRow()["car_classification"].ToString();
            tbYear.Text = order.getDataRow()["car_model_year"].ToString();
            tbColor.Text = order.getDataRow()["car_color"].ToString();
            //tbMile.Text = String.Format("{0:#,0}", Int32.Parse(order.getDataRow()["car_mileage"].ToString())) + "km";
            tbMile.Text = order.getDataRow()["car_mileage"].ToString();
            //tbPrice.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(order.getDataRow()["budget"].ToString()));
            tbPrice.Text = order.getDataRow()["budget"].ToString();
            tbInfo.Text = order.getDataRow()["fine_info"].ToString();

            String id = order.getDataRow()["order_rep"].ToString();
            cbOrderRep.ValueMember = "id";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL文を発行する
            DataSet dset = new DataSet("bid");
            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();

            //日付************************************************
            String date = dateTimePicker1.Value.ToShortDateString();
            date.Replace("/", "-");
            //*****************************************************


            if (radioButton3.Checked == true)
            {
                
                trans = "0";
            }
            else if (radioButton4.Checked == true)
            {
                
                trans = "1";
            }



            String sql = "UPDATE `sugukuru`.`orders` " +
            "SET `car_model` = '"+tbModel.Text+"', `car_classification` = '"+tbCarName.Text+"', `car_model_year` = '"+tbYear.Text+"', `car_color` = '"+tbColor.Text+"', `transmission` = '"+trans+"', `car_mileage` = '"+tbMile.Text+"', `budget` = '"+tbPrice.Text+"', `fine_info` = '"+tbInfo.Text+ "',update_at = '" + date + "', `update_rep` = '" + cbChengeRep.SelectedValue+"' WHERE `orders`.`id` = '"+ order.getDataRow()["id"].ToString() + "';";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("変更しました。");


            Close();

        }
    }
}

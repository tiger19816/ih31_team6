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

namespace sugukuru.Customer
{
    public partial class CustomerListControl : sugukuru.FormMaster.UserControlMST
    {
        String conStr;
        public CustomerListControl()
        {
            Console.WriteLine("A");
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            //受注担当者をセットする(営業担当者のみ)
            Utility.ResponsibleList.setSales(searchSalesReq);
            //初期選択を未選択にする
            searchSalesReq.SelectedIndex = -1;


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            Boolean flg = false;
            String SQL =    "SELECT client.id AS '顧客ID', "+
                            "client.formal_name AS '正式名称', "+
                            "client.formal_name_read AS '正式名称カナ', "+
                            "client.abbreviation AS '略称', "+
                            "client.abbreviation_read AS '略称読み', "+
                            "client.postal_code AS '郵便番号', "+
                            "client.prefectures AS '都道府県', "+
                            "client.municipality AS '市町村以下', "+
                            "client.client_division AS '取引先部署', "+
                            "client.client_rep AS '取引先担当者', "+
                            "client.phone_number AS '電話番号', "+
                            "client.fax AS 'ファックス', client.mail_address AS 'メールアドレス', "+
                            "client.fine_info AS '微細情報', "+
                            "CONCAT(employee.family_name, ' ', employee.first_name) AS '営業担当者' "+
                            "FROM client "+
                            "INNER JOIN employee ON client.sales_rep = employee.id";
            String searchType = "";
            if (radioButton1.Checked)
            {
                searchType = "OR";
            }
            if (radioButton2.Checked)
            {
                searchType = "AND";
            }

            if (!searchCustomerId.Text.Equals(""))
            {
                SQL += " WHERE id LIKE '%" + searchCustomerId.Text + "%'";
                flg = true;
            }
            if (!searchCustomerName.Text.Equals(""))
            {
                if (flg)
                {
                    SQL += " " + searchType + " formal_name LIKE '%" + searchCustomerName.Text + "%'";
                    SQL += " " + searchType + " formal_name_read LIKE '%" + searchCustomerName.Text + "%'";
                    SQL += " " + searchType + " abbreviation LIKE '%" + searchCustomerName.Text + "%'";
                    SQL += " " + searchType + " abbreviation_read LIKE '%" + searchCustomerName.Text + "%'";
                }
                else
                {
                    SQL += " WHERE formal_name LIKE '%" + searchCustomerName.Text + "%'";
                    SQL += " " + searchType + " formal_name_read LIKE '%" + searchCustomerName.Text + "%'";
                    SQL += " " + searchType + " abbreviation LIKE '%" + searchCustomerName.Text + "%'";
                    SQL += " " + searchType + " abbreviation_read LIKE '%" + searchCustomerName.Text + "%'";
                    flg = true;
                }
            }
            if (!searchCustomerPostalCode.Text.Equals(""))
            {
                if (flg)
                {
                    SQL += " " + searchType + " postal_code LIKE '%" + searchCustomerPostalCode.Text + "%'";
                }
                else
                {
                    SQL += " WHERE postal_code LIKE '%" + searchCustomerPostalCode.Text + "%'";
                    flg = true;
                }
            }
            if (!searchCustomerAddress.Text.Equals(""))
            {
                if (flg)
                {
                    SQL += " " + searchType + " prefectures LIKE '%" + searchCustomerAddress.Text + "%'";
                    SQL += " " + searchType + " municipality LIKE '%" + searchCustomerAddress.Text + "%'";
                }
                else
                {
                    SQL += " WHERE prefectures '%" + searchCustomerAddress.Text + "%'";
                    SQL += " " + searchType + " municipality LIKE '%" + searchCustomerAddress.Text + "%'";
                    flg = true;
                }
            }
            if (!searchCustomerTEL.Text.Equals(""))
            {
                if (flg)
                {
                    SQL += " " + searchType + " phone_number LIKE '%" + searchCustomerTEL.Text + "%'";
                }
                else
                {
                    SQL += " WHERE phone_number LIKE '%" + searchCustomerTEL.Text + "%'";
                    flg = true;
                }
            }
            //営業担当者用
            if (searchSalesReq.SelectedItem != null)
            {
                if (flg)
                {
                    SQL += " " + searchType + " CONCAT(employee.family_name, ' ', employee.first_name) LIKE '%" + searchSalesReq.Text + "%'";
                }
                else
                {
                    SQL += " WHERE CONCAT(employee.family_name, ' ', employee.first_name) LIKE '%" + searchSalesReq.Text + "%'";
                    flg = true;
                }
            }
            Console.WriteLine(SQL);

            DataSet dset = new DataSet("client");
            MySqlConnection con = new MySqlConnection(conStr);

            con.Open();
            MySqlDataAdapter mAdp = new MySqlDataAdapter(SQL, con);
            mAdp.Fill(dset, "client");
            clientList.DataSource = dset.Tables["client"];

            con.Close();
        }
    }
}

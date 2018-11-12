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
        public CustomerListControl()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //String conStr;
            //Boolean flg = false;
            //conStr = ConfigurationManager.AppSetting["DbCon"];
            //String SQL = "SELECT *";
            //String searchType;
            //if (radioButton1.Checked)
            //{
            //    searchType = "OR";
            //}
            //if (radioButton2.Checked)
            //{
            //    searchType = "AND";
            //}

            //if (searchCustomerId != null)
            //{
            //    SQL += " WHERE id LIKE '%" + searchCustomerId.ToString() + "%'";
            //    flg = true;
            //}
            //if (searchCustomerName != null)
            //{
            //    if (flg)
            //    {
            //        SQL += " '" + searchType + "' formal_name LIKE '%" + searchCustomerName.ToString() + "%'";
            //        SQL += " '" + searchType + "' formal_name_read LIKE '%" + searchCustomerName.ToString() + "%'";
            //        SQL += " '" + searchType + "' abbreviation LIKE '%" + searchCustomerName.ToString() + "%'";
            //        SQL += " '" + searchType + "' abbreviation_read LIKE '%" + searchCustomerName.ToString() + "%'";
            //    }
            //    else
            //    {
            //        SQL += " WHERE formal_name LIKE '%" + searchCustomerName.ToString() + "%'";
            //        SQL += " '" + searchType + "' formal_name_read LIKE '%" + searchCustomerName.ToString() + "%'";
            //        SQL += " '" + searchType + "' abbreviation LIKE '%" + searchCustomerName.ToString() + "%'";
            //        SQL += " '" + searchType + "' abbreviation_read LIKE '%" + searchCustomerName.ToString() + "%'";
            //        flg = true;
            //    }
            //}
            //if (searchCustomerPostalCode != null)
            //{
            //    if (flg)
            //    {
            //        SQL += " '" + searchType + "' postal_code LIKE '%" + searchCustomerPostalCode.ToString() + "%'";
            //    }
            //    else
            //    {
            //        SQL += " WHERE postal_code LIKE '%" + searchCustomerPostalCode.ToString() + "%'";
            //        flg = true;
            //    }
            //}
            //if (searchCustomerAddress != null)
            //{
            //    if (flg)
            //    {
            //        SQL += " '" + searchType + "' prefectures LIKE '%" + searchCustomerAddress.ToString() + "%'";
            //        SQL += " '" + searchType + "' municipality LIKE '%" + searchCustomerAddress.ToString() + "%'";
            //    }
            //    else
            //    {
            //        SQL += " WHERE prefectures '%" + searchCustomerAddress.ToString() + "%'";
            //        SQL += " '" + searchType + "' municipality LIKE '%" + searchCustomerAddress.ToString() + "%'";
            //        flg = true;
            //    }
            //}
            //if (searchCustomerTEL != null)
            //{
            //    if (flg)
            //    {
            //        SQL += " '" + searchType + "' phone_number LIKE '%" + searchCustomerTEL.ToString() + "%'";
            //    }
            //    else
            //    {
            //        SQL += " WHERE phone_number LIKE '%" + searchCustomerTEL.ToString() + "%'";
            //        flg = true;
            //    }
            //}
            ////営業担当者用
            //if ( != null)
            //{
            //    if (flg)
            //    {
            //        SQL += " '" + searchType + "'  LIKE '%" + +"%'";
            //    }
            //    else
            //    {
            //        SQL += " WHERE  '%" + +"%'";
            //        flg = true;
            //    }
            //}
            //DataSet dset = new DataSet("client");
            //MySqlConnection con = new MySqlConnection(conStr);

            //con.Open();
            //MySqlDataAdapter mAdp = new MySqlDataAdapter(SQL, con);
            //mAdp.Fill(dset, "client");
            //clientList.DataSource = dset.Tables["client"];
            //con.Close();
        }
    }
}

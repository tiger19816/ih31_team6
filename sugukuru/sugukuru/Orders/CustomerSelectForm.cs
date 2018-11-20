﻿using System;
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
    public partial class CustomerSelectForm : FormMaster.OpenFormMST
    {
        public bool SelectFlg;
        private Utility.Customer customer = new Utility.Customer();
        String conStr;
        DataTable client = new DataTable("client");
        public Utility.Customer Customer { get => customer; set => customer = value; }

        public CustomerSelectForm()
        {
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
            String SQL = "SELECT * " +
                         "FROM client " +
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

            DataSet dset = new DataSet("client");
            MySqlConnection con = new MySqlConnection(conStr);
            dset.Tables.Add("client");
            con.Open();
            MySqlDataAdapter mAdp = new MySqlDataAdapter(SQL, con);
            mAdp.Fill(dset.Tables["client"]);

            client = dset.Tables["client"];

            DataTable clientInfo = new DataTable("clientInfo");
            clientInfo.Columns.Add("顧客ID", typeof(String));
            clientInfo.Columns.Add("正式名称", typeof(String));
            clientInfo.Columns.Add("正式名称カナ", typeof(String));
            clientInfo.Columns.Add("略称", typeof(String));
            clientInfo.Columns.Add("略称読み", typeof(String));
            clientInfo.Columns.Add("郵便番号", typeof(String));
            clientInfo.Columns.Add("都道府県", typeof(String));
            clientInfo.Columns.Add("市町村以下", typeof(String));
            clientInfo.Columns.Add("取引先部署", typeof(String));
            clientInfo.Columns.Add("取引先担当者", typeof(String));
            clientInfo.Columns.Add("電話番号", typeof(String));
            clientInfo.Columns.Add("ファックス", typeof(String));
            clientInfo.Columns.Add("微細情報", typeof(String));
            clientInfo.Columns.Add("営業担当者姓", typeof(String));
            clientInfo.Columns.Add("営業担当者名", typeof(String));

            for (int i = 0; i < dset.Tables["client"].Rows.Count; i++)
            {
                DataRow datarow = clientInfo.NewRow();
                datarow["顧客ID"] = client.Rows[i]["id"].ToString();
                datarow["正式名称"] = client.Rows[i]["formal_name"].ToString();
                datarow["正式名称カナ"] = client.Rows[i]["formal_name_read"].ToString();
                datarow["略称"] = client.Rows[i]["abbreviation"].ToString();
                datarow["略称読み"] = client.Rows[i]["abbreviation"].ToString();
                datarow["郵便番号"] = client.Rows[i]["postal_code"].ToString();
                datarow["都道府県"] = client.Rows[i]["prefectures"].ToString();
                datarow["市町村以下"] = client.Rows[i]["municipality"].ToString();
                datarow["取引先部署"] = client.Rows[i]["client_division"].ToString();
                datarow["取引先担当者"] = client.Rows[i]["client_rep"].ToString();
                datarow["電話番号"] = client.Rows[i]["phone_number"].ToString();
                datarow["ファックス"] = client.Rows[i]["fax"].ToString();
                datarow["微細情報"] = client.Rows[i]["fine_info"].ToString();
                datarow["営業担当者姓"] = client.Rows[i]["family_name"].ToString();
                datarow["営業担当者名"] = client.Rows[i]["first_name"].ToString();
                clientInfo.Rows.Add(datarow);
            }
            clientList.DataSource = clientInfo;
            con.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in clientList.SelectedRows)
            {
                SelectFlg = true;
                customer.setDataRow(client.Rows[r.Index]);
                this.Close();
            }
        }
    }
}

﻿using System;
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
    public partial class OrderSelectForm : FormMaster.OpenFormMST
    {
        public bool SelectFlg;
        //DB接続文字列取得
        String conStr;
        //返り値用のDataRowが入るDataTable
        DataTable order = new DataTable("order");
        //返り値用のUtility
        public Utility.Customer Order = new Utility.Customer();

        public OrderSelectForm()
        {
            InitializeComponent();
            //DB接続文字列取得
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        //顧客ID検索ボタン押下
        private void btSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        //検索ボタン
        private void btSearch_Click(object sender, EventArgs e)
        {
            //SQL文発行する
            DataSet dset = new DataSet("order");
            String sql = "SELECT `id`, `client_id`, `order_type`, `car_model`, `car_classification`, `car_model_year`, `car_color`, `car_mileage`, `budget`, `fine_info` FROM sugukuru.orders";
            if (!tbSearchOrderId.Text.Equals(""))
            {
                sql += " where id = '" + tbSearchOrderId.Text + "'";
            }

            MySqlConnection con = new MySqlConnection(this.conStr);
            con.Open();
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);
            mAdp.Fill(dset, "order");

            order = dset.Tables["order"];

            //GridView用のDataTableの作成
            DataTable orderInfo = new DataTable();
            orderInfo.Columns.Add("受注ID", typeof(String));
            orderInfo.Columns.Add("顧客ID", typeof(String));
            orderInfo.Columns.Add("受注種別", typeof(String));
            orderInfo.Columns.Add("型式", typeof(String));
            orderInfo.Columns.Add("車種", typeof(String));
            orderInfo.Columns.Add("年式", typeof(String));
            orderInfo.Columns.Add("色", typeof(String));
            orderInfo.Columns.Add("走行距離", typeof(String));
            orderInfo.Columns.Add("予算", typeof(String));
            orderInfo.Columns.Add("微細情報", typeof(String));

            //GridView用のDataTableにDataを入れる
            for (int i = 0; i < dset.Tables["order"].Rows.Count; i++)
            {
                //DataTableの内の一行を作成する
                DataRow datarow = orderInfo.NewRow();
                datarow["受注ID"] = order.Rows[i]["id"].ToString();
                datarow["顧客ID"] = order.Rows[i]["client_id"].ToString();
                datarow["受注種別"] = order.Rows[i]["order_type"].ToString();
                datarow["型式"] = order.Rows[i]["car_model"].ToString();
                datarow["車種"] = order.Rows[i]["car_classification"].ToString();
                datarow["年式"] = order.Rows[i]["car_model_year"].ToString();
                datarow["色"] = order.Rows[i]["car_color"].ToString();
                datarow["走行距離"] = order.Rows[i]["car_mileage"].ToString();
                datarow["予算"] = order.Rows[i]["budget"].ToString();
                datarow["微細情報"] = order.Rows[i]["fine_info"].ToString();
                orderInfo.Rows.Add(datarow);
            }
            //GridViewへの反映
            gvOrderList.DataSource = orderInfo;
            con.Close();
        }

        //選択ボタン押下処理
        private void btSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gvOrderList.SelectedRows)
            {
                SelectFlg = true;
                Order.setDataRow(order.Rows[r.Index]);
                this.Close();
            }
        }
    }
}

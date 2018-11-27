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
    public partial class OrderListControl : FormMaster.UserControlMST
    {
        //DB接続文字列取得
        String conStr;
        //引数用のDataRowが入るDataTable
        DataTable order = new DataTable("order");
        //引数用のUtility
        public Utility.Customer Order = new Utility.Customer();
        public OrderListControl()
        {
            InitializeComponent();
            //DB接続文字列取得
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        //詳細ボタン
        private void btDetail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gvOrderList.SelectedRows)
            {
                Order.setDataRow(order.Rows[r.Index]);
            }
            Form OpenFM = new OrderDetailForm(Order);
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        //検索ボタン
        private void btSearch_Click(object sender, EventArgs e)
        {
            //SQL文発行する
            DataSet dset = new DataSet("order");
            String sql =    "SELECT * " +
                            "FROM sugukuru.orders " +
                            "LEFT JOIN bid ON id = bid.order_id";
            bool flg = false;
            if (!tbSearchOrderId.Text.Equals(""))
            {
                sql += " WHERE id = '" + tbSearchOrderId.Text + "'";
                flg = true;
            }
            if (cbSearchProgress.SelectedItem != null)
            {
                if(cbSearchProgress.SelectedItem.ToString() == "未入札")
                {
                    if (flg)
                    {
                        sql += " AND bid.bid_result IS null";
                    }
                    else
                    {
                        sql += " WHERE bid.bid_result IS null";
                    }
                }
                if (cbSearchProgress.SelectedItem.ToString() == "買注残")
                {
                    if (flg)
                    {
                        sql += " AND bid.bid_result = 0";
                    }
                    else
                    {
                        sql += " WHERE bid.bid_result = 0";
                    }
                }
                if (cbSearchProgress.SelectedItem.ToString() == "落札済")
                {
                    if (flg)
                    {
                        sql += " AND bid.bid_result = 1";
                    }
                    else
                    {
                        sql += " WHERE bid.bid_result = 1";
                    }
                }
                
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
            orderInfo.Columns.Add("予算", typeof(int));
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
                datarow["走行距離"] = String.Format("{0:#,0}", Int32.Parse(order.Rows[i]["car_mileage"].ToString())) + "km";
                datarow["予算"] = Int32.Parse(order.Rows[i]["budget"].ToString());
                datarow["微細情報"] = order.Rows[i]["fine_info"].ToString();
                orderInfo.Rows.Add(datarow);
            }
            //GridViewへの反映
            gvOrderList.DataSource = orderInfo;
            gvOrderList.Columns["走行距離"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvOrderList.Columns["予算"].DefaultCellStyle.Format = "c";
            gvOrderList.Columns["予算"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
    }
}

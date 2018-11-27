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
        //検索モード
        private int sqlMode = 0;

        public OrderSelectForm()
        {
            InitializeComponent();
            //DB接続文字列取得
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }
        public OrderSelectForm(int mode)
        {
            InitializeComponent();
            //DB接続文字列取得
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            //SQLモードの設定
            this.sqlMode = mode;
        }

        //顧客ID検索ボタン押下
        private void btSearchCustomer_Click(object sender, EventArgs e)
        {
            //子フォームを開く
            Orders.CustomerSelectForm MenuFM = new Orders.CustomerSelectForm();
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
                tbSearchClientId.Text = selectRow["id"].ToString();
            }
        }

        //検索ボタン
        private void btSearch_Click(object sender, EventArgs e)
        {
            //SQL文発行する
            DataSet dset = new DataSet("order");
            String sql =    "SELECT * " +
                            "FROM sugukuru.orders ";
            bool flg = false;
            

            switch (this.sqlMode)
            {
                //絶対条件なし
                case 0:
                    
                    break;
                //入札登録
                case 1:
                    sql +=  "LEFT JOIN bid ON id = bid.order_id " +
                            "LEFT JOIN quote_detail ON id = quote_detail.order_id " +
                            "WHERE quote_detail.quote_id IS NOT null " +
                            "AND bid.bid_result = 0";
                    break;

                //陸送登録
                case 2:
                    sql +=  "LEFT JOIN bid ON id = bid.order_id " +
                            "LEFT JOIN transportation ON id = transportation.order_id " +
                            "WHERE bid.bid_result = 1 " +
                            "AND transportation.order_id IS null";
                    break;
                    
                //落札後処理状況
                case 3:
                    sql +=  "LEFT JOIN successful_bid_vehicle ON id = successful_bid_vehicle.order_id " +
                            "WHERE successful_bid_vehicle.successful_bid_fixing = 1";
                    break;
            }
            MessageBox.Show(sql);

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

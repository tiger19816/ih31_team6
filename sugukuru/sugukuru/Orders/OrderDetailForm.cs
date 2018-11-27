using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sugukuru.Utility;

namespace sugukuru.Orders
{
    public partial class OrderDetailForm : FormMaster.OpenFormMST
    {
        private Utility.Customer order;

        public OrderDetailForm()
        {
            InitializeComponent();
        }

        public OrderDetailForm(Utility.Customer order)
        {
            InitializeComponent();
            this.order = order;
            DataRow chainRow = Utility.Customer.ChainCustomerId(order.getDataRow()["client_id"].ToString());

            lbOrderId.Text = order.getDataRow()["id"].ToString();
            if (order.getDataRow()["order_type"].ToString() == "1")
            {
                lbOrderType.Text = "買注文";
            }
            else if (order.getDataRow()["order_type"].ToString() == "2")
            {
                lbOrderType.Text = "売注文";
            }
            DataRow chainEmployeeRow = Utility.Customer.ChainEmployeeId(order.getDataRow()["order_rep"].ToString());
            lbOrderRep.Text = chainEmployeeRow["family_name"].ToString() + " " + chainEmployeeRow["first_name"].ToString();
            lbCarModel.Text = order.getDataRow()["car_model"].ToString();
            lbCarClassification.Text = order.getDataRow()["car_classification"].ToString();
            lbCarModelYear.Text = order.getDataRow()["car_model_year"].ToString();
            lbCarColor.Text = order.getDataRow()["car_color"].ToString();
            lbCarMileage.Text = String.Format("{0:#,0}", Int32.Parse(order.getDataRow()["car_mileage"].ToString())) + "km";
            lbBudget.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(order.getDataRow()["budget"].ToString()));

            if (order.getDataRow()["transmission"].ToString() == "0")
            {
                lbTransmission.Text = "AT";
            }
            else if(order.getDataRow()["transmission"].ToString() == "1")
            {
                lbTransmission.Text = "MT";
            }
            lbFineInfo.Text = order.getDataRow()["fine_info"].ToString();

            //登録日
            DateTime bufDate = DateTime.Parse(order.getDataRow()["create_at"].ToString());
            lbOrderReceiveDate.Text = bufDate.ToString("yyyy年MM月dd日");
            chainEmployeeRow = Utility.Customer.ChainEmployeeId(order.getDataRow()["create_rep"].ToString());
            lbOrderReceiveRep.Text = chainEmployeeRow["family_name"].ToString() + " " + chainEmployeeRow["first_name"].ToString(); ;
            //変更日
            bufDate = DateTime.Parse(order.getDataRow()["update_at"].ToString());
            if (bufDate.ToString("yyyy年MM月dd日") != "0001年01月01日")
            {
                lbUpdateDate.Text = bufDate.ToString("yyyy年MM月dd日");
                chainEmployeeRow = Utility.Customer.ChainEmployeeId(order.getDataRow()["create_rep"].ToString());
                lbUpdateRep.Text = chainEmployeeRow["family_name"].ToString() + " " + chainEmployeeRow["first_name"].ToString();
            }
            else
            {
                lbUpdateDate.Text = "";
            }

            lbClientName.Text = chainRow["formal_name"].ToString();
            lbClientNameRead.Text = chainRow["formal_name_read"].ToString();
            lbPostalCode.Text = String.Format("{0:000-0000}", Int32.Parse(chainRow["postal_code"].ToString()));
            lbAddress.Text = chainRow["address"].ToString();
            lbPhoneNumber.Text = chainRow["phone_number"].ToString();
            lbFax.Text = chainRow["fax"].ToString();
            lbClientDivision.Text = chainRow["client_division"].ToString();
            lbClientRep.Text = chainRow["client_rep"].ToString();

            DataTable chainAuction = Utility.Customer.ChainOrderId(order.getDataRow()["id"].ToString());
            DataTable auctionLog = new DataTable();

            auctionLog.Columns.Add("オークション会場名", typeof(String));
            auctionLog.Columns.Add("出品番号", typeof(String));
            auctionLog.Columns.Add("入札日付", typeof(String));
            auctionLog.Columns.Add("入札金額", typeof(int));
            auctionLog.Columns.Add("入札結果", typeof(String));

            for (int i = 0; i < chainAuction.Rows.Count; i++)
            {
                DataRow datarow = auctionLog.NewRow();
                datarow["オークション会場名"] = chainAuction.Rows[i]["auction_hall_name"].ToString();
                datarow["出品番号"] = chainAuction.Rows[i]["listing_number"].ToString();
                bufDate = DateTime.Parse(chainAuction.Rows[i]["bid_date"].ToString());
                datarow["入札日付"] = bufDate.ToString("yyyy年MM月dd日");
                datarow["入札金額"] = Int32.Parse(chainAuction.Rows[i]["bid_price"].ToString());
                if (chainAuction.Rows[i]["bid_result"].ToString() == "0") {
                    datarow["入札結果"] = "不成立";
                }else if (chainAuction.Rows[i]["bid_result"].ToString() == "1")
                {
                    datarow["入札結果"] = "成立";
                }
                auctionLog.Rows.Add(datarow);
            }
            if(chainAuction.Rows.Count != 0)
            {
                if(chainAuction.Rows[chainAuction.Rows.Count - 1]["bid_result"].ToString() == "0")
                {
                    lbState.Text = "注残";
                }
                else if (chainAuction.Rows[chainAuction.Rows.Count - 1]["bid_result"].ToString() == "1")
                {
                    lbState.Text = "完了";
                    btTransportation.Visible = true;
                    btCompleteOrderInfo.Visible = true;
                }
            }
            else
            {
                if (order.getDataRow()["order_type"].ToString() == "1")
                {
                    lbState.Text = "未入札";
                }
                else if(order.getDataRow()["order_type"].ToString() == "2")
                {
                    lbState.Text = "未出品";
                }
                
            }

            gvAuctionLog.DataSource = auctionLog;
            gvAuctionLog.Columns["入札金額"].DefaultCellStyle.Format = "c";
            gvAuctionLog.Columns["入札金額"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvAuctionLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }

        private void btOrderChange_Click(object sender, EventArgs e)
        {
            String select = "";
            for (int i = 0; i < order.getDataRow().ItemArray.Length; i++)
            {
                select += order.getDataRow()[i].ToString() + ", ";
            }
            MessageBox.Show(select);
            //Form OpenFM = new OrderChangeForm();
            //OpenFM.ShowDialog();
            //OpenFM.Dispose();
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow chainTrans = Utility.Customer.ChainTransportation(order.getDataRow()["id"].ToString());

            Form OpenFM = new Transportation(chainTrans);
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        private void btCompleteOrderInfo_Click(object sender, EventArgs e)
        {
            DataRow chainComplete = Utility.Customer.ChainComleteOrder(order.getDataRow()["id"].ToString());

            Form OpenFM = new OrderCompleteDetailForm(chainComplete);
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }
    }
}

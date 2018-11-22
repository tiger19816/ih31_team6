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
            if(order.getDataRow()["order_type"].ToString() == "1")
            {
                lbOrderType.Text = "買注文";
            }
            else if(order.getDataRow()["order_type"].ToString() == "2")
            {
                lbOrderType.Text = "売注文";
            }
            DataRow chainEmployeeRow = Utility.Customer.ChainEmployeeId(order.getDataRow()["order_rep"].ToString());
            lbOrderRep.Text = chainEmployeeRow["family_name"].ToString() + " " + chainEmployeeRow["first_name"].ToString();
            lbCarModel.Text = order.getDataRow()["car_model"].ToString();
            lbCarClassification.Text = order.getDataRow()["car_classification"].ToString();
            lbCarModelYear.Text = order.getDataRow()["car_model_year"].ToString();
            lbCarColor.Text = order.getDataRow()["car_color"].ToString();
            lbCarMileage.Text = order.getDataRow()["car_mileage"].ToString();
            lbBudget.Text = order.getDataRow()["budget"].ToString();
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
            lbPostalCode.Text = chainRow["postal_code"].ToString();
            lbAddress.Text = chainRow["address"].ToString();
            lbPhoneNumber.Text = chainRow["phone_number"].ToString();
            lbFax.Text = chainRow["fax"].ToString();
            lbClientDivision.Text = chainRow["client_division"].ToString();
            lbClientRep.Text = chainRow["client_rep"].ToString();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.Orders
{
    public partial class OrderChangeForm : FormMaster.OpenFormMST
    {

        private Utility.Customer order;

        public OrderChangeForm()
        {
            InitializeComponent();
        }


        public OrderChangeForm(Utility.Customer order)
        {
            InitializeComponent();

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
            tbMile.Text = String.Format("{0:#,0}", Int32.Parse(order.getDataRow()["car_mileage"].ToString())) + "km";
            tbPrice.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(order.getDataRow()["budget"].ToString()));




        }
    }
}

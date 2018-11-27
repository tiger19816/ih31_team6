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
    public partial class OrderCompleteDetailForm : Form
    {
        public OrderCompleteDetailForm()
        {
            InitializeComponent();
        }
        public OrderCompleteDetailForm(DataRow orderDetail)
        {
            InitializeComponent();
            lbOrderId.Text = orderDetail["order_id"].ToString();
            lbCarModel.Text = orderDetail["car_model"].ToString();
            lbUndercarriageNumber.Text = orderDetail["undercarriage_number"].ToString();
            lbCarModelYear.Text = orderDetail["car_model_year"].ToString();
            lbCarName.Text = orderDetail["car_name"].ToString();
            lbCarColor.Text = orderDetail["car_color"].ToString();
            lbCarMileage.Text = String.Format("{0:#,0}", Int32.Parse(orderDetail["car_mileage"].ToString())) + "km";
            lbTransmission.Text = orderDetail["transmission"].ToString();
            if (orderDetail["transmission"].ToString() == "0")
            {
                lbTransmission.Text = "AT";
            }
            else if (orderDetail["transmission"].ToString() == "1")
            {
                lbTransmission.Text = "MT";
            }
            lbFineInfo.Text = orderDetail["fine_info"].ToString();
            lbBidVehicleTax.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(orderDetail["successful_bid_vehicle_tax"].ToString()));
            lbContractedBidQuantity.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(orderDetail["contracted_successful_bid_quantity"].ToString()));
            lbVehicleTaxEquivalent.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(orderDetail["vehicle_tax_equivalent"].ToString()));
            lbFee.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(orderDetail["fee"].ToString()));
            if(orderDetail["successful_bid_fixing"].ToString() == "0")
            {
                lbBidFixing.Text = "未確定";
            }
            else if(orderDetail["successful_bid_fixing"].ToString() == "1")
            {
                lbBidFixing.Text = "確定";
            }
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

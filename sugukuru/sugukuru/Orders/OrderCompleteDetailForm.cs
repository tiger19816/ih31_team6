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
            lbCarMileage.Text = orderDetail["car_mileage"].ToString();
            lbTransmission.Text = orderDetail["transmission"].ToString();
            lbFineInfo.Text = orderDetail["fine_info"].ToString();
            lbBidVehicleTax.Text = orderDetail["successful_bid_vehicle_tax"].ToString();
            lbContractedBidQuantity.Text = orderDetail["contracted_successful_bid_quantity"].ToString();
            lbVehicleTaxEquivalent.Text = orderDetail["vehicle_tax_equivalent"].ToString();
            lbFee.Text = orderDetail["fee"].ToString();
            lbBidFixing.Text = orderDetail["successful_bid_fixing"].ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class OrdersForm : sugukuru.FormMaster.FormMST
    {
        //staticで宣言することでインスタンスを固定
        public static OrderRegistrationControl o_registration;
        public static OrderListControl o_list;
        public static EstimateControl o_estimate;

        public OrdersForm()
        {
            InitializeComponent();

            o_registration = new OrderRegistrationControl();
            o_list = new OrderListControl();
            o_estimate = new EstimateControl();

            panel1.Controls.Add(o_registration);
            panel1.Controls.Add(o_list);
            panel1.Controls.Add(o_estimate);

            o_list.Visible = true;
            o_registration.Visible = false;
            o_estimate.Visible = false;
        }

        private void btList_Click(object sender, EventArgs e)
        {
            o_list.Visible = true;
            o_registration.Visible = false;
            o_estimate.Visible = false;
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            o_list.Visible = false;
            o_registration.Visible = true;
            o_estimate.Visible = false;
        }

        private void btEstimate_Click(object sender, EventArgs e)
        {
            o_list.Visible = false;
            o_registration.Visible = false;
            o_estimate.Visible = true;
        }
    }
}

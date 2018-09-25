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

        public OrdersForm()
        {
            InitializeComponent();

            o_registration = new OrderRegistrationControl();

            panel1.Controls.Add(o_registration);

            o_registration.Visible = true;
        }

        private void btList_Click(object sender, EventArgs e)
        {

        }

        private void btRegistration_Click(object sender, EventArgs e)
        {

        }

        private void btQuotation_Click(object sender, EventArgs e)
        {

        }
    }
}

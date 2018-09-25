using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.Orders
{
    public partial class OrderListControl : FormMaster.UserControlMST
    {
        public OrderListControl()
        {
            InitializeComponent();
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            Form OpenFM = new OrderDetailForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }
    }
}

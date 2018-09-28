using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.ClaimCollection
{
    public partial class ReceiptPrinting : FormMaster.UserControlMST
    {
        public ReceiptPrinting()
        {
            InitializeComponent();
        }

        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Form OpenFM = new sugukuru.Orders.CustomerSelectForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

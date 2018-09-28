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
    public partial class EstimateControl : FormMaster.UserControlMST
    {
        public EstimateControl()
        {
            InitializeComponent();
        }

        private void btEstimateAdd_Click(object sender, EventArgs e)
        {
            Form OpenFM = new EstimateAddForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Form OpenFM = new CustomerSelectForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }
    }
}

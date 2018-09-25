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
    public partial class OrderDetailForm : FormMaster.OpenFormMST
    {
        public OrderDetailForm()
        {
            InitializeComponent();
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
            Form OpenFM = new OrderChangeForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }
    }
}

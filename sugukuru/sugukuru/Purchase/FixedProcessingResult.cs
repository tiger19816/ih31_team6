using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.Purchase
{
    public partial class FixedProcessingResult : UserControl
    {
        public FixedProcessingResult()
        {
            InitializeComponent();
        }

        private void btData_Click(object sender, EventArgs e)
        {
            BidResult b = new BidResult();
            b.Show();
        }
    }
}

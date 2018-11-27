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
    public partial class Transportation : Form
    {
        public Transportation()
        {
            InitializeComponent();
        }
        public Transportation(DataRow transportation)
        {
            InitializeComponent();
            lbOrderId.Text = transportation["order_id"].ToString();
            lbVenderName.Text = transportation["name"].ToString();
            lbStartPostalCode.Text = String.Format("{0:000-0000}", Int32.Parse(transportation["starting_postal_code"].ToString()));
            lbStartAddress.Text = transportation["starting_address"].ToString();
            lbEndPostalCode.Text = String.Format("{0:000-0000}", Int32.Parse(transportation["destination_postal_code"].ToString()));
            lbEndAddress.Text = transportation["destination_address"].ToString();
            lbFee.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(transportation["fee"].ToString()));
            DateTime bufDate = DateTime.Parse(transportation["order_date"].ToString());
            lbOrderDate.Text = bufDate.ToString("yyyy年MM月dd日");
            lbSlipNumber.Text = transportation["slip_number"].ToString();
            lbResponsName.Text = transportation["family_name"].ToString() + " " + transportation["first_name"].ToString(); ;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.MainMenu
{
    public partial class MainMenuForm : sugukuru.FormMaster.BaseFormMST
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Form ContentFM = null;
            if (sender.Equals(btOrder))
            {
                ContentFM = new Orders.OrdersForm();
            }
            else if (sender.Equals(btCustomer))
            {
                ContentFM = new Customer.CustomerForm();
            }
            else if (sender.Equals(btClaimCollection))
            {
                ContentFM = new ClaimCollection.ClaimCollectionForm();
            }
            else if (sender.Equals(btPurchase))
            {
                ContentFM = new Purchase.Purchase();
            }
            else if (sender.Equals(btSales))
            {
                ContentFM = new Purchase.SaleForm();
            }
            ContentFM.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("ログアウトします。よろしいですか？", "確認", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

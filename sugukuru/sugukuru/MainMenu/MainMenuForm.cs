﻿using System;
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
            this.Hide();
            ContentFM.ShowDialog();
            ContentFM.Dispose();
            this.Show();
        }
    }
}

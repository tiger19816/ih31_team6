﻿using System;
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
    public partial class BidInfoInput : FormMaster.UserControlMST
    {
        public BidInfoInput()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void btFixed_Click(object sender, EventArgs e)
        {
            //確定ボタン
           
            
    
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Form MenuFM = new OrderSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();
        }
    }
}

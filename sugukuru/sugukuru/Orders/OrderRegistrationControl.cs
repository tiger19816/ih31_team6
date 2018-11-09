﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sugukuru.Orders
{
    public partial class OrderRegistrationControl : UserControl
    {
        //DB接続文字列の取得
        string conStr;

        public OrderRegistrationControl()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }

        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Form MenuFM = new CustomerSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();
        }
    }
}

﻿using System;
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
    public partial class IndividualReconciliation : UserControl
    {
        public IndividualReconciliation()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<String> receiveList = IndividualSelectForm.ShowForm();
        }
    }
}

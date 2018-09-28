using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.ClaimCollection
{
    public partial class ClaimCollectionForm : sugukuru.FormMaster.FormMST
    {
        public static CheckAccountReceivable ctr1;
        public static IndividualClaim ctr2;
        public static BulkClaim ctr3;
        public static IndividualReconciliation ctr4;
        public static BulkReconciliation ctr5;
        public static RepetitionClaim ctr6;
        public static ReceiptPrinting ctr7;

        public ClaimCollectionForm()
        {
            InitializeComponent();

            inheritableFlowLayoutPanel1.SuspendLayout();

            //currentButtonのインデックス値を0にして先頭にする
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btCheckAccountReceivable, 0);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btIndividualClaim, 1);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btBulkClaim, 2);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btIndividualReconciliation, 3);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btBulkReconciliation, 4);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btRepetitionClaim, 5);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btReceiptPrinting, 6);

            btIndividualClaim.Text = "個別請求書" + Environment.NewLine + "発行";
            btBulkClaim.Text = "一括請求書" + Environment.NewLine + "発行";

            inheritableFlowLayoutPanel1.ResumeLayout();

            ctr1 = new CheckAccountReceivable();
            ctr2 = new IndividualClaim();
            ctr3 = new BulkClaim();
            ctr4 = new IndividualReconciliation();
            ctr5 = new BulkReconciliation();
            ctr6 = new RepetitionClaim();
            ctr7 = new ReceiptPrinting();

            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            panel1.Controls.Add(ctr3);
            panel1.Controls.Add(ctr4);
            panel1.Controls.Add(ctr5);
            panel1.Controls.Add(ctr6);
            panel1.Controls.Add(ctr7);

            ctr1.Visible = true;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;
            ctr5.Visible = false;
            ctr6.Visible = false;
            ctr7.Visible = false;
        }

        private void btCheckAccountReceivable_Click(object sender, EventArgs e)
        {
            ctr1.Visible = true;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;
            ctr5.Visible = false;
            ctr6.Visible = false;
            ctr7.Visible = false;
        }

        private void btIndividualClaim_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = true;
            ctr3.Visible = false;
            ctr4.Visible = false;
            ctr5.Visible = false;
            ctr6.Visible = false;
            ctr7.Visible = false;
        }

        private void btBulkClaim_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = false;
            ctr3.Visible = true;
            ctr4.Visible = false;
            ctr5.Visible = false;
            ctr6.Visible = false;
            ctr7.Visible = false;
        }

        private void btIndividualReconciliation_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = true;
            ctr5.Visible = false;
            ctr6.Visible = false;
            ctr7.Visible = false;
        }

        private void btBulkReconciliation_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;
            ctr5.Visible = true;
            ctr6.Visible = false;
            ctr7.Visible = false;
        }

        private void btRepetitionClaim_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;
            ctr5.Visible = false;
            ctr6.Visible = true;
            ctr7.Visible = false;
        }

        private void btReceiptPrinting_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;
            ctr5.Visible = false;
            ctr6.Visible = false;
            ctr7.Visible = true;
        }
    }
}

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
    public partial class BidCarProcessing : UserControl
    {
        public static BidResult BidResult;
        public static FixedPostProcessing FixedPostProcessing;
        public static FixedProcessingResult FixedProcessingResult;
       
            


        public BidCarProcessing()
        {
            InitializeComponent();

            BidResult = new BidResult();
            FixedPostProcessing = new FixedPostProcessing();
            FixedProcessingResult = new FixedProcessingResult();

            panel2.Controls.Add(BidResult);
            panel2.Controls.Add(FixedPostProcessing);
            panel2.Controls.Add(FixedProcessingResult);




        }

        private void btCarResult_Click(object sender, EventArgs e)
        {
            //落札車両確定
            BidResult.Visible = true;
            FixedPostProcessing.Visible = false;
            FixedProcessingResult.Visible = false;

        }

        private void btFixedProcessing_Click(object sender, EventArgs e)
        {
            //落札後処理登録
            BidResult.Visible = false;
            FixedPostProcessing.Visible = true;
            FixedProcessingResult.Visible = false;
        }

        private void btProcessingResult_Click(object sender, EventArgs e)
        {
            //落札後処理確認・確定
            BidResult.Visible = false;
            FixedPostProcessing.Visible = false;
            FixedProcessingResult.Visible = true;
        }
    }
}

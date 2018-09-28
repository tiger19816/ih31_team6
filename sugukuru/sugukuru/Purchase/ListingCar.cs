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
    public partial class ListingCar : UserControl
    {

        public static ListingProcessingResult listingProcessingResult;
        public static ListingPostProcessing listingPostProcessing;
        public static ListingResultFixed listingResultFixed;

        public ListingCar()
        {
            InitializeComponent();
            listingProcessingResult = new ListingProcessingResult();
            listingPostProcessing = new ListingPostProcessing();
            listingResultFixed = new ListingResultFixed();

            panel2.Controls.Add(listingProcessingResult);
            panel2.Controls.Add(listingPostProcessing);
            panel2.Controls.Add(listingResultFixed);



        }

        private void btResult_Click(object sender, EventArgs e)
        {
            //出品結果確定
            listingResultFixed.Visible = true;
            listingPostProcessing.Visible = false;
            listingProcessingResult.Visible = false;

        }

        private void btListingProcessing_Click(object sender, EventArgs e)
        {
            //出品後手続き内容登録
            listingResultFixed.Visible = false;
            listingPostProcessing.Visible = true;
            listingProcessingResult.Visible = false;
        }

        private void btProccesingResult_Click(object sender, EventArgs e)
        {
            //出品後手続確認・確定
            listingResultFixed.Visible = false;
            listingPostProcessing.Visible = false;
            listingProcessingResult.Visible = true;
        }
    }
}

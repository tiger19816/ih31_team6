using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.Purchase
{
    public partial class SaleForm : FormMaster.FormMST
    {
        public static BidInfoInput BidInfoInput;
        public static Transport Transport;
        public static ListingRegistration listingRegistration;
        public static ListingResult ListingResult;
        public static ListingCar ListingCar;

        public SaleForm()
        {
            InitializeComponent();

            BidInfoInput = new BidInfoInput();
            Transport = new Transport();
            listingRegistration = new ListingRegistration();
            ListingResult = new ListingResult();
            ListingCar = new ListingCar();
            
            panel1.Controls.Add(BidInfoInput);
            panel1.Controls.Add(Transport);
            panel1.Controls.Add(listingRegistration);
            panel1.Controls.Add(ListingResult);
            panel1.Controls.Add(ListingCar);
            
            BidInfoInput.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            ListingResult.Visible = false;
            ListingCar.Visible = false;
        }

        private void btListingResult_Click(object sender, EventArgs e)
        {
            BidInfoInput.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            ListingResult.Visible = true;
            ListingCar.Visible = false;
        }

        private void btBitInfo_Click(object sender, EventArgs e)
        {
            BidInfoInput.Visible = true;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            ListingResult.Visible = false;
            ListingCar.Visible = false;
        }

        private void btListingCar_Click(object sender, EventArgs e)
        {
            BidInfoInput.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            ListingResult.Visible = false;
            ListingCar.Visible = true;
        }

        private void btTransportInfo_Click(object sender, EventArgs e)
        {
            BidInfoInput.Visible = false;
            Transport.Visible = true;
            listingRegistration.Visible = false;
            ListingResult.Visible = false;
            ListingCar.Visible = false;
        }

        private void btDisposalCar_Click(object sender, EventArgs e)
        {
            BidInfoInput.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = true;
            ListingResult.Visible = false;
            ListingCar.Visible = false;
        }
    }
}

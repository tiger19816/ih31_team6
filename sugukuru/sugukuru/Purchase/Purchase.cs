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
    public partial class Purchase : sugukuru.FormMaster.FormMST
    {

        public static Search ctr1;
        public static BidInfoInput BidInfoInput;
        public static DeliverySlip DeliverySlip;
        //public static BidCarInput BidCarInput;
        public static Transport Transport;
        public static ListingRegistration listingRegistration;
        public static Discount Discount;
        public static ListingResult ListingResult;
        public static BidCarProcessing BidCarProcessing;
        public static ListingCar ListingCar;
        




       public Purchase()
        {
            InitializeComponent();

            ctr1 = new Search();
            BidInfoInput = new BidInfoInput();
            DeliverySlip = new DeliverySlip();
            //BidCarInput = new BidCarInput();
            Transport = new Transport();
            listingRegistration = new ListingRegistration();
            Discount = new Discount();
            ListingResult = new ListingResult();
            BidCarProcessing = new BidCarProcessing();
            ListingCar = new ListingCar();

            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(BidInfoInput);
            panel1.Controls.Add(DeliverySlip);
            //panel1.Controls.Add(BidCarInput);
            panel1.Controls.Add(Transport);
            panel1.Controls.Add(listingRegistration);
            panel1.Controls.Add(Discount);
            panel1.Controls.Add(ListingResult);
            panel1.Controls.Add(BidCarProcessing);
            panel1.Controls.Add(ListingCar);

            ctr1.Visible = true;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            //BidCarInput.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;
           

        }
        

        private void btBitInfo_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            BidInfoInput.Visible = true;
            DeliverySlip.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;
        }

        private void btDeliverySlip_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = true;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;
        }

        private void btBitCar_Click(object sender, EventArgs e)
        {
            //落札車両処理
            ctr1.Visible = false;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = true;
            ListingCar.Visible = false;


        }

        private void btTransportInfo_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            Transport.Visible = true;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;
        }

        private void btDisposalCar_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = true;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;
        }

        private void btDisposalCarPurchase_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = true;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;
        }

        private void btBidCarList_Click(object sender, EventArgs e)
        {
            ctr1.Visible = true;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;
        }

        private void btListingCar_Click(object sender, EventArgs e)
        {
            //出品車両処理
            ctr1.Visible = false;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            //BidCarInput.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = false;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = true;



        }

        private void btListingResult_Click(object sender, EventArgs e)
        {
            //出品結果登録
            ctr1.Visible = false;
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            //BidCarInput.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            ListingResult.Visible = true;
            BidCarProcessing.Visible = false;
            ListingCar.Visible = false;

        }

        private void btBidCarInput_Click(object sender, EventArgs e)
        {
            BidCarInput f = new BidCarInput();
            //Form2を表示する
            f.Show();
            
        }
    }
}

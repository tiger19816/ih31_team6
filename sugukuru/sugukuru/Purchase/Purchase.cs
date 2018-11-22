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
        
        public static BidInfoInput BidInfoInput;
        public static DeliverySlip DeliverySlip;
        public static BitCarList BidCarList;
        public static Transport Transport;
        public static ListingRegistration listingRegistration;
        public static Discount Discount;
        public static BidCarProcessing BidCarProcessing;
        
       public Purchase()
        {
            InitializeComponent();
            
            BidInfoInput = new BidInfoInput();
            DeliverySlip = new DeliverySlip();
            BidCarList = new BitCarList();
            Transport = new Transport();
            listingRegistration = new ListingRegistration();
            Discount = new Discount();
            BidCarProcessing = new BidCarProcessing();

            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btBitInfo, 0);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btBidCarInput, 1);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btBitCar, 2);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btDeliverySlip, 3);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btTransportInfo, 4);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btDisposalCarPurchase, 5);
            
            panel1.Controls.Add(BidInfoInput);
            panel1.Controls.Add(DeliverySlip);
            panel1.Controls.Add(BidCarList);
            panel1.Controls.Add(Transport);
            panel1.Controls.Add(listingRegistration);
            panel1.Controls.Add(Discount);
            panel1.Controls.Add(BidCarProcessing);
            
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            BidCarList.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            BidCarProcessing.Visible = false;
           

        }
        

        private void btBitInfo_Click(object sender, EventArgs e)
        {
            //入札登録
            BidInfoInput.Visible = true;
            DeliverySlip.Visible = false;
            BidCarList.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            BidCarProcessing.Visible = false;
        }

        private void btDeliverySlip_Click(object sender, EventArgs e)
        {
            //納品書
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = true;
            BidCarList.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            BidCarProcessing.Visible = false;
        }

        private void btBitCar_Click(object sender, EventArgs e)
        {
            BidCarProcessing.sqlBid();

            //落札車両処理
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            BidCarList.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            BidCarProcessing.Visible = true;


        }

        private void btTransportInfo_Click(object sender, EventArgs e)
        {
            //陸送登録
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            BidCarList.Visible = false;
            Transport.Visible = true;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            BidCarProcessing.Visible = false;
        }

        private void btDisposalCarPurchase_Click(object sender, EventArgs e)
        {
            //社内販売
            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            BidCarList.Visible = false;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = true;
            BidCarProcessing.Visible = false;
        }

        private void btBidCarInput_Click(object sender, EventArgs e)
        {
            //落札車両登録

            BidCarList.sqlOrder();

            BidInfoInput.Visible = false;
            DeliverySlip.Visible = false;
            BidCarList.Visible = true;
            Transport.Visible = false;
            listingRegistration.Visible = false;
            Discount.Visible = false;
            BidCarProcessing.Visible = false;

        }
    }
}

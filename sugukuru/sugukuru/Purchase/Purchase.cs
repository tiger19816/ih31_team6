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
        public static BidCarInput BidCarInput;
        public static Transport Transport;






       public Purchase()
        {

            ctr1 = new Search();
            panel1.Controls.Add(ctr1);
            ctr1.Visible = true;

            InitializeComponent();

          


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btMenu3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        

        private void btBitInfo_Click(object sender, EventArgs e)
        {
            //入札情報登録画面を開く
            BidInfoInput = new BidInfoInput();
            panel1.Controls.Add(BidInfoInput);


            BidInfoInput.Visible = true;
            ctr1.Visible = false;

        }

        private void btDeliverySlip_Click(object sender, EventArgs e)
        {
            DeliverySlip = new DeliverySlip();
            panel1.Controls.Add(DeliverySlip);
            DeliverySlip.Visible = true;
            ctr1.Visible = false;
        }

        private void btBitCar_Click(object sender, EventArgs e)
        {
            BidCarInput = new BidCarInput();
            panel1.Controls.Add(BidCarInput);
            BidCarInput.Visible = true;
            ctr1.Visible = false;

        }

        private void btTransportInfo_Click(object sender, EventArgs e)
        {
            //陸送情報
            Transport = new Transport();
            panel1.Controls.Add(Transport);
            Transport.Visible = true;
            ctr1.Visible = false;


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.FormSample
{
    public partial class Sample : sugukuru.FormMaster.FormMST
    {
        //staticで宣言することでインスタンスを固定
        public static SampleUserControl1 ctr1;
        public static SampleUserControl2 ctr2;

        public Sample()
        {
            InitializeComponent();
            inheritableFlowLayoutPanel1.SuspendLayout();

            //currentButtonのインデックス値を0にして先頭にする
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btMenu1, 0);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btMenu2, 1);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btMenu3, 2);
            inheritableFlowLayoutPanel1.Controls.SetChildIndex(btMenu4, 3);

            btMenu1.Text = "見積書" + Environment.NewLine + "発行";

            btMenu3.Visible = false;

            inheritableFlowLayoutPanel1.ResumeLayout();


            ctr1 = new SampleUserControl1();
            ctr2 = new SampleUserControl2();

            //パネルにコントロール１、２を追加
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);

            //コントロール1のみを見えるようにする
            ctr1.Visible = true;
            ctr2.Visible = false;
        }

        private void btMenu1_Click(object sender, EventArgs e)
        {
            ctr1.Visible = true;
            ctr2.Visible = false;
        }

        private void btMenu2_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = true;
        }
    }
}

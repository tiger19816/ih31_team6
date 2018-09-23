using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.Customer
{
    public partial class CustomerForm : sugukuru.FormMaster.FormMST
    {
        //staticで宣言することでインスタンスを固定
        public static CustomerRegistrationControl c_registration;
        public static CustomerListControl c_list;

        public CustomerForm()
        {
            InitializeComponent();

            c_registration = new CustomerRegistrationControl();
            c_list = new CustomerListControl();

            //パネルにコントロール１、２を追加
            panel1.Controls.Add(c_registration);
            panel1.Controls.Add(c_list);

            //コントロール1のみを見えるようにする
            c_list.Visible = true;
            c_registration.Visible = false;
        }

        private void btList_Click(object sender, EventArgs e)
        {
            c_list.Visible = true;
            c_registration.Visible = false;
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            c_list.Visible = false;
            c_registration.Visible = true;
        }
    }
}

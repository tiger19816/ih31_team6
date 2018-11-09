using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.FormMaster
{
    public partial class BaseFormMST : Form
    {
        public static int ID;
        public static string NAME = "";
        public static int DIVISION = 1;

        public BaseFormMST()
        {
            InitializeComponent();
            displayControl();
        }

        public BaseFormMST(int id, string name, int division)
        {
            InitializeComponent();
            ID = id;
            NAME = name;
            DIVISION = division;
            displayControl();
        }

        //****************************************************************************
        #region ステータスバーの表示コントロール
        //****************************************************************************
        private void displayControl()
        {
            tsUserName.Text = NAME;
            if (DIVISION == 1)
            {
                tsMySalesLabel.Visible = false;
                tsMySales.Visible = false;
            }
            else
            {
                tsMySalesLabel.Visible = true;
                tsMySales.Visible = true;
            }
        }
        #endregion
    }
}

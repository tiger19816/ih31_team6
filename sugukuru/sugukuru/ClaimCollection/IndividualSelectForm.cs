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
    public partial class IndividualSelectForm : sugukuru.FormMaster.OpenFormMST
    {
        private List<String> returnList;

        public IndividualSelectForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataList.RowCount; i++)
            {
                if (dataList.Rows[i].Cells[7].Value.Equals(true))
                {
                    returnList.Add(dataList.Rows[i].Cells[0].Value.ToString());
                }
            }
        }

        static public List<String> ShowForm()
        {
            IndividualSelectForm form = new IndividualSelectForm();
            form.ShowDialog();
            List<String> reciveList = form.returnList;
            form.Dispose();

            return reciveList;
        }
    }
}

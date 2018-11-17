using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sugukuru.Orders
{
    public partial class EstimateControl : FormMaster.UserControlMST
    {
        DataTable table;
        public EstimateControl()
        {
            InitializeComponent();
            table = new DataTable();
        }

        private void EstimateControl_Load(object sender, EventArgs e)
        {
            // カラムを指定
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // データをつくる
            table.Columns.Add("受注番号");
            table.Columns.Add("品名");
            table.Columns.Add("数量");
            table.Columns.Add("単位");
            table.Columns.Add("単価");
            table.Columns.Add("金額");
            dataGridView1.DataSource = table;
            dataGridView1.Columns["品名"].Width = 250;
        }

        private void btEstimateAdd_Click(object sender, EventArgs e)
        {
            EstimateAddForm OpenFM = new EstimateAddForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();

            if(OpenFM.SelectFlg)
            { 
                DataRow row = table.NewRow();
                row["受注番号"] = OpenFM.Estimate.OrderNumber;
                row["品名"] = OpenFM.Estimate.ProductName;
                row["数量"] = OpenFM.Estimate.Quantity;
                row["単位"] = OpenFM.Estimate.Unit;
                row["単価"] = OpenFM.Estimate.UnitPrice;
                row["金額"] = OpenFM.Estimate.TotalPrice;
                table.Rows.Add(row);
            }
        }

        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Form OpenFM = new CustomerSelectForm();
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();
        }

        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }

    }
}

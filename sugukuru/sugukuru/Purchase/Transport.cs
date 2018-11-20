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
    public partial class Transport : FormMaster.UserControlMST
    {
        public Transport()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //子フォームを開く
            OrderSelectForm selectFM = new OrderSelectForm();
            selectFM.ShowDialog();
            selectFM.Dispose();
            this.Show();

            //子フォームで選択ボタンが押された場合の処理
            if (selectFM.SelectFlg)
            {
                //子フォームからの返り値(DataRow)
                DataRow selectRow = selectFM.Order.getDataRow();
                //DataRowの中身をフォームの中身に追加していく
                //DataRowからの引数はデータベースのカラム名そのまま
                tbOrderId.Text = selectRow["id"].ToString();
                tbCustomerId.Text = selectRow["client_id"].ToString();
                //顧客IDから紐づいている顧客データの取得
                DataRow chainRow = Utility.Customer.ChainCustomerId(selectRow["client_id"].ToString());

                //取得確認用メッセージボックス
                String chainData = "";
                for (int i = 0; i < chainRow.ItemArray.Length; i++)
                {
                    chainData += chainRow[i].ToString() + ", ";
                }
                MessageBox.Show(chainData);
            }
        }
    }
}

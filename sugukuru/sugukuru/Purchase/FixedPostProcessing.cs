using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sugukuru.Purchase
{
    public partial class FixedPostProcessing : FormMaster.UserControlMinMST
    {
        // 受注番号
        string orderId;

        // 担当者番号
        string repId;　// .selected.value

        // 支払い状況
        // 1:支払い済み 0:未支払い
        int paymentStatus;

        // 車両登録状況
        // 1:登録ナンバー付き 0:なし
        int vehicleRegistrationStatus;

        // 支払期限
        string paymentDue;

        // 手続内容
        // 1:移転登録 0:抹消登録
        int procedureContent;

        // 報告期限
        string reportDeadline;

        // 報告完了日付
        string reportCompleteDate;

        // オークション会社に伝達完了
        // 1:チェック 0:未チェック
        int procedureFlag;

        string conStr;
        string sql;

        public FixedPostProcessing()
        {
            InitializeComponent();
            Utility.ResponsibleList.setSales(comboBox1);
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        // Formロード時の処理
        private void FixedPostProcessing_Load(object sender, EventArgs e)
        {
            
        }

        // 検索ボタンが押された処理
        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "181110001";
        }

        // 車両登録状況の登録ナンバー付にチェックが入ったら手続き内容を入力可にする
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        // 車両登録状況のなしにチェックが入ったら手続き内容を入力可にする
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
        }

        // 確定ボタンが押された時の処理
        private void button1_Click(object sender, EventArgs e)
        {
            // データをDBへ追加する
            // DB接続オブジェクトを作成
            //MySqlConnection con = new MySqlConnection(this.conStr);

            //// DB接続
            //con.Open();

            //// SQL発行準備
            //MySqlCommand cmd = new MySqlCommand(sql, con);

            //// SQLの実行
            //cmd.ExecuteNonQuery();

            //// DB切断
            //con.Close();

            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("処理内容を登録しました。",
                "質問",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //何が選択されたか調べる
            if (result == DialogResult.OK)
            {
                //「はい」が選択された時               
            }
        }
    }
}

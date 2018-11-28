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
using IronPdf;

namespace sugukuru.ClaimCollection
{
    public partial class IndividualClaim : FormMaster.UserControlMST
    {
        DataTable table;
        string sql;
        string conStr;

        string clientTEL;
        string clientFAX;

        List<Entites.Estimate> bulkDetailList;

        int resultTemp = 0;

        public IndividualClaim()
        {
            InitializeComponent();
            table = new DataTable();
            this.sql = "";
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            Utility.ResponsibleList.setSales(comboBox1);
            bulkDetailList = new List<Entites.Estimate>();
        }

        private void IndividualClaim_Load(object sender, EventArgs e)
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
            table.Columns.Add("単価", Type.GetType("System.Int32"));
            table.Columns.Add("金額", Type.GetType("System.Int32"));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["品名"].Width = 250;

            //データグリッドビュー料金の3桁カンマ区切り
            dataGridView1.Columns["単価"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["金額"].DefaultCellStyle.Format = "c";

            //データグリッドビュー料金の右揃え
            dataGridView1.Columns["単価"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["金額"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        // 顧客検索時
        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            Orders.CustomerSelectForm MenuFM = new Orders.CustomerSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();

            //子フォームで追加が押下された場合の処理
            if (MenuFM.SelectFlg)
            {
                //返り値の取得(DataRow)
                DataRow selectRow = MenuFM.Customer.getDataRow();
                textBox1.Text = selectRow["id"].ToString();

                this.sql = "SELECT formal_name,postal_code,prefectures,municipality,client_division,client_rep,phone_number,fax FROM `client` WHERE id = '" + textBox1.Text + "'";

                // データを追加
                //抽象データ格納データセットを作成
                DataSet dset = new DataSet("ClientInfo");

                //DB接続オブジェクトを作成
                MySqlConnection con = new MySqlConnection(this.conStr);

                //DB接続
                con.Open();

                //データアダプターの生成
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

                ///データ抽出＆取得
                mAdp.Fill(dset, "ClientInfo");

                //DB切断
                con.Close();

                //抽出件数を取得
                int rcnt = dset.Tables["ClientInfo"].Rows.Count;

                //0件の場合はエラー
                if (rcnt != 0)
                {
                    // 顧客名をセット
                    clientNameLabel.Text = dset.Tables["ClientInfo"].Rows[0]["formal_name"].ToString();

                    // 住所〒をセット
                    clientPostalLabel.Text = dset.Tables["ClientInfo"].Rows[0]["postal_code"].ToString();

                    // 所在地をセット
                    clientAddressLabel.Text = dset.Tables["ClientInfo"].Rows[0]["prefectures"].ToString() + dset.Tables["ClientInfo"].Rows[0]["municipality"].ToString();

                    // 取引先部署をセット
                    clientDivisionLabel.Text = dset.Tables["ClientInfo"].Rows[0]["client_division"].ToString();

                    // 取引先担当者をセット
                    clientReqLabel.Text = dset.Tables["ClientInfo"].Rows[0]["client_rep"].ToString();

                    // FAXをセット
                    clientFAX = dset.Tables["ClientInfo"].Rows[0]["fax"].ToString();

                    // TELをセット
                    clientTEL = dset.Tables["ClientInfo"].Rows[0]["phone_number"].ToString();

                }
                else
                {
                    MessageBox.Show("顧客IDが誤っています。");
                }
            }
        }

        // 追加時
        private void btEstimateAdd_Click(object sender, EventArgs e)
        {
            ClaimCollection.IndividualSelectForm OpenFM = new ClaimCollection.IndividualSelectForm(textBox1.Text);
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();

            if (OpenFM.SelectFlg)
            {
                // OpenFM.Estimateの配列に追加していく
                bulkDetailList.Add(OpenFM.Individual);

                // 追加した項目をデータグリッドビューへ反映
                DataRow row = table.NewRow();
                row["受注番号"] = OpenFM.Individual.OrderNumber;
                row["品名"] = OpenFM.Individual.ProductName;
                row["数量"] = OpenFM.Individual.Quantity;
                row["単位"] = OpenFM.Individual.Unit;
                row["単価"] = OpenFM.Individual.UnitPrice;
                row["金額"] = OpenFM.Individual.TotalPrice;
                table.Rows.Add(row);

                resultTemp += int.Parse(OpenFM.Individual.TotalPrice);

                // 小計を計算し表示
                int result1 = resultTemp;
                subTotalLabel.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(result1.ToString()));
                // 消費税を計算し表示
                int result2 = (result1 / 100 * 8);
                taxLabel.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(result2.ToString()));
                // 合計金額額を計算し表示
                int result3 = (result1 + result2);
                totalLabel.Text = "\\" + String.Format("{0:#,0}", Int32.Parse(result3.ToString()));
            }
        }

        // 印刷
        private void button2_Click(object sender, EventArgs e)
        {
            System.Random r = new System.Random();
            int i1 = r.Next(100000);
            string no = 20000 + String.Format("{0:00000}", i1);

            // 見積内容をhtmlにセットしていく
            DocumentHtmlTemplate page = new DocumentHtmlTemplate();

            // 書類種別をセット
            page.DocumentType = "請求";
            // 書類作成日をセット
            page.DocumentCreationDate = DateTime.Parse(dateTimePicker1.Text).ToString("yyyyMMdd");
            // 書類作成者をセット
            page.DocumentCreationReq = FormMaster.BaseFormMST.NAME;
            // 書類番号をセット
            page.DocumentNumber = no;
            // 書類有効期限
            page.ExpirationDate = "";
            // 支払期限
            page.PaymentDeadline = DateTime.Parse(dateTimePicker2.Text).ToString("yyyy年MM月dd日");
            // 顧客名をセット
            page.ClientName = clientNameLabel.Text;
            // 顧客郵便番号をセット
            page.ClientZip = clientPostalLabel.Text;
            // 顧客住所1をセット
            page.ClientAddress1 = clientAddressLabel.Text;
            // 顧客住所2をセット
            page.ClientAddress2 = "";
            // 顧客FAXをセット
            page.ClientFAX = String.Format("{0:(###)###-####}", Convert.ToInt64(clientFAX));
            // 顧客TELをセット
            page.ClientTEL = String.Format("{0:(###)###-####}", Convert.ToInt64(clientTEL)); ;
            // 顧客部署をセット
            page.ClientDivision = clientDivisionLabel.Text;
            // 顧客担当者をセット
            page.ClientReq = clientReqLabel.Text;
            // 支払い条件をセット
            page.ClientPaymentTerms = "";
            // 納期をセット
            page.ClientDeliveryDate = "";
            // 備考をセット
            page.Remarks = "";
            // 明細情報をセット
            page.DetailList = bulkDetailList;

            // HTML文字列取得
            String pageContent = page.TransformText();

            // PDFライブラリ呼び出し
            var Renderer = new IronPdf.HtmlToPdf();

            // JSを適用
            Renderer.PrintOptions.EnableJavaScript = true;
            Renderer.PrintOptions.RenderDelay = 500;

            // PDFサイズを設定
            Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4;
            Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape;

            // PDF作成
            var PDF = Renderer.RenderHtmlAsPdf(pageContent);

            // PATH&ファイル名指定
            var OutputPath = "書類\\請求書\\請求書" + no + ".pdf";

            // 作成したPDFファイルに名前付け
            PDF.SaveAs(OutputPath);

            // PDFをブラウザで表示
            System.Diagnostics.Process.Start(OutputPath);

            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("処理内容をPDF化しました。",
            "質問",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            //何が選択されたか調べる
            if (result == DialogResult.OK)
            {
                textBox1.Text = "";
                clientNameLabel.Text = "";
                clientPostalLabel.Text = "";
                clientAddressLabel.Text = "";
                clientDivisionLabel.Text = "";
                clientReqLabel.Text = "";
                clientFAX = "";
                clientTEL = "";
                textBox3.Text = "";
                subTotalLabel.Text = "";
                taxLabel.Text = "";
                totalLabel.Text = "";
                table.Rows.Clear();
                resultTemp = 0;
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                bulkDetailList = new List<Entites.Estimate>();
            }

        }
    }
}

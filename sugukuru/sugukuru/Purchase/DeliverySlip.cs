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

namespace sugukuru.Purchase
{
    public partial class DeliverySlip : FormMaster.UserControlMST
    {
        string sql;
        string conStr;

        string clientTEL;
        string clientFAX;

        DataSet quoteInfoData;

        List<Entites.Estimate> quoteDetailList;

        public DeliverySlip()
        {
            InitializeComponent();
            this.sql = "";
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            Utility.ResponsibleList.setSales(comboBox1);
        }


        // Formがロードされた時
        private void DeliverySlip_Load(object sender, EventArgs e)
        {
            // カラムを指定
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 印刷が押された時の処理
        private void button2_Click(object sender, EventArgs e)
        {
            string InvoiceNo = textBox4.Text;

            // 納品書内容をhtmlにセットしていく
            InvoiceHtmlTemplate page = new InvoiceHtmlTemplate();

            // 書類種別をセット
            page.DocumentType = "納品";
            // 書類作成日をセット
            page.DocumentCreationDate = DateTime.Parse(dateTimePicker1.Text).ToString("yyyyMMdd");
            // 書類作成者をセット
            page.DocumentCreationReq = comboBox1.Text;
            // 書類番号をセット
            page.DocumentNumber = InvoiceNo;
            // 顧客名をセット
            page.ClientName = clientNameLabel.Text;
            // 顧客郵便番号をセット
            page.ClientZip = clientPostalLabel.Text;
            // 顧客住所1をセット
            page.ClientAddress1 = clientAddressLabel.Text; ;
            // 顧客住所2をセット
            page.ClientAddress2 = "";
            // 顧客FAXをセット
            page.ClientFAX = String.Format("{0:(###)###-####}", Convert.ToInt64(clientFAX)); ;
            // 顧客TELをセット
            page.ClientTEL = String.Format("{0:(###)###-####}", Convert.ToInt64(clientTEL)); ;
            // 顧客部署をセット
            page.ClientDivision = clientDivisionLabel.Text;
            // 顧客担当者をセット
            page.ClientReq = clientRepLabel.Text;
            // 備考をセット
            page.Remarks = textBox3.Text;
            // 明細情報をセット
            page.List = quoteDetailList;

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
            var OutputPath = "書類\\納品書\\納品書"+InvoiceNo+".pdf";

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
                textBox4.Text = "";
                clientNameLabel.Text = "";
                clientPostalLabel.Text = "";
                clientAddressLabel.Text = "";
                clientDivisionLabel.Text = "";
                dateTimePicker1.Text = "";
                clientRepLabel.Text = "";
                textBox3.Text = "";
                subTotalLabel.Text = "";
                taxLabel.Text = "";
                totalLabel.Text = "";
                quoteInfoData.Tables["QuoteInfo"].Rows.Clear();
                button1.Enabled = false;
            }
        }

        // 見積の検索が押された時の処理
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals(""))
            {
                quoteDetailList = new List<Entites.Estimate>();

                this.sql = "SELECT order_id,product_name,quantity,unit,price FROM `quote_detail` WHERE quote_id = '" + textBox4.Text+"'";

                // データを追加
                //抽象データ格納データセットを作成
                quoteInfoData = new DataSet("QuoteInfo");

                //DB接続オブジェクトを作成
                MySqlConnection con = new MySqlConnection(this.conStr);

                //DB接続
                con.Open();

                //データアダプターの生成
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

                ///データ抽出＆取得
                mAdp.Fill(quoteInfoData, "QuoteInfo");

                //DB切断
                con.Close();

                //抽出件数を取得
                int rcnt = quoteInfoData.Tables["QuoteInfo"].Rows.Count;

                //0件の場合はエラー
                if (rcnt != 0)
                {
                    dataGridView1.DataSource = quoteInfoData.Tables["QuoteInfo"];
                    dataGridView1.Columns["order_id"].HeaderText = "受注番号";
                    dataGridView1.Columns["product_name"].HeaderText = "商品名";
                    dataGridView1.Columns["quantity"].HeaderText = "数量";
                    dataGridView1.Columns["unit"].HeaderText = "単位";
                    dataGridView1.Columns["price"].HeaderText = "単価";

                    //データグリッドビュー料金の3桁カンマ区切り
                    dataGridView1.Columns["price"].DefaultCellStyle.Format = "c";

                    //データグリッドビュー料金の右揃え
                    dataGridView1.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // 小計
                    int subtotal = 0;
                    // 消費税
                    int tax = 0;
                    // 合計
                    int total = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        Entites.Estimate quote = new Entites.Estimate();
                        quote.ProductName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        quote.Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        quote.UnitPrice = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        subtotal = subtotal + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        quoteDetailList.Add(quote);
                    }
                    tax = (subtotal / 100) * 8;
                    total = subtotal + tax;

                    subTotalLabel.Text = subtotal.ToString();
                    taxLabel.Text = tax.ToString();
                    totalLabel.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("見積番号が誤っています。");
                }
            }

        }

        // 顧客の検索が押された時の処理
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

                this.sql = "SELECT formal_name,postal_code,prefectures,municipality,client_division,client_rep,phone_number,fax FROM `client` WHERE id = '"+textBox1.Text+"'";

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
                    clientRepLabel.Text = dset.Tables["ClientInfo"].Rows[0]["client_rep"].ToString();

                    // FAXをセット
                    clientFAX = dset.Tables["ClientInfo"].Rows[0]["fax"].ToString();

                    // TELをセット
                    clientTEL = dset.Tables["ClientInfo"].Rows[0]["phone_number"].ToString();

                    button1.Enabled = true;

                }
                else
                {
                    MessageBox.Show("顧客IDが誤っています。");
                }
            }
        }
    }
}

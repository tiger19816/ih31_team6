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
    public partial class BulkClaim : FormMaster.UserControlMST
    {
        //DB接続文字列の取得
        string conStr;
        List<Entites.Estimate> bulkDetailList;
        Entites.Estimate bulkEntity;

        public BulkClaim()
        {
            InitializeComponent();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            DateTime date = DateTime.Now;
           
            //年の設定
            int i = 2018;
            while (i <= date.Year)
            {
                cbYear.Items.Add(i.ToString());
                i++;
            }
            cbYear.SelectedItem = date.Year.ToString();
            //月の設定
            i = 1;
            while (i <= 12)
            {
                cbMonth.Items.Add(i.ToString());
                i++;
            }
            cbMonth.SelectedItem = date.Month.ToString();
        }

        //****************************************************************************
        #region 表示ボタンが押された時の処理
        //****************************************************************************
        private void btDisplay_Click(object sender, EventArgs e)
        {
            dataGridViewDisplay();
        }
        #endregion

        //****************************************************************************
        #region 印刷ボタンが押された時の処理
        //****************************************************************************
        private void btPrint_Click(object sender, EventArgs e)
        {
            string strYear = cbYear.SelectedItem.ToString();
            string strMonth = cbMonth.SelectedItem.ToString();

            for (int i = 0; i < dgvBulk.RowCount; i++)
            {
                if ("True".Equals(dgvBulk.Rows[i].Cells["BooleanCol"].Value.ToString()))
                {
                    bulkDetailList = new List<Entites.Estimate>();

                    string id = dgvBulk.Rows[i].Cells["id"].Value.ToString();
                    string date = dtpBill.Value.ToShortDateString();
                    
                    string no = id + DateTime.Now.ToString("yy") + "0" + cbMonth.SelectedItem.ToString();
                    string payment = "月末締翌月末払";

                    string sql = "INSERT INTO bill (invoice_number,customer_id,billing_date,billing_representative,payment_criteria) VALUES("
                        + "'" + no + "',"
                        + "'" + id + "',"
                        + "'" + date + "',"
                        + "'" + FormMaster.BaseFormMST.ID + "',"
                        + "'" + payment + "');";
                    
                    //DB接続オブジェクトを作成
                    MySqlConnection con = new MySqlConnection(this.conStr);

                    //DB接続
                    con.Open();

                    //SQL発行準備
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    ///SQLの実行
                    cmd.ExecuteNonQuery();

                    sql = "INSERT INTO billing_clearing(no) VALUES('" + no +" ');";

                    //SQL発行準備
                    cmd = new MySqlCommand(sql, con);

                    ///SQLの実行
                    cmd.ExecuteNonQuery();

                    sql = "SELECT * FROM unbilled_data "
                        + "WHERE recorded_date LIKE '" + strYear + "-" + strMonth + "%' "
                        + "AND customer_id = '" + id + "'";

                    Console.WriteLine(sql);

                    //抽象データ格納データセットを作成
                    DataSet dset = new DataSet("unbilled");

                    //データアダプターの生成
                    MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

                    ///データ抽出＆取得
                    mAdp.Fill(dset, "unbilled");

                    for (int j = 0; j < dset.Tables["unbilled"].Rows.Count; j++)
                    {
                        bulkEntity = new Entites.Estimate();

                        sql = "INSERT INTO billing_detail VALUES("
                            + "'" + no + "',"
                            + "'" + (j + 1) + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["order_id"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["billing_amount"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["quantity"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["unit"].ToString() + "',"
                            + "'" + dset.Tables["unbilled"].Rows[j]["unit_price"].ToString() + "')";

                        //SQL発行準備
                        cmd = new MySqlCommand(sql, con);

                        ///SQLの実行
                        cmd.ExecuteNonQuery();

                        sql = "UPDATE unbilled_data SET comp_flag = 1 WHERE id = " + dset.Tables["unbilled"].Rows[j]["id"].ToString();

                        //SQL発行準備
                        cmd = new MySqlCommand(sql, con);

                        ///SQLの実行
                        cmd.ExecuteNonQuery();

                        bulkEntity.OrderNumber = dset.Tables["unbilled"].Rows[j]["order_id"].ToString();
                        bulkEntity.ProductName = dset.Tables["unbilled"].Rows[j]["billing_amount"].ToString();
                        bulkEntity.Unit = dset.Tables["unbilled"].Rows[j]["unit"].ToString();
                        bulkEntity.UnitPrice = dset.Tables["unbilled"].Rows[j]["unit_price"].ToString();
                        bulkEntity.Quantity = dset.Tables["unbilled"].Rows[j]["quantity"].ToString();
                        bulkEntity.TotalPrice = dgvBulk.Rows[i].Cells["price"].Value.ToString();

                        bulkDetailList.Add(bulkEntity);
                    }
                    //DB切断
                    con.Close();

                    // 見積内容をhtmlにセットしていく
                    DocumentHtmlTemplate page = new DocumentHtmlTemplate();

                    // 書類種別をセット
                    page.DocumentType = "請求";
                    // 書類作成日をセット
                    page.DocumentCreationDate = DateTime.Parse(dtpBill.Text).ToString("yyyyMMdd");
                    // 書類作成者をセット
                    page.DocumentCreationReq = FormMaster.BaseFormMST.NAME;
                    // 書類番号をセット
                    page.DocumentNumber = no;
                    // 書類有効期限
                    page.ExpirationDate = "";
                    // 支払期限
                    page.PaymentDeadline = DateTime.Parse(dtpBill.Text).AddDays(14).ToString("yyyy年MM月dd日");
                    // 顧客名をセット
                    page.ClientName = dgvBulk.Rows[i].Cells["formal_name"].Value.ToString();
                    // 顧客郵便番号をセット
                    page.ClientZip = dgvBulk.Rows[i].Cells["postal_code"].Value.ToString();
                    // 顧客住所1をセット
                    page.ClientAddress1 = dgvBulk.Rows[i].Cells["prefectures"].Value.ToString() + dgvBulk.Rows[i].Cells["municipality"].Value.ToString();
                    // 顧客住所2をセット
                    page.ClientAddress2 = "";
                    // 顧客FAXをセット
                    page.ClientFAX = String.Format("{0:(###)###-####}", Convert.ToInt64(dgvBulk.Rows[i].Cells["fax"].Value.ToString())); ;
                    // 顧客TELをセット
                    page.ClientTEL = String.Format("{0:(###)###-####}", Convert.ToInt64(dgvBulk.Rows[i].Cells["phone_number"].Value.ToString())); ;
                    // 顧客部署をセット
                    page.ClientDivision = dgvBulk.Rows[i].Cells["client_division"].Value.ToString();
                    // 顧客担当者をセット
                    page.ClientReq = dgvBulk.Rows[i].Cells["client_rep"].Value.ToString();
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
                }
            }

            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("請求内容をPDF化しました。",
                "質問",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //何が選択されたか調べる
            if (result == DialogResult.OK)
            {
                //「はい」が選択された時               
            }
            dataGridViewDisplay();
        }
        #endregion

        //****************************************************************************
        #region DataGridViewの表示
        //****************************************************************************
        private void dataGridViewDisplay()
        {
            string strYear = cbYear.SelectedItem.ToString();
            string strMonth = cbMonth.SelectedItem.ToString();

            //SQL文を作成する
            string sql = "SELECT c.id, c.formal_name, c.postal_code, c.prefectures, c.municipality, c.client_division, c.client_rep, c.phone_number, c.fax, d.price "
                + "FROM client c INNER JOIN "
                + "(SELECT customer_id, SUM(unit_price * quantity) AS price "
                + "FROM unbilled_data "
                + "WHERE recorded_date LIKE '" + strYear + "-" + strMonth + "%' "
                + "AND comp_flag = 0 "
                + "GROUP BY customer_id) d "
                + "ON c.id = d.customer_id "
                + "ORDER BY c.formal_name_read;";

            Console.WriteLine(sql);

            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("bulk");

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "bulk");

            //DB切断
            con.Close();

            // カラムを指定
            dgvBulk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBulk.RowHeadersVisible = false;
            dgvBulk.RowHeadersVisible = false;
            dgvBulk.AllowUserToAddRows = false;
            dgvBulk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBulk.DataSource = dset.Tables["bulk"];

            //データグリッドビュー料金の3桁カンマ区切り
            dgvBulk.Columns["price"].DefaultCellStyle.Format = "c";
            //データグリッドビュー料金の右揃え
            dgvBulk.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataColumn colBoolean = new DataColumn("BooleanCol");
            colBoolean.DataType = Type.GetType("System.Boolean");
            colBoolean.DefaultValue = true;
            DataTable dtbl = (DataTable)dgvBulk.DataSource;
            dtbl.Columns.Add(colBoolean);

            dgvBulk.Columns["BooleanCol"].DisplayIndex = 0;
            dgvBulk.Columns["id"].ReadOnly = true;
            dgvBulk.Columns["formal_name"].ReadOnly = true;
            dgvBulk.Columns["price"].ReadOnly = true;

            dgvBulk.Columns["BooleanCol"].HeaderText = "";

            dgvBulk.Columns["id"].HeaderText = "顧客ID";

            dgvBulk.Columns["formal_name"].HeaderText = "会社名";

            dgvBulk.Columns["price"].HeaderText = "請求金額";

            dgvBulk.Columns["postal_code"].HeaderText = "郵便番号";
            dgvBulk.Columns["postal_code"].Visible = false;

            dgvBulk.Columns["prefectures"].HeaderText = "都道府県";
            dgvBulk.Columns["prefectures"].Visible = false;

            dgvBulk.Columns["municipality"].HeaderText = "市町村以下";
            dgvBulk.Columns["municipality"].Visible = false;

            dgvBulk.Columns["client_division"].HeaderText = "取引先担当部署";
            dgvBulk.Columns["client_rep"].HeaderText = "取引先担当者";

            dgvBulk.Columns["phone_number"].HeaderText = "TEL";
            dgvBulk.Columns["phone_number"].Visible = false;

            dgvBulk.Columns["fax"].HeaderText = "FAX";
            dgvBulk.Columns["fax"].Visible = false;
        }
        #endregion
    }
}

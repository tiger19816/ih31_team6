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

namespace sugukuru.Orders
{
    public partial class EstimateControl : FormMaster.UserControlMST
    {
        DataTable table;
        string conStr;
        string sql;
        List<Entites.Estimate> quoteDetailList;
        string clientFAX;
        string clientTEL;


        public EstimateControl()
        {
            InitializeComponent();
            table = new DataTable();
            this.conStr = ConfigurationManager.AppSettings["DbConKey"];
            Utility.ResponsibleList.setSales(comboBox1);
            quoteDetailList = new List<Entites.Estimate>();
        }

        private void EstimateControl_Load(object sender, EventArgs e)
        {
            // 初期化
            textBox10.Text = 0.ToString();
            textBox11.Text = 0.ToString();
            textBox12.Text = 0.ToString();
            textBox13.Text = "見積後２週間";
            clientFAX = "";
            clientTEL = "";

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

        // 追加を押したときの処理　
        private void btEstimateAdd_Click(object sender, EventArgs e)
        {
            EstimateAddForm OpenFM = new EstimateAddForm(textBox1.Text);
            OpenFM.ShowDialog();
            OpenFM.Dispose();
            this.Show();

            if(OpenFM.SelectFlg)
            {
                // OpenFM.Estimateの配列に追加していく
                quoteDetailList.Add(OpenFM.Estimate);

                // 追加した項目をデータグリッドビューへ反映
                DataRow row = table.NewRow();
                row["受注番号"] = OpenFM.Estimate.OrderNumber;
                row["品名"] = OpenFM.Estimate.ProductName;
                row["数量"] = OpenFM.Estimate.Quantity;
                row["単位"] = OpenFM.Estimate.Unit;
                row["単価"] = OpenFM.Estimate.UnitPrice;
                row["金額"] = OpenFM.Estimate.TotalPrice;
                table.Rows.Add(row);

                // 小計を計算し表示
                textBox10.Text = (int.Parse(textBox10.Text) + int.Parse(OpenFM.Estimate.TotalPrice)).ToString();
                // 消費税を計算し表示
                textBox11.Text = (int.Parse(textBox10.Text) / 100 * 8).ToString();
                // 合計金額額を計算し表示
                textBox12.Text = (int.Parse(textBox10.Text) + int.Parse(textBox11.Text)).ToString();
            }
        }

        // 削除を押したときの処理
        private void btEstimateDelete_Click(object sender, EventArgs e)
        {

        }

        // 検索ボタンが押された時の処理
        private void btCustomerSearch_Click(object sender, EventArgs e)
        {
            CustomerSelectForm MenuFM = new CustomerSelectForm();
            MenuFM.ShowDialog();
            MenuFM.Dispose();
            this.Show();

            //子フォームで追加が押下された場合の処理
            if (MenuFM.SelectFlg)
            {
                // dataGridView1に既に値がある場合初期化
                if (quoteDetailList.Count() != 0)
                {
                    quoteDetailList.Clear();
                }         
                if (table.Rows.Count != 0 )
                {
                    table.Rows.Clear();
                }           
               

                //返り値の取得(DataRow)
                DataRow selectRow = MenuFM.Customer.getDataRow();
                //DataRowの中身をフォームの中身に追加していく
                //DataRowからの引数はデータベースのカラム名そのまま
                textBox1.Text = selectRow["id"].ToString();

                sql = "SELECT formal_name,postal_code,prefectures,municipality,client_division,client_rep,recovery_condition,phone_number,fax," +
                " (CASE WHEN closing_date >= 30 THEN '月末締' ELSE CONCAT(closing_date, '日締') END) as closing_date," +
                " (CASE WHEN collection_month = 1 THEN '翌月' WHEN collection_month = 2 THEN '翌々月' WHEN collection_month = 3 THEN '翌々々月' ELSE '別途相談' END)as collection_month," +
                " collection_date" +
                " FROM client" +
                " WHERE id = " + textBox1.Text;         

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
                    textBox2.Text = dset.Tables["ClientInfo"].Rows[0]["formal_name"].ToString();

                    // 住所〒をセット
                    textBox4.Text = dset.Tables["ClientInfo"].Rows[0]["postal_code"].ToString();

                    // 所在地をセット
                    textBox7.Text = dset.Tables["ClientInfo"].Rows[0]["prefectures"].ToString() + dset.Tables["ClientInfo"].Rows[0]["municipality"].ToString();

                    // 取引先部署をセット
                    textBox8.Text = dset.Tables["ClientInfo"].Rows[0]["client_division"].ToString();

                    // 取引先担当者をセット
                    textBox9.Text = dset.Tables["ClientInfo"].Rows[0]["client_rep"].ToString();

                    // 支払い条件をセット
                    textBox5.Text = dset.Tables["ClientInfo"].Rows[0]["closing_date"].ToString() + dset.Tables["ClientInfo"].Rows[0]["collection_month"].ToString() + dset.Tables["ClientInfo"].Rows[0]["collection_date"].ToString() + "日払";

                    // 納期をセット
                    textBox6.Text = "別途相談";

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

        private void tblCustomer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 印刷を押したときの処理
        private void button2_Click(object sender, EventArgs e)
        {
            // 見積書番号の作成
            // WWWWW　18001（顧客ID）
            // XX　　 18（2018年）
            // YYYY　 0（連番)
            string quoteID = "";
            int count = 0;
            string year = "";

            sql = "SELECT COUNT(*) as count,DATE_FORMAT(now(), '%y') as year FROM quote WHERE DATE_FORMAT(quote_date, '%Y')=year(now()) AND client_id = '"+textBox1.Text+"'";

            // データを追加
            //抽象データ格納データセットを作成
            DataSet dset = new DataSet("QuoteIdCount");

            //DB接続オブジェクトを作成
            MySqlConnection con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //データアダプターの生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            ///データ抽出＆取得
            mAdp.Fill(dset, "QuoteIdCount");

            //DB切断
            con.Close();

            //抽出件数を取得
            int rcnt = dset.Tables["QuoteIdCount"].Rows.Count;

            //0件の場合はエラー
            if (rcnt != 0)
            {
                // 連番をセット
                count = int.Parse(dset.Tables["QuoteIdCount"].Rows[0]["count"].ToString()) + 1;
                // 年をセット
                year = dset.Tables["QuoteIdCount"].Rows[0]["year"].ToString();
            }

            // 見積番号をセット
            quoteID = textBox1.Text + year + String.Format("{0:D3}", count);


            // 見積テーブルと見積詳細テーブルに追加
            // 見積テーブルにデータを追加
            sql = "INSERT INTO `quote`(`id`, `client_id`, `quote_date`, `quote_rep`, `expiry_date`, `payment_term`, `delivery_date`, `remarks`) " +
                " VALUES('"+quoteID+"', '"+textBox1.Text+"', '"+dateTimePicker1.Value.ToShortDateString()+ "', '"+comboBox1.Text+"', '"+textBox13.Text+"', '"+textBox5.Text+"', '"+textBox6.Text+"', '"+textBox3.Text+"')";

            //DB接続オブジェクトを作成
            con = new MySqlConnection(this.conStr);

            //DB接続
            con.Open();

            //SQL発行準備
            MySqlCommand cmd = new MySqlCommand(sql, con);

            //SQLの実行
            cmd.ExecuteNonQuery();

            //DB切断
            con.Close();

            int cnt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // 項目番号をセット
                cnt = i + 1;

                // 見積詳細テーブルにデータを追加
                sql = "INSERT INTO `quote_detail`(`quote_id`, `order_id`, `no`, `product_name`, `quantity`, `unit`, `price`)" +
                    " VALUES('" + quoteID + "', '" + quoteDetailList[i].OrderNumber + "', "+ cnt + ", '" + quoteDetailList[i].ProductName + "', '" + quoteDetailList[i].Quantity + "', '" + quoteDetailList[i].Unit + "', '" + quoteDetailList[i].UnitPrice + "')";

                //DB接続オブジェクトを作成
                con = new MySqlConnection(this.conStr);

                //DB接続
                con.Open();

                //SQL発行準備
                cmd = new MySqlCommand(sql, con);

                ///SQLの実行
                cmd.ExecuteNonQuery();
            }

            //DB切断
            con.Close();

            // 見積内容をhtmlにセットしていく
            DocumentHtmlTemplate page = new DocumentHtmlTemplate();
            
            // 書類種別をセット
            page.DocumentType = "見積";
            // 書類作成日をセット
            page.DocumentCreationDate = DateTime.Parse(dateTimePicker1.Text).ToString("yyyyMMdd");
            // 書類作成者をセット
            page.DocumentCreationReq = comboBox1.Text;
            // 書類番号をセット
            page.DocumentNumber = quoteID;
            // 書類有効期限
            page.ExpirationDate = textBox13.Text;
            // 顧客名をセット
            page.ClientName = textBox2.Text;
            // 顧客郵便番号をセット
            page.ClientZip = textBox4.Text;
            // 顧客住所1をセット
            page.ClientAddress1 = textBox7.Text; ;
            // 顧客住所2をセット
            page.ClientAddress2 = "";
            // 顧客FAXをセット
            page.ClientFAX = String.Format("{0:(###)###-####}", Convert.ToInt64(clientFAX)); ;
            // 顧客TELをセット
            page.ClientTEL = String.Format("{0:(###)###-####}", Convert.ToInt64(clientTEL)); ;
            // 顧客部署をセット
            page.ClientDivision = textBox8.Text;
            // 顧客担当者をセット
            page.ClientReq = textBox9.Text;
            // 支払い条件をセット
            page.ClientPaymentTerms = textBox5.Text;
            // 納期をセット
            page.ClientDeliveryDate = textBox6.Text;
            // 備考をセット
            page.Remarks = textBox3.Text;
            // 明細情報をセット
            page.DetailList = quoteDetailList;

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
            var OutputPath = "書類\\見積書\\見積書"+quoteID+".pdf";

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
                textBox2.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                dateTimePicker1.Text = "";
                textBox13.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                table.Rows.Clear();
            }
        }
    }
}

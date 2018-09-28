namespace sugukuru.Purchase
{
    partial class ListingProcessingResult
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tbCustomerNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbListingNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAuctionCompany = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btData
            // 
            this.btData.Location = new System.Drawing.Point(429, 350);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(235, 23);
            this.btData.TabIndex = 160;
            this.btData.Text = "データを選択してもらう";
            this.btData.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 19);
            this.textBox1.TabIndex = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 158;
            this.label1.Text = "担当者";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(37, 188);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 157;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 252);
            this.dataGridView1.TabIndex = 156;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(93, 74);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 19);
            this.dtpStart.TabIndex = 155;
            // 
            // tbCustomerNumber
            // 
            this.tbCustomerNumber.Location = new System.Drawing.Point(93, 109);
            this.tbCustomerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerNumber.Name = "tbCustomerNumber";
            this.tbCustomerNumber.Size = new System.Drawing.Size(79, 19);
            this.tbCustomerNumber.TabIndex = 154;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 153;
            this.label12.Text = "顧客番号";
            // 
            // tbListingNumber
            // 
            this.tbListingNumber.Location = new System.Drawing.Point(585, 79);
            this.tbListingNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbListingNumber.Name = "tbListingNumber";
            this.tbListingNumber.Size = new System.Drawing.Size(79, 19);
            this.tbListingNumber.TabIndex = 152;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 151;
            this.label11.Text = "出品番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 150;
            this.label3.Text = "受注日付";
            // 
            // cbAuctionCompany
            // 
            this.cbAuctionCompany.FormattingEnabled = true;
            this.cbAuctionCompany.Location = new System.Drawing.Point(429, 76);
            this.cbAuctionCompany.Margin = new System.Windows.Forms.Padding(2);
            this.cbAuctionCompany.Name = "cbAuctionCompany";
            this.cbAuctionCompany.Size = new System.Drawing.Size(95, 20);
            this.cbAuctionCompany.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 148;
            this.label2.Text = "オークション主催会社";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 147;
            this.label7.Text = "出品後処理確認";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListingProcessingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.tbCustomerNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbListingNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAuctionCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "ListingProcessingResult";
            this.Size = new System.Drawing.Size(1129, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox tbCustomerNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbListingNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAuctionCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}

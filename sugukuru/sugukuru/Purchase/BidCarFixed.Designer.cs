namespace sugukuru.Purchase
{
    partial class BidCarFixed
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tbCustomerNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbListingNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAuctionCompany = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(16, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 115;
            this.label7.Text = "落札結果確定";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 252);
            this.dataGridView1.TabIndex = 124;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(77, 60);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 19);
            this.dtpStart.TabIndex = 123;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // tbCustomerNumber
            // 
            this.tbCustomerNumber.Location = new System.Drawing.Point(77, 95);
            this.tbCustomerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerNumber.Name = "tbCustomerNumber";
            this.tbCustomerNumber.Size = new System.Drawing.Size(79, 19);
            this.tbCustomerNumber.TabIndex = 122;
            this.tbCustomerNumber.TextChanged += new System.EventHandler(this.tbCustomerNumber_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 95);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 121;
            this.label12.Text = "顧客番号";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbListingNumber
            // 
            this.tbListingNumber.Location = new System.Drawing.Point(569, 65);
            this.tbListingNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbListingNumber.Name = "tbListingNumber";
            this.tbListingNumber.Size = new System.Drawing.Size(79, 19);
            this.tbListingNumber.TabIndex = 120;
            this.tbListingNumber.TextChanged += new System.EventHandler(this.tbListingNumber_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "出品番号";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 118;
            this.label3.Text = "受注日付";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbAuctionCompany
            // 
            this.cbAuctionCompany.FormattingEnabled = true;
            this.cbAuctionCompany.Location = new System.Drawing.Point(413, 62);
            this.cbAuctionCompany.Margin = new System.Windows.Forms.Padding(2);
            this.cbAuctionCompany.Name = "cbAuctionCompany";
            this.cbAuctionCompany.Size = new System.Drawing.Size(95, 20);
            this.cbAuctionCompany.TabIndex = 117;
            this.cbAuctionCompany.SelectedIndexChanged += new System.EventHandler(this.cbAuctionCompany_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 116;
            this.label2.Text = "オークション主催会社";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(21, 174);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 125;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 126;
            this.label1.Text = "担当者";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 19);
            this.textBox1.TabIndex = 127;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(714, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 129;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 128;
            this.label4.Text = "落札日付";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btData
            // 
            this.btData.Location = new System.Drawing.Point(413, 336);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(235, 23);
            this.btData.TabIndex = 130;
            this.btData.Text = "データを選択してもらう";
            this.btData.UseVisualStyleBackColor = true;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // BidCarFixed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
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
            this.Name = "BidCarFixed";
            this.Size = new System.Drawing.Size(1129, 515);
            this.Load += new System.EventHandler(this.BidCarFixed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox tbCustomerNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbListingNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAuctionCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btData;
    }
}

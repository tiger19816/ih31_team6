namespace sugukuru.Purchase
{
    partial class Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btBitCar = new System.Windows.Forms.Button();
            this.btBitInfo = new System.Windows.Forms.Button();
            this.btTransportInfo = new System.Windows.Forms.Button();
            this.btDisposalCarPurchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuctionCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYaerStart = new System.Windows.Forms.ComboBox();
            this.cbMonthStart = new System.Windows.Forms.ComboBox();
            this.cbDayStart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbYearEnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMonthEnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbListingNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCustomerNumber = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btBidCarList = new System.Windows.Forms.Button();
            this.btDeliverySlip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.inheritableFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.tbCustomerNumber);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbListingNumber);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbMonthEnd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbYearEnd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbDayStart);
            this.panel1.Controls.Add(this.cbMonthStart);
            this.panel1.Controls.Add(this.cbYaerStart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbAuctionCompany);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbOrderNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // inheritableFlowLayoutPanel1
            // 
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btDeliverySlip);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBidCarList);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBitInfo);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btDisposalCarPurchase);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBitCar);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btTransportInfo);
            // 
            // btBitCar
            // 
            this.btBitCar.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBitCar.Location = new System.Drawing.Point(2, 262);
            this.btBitCar.Margin = new System.Windows.Forms.Padding(2);
            this.btBitCar.Name = "btBitCar";
            this.btBitCar.Size = new System.Drawing.Size(94, 60);
            this.btBitCar.TabIndex = 0;
            this.btBitCar.Text = "落札車両登録";
            this.btBitCar.UseVisualStyleBackColor = true;
            // 
            // btBitInfo
            // 
            this.btBitInfo.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBitInfo.Location = new System.Drawing.Point(2, 134);
            this.btBitInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btBitInfo.Name = "btBitInfo";
            this.btBitInfo.Size = new System.Drawing.Size(94, 60);
            this.btBitInfo.TabIndex = 1;
            this.btBitInfo.Text = "入札情報登録";
            this.btBitInfo.UseVisualStyleBackColor = true;
            // 
            // btTransportInfo
            // 
            this.btTransportInfo.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTransportInfo.Location = new System.Drawing.Point(2, 326);
            this.btTransportInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btTransportInfo.Name = "btTransportInfo";
            this.btTransportInfo.Size = new System.Drawing.Size(94, 60);
            this.btTransportInfo.TabIndex = 2;
            this.btTransportInfo.Text = "陸送情報登録";
            this.btTransportInfo.UseVisualStyleBackColor = true;
            // 
            // btDisposalCarPurchase
            // 
            this.btDisposalCarPurchase.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDisposalCarPurchase.Location = new System.Drawing.Point(2, 198);
            this.btDisposalCarPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btDisposalCarPurchase.Name = "btDisposalCarPurchase";
            this.btDisposalCarPurchase.Size = new System.Drawing.Size(94, 60);
            this.btDisposalCarPurchase.TabIndex = 3;
            this.btDisposalCarPurchase.Text = "売却車両購入";
            this.btDisposalCarPurchase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "受注番号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Location = new System.Drawing.Point(95, 26);
            this.tbOrderNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(79, 27);
            this.tbOrderNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "オークション主催会社";
            // 
            // cbAuctionCompany
            // 
            this.cbAuctionCompany.FormattingEnabled = true;
            this.cbAuctionCompany.Location = new System.Drawing.Point(320, 26);
            this.cbAuctionCompany.Margin = new System.Windows.Forms.Padding(2);
            this.cbAuctionCompany.Name = "cbAuctionCompany";
            this.cbAuctionCompany.Size = new System.Drawing.Size(95, 24);
            this.cbAuctionCompany.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "受注日付";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "年";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "月";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbYaerStart
            // 
            this.cbYaerStart.FormattingEnabled = true;
            this.cbYaerStart.Location = new System.Drawing.Point(97, 67);
            this.cbYaerStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbYaerStart.Name = "cbYaerStart";
            this.cbYaerStart.Size = new System.Drawing.Size(54, 24);
            this.cbYaerStart.TabIndex = 9;
            // 
            // cbMonthStart
            // 
            this.cbMonthStart.FormattingEnabled = true;
            this.cbMonthStart.Location = new System.Drawing.Point(178, 67);
            this.cbMonthStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonthStart.Name = "cbMonthStart";
            this.cbMonthStart.Size = new System.Drawing.Size(43, 24);
            this.cbMonthStart.TabIndex = 10;
            // 
            // cbDayStart
            // 
            this.cbDayStart.FormattingEnabled = true;
            this.cbDayStart.Location = new System.Drawing.Point(248, 67);
            this.cbDayStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbDayStart.Name = "cbDayStart";
            this.cbDayStart.Size = new System.Drawing.Size(47, 24);
            this.cbDayStart.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(299, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "～";
            // 
            // cbYearEnd
            // 
            this.cbYearEnd.FormattingEnabled = true;
            this.cbYearEnd.Location = new System.Drawing.Point(368, 67);
            this.cbYearEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbYearEnd.Name = "cbYearEnd";
            this.cbYearEnd.Size = new System.Drawing.Size(62, 24);
            this.cbYearEnd.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "年";
            // 
            // cbMonthEnd
            // 
            this.cbMonthEnd.FormattingEnabled = true;
            this.cbMonthEnd.Location = new System.Drawing.Point(457, 67);
            this.cbMonthEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonthEnd.Name = "cbMonthEnd";
            this.cbMonthEnd.Size = new System.Drawing.Size(44, 24);
            this.cbMonthEnd.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "月";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(528, 67);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "日";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "出品番号";
            // 
            // tbListingNumber
            // 
            this.tbListingNumber.Location = new System.Drawing.Point(485, 27);
            this.tbListingNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbListingNumber.Name = "tbListingNumber";
            this.tbListingNumber.Size = new System.Drawing.Size(79, 27);
            this.tbListingNumber.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "顧客番号";
            // 
            // tbCustomerNumber
            // 
            this.tbCustomerNumber.Location = new System.Drawing.Point(95, 108);
            this.tbCustomerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerNumber.Name = "tbCustomerNumber";
            this.tbCustomerNumber.Size = new System.Drawing.Size(79, 27);
            this.tbCustomerNumber.TabIndex = 23;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1091, 389);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(58, 26);
            this.btSearch.TabIndex = 24;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 214);
            this.dataGridView1.TabIndex = 25;
            // 
            // btBidCarList
            // 
            this.btBidCarList.Location = new System.Drawing.Point(3, 69);
            this.btBidCarList.Name = "btBidCarList";
            this.btBidCarList.Size = new System.Drawing.Size(94, 60);
            this.btBidCarList.TabIndex = 4;
            this.btBidCarList.Text = "落札車両一覧";
            this.btBidCarList.UseVisualStyleBackColor = true;
            // 
            // btDeliverySlip
            // 
            this.btDeliverySlip.Location = new System.Drawing.Point(3, 3);
            this.btDeliverySlip.Name = "btDeliverySlip";
            this.btDeliverySlip.Size = new System.Drawing.Size(94, 60);
            this.btDeliverySlip.TabIndex = 5;
            this.btDeliverySlip.Text = "納品書発行";
            this.btDeliverySlip.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.inheritableFlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBitInfo;
        private System.Windows.Forms.Button btDisposalCarPurchase;
        private System.Windows.Forms.Button btBitCar;
        private System.Windows.Forms.Button btTransportInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonthStart;
        private System.Windows.Forms.ComboBox cbYaerStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAuctionCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbCustomerNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbListingNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMonthEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbYearEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDayStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btBidCarList;
        private System.Windows.Forms.Button btDeliverySlip;
    }
}
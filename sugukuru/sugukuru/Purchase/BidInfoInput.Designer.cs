namespace sugukuru.Purchase
{
    partial class BidInfoInput
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAuction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbListingNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.rbSatisfied = new System.Windows.Forms.RadioButton();
            this.rbUnsatisfied = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.gbBidResult = new System.Windows.Forms.GroupBox();
            this.btFixed = new System.Windows.Forms.Button();
            this.gbBidResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "受注番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "オークション会場";
            // 
            // cbAuction
            // 
            this.cbAuction.FormattingEnabled = true;
            this.cbAuction.Location = new System.Drawing.Point(148, 135);
            this.cbAuction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAuction.Name = "cbAuction";
            this.cbAuction.Size = new System.Drawing.Size(140, 24);
            this.cbAuction.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "出品番号";
            // 
            // tbListingNumber
            // 
            this.tbListingNumber.Location = new System.Drawing.Point(148, 180);
            this.tbListingNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbListingNumber.Name = "tbListingNumber";
            this.tbListingNumber.Size = new System.Drawing.Size(116, 27);
            this.tbListingNumber.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 331);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "入札日付";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "入札金額";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(148, 375);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(116, 27);
            this.tbPrice.TabIndex = 11;
            // 
            // rbSatisfied
            // 
            this.rbSatisfied.AutoSize = true;
            this.rbSatisfied.Checked = true;
            this.rbSatisfied.Location = new System.Drawing.Point(18, 27);
            this.rbSatisfied.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSatisfied.Name = "rbSatisfied";
            this.rbSatisfied.Size = new System.Drawing.Size(74, 20);
            this.rbSatisfied.TabIndex = 12;
            this.rbSatisfied.TabStop = true;
            this.rbSatisfied.Text = "入札成立";
            this.rbSatisfied.UseVisualStyleBackColor = true;
            // 
            // rbUnsatisfied
            // 
            this.rbUnsatisfied.AutoSize = true;
            this.rbUnsatisfied.Location = new System.Drawing.Point(18, 64);
            this.rbUnsatisfied.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUnsatisfied.Name = "rbUnsatisfied";
            this.rbUnsatisfied.Size = new System.Drawing.Size(86, 20);
            this.rbUnsatisfied.TabIndex = 13;
            this.rbUnsatisfied.TabStop = true;
            this.rbUnsatisfied.Text = "入札不成立";
            this.rbUnsatisfied.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "入札情報登録";
            // 
            // tbOrderId
            // 
            this.tbOrderId.Location = new System.Drawing.Point(148, 89);
            this.tbOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(116, 27);
            this.tbOrderId.TabIndex = 15;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(270, 86);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(87, 31);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // gbBidResult
            // 
            this.gbBidResult.Controls.Add(this.rbUnsatisfied);
            this.gbBidResult.Controls.Add(this.rbSatisfied);
            this.gbBidResult.Location = new System.Drawing.Point(36, 424);
            this.gbBidResult.Name = "gbBidResult";
            this.gbBidResult.Size = new System.Drawing.Size(200, 100);
            this.gbBidResult.TabIndex = 17;
            this.gbBidResult.TabStop = false;
            this.gbBidResult.Text = "入札結果";
            // 
            // btFixed
            // 
            this.btFixed.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFixed.Location = new System.Drawing.Point(1057, 587);
            this.btFixed.Name = "btFixed";
            this.btFixed.Size = new System.Drawing.Size(100, 40);
            this.btFixed.TabIndex = 72;
            this.btFixed.Text = "確定";
            this.btFixed.UseVisualStyleBackColor = true;
            this.btFixed.Click += new System.EventHandler(this.btFixed_Click);
            // 
            // BidInfoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btFixed);
            this.Controls.Add(this.gbBidResult);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbOrderId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbListingNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAuction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BidInfoInput";
            this.gbBidResult.ResumeLayout(false);
            this.gbBidResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAuction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbListingNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.RadioButton rbSatisfied;
        private System.Windows.Forms.RadioButton rbUnsatisfied;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox gbBidResult;
        private System.Windows.Forms.Button btFixed;
    }
}

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
            this.btFixed = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.rbSatisfied = new System.Windows.Forms.RadioButton();
            this.rbUnsatisfied = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "受注番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "オークション会場";
            // 
            // cbAuction
            // 
            this.cbAuction.FormattingEnabled = true;
            this.cbAuction.Location = new System.Drawing.Point(127, 101);
            this.cbAuction.Name = "cbAuction";
            this.cbAuction.Size = new System.Drawing.Size(121, 20);
            this.cbAuction.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "出品番号";
            // 
            // tbListingNumber
            // 
            this.tbListingNumber.Location = new System.Drawing.Point(89, 135);
            this.tbListingNumber.Name = "tbListingNumber";
            this.tbListingNumber.Size = new System.Drawing.Size(100, 19);
            this.tbListingNumber.TabIndex = 6;
            // 
            // btFixed
            // 
            this.btFixed.Location = new System.Drawing.Point(30, 336);
            this.btFixed.Name = "btFixed";
            this.btFixed.Size = new System.Drawing.Size(75, 23);
            this.btFixed.TabIndex = 7;
            this.btFixed.Text = "確定";
            this.btFixed.UseVisualStyleBackColor = true;
            this.btFixed.Click += new System.EventHandler(this.btFixed_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "入札日付";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "入札金額";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(87, 281);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 19);
            this.tbPrice.TabIndex = 11;
            // 
            // rbSatisfied
            // 
            this.rbSatisfied.AutoSize = true;
            this.rbSatisfied.Location = new System.Drawing.Point(29, 303);
            this.rbSatisfied.Name = "rbSatisfied";
            this.rbSatisfied.Size = new System.Drawing.Size(71, 16);
            this.rbSatisfied.TabIndex = 12;
            this.rbSatisfied.TabStop = true;
            this.rbSatisfied.Text = "入札成立";
            this.rbSatisfied.UseVisualStyleBackColor = true;
            // 
            // rbUnsatisfied
            // 
            this.rbUnsatisfied.AutoSize = true;
            this.rbUnsatisfied.Location = new System.Drawing.Point(106, 303);
            this.rbUnsatisfied.Name = "rbUnsatisfied";
            this.rbUnsatisfied.Size = new System.Drawing.Size(83, 16);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 15;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(202, 65);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // BidInfoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbUnsatisfied);
            this.Controls.Add(this.rbSatisfied);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btFixed);
            this.Controls.Add(this.tbListingNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAuction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "BidInfoInput";
            this.Size = new System.Drawing.Size(1160, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAuction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbListingNumber;
        private System.Windows.Forms.Button btFixed;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.RadioButton rbSatisfied;
        private System.Windows.Forms.RadioButton rbUnsatisfied;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btSearch;
    }
}

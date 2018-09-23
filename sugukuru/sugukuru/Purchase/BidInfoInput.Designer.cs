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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAuction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbListingNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "入札情報登録";
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
            // cbOrder
            // 
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(87, 70);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(121, 20);
            this.cbOrder.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "オークション会場";
            // 
            // cbAuction
            // 
            this.cbAuction.FormattingEnabled = true;
            this.cbAuction.Location = new System.Drawing.Point(357, 69);
            this.cbAuction.Name = "cbAuction";
            this.cbAuction.Size = new System.Drawing.Size(121, 20);
            this.cbAuction.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "出品番号";
            // 
            // tbListingNumber
            // 
            this.tbListingNumber.Location = new System.Drawing.Point(591, 70);
            this.tbListingNumber.Name = "tbListingNumber";
            this.tbListingNumber.Size = new System.Drawing.Size(100, 19);
            this.tbListingNumber.TabIndex = 6;
            // 
            // BidInfoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbListingNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAuction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BidInfoInput";
            this.Size = new System.Drawing.Size(1160, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAuction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbListingNumber;
    }
}

namespace sugukuru.Purchase
{
    partial class DeliverySlip
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbListingNumber = new System.Windows.Forms.ComboBox();
            this.btIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "納品書発行";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "出品番号";
            // 
            // cbListingNumber
            // 
            this.cbListingNumber.FormattingEnabled = true;
            this.cbListingNumber.Location = new System.Drawing.Point(83, 66);
            this.cbListingNumber.Name = "cbListingNumber";
            this.cbListingNumber.Size = new System.Drawing.Size(121, 20);
            this.cbListingNumber.TabIndex = 11;
            // 
            // btIssue
            // 
            this.btIssue.Location = new System.Drawing.Point(358, 66);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(75, 23);
            this.btIssue.TabIndex = 12;
            this.btIssue.Text = "発行";
            this.btIssue.UseVisualStyleBackColor = true;
            // 
            // DeliverySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.cbListingNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "DeliverySlip";
            this.Size = new System.Drawing.Size(1160, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbListingNumber;
        private System.Windows.Forms.Button btIssue;
    }
}

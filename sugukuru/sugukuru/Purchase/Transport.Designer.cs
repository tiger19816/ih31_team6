namespace sugukuru.Purchase
{
    partial class Transport
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
            this.cbTransport = new System.Windows.Forms.ComboBox();
            this.btConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "陸送情報登録";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "陸送業者";
            // 
            // cbTransport
            // 
            this.cbTransport.FormattingEnabled = true;
            this.cbTransport.Location = new System.Drawing.Point(75, 62);
            this.cbTransport.Name = "cbTransport";
            this.cbTransport.Size = new System.Drawing.Size(121, 20);
            this.cbTransport.TabIndex = 2;
            // 
            // btConfirmation
            // 
            this.btConfirmation.Location = new System.Drawing.Point(15, 130);
            this.btConfirmation.Name = "btConfirmation";
            this.btConfirmation.Size = new System.Drawing.Size(75, 23);
            this.btConfirmation.TabIndex = 3;
            this.btConfirmation.Text = "確認";
            this.btConfirmation.UseVisualStyleBackColor = true;
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btConfirmation);
            this.Controls.Add(this.cbTransport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transport";
            this.Size = new System.Drawing.Size(1160, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTransport;
        private System.Windows.Forms.Button btConfirmation;
    }
}

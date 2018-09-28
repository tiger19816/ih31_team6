namespace sugukuru.Purchase
{
    partial class ListingCar
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
            this.btResult = new System.Windows.Forms.Button();
            this.btListingProcessing = new System.Windows.Forms.Button();
            this.btProccesingResult = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 114;
            this.label7.Text = "出品車両処理";
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(15, 60);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(134, 23);
            this.btResult.TabIndex = 115;
            this.btResult.Text = "出品結果確定";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // btListingProcessing
            // 
            this.btListingProcessing.Location = new System.Drawing.Point(155, 60);
            this.btListingProcessing.Name = "btListingProcessing";
            this.btListingProcessing.Size = new System.Drawing.Size(134, 23);
            this.btListingProcessing.TabIndex = 116;
            this.btListingProcessing.Text = "出品後手続き内容登録";
            this.btListingProcessing.UseVisualStyleBackColor = true;
            this.btListingProcessing.Click += new System.EventHandler(this.btListingProcessing_Click);
            // 
            // btProccesingResult
            // 
            this.btProccesingResult.Location = new System.Drawing.Point(295, 60);
            this.btProccesingResult.Name = "btProccesingResult";
            this.btProccesingResult.Size = new System.Drawing.Size(134, 23);
            this.btProccesingResult.TabIndex = 117;
            this.btProccesingResult.Text = "出品後手続確認・確定";
            this.btProccesingResult.UseVisualStyleBackColor = true;
            this.btProccesingResult.Click += new System.EventHandler(this.btProccesingResult_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(15, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 515);
            this.panel2.TabIndex = 118;
            // 
            // ListingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btProccesingResult);
            this.Controls.Add(this.btListingProcessing);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.label7);
            this.Name = "ListingCar";
            this.Size = new System.Drawing.Size(1160, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btListingProcessing;
        private System.Windows.Forms.Button btProccesingResult;
        private System.Windows.Forms.Panel panel2;
    }
}

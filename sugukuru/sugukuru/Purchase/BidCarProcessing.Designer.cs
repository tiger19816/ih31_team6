namespace sugukuru.Purchase
{
    partial class BidCarProcessing
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
            this.btCarResult = new System.Windows.Forms.Button();
            this.btFixedProcessing = new System.Windows.Forms.Button();
            this.btProcessingResult = new System.Windows.Forms.Button();
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
            this.label7.TabIndex = 113;
            this.label7.Text = "落札車両処理";
            // 
            // btCarResult
            // 
            this.btCarResult.Location = new System.Drawing.Point(15, 52);
            this.btCarResult.Name = "btCarResult";
            this.btCarResult.Size = new System.Drawing.Size(154, 23);
            this.btCarResult.TabIndex = 114;
            this.btCarResult.Text = "落札車両確定";
            this.btCarResult.UseVisualStyleBackColor = true;
            this.btCarResult.Click += new System.EventHandler(this.btCarResult_Click);
            // 
            // btFixedProcessing
            // 
            this.btFixedProcessing.Location = new System.Drawing.Point(175, 52);
            this.btFixedProcessing.Name = "btFixedProcessing";
            this.btFixedProcessing.Size = new System.Drawing.Size(154, 23);
            this.btFixedProcessing.TabIndex = 115;
            this.btFixedProcessing.Text = "落札後処理登録";
            this.btFixedProcessing.UseVisualStyleBackColor = true;
            this.btFixedProcessing.Click += new System.EventHandler(this.btFixedProcessing_Click);
            // 
            // btProcessingResult
            // 
            this.btProcessingResult.Location = new System.Drawing.Point(335, 52);
            this.btProcessingResult.Name = "btProcessingResult";
            this.btProcessingResult.Size = new System.Drawing.Size(154, 23);
            this.btProcessingResult.TabIndex = 116;
            this.btProcessingResult.Text = "落札後処理確認・確定";
            this.btProcessingResult.UseVisualStyleBackColor = true;
            this.btProcessingResult.Click += new System.EventHandler(this.btProcessingResult_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(15, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 515);
            this.panel2.TabIndex = 119;
            // 
            // BidCarProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btProcessingResult);
            this.Controls.Add(this.btFixedProcessing);
            this.Controls.Add(this.btCarResult);
            this.Controls.Add(this.label7);
            this.Name = "BidCarProcessing";
            this.Size = new System.Drawing.Size(1160, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCarResult;
        private System.Windows.Forms.Button btFixedProcessing;
        private System.Windows.Forms.Button btProcessingResult;
        private System.Windows.Forms.Panel panel2;
    }
}

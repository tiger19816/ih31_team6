namespace sugukuru.ClaimCollection
{
    partial class BulkClaim
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.underMonth = new System.Windows.Forms.Label();
            this.underYear = new System.Windows.Forms.Label();
            this.comboBoxUnderMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxUnderYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1040, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "印刷";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "一括 請求書発行";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 470);
            this.dataGridView1.TabIndex = 101;
            // 
            // underMonth
            // 
            this.underMonth.AutoSize = true;
            this.underMonth.Location = new System.Drawing.Point(281, 54);
            this.underMonth.Name = "underMonth";
            this.underMonth.Size = new System.Drawing.Size(20, 16);
            this.underMonth.TabIndex = 105;
            this.underMonth.Text = "月";
            // 
            // underYear
            // 
            this.underYear.AutoSize = true;
            this.underYear.Location = new System.Drawing.Point(205, 54);
            this.underYear.Name = "underYear";
            this.underYear.Size = new System.Drawing.Size(20, 16);
            this.underYear.TabIndex = 104;
            this.underYear.Text = "年";
            // 
            // comboBoxUnderMonth
            // 
            this.comboBoxUnderMonth.FormattingEnabled = true;
            this.comboBoxUnderMonth.Location = new System.Drawing.Point(232, 51);
            this.comboBoxUnderMonth.Name = "comboBoxUnderMonth";
            this.comboBoxUnderMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderMonth.TabIndex = 103;
            // 
            // comboBoxUnderYear
            // 
            this.comboBoxUnderYear.FormattingEnabled = true;
            this.comboBoxUnderYear.Location = new System.Drawing.Point(105, 51);
            this.comboBoxUnderYear.Name = "comboBoxUnderYear";
            this.comboBoxUnderYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxUnderYear.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "請求年月";
            // 
            // BulkClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.underMonth);
            this.Controls.Add(this.underYear);
            this.Controls.Add(this.comboBoxUnderMonth);
            this.Controls.Add(this.comboBoxUnderYear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BulkClaim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label underMonth;
        private System.Windows.Forms.Label underYear;
        private System.Windows.Forms.ComboBox comboBoxUnderMonth;
        private System.Windows.Forms.ComboBox comboBoxUnderYear;
        private System.Windows.Forms.Label label2;
    }
}

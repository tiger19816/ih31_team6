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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.underMonth = new System.Windows.Forms.Label();
            this.underYear = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.dgvBulk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.btDisplay = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dtpBill = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulk)).BeginInit();
            this.SuspendLayout();
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
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(232, 51);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(44, 24);
            this.cbMonth.TabIndex = 103;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(105, 51);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(94, 24);
            this.cbYear.TabIndex = 102;
            // 
            // dgvBulk
            // 
            this.dgvBulk.AllowUserToAddRows = false;
            this.dgvBulk.AllowUserToDeleteRows = false;
            this.dgvBulk.AllowUserToResizeColumns = false;
            this.dgvBulk.AllowUserToResizeRows = false;
            this.dgvBulk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBulk.Location = new System.Drawing.Point(20, 96);
            this.dgvBulk.Name = "dgvBulk";
            this.dgvBulk.RowTemplate.Height = 21;
            this.dgvBulk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBulk.Size = new System.Drawing.Size(1120, 437);
            this.dgvBulk.TabIndex = 101;
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
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPrint.Location = new System.Drawing.Point(1040, 573);
            this.btPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(117, 53);
            this.btPrint.TabIndex = 3;
            this.btPrint.Text = "印刷";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btDisplay
            // 
            this.btDisplay.Location = new System.Drawing.Point(332, 51);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(89, 27);
            this.btDisplay.TabIndex = 109;
            this.btDisplay.Text = "表示";
            this.btDisplay.UseVisualStyleBackColor = true;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dtpBill
            // 
            this.dtpBill.Location = new System.Drawing.Point(969, 539);
            this.dtpBill.Name = "dtpBill";
            this.dtpBill.Size = new System.Drawing.Size(171, 27);
            this.dtpBill.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 111;
            this.label3.Text = "請求書発行日";
            // 
            // BulkClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBill);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.underMonth);
            this.Controls.Add(this.underYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.dgvBulk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPrint);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BulkClaim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBulk;
        private System.Windows.Forms.Label underMonth;
        private System.Windows.Forms.Label underYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker dtpBill;
        private System.Windows.Forms.Label label3;
    }
}

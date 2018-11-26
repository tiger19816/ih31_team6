namespace sugukuru.ClaimCollection
{
    partial class BulkReconciliation
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
            this.btAllocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btFileOpen = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReconciliation = new System.Windows.Forms.DataGridView();
            this.underDay = new System.Windows.Forms.Label();
            this.underMonth = new System.Windows.Forms.Label();
            this.underYear = new System.Windows.Forms.Label();
            this.comboBoxUnderDay = new System.Windows.Forms.ComboBox();
            this.comboBoxUnderMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxUnderYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReconciliation)).BeginInit();
            this.SuspendLayout();
            // 
            // btAllocation
            // 
            this.btAllocation.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAllocation.Location = new System.Drawing.Point(1040, 570);
            this.btAllocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAllocation.Name = "btAllocation";
            this.btAllocation.Size = new System.Drawing.Size(117, 53);
            this.btAllocation.TabIndex = 4;
            this.btAllocation.Text = "引き当て";
            this.btAllocation.UseVisualStyleBackColor = true;
            this.btAllocation.Click += new System.EventHandler(this.btAllocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "一括消込";
            // 
            // btFileOpen
            // 
            this.btFileOpen.Location = new System.Drawing.Point(1001, 47);
            this.btFileOpen.Name = "btFileOpen";
            this.btFileOpen.Size = new System.Drawing.Size(89, 27);
            this.btFileOpen.TabIndex = 108;
            this.btFileOpen.Text = "参照";
            this.btFileOpen.UseVisualStyleBackColor = true;
            this.btFileOpen.Click += new System.EventHandler(this.btFileOpen_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(693, 47);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(302, 27);
            this.tbFileName.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "入金情報ファイル";
            // 
            // dgvReconciliation
            // 
            this.dgvReconciliation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReconciliation.Location = new System.Drawing.Point(20, 130);
            this.dgvReconciliation.Name = "dgvReconciliation";
            this.dgvReconciliation.RowTemplate.Height = 21;
            this.dgvReconciliation.Size = new System.Drawing.Size(1120, 433);
            this.dgvReconciliation.TabIndex = 109;
            // 
            // underDay
            // 
            this.underDay.AutoSize = true;
            this.underDay.Location = new System.Drawing.Point(379, 50);
            this.underDay.Name = "underDay";
            this.underDay.Size = new System.Drawing.Size(47, 16);
            this.underDay.TabIndex = 115;
            this.underDay.Text = "日 以降";
            // 
            // underMonth
            // 
            this.underMonth.AutoSize = true;
            this.underMonth.Location = new System.Drawing.Point(303, 50);
            this.underMonth.Name = "underMonth";
            this.underMonth.Size = new System.Drawing.Size(20, 16);
            this.underMonth.TabIndex = 114;
            this.underMonth.Text = "月";
            // 
            // underYear
            // 
            this.underYear.AutoSize = true;
            this.underYear.Location = new System.Drawing.Point(227, 50);
            this.underYear.Name = "underYear";
            this.underYear.Size = new System.Drawing.Size(20, 16);
            this.underYear.TabIndex = 113;
            this.underYear.Text = "年";
            // 
            // comboBoxUnderDay
            // 
            this.comboBoxUnderDay.FormattingEnabled = true;
            this.comboBoxUnderDay.Location = new System.Drawing.Point(329, 47);
            this.comboBoxUnderDay.Name = "comboBoxUnderDay";
            this.comboBoxUnderDay.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderDay.TabIndex = 112;
            // 
            // comboBoxUnderMonth
            // 
            this.comboBoxUnderMonth.FormattingEnabled = true;
            this.comboBoxUnderMonth.Location = new System.Drawing.Point(254, 47);
            this.comboBoxUnderMonth.Name = "comboBoxUnderMonth";
            this.comboBoxUnderMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderMonth.TabIndex = 111;
            // 
            // comboBoxUnderYear
            // 
            this.comboBoxUnderYear.FormattingEnabled = true;
            this.comboBoxUnderYear.Location = new System.Drawing.Point(127, 47);
            this.comboBoxUnderYear.Name = "comboBoxUnderYear";
            this.comboBoxUnderYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxUnderYear.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 123;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(503, 84);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(150, 40);
            this.btCreate.TabIndex = 124;
            this.btCreate.Text = "消込処理開始";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 125;
            this.label4.Text = "消込期間";
            // 
            // BulkReconciliation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.underDay);
            this.Controls.Add(this.underMonth);
            this.Controls.Add(this.underYear);
            this.Controls.Add(this.comboBoxUnderDay);
            this.Controls.Add(this.comboBoxUnderMonth);
            this.Controls.Add(this.comboBoxUnderYear);
            this.Controls.Add(this.dgvReconciliation);
            this.Controls.Add(this.btFileOpen);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAllocation);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BulkReconciliation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReconciliation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAllocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFileOpen;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReconciliation;
        private System.Windows.Forms.Label underDay;
        private System.Windows.Forms.Label underMonth;
        private System.Windows.Forms.Label underYear;
        private System.Windows.Forms.ComboBox comboBoxUnderDay;
        private System.Windows.Forms.ComboBox comboBoxUnderMonth;
        private System.Windows.Forms.ComboBox comboBoxUnderYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label label4;
    }
}

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receipt_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claim_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_closing_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receipt_no,
            this.order_no,
            this.car_name,
            this.claim_amount,
            this.customer_name,
            this.issue_day,
            this.payment_closing_day});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 550);
            this.dataGridView1.TabIndex = 1;
            // 
            // receipt_no
            // 
            this.receipt_no.HeaderText = "請求書番号";
            this.receipt_no.Name = "receipt_no";
            // 
            // order_no
            // 
            this.order_no.HeaderText = "受注番号";
            this.order_no.Name = "order_no";
            // 
            // car_name
            // 
            this.car_name.HeaderText = "車名";
            this.car_name.Name = "car_name";
            // 
            // claim_amount
            // 
            this.claim_amount.HeaderText = "請求額";
            this.claim_amount.Name = "claim_amount";
            // 
            // customer_name
            // 
            this.customer_name.HeaderText = "顧客名";
            this.customer_name.Name = "customer_name";
            // 
            // issue_day
            // 
            this.issue_day.HeaderText = "発行日付";
            this.issue_day.Name = "issue_day";
            // 
            // payment_closing_day
            // 
            this.payment_closing_day.HeaderText = "支払締日";
            this.payment_closing_day.Name = "payment_closing_day";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(531, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "追加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BulkClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BulkClaim";
            this.Size = new System.Drawing.Size(1160, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn claim_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_closing_day;
        private System.Windows.Forms.Button button1;
    }
}

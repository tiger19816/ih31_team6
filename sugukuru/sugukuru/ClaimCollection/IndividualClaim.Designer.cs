namespace sugukuru.ClaimCollection
{
    partial class IndividualClaim
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
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.payment_closing_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claim_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_year_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receipt_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receipt_no,
            this.order_no,
            this.client_name,
            this.car_type,
            this.car_year_type,
            this.car_name,
            this.claim_amount,
            this.payment_closing_day});
            this.dataGridView1.Location = new System.Drawing.Point(20, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(960, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addButton.Location = new System.Drawing.Point(450, 430);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(897, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "印刷";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "個別請求書発行　印刷一覧";
            // 
            // payment_closing_day
            // 
            this.payment_closing_day.HeaderText = "支払締日";
            this.payment_closing_day.Name = "payment_closing_day";
            // 
            // claim_amount
            // 
            this.claim_amount.HeaderText = "請求額";
            this.claim_amount.Name = "claim_amount";
            // 
            // car_name
            // 
            this.car_name.HeaderText = "車名";
            this.car_name.Name = "car_name";
            // 
            // car_year_type
            // 
            this.car_year_type.HeaderText = "年式";
            this.car_year_type.Name = "car_year_type";
            // 
            // car_type
            // 
            this.car_type.HeaderText = "型式";
            this.car_type.Name = "car_type";
            // 
            // client_name
            // 
            this.client_name.HeaderText = "顧客名";
            this.client_name.Name = "client_name";
            // 
            // order_no
            // 
            this.order_no.HeaderText = "受注番号";
            this.order_no.Name = "order_no";
            // 
            // receipt_no
            // 
            this.receipt_no.HeaderText = "請求書番号";
            this.receipt_no.Name = "receipt_no";
            // 
            // IndividualClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IndividualClaim";
            this.Size = new System.Drawing.Size(1000, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_year_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn claim_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_closing_day;
    }
}

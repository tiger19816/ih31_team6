namespace sugukuru.Purchase
{
    partial class BidResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btFixed = new System.Windows.Forms.Button();
            this.btCorrection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 116;
            this.label7.Text = "落札車両情報";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(796, 150);
            this.dataGridView1.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 12);
            this.label1.TabIndex = 118;
            this.label1.Text = "選択された落札車両の手続データ";
            // 
            // btFixed
            // 
            this.btFixed.Location = new System.Drawing.Point(695, 269);
            this.btFixed.Name = "btFixed";
            this.btFixed.Size = new System.Drawing.Size(105, 44);
            this.btFixed.TabIndex = 119;
            this.btFixed.Text = "確定";
            this.btFixed.UseVisualStyleBackColor = true;
            // 
            // btCorrection
            // 
            this.btCorrection.Location = new System.Drawing.Point(556, 269);
            this.btCorrection.Name = "btCorrection";
            this.btCorrection.Size = new System.Drawing.Size(105, 44);
            this.btCorrection.TabIndex = 120;
            this.btCorrection.Text = "訂正";
            this.btCorrection.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 121;
            this.button1.Text = "訂正";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BidResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCorrection);
            this.Controls.Add(this.btFixed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Name = "BidResult";
            this.Text = "BidResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFixed;
        private System.Windows.Forms.Button btCorrection;
        private System.Windows.Forms.Button button1;
    }
}
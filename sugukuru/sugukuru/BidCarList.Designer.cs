namespace sugukuru
{
    partial class BidCarList
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
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btRewrite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRewrite);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btConfirm);
            this.panel1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "落札車両情報";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(908, 343);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 27);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "確定";
            this.btConfirm.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // btRewrite
            // 
            this.btRewrite.Location = new System.Drawing.Point(114, 343);
            this.btRewrite.Name = "btRewrite";
            this.btRewrite.Size = new System.Drawing.Size(75, 28);
            this.btRewrite.TabIndex = 4;
            this.btRewrite.Text = "訂正";
            this.btRewrite.UseVisualStyleBackColor = true;
            // 
            // BidCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Name = "BidCarList";
            this.Text = "落札車両情報";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRewrite;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
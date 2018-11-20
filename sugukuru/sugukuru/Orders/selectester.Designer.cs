namespace sugukuru.Orders
{
    partial class selectester
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
            this.selecter = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selecter)).BeginInit();
            this.SuspendLayout();
            // 
            // selecter
            // 
            this.selecter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selecter.Location = new System.Drawing.Point(32, 83);
            this.selecter.Name = "selecter";
            this.selecter.RowTemplate.Height = 21;
            this.selecter.Size = new System.Drawing.Size(814, 51);
            this.selecter.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(701, 176);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // selectester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 240);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.selecter);
            this.Name = "selectester";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.selecter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView selecter;
        private System.Windows.Forms.Button OK;

    }
}
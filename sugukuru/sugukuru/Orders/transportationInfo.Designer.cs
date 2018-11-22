namespace sugukuru.Orders
{
    partial class TransportationInfo
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
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(12, 398);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 40);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "閉じる";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // TransportationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClose);
            this.Name = "TransportationInfo";
            this.Text = "transportationInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
    }
}
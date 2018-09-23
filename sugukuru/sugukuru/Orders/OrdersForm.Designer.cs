namespace sugukuru.Orders
{
    partial class OrdersForm
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
            this.btQuotation = new System.Windows.Forms.Button();
            this.btRegistration = new System.Windows.Forms.Button();
            this.btList = new System.Windows.Forms.Button();
            this.inheritableFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inheritableFlowLayoutPanel1
            // 
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btList);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btRegistration);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btQuotation);
            // 
            // btQuotation
            // 
            this.btQuotation.Location = new System.Drawing.Point(3, 135);
            this.btQuotation.Name = "btQuotation";
            this.btQuotation.Size = new System.Drawing.Size(94, 60);
            this.btQuotation.TabIndex = 1;
            this.btQuotation.Text = "見積書発行";
            this.btQuotation.UseVisualStyleBackColor = true;
            this.btQuotation.Click += new System.EventHandler(this.btQuotation_Click);
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(3, 69);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(94, 60);
            this.btRegistration.TabIndex = 2;
            this.btRegistration.Text = "受注登録";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // btList
            // 
            this.btList.Location = new System.Drawing.Point(3, 3);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(94, 60);
            this.btList.TabIndex = 3;
            this.btList.Text = "受注一覧";
            this.btList.UseVisualStyleBackColor = true;
            this.btList.Click += new System.EventHandler(this.btList_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Name = "OrdersForm";
            this.Text = "受注 - スグクル社 車両販売管理システム";
            this.inheritableFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btList;
        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.Button btQuotation;
    }
}
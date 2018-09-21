namespace sugukuru.FormSample
{
    partial class Sample
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
            this.btMenu1 = new System.Windows.Forms.Button();
            this.btMenu2 = new System.Windows.Forms.Button();
            this.btMenu3 = new System.Windows.Forms.Button();
            this.btMenu4 = new System.Windows.Forms.Button();
            this.inheritableFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inheritableFlowLayoutPanel1
            // 
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btMenu3);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btMenu2);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btMenu4);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btMenu1);
            // 
            // btMenu1
            // 
            this.btMenu1.Location = new System.Drawing.Point(3, 201);
            this.btMenu1.Name = "btMenu1";
            this.btMenu1.Size = new System.Drawing.Size(94, 60);
            this.btMenu1.TabIndex = 0;
            this.btMenu1.Text = "見積書発行";
            this.btMenu1.UseVisualStyleBackColor = true;
            this.btMenu1.Click += new System.EventHandler(this.btMenu1_Click);
            // 
            // btMenu2
            // 
            this.btMenu2.Location = new System.Drawing.Point(3, 69);
            this.btMenu2.Name = "btMenu2";
            this.btMenu2.Size = new System.Drawing.Size(94, 60);
            this.btMenu2.TabIndex = 1;
            this.btMenu2.Text = "メニュー2";
            this.btMenu2.UseVisualStyleBackColor = true;
            this.btMenu2.Click += new System.EventHandler(this.btMenu2_Click);
            // 
            // btMenu3
            // 
            this.btMenu3.Location = new System.Drawing.Point(3, 3);
            this.btMenu3.Name = "btMenu3";
            this.btMenu3.Size = new System.Drawing.Size(94, 60);
            this.btMenu3.TabIndex = 2;
            this.btMenu3.Text = "メニュー3";
            this.btMenu3.UseVisualStyleBackColor = true;
            // 
            // btMenu4
            // 
            this.btMenu4.Location = new System.Drawing.Point(3, 135);
            this.btMenu4.Name = "btMenu4";
            this.btMenu4.Size = new System.Drawing.Size(94, 60);
            this.btMenu4.TabIndex = 3;
            this.btMenu4.Text = "メニュー4";
            this.btMenu4.UseVisualStyleBackColor = true;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Name = "Sample";
            this.Text = "Sample";
            this.inheritableFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btMenu3;
        private System.Windows.Forms.Button btMenu2;
        private System.Windows.Forms.Button btMenu4;
        private System.Windows.Forms.Button btMenu1;
    }
}
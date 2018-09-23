namespace sugukuru.MainMenu
{
    partial class MainMenuForm
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
            this.btPurchase = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btClaimCollection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPurchase
            // 
            this.btPurchase.Location = new System.Drawing.Point(298, 113);
            this.btPurchase.Name = "btPurchase";
            this.btPurchase.Size = new System.Drawing.Size(100, 100);
            this.btPurchase.TabIndex = 4;
            this.btPurchase.Text = "仕入・売却";
            this.btPurchase.UseVisualStyleBackColor = true;
            this.btPurchase.Click += new System.EventHandler(this.Button_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Location = new System.Drawing.Point(158, 241);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(100, 100);
            this.btCustomer.TabIndex = 5;
            this.btCustomer.Text = "顧客管理";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.Button_Click);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(158, 113);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(100, 100);
            this.btOrder.TabIndex = 6;
            this.btOrder.Text = "受注";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.Button_Click);
            // 
            // btClaimCollection
            // 
            this.btClaimCollection.Location = new System.Drawing.Point(438, 113);
            this.btClaimCollection.Name = "btClaimCollection";
            this.btClaimCollection.Size = new System.Drawing.Size(100, 100);
            this.btClaimCollection.TabIndex = 7;
            this.btClaimCollection.Text = "請求・回収・消込";
            this.btClaimCollection.UseVisualStyleBackColor = true;
            this.btClaimCollection.Click += new System.EventHandler(this.Button_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btClaimCollection);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.btPurchase);
            this.Name = "MainMenuForm";
            this.Text = "メインメニュー - スグクル社 車両販売管理システム";
            this.Controls.SetChildIndex(this.btPurchase, 0);
            this.Controls.SetChildIndex(this.btCustomer, 0);
            this.Controls.SetChildIndex(this.btOrder, 0);
            this.Controls.SetChildIndex(this.btClaimCollection, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPurchase;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btClaimCollection;
    }
}
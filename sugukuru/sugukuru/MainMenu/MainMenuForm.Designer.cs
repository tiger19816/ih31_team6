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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPurchase
            // 
            this.btPurchase.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPurchase.Location = new System.Drawing.Point(45, 233);
            this.btPurchase.Name = "btPurchase";
            this.btPurchase.Size = new System.Drawing.Size(250, 100);
            this.btPurchase.TabIndex = 4;
            this.btPurchase.Text = "仕入";
            this.btPurchase.UseVisualStyleBackColor = true;
            this.btPurchase.Click += new System.EventHandler(this.Button_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCustomer.Location = new System.Drawing.Point(389, 233);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(250, 100);
            this.btCustomer.TabIndex = 6;
            this.btCustomer.Text = "顧客管理";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.Button_Click);
            // 
            // btOrder
            // 
            this.btOrder.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOrder.Location = new System.Drawing.Point(45, 116);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(250, 100);
            this.btOrder.TabIndex = 1;
            this.btOrder.Text = "受注";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.Button_Click);
            // 
            // btClaimCollection
            // 
            this.btClaimCollection.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClaimCollection.Location = new System.Drawing.Point(389, 116);
            this.btClaimCollection.Name = "btClaimCollection";
            this.btClaimCollection.Size = new System.Drawing.Size(250, 100);
            this.btClaimCollection.TabIndex = 5;
            this.btClaimCollection.Text = "請求・回収・消込";
            this.btClaimCollection.UseVisualStyleBackColor = true;
            this.btClaimCollection.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "スグクル社 車両販売システム ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("游ゴシック", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "メインメニュー";
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLogout.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btLogout.Location = new System.Drawing.Point(45, 541);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(250, 100);
            this.btLogout.TabIndex = 11;
            this.btLogout.Text = "ログアウト";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btSales
            // 
            this.btSales.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSales.Location = new System.Drawing.Point(45, 350);
            this.btSales.Name = "btSales";
            this.btSales.Size = new System.Drawing.Size(250, 100);
            this.btSales.TabIndex = 12;
            this.btSales.Text = "売却";
            this.btSales.UseVisualStyleBackColor = true;
            this.btSales.Click += new System.EventHandler(this.Button_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btLogout, 0);
            this.Controls.SetChildIndex(this.btSales, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPurchase;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btClaimCollection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btSales;
    }
}
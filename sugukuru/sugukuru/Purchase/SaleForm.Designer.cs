namespace sugukuru.Purchase
{
    partial class SaleForm
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
            this.btListingResult = new System.Windows.Forms.Button();
            this.btListingCar = new System.Windows.Forms.Button();
            this.btDisposalCar = new System.Windows.Forms.Button();
            this.btBitInfo = new System.Windows.Forms.Button();
            this.btTransportInfo = new System.Windows.Forms.Button();
            this.inheritableFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inheritableFlowLayoutPanel1
            // 
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btListingResult);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBitInfo);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btListingCar);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btTransportInfo);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btDisposalCar);
            // 
            // btListingResult
            // 
            this.btListingResult.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListingResult.Location = new System.Drawing.Point(2, 2);
            this.btListingResult.Margin = new System.Windows.Forms.Padding(2);
            this.btListingResult.Name = "btListingResult";
            this.btListingResult.Size = new System.Drawing.Size(94, 60);
            this.btListingResult.TabIndex = 13;
            this.btListingResult.Text = "出品結果登録";
            this.btListingResult.UseVisualStyleBackColor = true;
            this.btListingResult.Click += new System.EventHandler(this.btListingResult_Click);
            // 
            // btListingCar
            // 
            this.btListingCar.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListingCar.Location = new System.Drawing.Point(2, 130);
            this.btListingCar.Margin = new System.Windows.Forms.Padding(2);
            this.btListingCar.Name = "btListingCar";
            this.btListingCar.Size = new System.Drawing.Size(94, 60);
            this.btListingCar.TabIndex = 12;
            this.btListingCar.Text = "出品車両処理";
            this.btListingCar.UseVisualStyleBackColor = true;
            this.btListingCar.Click += new System.EventHandler(this.btListingCar_Click);
            // 
            // btDisposalCar
            // 
            this.btDisposalCar.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDisposalCar.Location = new System.Drawing.Point(2, 258);
            this.btDisposalCar.Margin = new System.Windows.Forms.Padding(2);
            this.btDisposalCar.Name = "btDisposalCar";
            this.btDisposalCar.Size = new System.Drawing.Size(94, 60);
            this.btDisposalCar.TabIndex = 11;
            this.btDisposalCar.Text = "出品車両登録";
            this.btDisposalCar.UseVisualStyleBackColor = true;
            this.btDisposalCar.Click += new System.EventHandler(this.btDisposalCar_Click);
            // 
            // btBitInfo
            // 
            this.btBitInfo.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBitInfo.Location = new System.Drawing.Point(2, 66);
            this.btBitInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btBitInfo.Name = "btBitInfo";
            this.btBitInfo.Size = new System.Drawing.Size(94, 60);
            this.btBitInfo.TabIndex = 9;
            this.btBitInfo.Text = "入札情報登録";
            this.btBitInfo.UseVisualStyleBackColor = true;
            this.btBitInfo.Click += new System.EventHandler(this.btBitInfo_Click);
            // 
            // btTransportInfo
            // 
            this.btTransportInfo.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTransportInfo.Location = new System.Drawing.Point(2, 194);
            this.btTransportInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btTransportInfo.Name = "btTransportInfo";
            this.btTransportInfo.Size = new System.Drawing.Size(94, 60);
            this.btTransportInfo.TabIndex = 10;
            this.btTransportInfo.Text = "陸送情報登録";
            this.btTransportInfo.UseVisualStyleBackColor = true;
            this.btTransportInfo.Click += new System.EventHandler(this.btTransportInfo_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.inheritableFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btListingResult;
        private System.Windows.Forms.Button btListingCar;
        private System.Windows.Forms.Button btDisposalCar;
        private System.Windows.Forms.Button btBitInfo;
        private System.Windows.Forms.Button btTransportInfo;
    }
}
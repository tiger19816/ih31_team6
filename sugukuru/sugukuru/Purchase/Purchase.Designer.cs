namespace sugukuru.Purchase
{
    partial class Purchase
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
            this.btBitCar = new System.Windows.Forms.Button();
            this.btBitInfo = new System.Windows.Forms.Button();
            this.btTransportInfo = new System.Windows.Forms.Button();
            this.btDisposalCarPurchase = new System.Windows.Forms.Button();
            this.btDeliverySlip = new System.Windows.Forms.Button();
            this.btDisposalCar = new System.Windows.Forms.Button();
            this.btListingCar = new System.Windows.Forms.Button();
            this.btListingResult = new System.Windows.Forms.Button();
            this.btBidCarInput = new System.Windows.Forms.Button();
            this.inheritableFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inheritableFlowLayoutPanel1
            // 
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBidCarInput);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btListingResult);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btListingCar);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btDisposalCar);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btDeliverySlip);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBitInfo);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btDisposalCarPurchase);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBitCar);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btTransportInfo);
            // 
            // btBitCar
            // 
            this.btBitCar.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBitCar.Location = new System.Drawing.Point(2, 452);
            this.btBitCar.Margin = new System.Windows.Forms.Padding(2);
            this.btBitCar.Name = "btBitCar";
            this.btBitCar.Size = new System.Drawing.Size(94, 60);
            this.btBitCar.TabIndex = 0;
            this.btBitCar.Text = "落札車両処理";
            this.btBitCar.UseVisualStyleBackColor = true;
            this.btBitCar.Click += new System.EventHandler(this.btBitCar_Click);
            // 
            // btBitInfo
            // 
            this.btBitInfo.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBitInfo.Location = new System.Drawing.Point(2, 324);
            this.btBitInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btBitInfo.Name = "btBitInfo";
            this.btBitInfo.Size = new System.Drawing.Size(94, 60);
            this.btBitInfo.TabIndex = 1;
            this.btBitInfo.Text = "入札情報登録";
            this.btBitInfo.UseVisualStyleBackColor = true;
            this.btBitInfo.Click += new System.EventHandler(this.btBitInfo_Click);
            // 
            // btTransportInfo
            // 
            this.btTransportInfo.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTransportInfo.Location = new System.Drawing.Point(2, 516);
            this.btTransportInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btTransportInfo.Name = "btTransportInfo";
            this.btTransportInfo.Size = new System.Drawing.Size(94, 60);
            this.btTransportInfo.TabIndex = 2;
            this.btTransportInfo.Text = "陸送情報登録";
            this.btTransportInfo.UseVisualStyleBackColor = true;
            this.btTransportInfo.Click += new System.EventHandler(this.btTransportInfo_Click);
            // 
            // btDisposalCarPurchase
            // 
            this.btDisposalCarPurchase.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDisposalCarPurchase.Location = new System.Drawing.Point(2, 388);
            this.btDisposalCarPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btDisposalCarPurchase.Name = "btDisposalCarPurchase";
            this.btDisposalCarPurchase.Size = new System.Drawing.Size(94, 60);
            this.btDisposalCarPurchase.TabIndex = 3;
            this.btDisposalCarPurchase.Text = "社内販売";
            this.btDisposalCarPurchase.UseVisualStyleBackColor = true;
            this.btDisposalCarPurchase.Click += new System.EventHandler(this.btDisposalCarPurchase_Click);
            // 
            // btDeliverySlip
            // 
            this.btDeliverySlip.Location = new System.Drawing.Point(3, 259);
            this.btDeliverySlip.Name = "btDeliverySlip";
            this.btDeliverySlip.Size = new System.Drawing.Size(94, 60);
            this.btDeliverySlip.TabIndex = 5;
            this.btDeliverySlip.Text = "納品書発行";
            this.btDeliverySlip.UseVisualStyleBackColor = true;
            this.btDeliverySlip.Click += new System.EventHandler(this.btDeliverySlip_Click);
            // 
            // btDisposalCar
            // 
            this.btDisposalCar.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDisposalCar.Location = new System.Drawing.Point(2, 194);
            this.btDisposalCar.Margin = new System.Windows.Forms.Padding(2);
            this.btDisposalCar.Name = "btDisposalCar";
            this.btDisposalCar.Size = new System.Drawing.Size(94, 60);
            this.btDisposalCar.TabIndex = 6;
            this.btDisposalCar.Text = "出品車両登録";
            this.btDisposalCar.UseVisualStyleBackColor = true;
            this.btDisposalCar.Click += new System.EventHandler(this.btDisposalCar_Click);
            // 
            // btListingCar
            // 
            this.btListingCar.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListingCar.Location = new System.Drawing.Point(2, 130);
            this.btListingCar.Margin = new System.Windows.Forms.Padding(2);
            this.btListingCar.Name = "btListingCar";
            this.btListingCar.Size = new System.Drawing.Size(94, 60);
            this.btListingCar.TabIndex = 7;
            this.btListingCar.Text = "出品車両処理";
            this.btListingCar.UseVisualStyleBackColor = true;
            this.btListingCar.Click += new System.EventHandler(this.btListingCar_Click);
            // 
            // btListingResult
            // 
            this.btListingResult.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListingResult.Location = new System.Drawing.Point(2, 66);
            this.btListingResult.Margin = new System.Windows.Forms.Padding(2);
            this.btListingResult.Name = "btListingResult";
            this.btListingResult.Size = new System.Drawing.Size(94, 60);
            this.btListingResult.TabIndex = 8;
            this.btListingResult.Text = "出品結果登録";
            this.btListingResult.UseVisualStyleBackColor = true;
            this.btListingResult.Click += new System.EventHandler(this.btListingResult_Click);
            // 
            // btBidCarInput
            // 
            this.btBidCarInput.Font = new System.Drawing.Font("游ゴシック", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBidCarInput.Location = new System.Drawing.Point(2, 2);
            this.btBidCarInput.Margin = new System.Windows.Forms.Padding(2);
            this.btBidCarInput.Name = "btBidCarInput";
            this.btBidCarInput.Size = new System.Drawing.Size(94, 60);
            this.btBidCarInput.TabIndex = 9;
            this.btBidCarInput.Text = "落札車両登録";
            this.btBidCarInput.UseVisualStyleBackColor = true;
            this.btBidCarInput.Click += new System.EventHandler(this.btBidCarInput_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Purchase";
            this.Text = "仕入れ -スグクル社車両販売システム";
            this.inheritableFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBitInfo;
        private System.Windows.Forms.Button btDisposalCarPurchase;
        private System.Windows.Forms.Button btBitCar;
        private System.Windows.Forms.Button btTransportInfo;
        private System.Windows.Forms.Button btDeliverySlip;
        private System.Windows.Forms.Button btDisposalCar;
        private System.Windows.Forms.Button btListingCar;
        private System.Windows.Forms.Button btListingResult;
        private System.Windows.Forms.Button btBidCarInput;
    }
}
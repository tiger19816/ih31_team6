namespace sugukuru.ClaimCollection
{
    partial class ClaimCollectionForm
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
            this.btReceiptPrinting = new System.Windows.Forms.Button();
            this.btRepetitionClaim = new System.Windows.Forms.Button();
            this.btBulkReconciliation = new System.Windows.Forms.Button();
            this.btIndividualReconciliation = new System.Windows.Forms.Button();
            this.btBulkClaim = new System.Windows.Forms.Button();
            this.btIndividualClaim = new System.Windows.Forms.Button();
            this.btCheckAccountReceivable = new System.Windows.Forms.Button();
            this.inheritableFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inheritableFlowLayoutPanel1
            // 
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btCheckAccountReceivable);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btIndividualClaim);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBulkClaim);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btIndividualReconciliation);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btBulkReconciliation);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btRepetitionClaim);
            this.inheritableFlowLayoutPanel1.Controls.Add(this.btReceiptPrinting);
            // 
            // btReceiptPrinting
            // 
            this.btReceiptPrinting.Location = new System.Drawing.Point(3, 399);
            this.btReceiptPrinting.Name = "btReceiptPrinting";
            this.btReceiptPrinting.Size = new System.Drawing.Size(94, 60);
            this.btReceiptPrinting.TabIndex = 6;
            this.btReceiptPrinting.Text = "領収書発行";
            this.btReceiptPrinting.UseVisualStyleBackColor = true;
            this.btReceiptPrinting.Click += new System.EventHandler(this.btReceiptPrinting_Click);
            // 
            // btRepetitionClaim
            // 
            this.btRepetitionClaim.Location = new System.Drawing.Point(3, 333);
            this.btRepetitionClaim.Name = "btRepetitionClaim";
            this.btRepetitionClaim.Size = new System.Drawing.Size(94, 60);
            this.btRepetitionClaim.TabIndex = 7;
            this.btRepetitionClaim.Text = "繰越請求書発行";
            this.btRepetitionClaim.UseVisualStyleBackColor = true;
            this.btRepetitionClaim.Click += new System.EventHandler(this.btRepetitionClaim_Click);
            // 
            // btBulkReconciliation
            // 
            this.btBulkReconciliation.Location = new System.Drawing.Point(3, 267);
            this.btBulkReconciliation.Name = "btBulkReconciliation";
            this.btBulkReconciliation.Size = new System.Drawing.Size(94, 60);
            this.btBulkReconciliation.TabIndex = 8;
            this.btBulkReconciliation.Text = "一括消込";
            this.btBulkReconciliation.UseVisualStyleBackColor = true;
            this.btBulkReconciliation.Click += new System.EventHandler(this.btBulkReconciliation_Click);
            // 
            // btIndividualReconciliation
            // 
            this.btIndividualReconciliation.Location = new System.Drawing.Point(3, 201);
            this.btIndividualReconciliation.Name = "btIndividualReconciliation";
            this.btIndividualReconciliation.Size = new System.Drawing.Size(94, 60);
            this.btIndividualReconciliation.TabIndex = 9;
            this.btIndividualReconciliation.Text = "個別消込";
            this.btIndividualReconciliation.UseVisualStyleBackColor = true;
            this.btIndividualReconciliation.Click += new System.EventHandler(this.btIndividualReconciliation_Click);
            // 
            // btBulkClaim
            // 
            this.btBulkClaim.Location = new System.Drawing.Point(3, 135);
            this.btBulkClaim.Name = "btBulkClaim";
            this.btBulkClaim.Size = new System.Drawing.Size(94, 60);
            this.btBulkClaim.TabIndex = 10;
            this.btBulkClaim.Text = "一括請求書発行";
            this.btBulkClaim.UseVisualStyleBackColor = true;
            this.btBulkClaim.Click += new System.EventHandler(this.btBulkClaim_Click);
            // 
            // btIndividualClaim
            // 
            this.btIndividualClaim.Location = new System.Drawing.Point(3, 69);
            this.btIndividualClaim.Name = "btIndividualClaim";
            this.btIndividualClaim.Size = new System.Drawing.Size(94, 60);
            this.btIndividualClaim.TabIndex = 11;
            this.btIndividualClaim.Text = "個別請求書発行";
            this.btIndividualClaim.UseVisualStyleBackColor = true;
            this.btIndividualClaim.Click += new System.EventHandler(this.btIndividualClaim_Click);
            // 
            // btCheckAccountReceivable
            // 
            this.btCheckAccountReceivable.Location = new System.Drawing.Point(3, 3);
            this.btCheckAccountReceivable.Name = "btCheckAccountReceivable";
            this.btCheckAccountReceivable.Size = new System.Drawing.Size(94, 60);
            this.btCheckAccountReceivable.TabIndex = 12;
            this.btCheckAccountReceivable.Text = "売掛金参照";
            this.btCheckAccountReceivable.UseVisualStyleBackColor = true;
            this.btCheckAccountReceivable.Click += new System.EventHandler(this.btCheckAccountReceivable_Click);
            // 
            // ClaimCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Name = "ClaimCollectionForm";
            this.Text = "ClaimCollectionForm";
            this.inheritableFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReceiptPrinting;
        private System.Windows.Forms.Button btCheckAccountReceivable;
        private System.Windows.Forms.Button btIndividualClaim;
        private System.Windows.Forms.Button btBulkClaim;
        private System.Windows.Forms.Button btIndividualReconciliation;
        private System.Windows.Forms.Button btBulkReconciliation;
        private System.Windows.Forms.Button btRepetitionClaim;
    }
}
namespace sugukuru.ClaimCollection
{
    partial class AllocationForm
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
            this.dgvAllocation = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.tblCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbDate2 = new System.Windows.Forms.Label();
            this.lbDate1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).BeginInit();
            this.tblCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 100;
            this.label1.Text = "引き当て";
            // 
            // dgvAllocation
            // 
            this.dgvAllocation.AllowUserToAddRows = false;
            this.dgvAllocation.AllowUserToDeleteRows = false;
            this.dgvAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocation.Location = new System.Drawing.Point(12, 88);
            this.dgvAllocation.Name = "dgvAllocation";
            this.dgvAllocation.ReadOnly = true;
            this.dgvAllocation.RowTemplate.Height = 21;
            this.dgvAllocation.Size = new System.Drawing.Size(929, 291);
            this.dgvAllocation.TabIndex = 101;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 102;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFix
            // 
            this.btFix.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFix.Location = new System.Drawing.Point(841, 385);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(100, 40);
            this.btFix.TabIndex = 103;
            this.btFix.Text = "確定";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // tblCustomer
            // 
            this.tblCustomer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCustomer.ColumnCount = 8;
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tblCustomer.Controls.Add(this.lbAmount, 7, 0);
            this.tblCustomer.Controls.Add(this.lbDate2, 5, 0);
            this.tblCustomer.Controls.Add(this.lbDate1, 3, 0);
            this.tblCustomer.Controls.Add(this.lbName, 1, 0);
            this.tblCustomer.Controls.Add(this.label5, 6, 0);
            this.tblCustomer.Controls.Add(this.label4, 4, 0);
            this.tblCustomer.Controls.Add(this.lblabel, 2, 0);
            this.tblCustomer.Controls.Add(this.label3, 0, 0);
            this.tblCustomer.Location = new System.Drawing.Point(12, 37);
            this.tblCustomer.Name = "tblCustomer";
            this.tblCustomer.RowCount = 1;
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblCustomer.Size = new System.Drawing.Size(929, 45);
            this.tblCustomer.TabIndex = 104;
            this.tblCustomer.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblCustomer_CellPaint);
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Location = new System.Drawing.Point(928, 16);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(0, 16);
            this.lbAmount.TabIndex = 105;
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDate2
            // 
            this.lbDate2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDate2.AutoSize = true;
            this.lbDate2.BackColor = System.Drawing.Color.Transparent;
            this.lbDate2.Location = new System.Drawing.Point(609, 16);
            this.lbDate2.Name = "lbDate2";
            this.lbDate2.Size = new System.Drawing.Size(0, 16);
            this.lbDate2.TabIndex = 105;
            // 
            // lbDate1
            // 
            this.lbDate1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDate1.AutoSize = true;
            this.lbDate1.BackColor = System.Drawing.Color.Transparent;
            this.lbDate1.Location = new System.Drawing.Point(407, 16);
            this.lbDate1.Name = "lbDate1";
            this.lbDate1.Size = new System.Drawing.Size(0, 16);
            this.lbDate1.TabIndex = 105;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(105, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 16);
            this.lbName.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(730, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 105;
            this.label5.Text = "金額";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(528, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "起算日";
            // 
            // lblabel
            // 
            this.lblabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblabel.AutoSize = true;
            this.lblabel.BackColor = System.Drawing.Color.Transparent;
            this.lblabel.Location = new System.Drawing.Point(326, 16);
            this.lblabel.Name = "lblabel";
            this.lblabel.Size = new System.Drawing.Size(44, 16);
            this.lblabel.TabIndex = 105;
            this.lblabel.Text = "勘定日";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "振込依頼人名";
            // 
            // AllocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.tblCustomer);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAllocation);
            this.Controls.Add(this.label1);
            this.Name = "AllocationForm";
            this.Text = "引き当て - スグクル社車両販売システム";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvAllocation, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btFix, 0);
            this.Controls.SetChildIndex(this.tblCustomer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).EndInit();
            this.tblCustomer.ResumeLayout(false);
            this.tblCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.TableLayoutPanel tblCustomer;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbDate2;
        private System.Windows.Forms.Label lbDate1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblabel;
        private System.Windows.Forms.Label label3;
    }
}
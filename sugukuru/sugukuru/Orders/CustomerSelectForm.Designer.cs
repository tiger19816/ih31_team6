namespace sugukuru.Orders
{
    partial class CustomerSelectForm
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
            this.searchSalesReq = new System.Windows.Forms.ComboBox();
            this.searchCustomerAddress = new System.Windows.Forms.TextBox();
            this.searchCustomerPostalCode = new System.Windows.Forms.TextBox();
            this.searchCustomerTEL = new System.Windows.Forms.TextBox();
            this.searchCustomerName = new System.Windows.Forms.TextBox();
            this.searchCustomerId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchSalesReq
            // 
            this.searchSalesReq.FormattingEnabled = true;
            this.searchSalesReq.Location = new System.Drawing.Point(467, 126);
            this.searchSalesReq.Name = "searchSalesReq";
            this.searchSalesReq.Size = new System.Drawing.Size(121, 24);
            this.searchSalesReq.TabIndex = 61;
            // 
            // searchCustomerAddress
            // 
            this.searchCustomerAddress.Location = new System.Drawing.Point(467, 92);
            this.searchCustomerAddress.Name = "searchCustomerAddress";
            this.searchCustomerAddress.Size = new System.Drawing.Size(260, 27);
            this.searchCustomerAddress.TabIndex = 60;
            // 
            // searchCustomerPostalCode
            // 
            this.searchCustomerPostalCode.Location = new System.Drawing.Point(467, 58);
            this.searchCustomerPostalCode.Name = "searchCustomerPostalCode";
            this.searchCustomerPostalCode.Size = new System.Drawing.Size(100, 27);
            this.searchCustomerPostalCode.TabIndex = 59;
            // 
            // searchCustomerTEL
            // 
            this.searchCustomerTEL.Location = new System.Drawing.Point(147, 126);
            this.searchCustomerTEL.Name = "searchCustomerTEL";
            this.searchCustomerTEL.Size = new System.Drawing.Size(100, 27);
            this.searchCustomerTEL.TabIndex = 58;
            // 
            // searchCustomerName
            // 
            this.searchCustomerName.Location = new System.Drawing.Point(147, 92);
            this.searchCustomerName.Name = "searchCustomerName";
            this.searchCustomerName.Size = new System.Drawing.Size(180, 27);
            this.searchCustomerName.TabIndex = 57;
            // 
            // searchCustomerId
            // 
            this.searchCustomerId.Location = new System.Drawing.Point(147, 58);
            this.searchCustomerId.Name = "searchCustomerId";
            this.searchCustomerId.Size = new System.Drawing.Size(100, 27);
            this.searchCustomerId.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "所在地〒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "TEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "営業担当者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "顧客ID";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AND検索";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "OR検索";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "住所";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(830, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 100);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索オプション";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(989, 130);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 48;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clientList
            // 
            this.clientList.AllowUserToAddRows = false;
            this.clientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientList.Location = new System.Drawing.Point(12, 172);
            this.clientList.MultiSelect = false;
            this.clientList.Name = "clientList";
            this.clientList.RowTemplate.Height = 21;
            this.clientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientList.Size = new System.Drawing.Size(1240, 436);
            this.clientList.TabIndex = 47;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.selectButton.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectButton.Location = new System.Drawing.Point(1152, 615);
            this.selectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(100, 40);
            this.selectButton.TabIndex = 46;
            this.selectButton.Text = "選択";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "業者選択";
            // 
            // CustomerSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.searchSalesReq);
            this.Controls.Add(this.searchCustomerAddress);
            this.Controls.Add(this.searchCustomerPostalCode);
            this.Controls.Add(this.searchCustomerTEL);
            this.Controls.Add(this.searchCustomerName);
            this.Controls.Add(this.searchCustomerId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSelectForm";
            this.Text = "CustomerSelectForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.selectButton, 0);
            this.Controls.SetChildIndex(this.clientList, 0);
            this.Controls.SetChildIndex(this.searchButton, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.searchCustomerId, 0);
            this.Controls.SetChildIndex(this.searchCustomerName, 0);
            this.Controls.SetChildIndex(this.searchCustomerTEL, 0);
            this.Controls.SetChildIndex(this.searchCustomerPostalCode, 0);
            this.Controls.SetChildIndex(this.searchCustomerAddress, 0);
            this.Controls.SetChildIndex(this.searchSalesReq, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchSalesReq;
        private System.Windows.Forms.TextBox searchCustomerAddress;
        private System.Windows.Forms.TextBox searchCustomerPostalCode;
        private System.Windows.Forms.TextBox searchCustomerTEL;
        private System.Windows.Forms.TextBox searchCustomerName;
        private System.Windows.Forms.TextBox searchCustomerId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView clientList;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label label1;
    }
}
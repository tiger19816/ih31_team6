namespace sugukuru.Customer
{
    partial class CustomerListControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOption = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchCustomerId = new System.Windows.Forms.TextBox();
            this.searchCustomerName = new System.Windows.Forms.TextBox();
            this.searchCustomerTEL = new System.Windows.Forms.TextBox();
            this.searchCustomerPostalCode = new System.Windows.Forms.TextBox();
            this.searchCustomerAddress = new System.Windows.Forms.TextBox();
            this.searchSalesReq = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).BeginInit();
            this.searchOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "業者一覧";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(1040, 573);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 53);
            this.button2.TabIndex = 29;
            this.button2.Text = "詳細";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // clientList
            // 
            this.clientList.AllowUserToAddRows = false;
            this.clientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientList.Location = new System.Drawing.Point(48, 166);
            this.clientList.Name = "clientList";
            this.clientList.RowTemplate.Height = 21;
            this.clientList.Size = new System.Drawing.Size(1120, 400);
            this.clientList.TabIndex = 30;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(942, 129);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchOption
            // 
            this.searchOption.Controls.Add(this.radioButton2);
            this.searchOption.Controls.Add(this.radioButton1);
            this.searchOption.Location = new System.Drawing.Point(783, 49);
            this.searchOption.Name = "searchOption";
            this.searchOption.Size = new System.Drawing.Size(119, 100);
            this.searchOption.TabIndex = 32;
            this.searchOption.TabStop = false;
            this.searchOption.Text = "検索オプション";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "顧客ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "営業担当者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "TEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "所在地〒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "名称";
            // 
            // searchCustomerId
            // 
            this.searchCustomerId.Location = new System.Drawing.Point(100, 57);
            this.searchCustomerId.Name = "searchCustomerId";
            this.searchCustomerId.Size = new System.Drawing.Size(100, 27);
            this.searchCustomerId.TabIndex = 39;
            // 
            // searchCustomerName
            // 
            this.searchCustomerName.Location = new System.Drawing.Point(100, 91);
            this.searchCustomerName.Name = "searchCustomerName";
            this.searchCustomerName.Size = new System.Drawing.Size(180, 27);
            this.searchCustomerName.TabIndex = 40;
            // 
            // searchCustomerTEL
            // 
            this.searchCustomerTEL.Location = new System.Drawing.Point(100, 125);
            this.searchCustomerTEL.Name = "searchCustomerTEL";
            this.searchCustomerTEL.Size = new System.Drawing.Size(100, 27);
            this.searchCustomerTEL.TabIndex = 41;
            // 
            // searchCustomerPostalCode
            // 
            this.searchCustomerPostalCode.Location = new System.Drawing.Point(420, 57);
            this.searchCustomerPostalCode.Name = "searchCustomerPostalCode";
            this.searchCustomerPostalCode.Size = new System.Drawing.Size(100, 27);
            this.searchCustomerPostalCode.TabIndex = 42;
            // 
            // searchCustomerAddress
            // 
            this.searchCustomerAddress.Location = new System.Drawing.Point(420, 91);
            this.searchCustomerAddress.Name = "searchCustomerAddress";
            this.searchCustomerAddress.Size = new System.Drawing.Size(260, 27);
            this.searchCustomerAddress.TabIndex = 43;
            // 
            // searchSalesReq
            // 
            this.searchSalesReq.FormattingEnabled = true;
            this.searchSalesReq.Location = new System.Drawing.Point(420, 125);
            this.searchSalesReq.Name = "searchSalesReq";
            this.searchSalesReq.Size = new System.Drawing.Size(121, 24);
            this.searchSalesReq.TabIndex = 44;
            // 
            // CustomerListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchOption);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerListControl";
            ((System.ComponentModel.ISupportInitialize)(this.clientList)).EndInit();
            this.searchOption.ResumeLayout(false);
            this.searchOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView clientList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox searchOption;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchCustomerId;
        private System.Windows.Forms.TextBox searchCustomerName;
        private System.Windows.Forms.TextBox searchCustomerTEL;
        private System.Windows.Forms.TextBox searchCustomerPostalCode;
        private System.Windows.Forms.TextBox searchCustomerAddress;
        private System.Windows.Forms.ComboBox searchSalesReq;
    }
}

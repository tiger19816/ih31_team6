namespace sugukuru.Purchase
{
    partial class OrderSelectForm
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
            this.gvOrderList = new System.Windows.Forms.DataGridView();
            this.tbSearchCurYearType = new System.Windows.Forms.TextBox();
            this.tbSearchCurName = new System.Windows.Forms.TextBox();
            this.tbSearchCurType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSearchTypeAND = new System.Windows.Forms.RadioButton();
            this.rbSearchTypeOR = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbSearchCharge = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btSearchCustomer = new System.Windows.Forms.Button();
            this.tbSearchClientId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.cbDateStart = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMonthStart = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbYearStart = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDataEnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMonthEnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbYearEnd = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSearchProgress = new System.Windows.Forms.ComboBox();
            this.tbSearchOrderId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvOrderList
            // 
            this.gvOrderList.AllowUserToAddRows = false;
            this.gvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderList.Location = new System.Drawing.Point(12, 174);
            this.gvOrderList.MultiSelect = false;
            this.gvOrderList.Name = "gvOrderList";
            this.gvOrderList.RowHeadersVisible = false;
            this.gvOrderList.RowTemplate.Height = 21;
            this.gvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrderList.Size = new System.Drawing.Size(1240, 436);
            this.gvOrderList.TabIndex = 48;
            // 
            // tbSearchCurYearType
            // 
            this.tbSearchCurYearType.Location = new System.Drawing.Point(895, 48);
            this.tbSearchCurYearType.Name = "tbSearchCurYearType";
            this.tbSearchCurYearType.Size = new System.Drawing.Size(100, 27);
            this.tbSearchCurYearType.TabIndex = 122;
            // 
            // tbSearchCurName
            // 
            this.tbSearchCurName.Location = new System.Drawing.Point(594, 82);
            this.tbSearchCurName.Name = "tbSearchCurName";
            this.tbSearchCurName.Size = new System.Drawing.Size(171, 27);
            this.tbSearchCurName.TabIndex = 121;
            // 
            // tbSearchCurType
            // 
            this.tbSearchCurType.Location = new System.Drawing.Point(594, 48);
            this.tbSearchCurType.Name = "tbSearchCurType";
            this.tbSearchCurType.Size = new System.Drawing.Size(171, 27);
            this.tbSearchCurType.TabIndex = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSearchTypeAND);
            this.groupBox1.Controls.Add(this.rbSearchTypeOR);
            this.groupBox1.Location = new System.Drawing.Point(1043, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 81);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索オプション";
            // 
            // rbSearchTypeAND
            // 
            this.rbSearchTypeAND.AutoSize = true;
            this.rbSearchTypeAND.Location = new System.Drawing.Point(21, 56);
            this.rbSearchTypeAND.Name = "rbSearchTypeAND";
            this.rbSearchTypeAND.Size = new System.Drawing.Size(76, 20);
            this.rbSearchTypeAND.TabIndex = 1;
            this.rbSearchTypeAND.TabStop = true;
            this.rbSearchTypeAND.Text = "AND検索";
            this.rbSearchTypeAND.UseVisualStyleBackColor = true;
            // 
            // rbSearchTypeOR
            // 
            this.rbSearchTypeOR.AutoSize = true;
            this.rbSearchTypeOR.Checked = true;
            this.rbSearchTypeOR.Location = new System.Drawing.Point(21, 27);
            this.rbSearchTypeOR.Name = "rbSearchTypeOR";
            this.rbSearchTypeOR.Size = new System.Drawing.Size(67, 20);
            this.rbSearchTypeOR.TabIndex = 0;
            this.rbSearchTypeOR.TabStop = true;
            this.rbSearchTypeOR.Text = "OR検索";
            this.rbSearchTypeOR.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 119;
            this.label5.Text = "年式";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(514, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 118;
            this.label13.Text = "車名";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(514, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 117;
            this.label14.Text = "型式";
            // 
            // cbSearchCharge
            // 
            this.cbSearchCharge.FormattingEnabled = true;
            this.cbSearchCharge.Location = new System.Drawing.Point(895, 115);
            this.cbSearchCharge.Name = "cbSearchCharge";
            this.cbSearchCharge.Size = new System.Drawing.Size(121, 24);
            this.cbSearchCharge.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(815, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 115;
            this.label12.Text = "営業担当者";
            // 
            // btSearchCustomer
            // 
            this.btSearchCustomer.Location = new System.Drawing.Point(388, 82);
            this.btSearchCustomer.Name = "btSearchCustomer";
            this.btSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.btSearchCustomer.TabIndex = 114;
            this.btSearchCustomer.Text = "業者検索";
            this.btSearchCustomer.UseVisualStyleBackColor = true;
            this.btSearchCustomer.Click += new System.EventHandler(this.btSearchCustomer_Click);
            // 
            // tbSearchClientId
            // 
            this.tbSearchClientId.Location = new System.Drawing.Point(274, 82);
            this.tbSearchClientId.Name = "tbSearchClientId";
            this.tbSearchClientId.Size = new System.Drawing.Size(100, 27);
            this.tbSearchClientId.TabIndex = 113;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(42, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 111);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "受注種別";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(21, 79);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 20);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "売注文";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 20);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "買注文";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(21, 27);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "全て";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(480, 119);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 16);
            this.label16.TabIndex = 112;
            this.label16.Text = "日";
            // 
            // cbDateStart
            // 
            this.cbDateStart.FormattingEnabled = true;
            this.cbDateStart.Location = new System.Drawing.Point(432, 115);
            this.cbDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbDateStart.Name = "cbDateStart";
            this.cbDateStart.Size = new System.Drawing.Size(45, 24);
            this.cbDateStart.TabIndex = 111;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(409, 119);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 16);
            this.label17.TabIndex = 110;
            this.label17.Text = "月";
            // 
            // cbMonthStart
            // 
            this.cbMonthStart.FormattingEnabled = true;
            this.cbMonthStart.Location = new System.Drawing.Point(362, 115);
            this.cbMonthStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonthStart.Name = "cbMonthStart";
            this.cbMonthStart.Size = new System.Drawing.Size(44, 24);
            this.cbMonthStart.TabIndex = 109;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(339, 119);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 16);
            this.label18.TabIndex = 108;
            this.label18.Text = "年";
            // 
            // cbYearStart
            // 
            this.cbYearStart.FormattingEnabled = true;
            this.cbYearStart.Location = new System.Drawing.Point(274, 115);
            this.cbYearStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbYearStart.Name = "cbYearStart";
            this.cbYearStart.Size = new System.Drawing.Size(62, 24);
            this.cbYearStart.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(751, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "日";
            // 
            // cbDataEnd
            // 
            this.cbDataEnd.FormattingEnabled = true;
            this.cbDataEnd.Location = new System.Drawing.Point(703, 115);
            this.cbDataEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataEnd.Name = "cbDataEnd";
            this.cbDataEnd.Size = new System.Drawing.Size(45, 24);
            this.cbDataEnd.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 104;
            this.label9.Text = "月";
            // 
            // cbMonthEnd
            // 
            this.cbMonthEnd.FormattingEnabled = true;
            this.cbMonthEnd.Location = new System.Drawing.Point(633, 115);
            this.cbMonthEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonthEnd.Name = "cbMonthEnd";
            this.cbMonthEnd.Size = new System.Drawing.Size(44, 24);
            this.cbMonthEnd.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "年";
            // 
            // cbYearEnd
            // 
            this.cbYearEnd.FormattingEnabled = true;
            this.cbYearEnd.Location = new System.Drawing.Point(545, 115);
            this.cbYearEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbYearEnd.Name = "cbYearEnd";
            this.cbYearEnd.Size = new System.Drawing.Size(62, 24);
            this.cbYearEnd.TabIndex = 101;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 100;
            this.label11.Text = "～";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(194, 118);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 99;
            this.label15.Text = "受注日付";
            // 
            // cbSearchProgress
            // 
            this.cbSearchProgress.FormattingEnabled = true;
            this.cbSearchProgress.Location = new System.Drawing.Point(895, 82);
            this.cbSearchProgress.Name = "cbSearchProgress";
            this.cbSearchProgress.Size = new System.Drawing.Size(121, 24);
            this.cbSearchProgress.TabIndex = 98;
            // 
            // tbSearchOrderId
            // 
            this.tbSearchOrderId.Location = new System.Drawing.Point(274, 48);
            this.tbSearchOrderId.Name = "tbSearchOrderId";
            this.tbSearchOrderId.Size = new System.Drawing.Size(100, 27);
            this.tbSearchOrderId.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "顧客ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 95;
            this.label4.Text = "進捗状況";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "受注ID";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1087, 125);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 91;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "受注一覧";
            // 
            // btSelect
            // 
            this.btSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSelect.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSelect.Location = new System.Drawing.Point(1152, 615);
            this.btSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(100, 40);
            this.btSelect.TabIndex = 123;
            this.btSelect.Text = "選択";
            this.btSelect.UseVisualStyleBackColor = false;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // OrderSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.tbSearchCurYearType);
            this.Controls.Add(this.tbSearchCurName);
            this.Controls.Add(this.tbSearchCurType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbSearchCharge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btSearchCustomer);
            this.Controls.Add(this.tbSearchClientId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbDateStart);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbMonthStart);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbYearStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbDataEnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMonthEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbYearEnd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbSearchProgress);
            this.Controls.Add(this.tbSearchOrderId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvOrderList);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OrderSelectForm";
            this.Text = "OrderSelectForm";
            this.Controls.SetChildIndex(this.gvOrderList, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btSearch, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbSearchOrderId, 0);
            this.Controls.SetChildIndex(this.cbSearchProgress, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cbYearEnd, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cbMonthEnd, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cbDataEnd, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cbYearStart, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.cbMonthStart, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.cbDateStart, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.tbSearchClientId, 0);
            this.Controls.SetChildIndex(this.btSearchCustomer, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.cbSearchCharge, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tbSearchCurType, 0);
            this.Controls.SetChildIndex(this.tbSearchCurName, 0);
            this.Controls.SetChildIndex(this.tbSearchCurYearType, 0);
            this.Controls.SetChildIndex(this.btSelect, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrderList;
        private System.Windows.Forms.TextBox tbSearchCurYearType;
        private System.Windows.Forms.TextBox tbSearchCurName;
        private System.Windows.Forms.TextBox tbSearchCurType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSearchTypeAND;
        private System.Windows.Forms.RadioButton rbSearchTypeOR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbSearchCharge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btSearchCustomer;
        private System.Windows.Forms.TextBox tbSearchClientId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbDateStart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbMonthStart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbYearStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDataEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMonthEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbYearEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSearchProgress;
        private System.Windows.Forms.TextBox tbSearchOrderId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelect;
    }
}
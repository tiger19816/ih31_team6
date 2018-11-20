namespace sugukuru.Orders
{
    partial class OrderListControl
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
            this.gvOrderList = new System.Windows.Forms.DataGridView();
            this.btDetail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSearchTypeAND = new System.Windows.Forms.RadioButton();
            this.rbSearchTypeOR = new System.Windows.Forms.RadioButton();
            this.btSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSearchProgress = new System.Windows.Forms.ComboBox();
            this.tbSearchOrderId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDataEnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMonthEnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbYearEnd = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbDateStart = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMonthStart = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbYearStart = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.tbSearchCustomerId = new System.Windows.Forms.TextBox();
            this.cbSearchCharge = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSearchCurYearType = new System.Windows.Forms.TextBox();
            this.tbSearchCurName = new System.Windows.Forms.TextBox();
            this.tbSearchCurType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "受注一覧";
            // 
            // gvOrderList
            // 
            this.gvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderList.Location = new System.Drawing.Point(20, 157);
            this.gvOrderList.Name = "gvOrderList";
            this.gvOrderList.RowTemplate.Height = 21;
            this.gvOrderList.Size = new System.Drawing.Size(1120, 409);
            this.gvOrderList.TabIndex = 32;
            // 
            // btDetail
            // 
            this.btDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDetail.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDetail.Location = new System.Drawing.Point(1040, 573);
            this.btDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(117, 53);
            this.btDetail.TabIndex = 31;
            this.btDetail.Text = "詳細";
            this.btDetail.UseVisualStyleBackColor = false;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSearchTypeAND);
            this.groupBox1.Controls.Add(this.rbSearchTypeOR);
            this.groupBox1.Location = new System.Drawing.Point(1021, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 81);
            this.groupBox1.TabIndex = 34;
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
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1065, 128);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 33;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "受注ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "進捗状況";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "顧客ID";
            // 
            // cbSearchProgress
            // 
            this.cbSearchProgress.FormattingEnabled = true;
            this.cbSearchProgress.Location = new System.Drawing.Point(873, 85);
            this.cbSearchProgress.Name = "cbSearchProgress";
            this.cbSearchProgress.Size = new System.Drawing.Size(121, 24);
            this.cbSearchProgress.TabIndex = 56;
            // 
            // tbSearchOrderId
            // 
            this.tbSearchOrderId.Location = new System.Drawing.Point(252, 51);
            this.tbSearchOrderId.Name = "tbSearchOrderId";
            this.tbSearchOrderId.Size = new System.Drawing.Size(100, 27);
            this.tbSearchOrderId.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "日";
            // 
            // cbDataEnd
            // 
            this.cbDataEnd.FormattingEnabled = true;
            this.cbDataEnd.Location = new System.Drawing.Point(681, 118);
            this.cbDataEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataEnd.Name = "cbDataEnd";
            this.cbDataEnd.Size = new System.Drawing.Size(45, 24);
            this.cbDataEnd.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(658, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "月";
            // 
            // cbMonthEnd
            // 
            this.cbMonthEnd.FormattingEnabled = true;
            this.cbMonthEnd.Location = new System.Drawing.Point(611, 118);
            this.cbMonthEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonthEnd.Name = "cbMonthEnd";
            this.cbMonthEnd.Size = new System.Drawing.Size(44, 24);
            this.cbMonthEnd.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "年";
            // 
            // cbYearEnd
            // 
            this.cbYearEnd.FormattingEnabled = true;
            this.cbYearEnd.Location = new System.Drawing.Point(523, 118);
            this.cbYearEnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbYearEnd.Name = "cbYearEnd";
            this.cbYearEnd.Size = new System.Drawing.Size(62, 24);
            this.cbYearEnd.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "～";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(172, 121);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 59;
            this.label15.Text = "受注日付";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(458, 122);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 16);
            this.label16.TabIndex = 78;
            this.label16.Text = "日";
            // 
            // cbDateStart
            // 
            this.cbDateStart.FormattingEnabled = true;
            this.cbDateStart.Location = new System.Drawing.Point(410, 118);
            this.cbDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbDateStart.Name = "cbDateStart";
            this.cbDateStart.Size = new System.Drawing.Size(45, 24);
            this.cbDateStart.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(387, 122);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 16);
            this.label17.TabIndex = 76;
            this.label17.Text = "月";
            // 
            // cbMonthStart
            // 
            this.cbMonthStart.FormattingEnabled = true;
            this.cbMonthStart.Location = new System.Drawing.Point(340, 118);
            this.cbMonthStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonthStart.Name = "cbMonthStart";
            this.cbMonthStart.Size = new System.Drawing.Size(44, 24);
            this.cbMonthStart.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(317, 122);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 16);
            this.label18.TabIndex = 74;
            this.label18.Text = "年";
            // 
            // cbYearStart
            // 
            this.cbYearStart.FormattingEnabled = true;
            this.cbYearStart.Location = new System.Drawing.Point(252, 118);
            this.cbYearStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbYearStart.Name = "cbYearStart";
            this.cbYearStart.Size = new System.Drawing.Size(62, 24);
            this.cbYearStart.TabIndex = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(20, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 111);
            this.groupBox2.TabIndex = 35;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 80;
            this.button4.Text = "業者検索";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tbSearchCustomerId
            // 
            this.tbSearchCustomerId.Location = new System.Drawing.Point(252, 85);
            this.tbSearchCustomerId.Name = "tbSearchCustomerId";
            this.tbSearchCustomerId.Size = new System.Drawing.Size(100, 27);
            this.tbSearchCustomerId.TabIndex = 79;
            // 
            // cbSearchCharge
            // 
            this.cbSearchCharge.FormattingEnabled = true;
            this.cbSearchCharge.Location = new System.Drawing.Point(873, 118);
            this.cbSearchCharge.Name = "cbSearchCharge";
            this.cbSearchCharge.Size = new System.Drawing.Size(121, 24);
            this.cbSearchCharge.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(793, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "営業担当者";
            // 
            // tbSearchCurYearType
            // 
            this.tbSearchCurYearType.Location = new System.Drawing.Point(873, 51);
            this.tbSearchCurYearType.Name = "tbSearchCurYearType";
            this.tbSearchCurYearType.Size = new System.Drawing.Size(100, 27);
            this.tbSearchCurYearType.TabIndex = 89;
            // 
            // tbSearchCurName
            // 
            this.tbSearchCurName.Location = new System.Drawing.Point(572, 85);
            this.tbSearchCurName.Name = "tbSearchCurName";
            this.tbSearchCurName.Size = new System.Drawing.Size(171, 27);
            this.tbSearchCurName.TabIndex = 88;
            // 
            // tbSearchCurType
            // 
            this.tbSearchCurType.Location = new System.Drawing.Point(572, 51);
            this.tbSearchCurType.Name = "tbSearchCurType";
            this.tbSearchCurType.Size = new System.Drawing.Size(171, 27);
            this.tbSearchCurType.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "年式";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 85;
            this.label13.Text = "車名";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(492, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 84;
            this.label14.Text = "型式";
            // 
            // OrderListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSearchCurYearType);
            this.Controls.Add(this.tbSearchCurName);
            this.Controls.Add(this.tbSearchCurType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbSearchCharge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbSearchCustomerId);
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
            this.Controls.Add(this.gvOrderList);
            this.Controls.Add(this.btDetail);
            this.Controls.Add(this.label1);
            this.Name = "OrderListControl";
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvOrderList;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSearchTypeAND;
        private System.Windows.Forms.RadioButton rbSearchTypeOR;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSearchProgress;
        private System.Windows.Forms.TextBox tbSearchOrderId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDataEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMonthEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbYearEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbDateStart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbMonthStart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbYearStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbSearchCustomerId;
        private System.Windows.Forms.ComboBox cbSearchCharge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSearchCurYearType;
        private System.Windows.Forms.TextBox tbSearchCurName;
        private System.Windows.Forms.TextBox tbSearchCurType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

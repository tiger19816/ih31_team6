namespace sugukuru.ClaimCollection
{
    partial class IndividualSelectForm
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
            this.dataList = new System.Windows.Forms.DataGridView();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_year_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claim_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.retrievalButton = new System.Windows.Forms.Button();
            this.radioButtonOrderTypeAll = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderTypeBuy = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderTypeSell = new System.Windows.Forms.RadioButton();
            this.searchOrderType = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.whiler = new System.Windows.Forms.Label();
            this.overDay = new System.Windows.Forms.Label();
            this.overMonth = new System.Windows.Forms.Label();
            this.overYear = new System.Windows.Forms.Label();
            this.comboBoxOverDay = new System.Windows.Forms.ComboBox();
            this.comboBoxOverMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxOverYear = new System.Windows.Forms.ComboBox();
            this.underDay = new System.Windows.Forms.Label();
            this.underMonth = new System.Windows.Forms.Label();
            this.underYear = new System.Windows.Forms.Label();
            this.comboBoxUnderDay = new System.Windows.Forms.ComboBox();
            this.comboBoxUnderMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxUnderYear = new System.Windows.Forms.ComboBox();
            this.searchDate = new System.Windows.Forms.Label();
            this.searchTextOrderNo = new System.Windows.Forms.TextBox();
            this.searchOrderNo = new System.Windows.Forms.Label();
            this.searchTextClient = new System.Windows.Forms.TextBox();
            this.searchClient = new System.Windows.Forms.Label();
            this.searchEmployeeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataList
            // 
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_no,
            this.employee_name,
            this.client_name,
            this.car_type,
            this.car_year_type,
            this.order_name,
            this.claim_amount,
            this.order_date,
            this.order_type,
            this.select});
            this.dataList.Location = new System.Drawing.Point(20, 200);
            this.dataList.Name = "dataList";
            this.dataList.RowTemplate.Height = 21;
            this.dataList.Size = new System.Drawing.Size(1224, 344);
            this.dataList.TabIndex = 6;
            // 
            // order_no
            // 
            this.order_no.HeaderText = "受注番号";
            this.order_no.Name = "order_no";
            // 
            // employee_name
            // 
            this.employee_name.HeaderText = "担当者名";
            this.employee_name.Name = "employee_name";
            // 
            // client_name
            // 
            this.client_name.HeaderText = "顧客名";
            this.client_name.Name = "client_name";
            // 
            // car_type
            // 
            this.car_type.HeaderText = "型式";
            this.car_type.Name = "car_type";
            // 
            // car_year_type
            // 
            this.car_year_type.HeaderText = "年式";
            this.car_year_type.Name = "car_year_type";
            // 
            // order_name
            // 
            this.order_name.HeaderText = "車名";
            this.order_name.Name = "order_name";
            // 
            // claim_amount
            // 
            this.claim_amount.HeaderText = "請求額";
            this.claim_amount.Name = "claim_amount";
            // 
            // order_date
            // 
            this.order_date.HeaderText = "受注日付";
            this.order_date.Name = "order_date";
            // 
            // order_type
            // 
            this.order_type.HeaderText = "受注種別";
            this.order_type.Name = "order_type";
            // 
            // select
            // 
            this.select.HeaderText = "選択";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addButton.Location = new System.Drawing.Point(1152, 616);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // retrievalButton
            // 
            this.retrievalButton.Location = new System.Drawing.Point(965, 111);
            this.retrievalButton.Name = "retrievalButton";
            this.retrievalButton.Size = new System.Drawing.Size(100, 40);
            this.retrievalButton.TabIndex = 13;
            this.retrievalButton.Text = "検索";
            this.retrievalButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrderTypeAll
            // 
            this.radioButtonOrderTypeAll.AutoSize = true;
            this.radioButtonOrderTypeAll.Location = new System.Drawing.Point(662, 45);
            this.radioButtonOrderTypeAll.Name = "radioButtonOrderTypeAll";
            this.radioButtonOrderTypeAll.Size = new System.Drawing.Size(50, 20);
            this.radioButtonOrderTypeAll.TabIndex = 97;
            this.radioButtonOrderTypeAll.TabStop = true;
            this.radioButtonOrderTypeAll.Text = "全て";
            this.radioButtonOrderTypeAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrderTypeBuy
            // 
            this.radioButtonOrderTypeBuy.AutoSize = true;
            this.radioButtonOrderTypeBuy.Location = new System.Drawing.Point(789, 45);
            this.radioButtonOrderTypeBuy.Name = "radioButtonOrderTypeBuy";
            this.radioButtonOrderTypeBuy.Size = new System.Drawing.Size(62, 20);
            this.radioButtonOrderTypeBuy.TabIndex = 96;
            this.radioButtonOrderTypeBuy.TabStop = true;
            this.radioButtonOrderTypeBuy.Text = "買注文";
            this.radioButtonOrderTypeBuy.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrderTypeSell
            // 
            this.radioButtonOrderTypeSell.AutoSize = true;
            this.radioButtonOrderTypeSell.Location = new System.Drawing.Point(720, 45);
            this.radioButtonOrderTypeSell.Name = "radioButtonOrderTypeSell";
            this.radioButtonOrderTypeSell.Size = new System.Drawing.Size(62, 20);
            this.radioButtonOrderTypeSell.TabIndex = 95;
            this.radioButtonOrderTypeSell.TabStop = true;
            this.radioButtonOrderTypeSell.Text = "売注文";
            this.radioButtonOrderTypeSell.UseVisualStyleBackColor = true;
            // 
            // searchOrderType
            // 
            this.searchOrderType.AutoSize = true;
            this.searchOrderType.Location = new System.Drawing.Point(597, 47);
            this.searchOrderType.Name = "searchOrderType";
            this.searchOrderType.Size = new System.Drawing.Size(56, 16);
            this.searchOrderType.TabIndex = 94;
            this.searchOrderType.Text = "受注種別";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(338, 82);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(149, 24);
            this.comboBox7.TabIndex = 93;
            // 
            // whiler
            // 
            this.whiler.AutoSize = true;
            this.whiler.Location = new System.Drawing.Point(625, 123);
            this.whiler.Name = "whiler";
            this.whiler.Size = new System.Drawing.Size(17, 16);
            this.whiler.TabIndex = 92;
            this.whiler.Text = "~";
            // 
            // overDay
            // 
            this.overDay.AutoSize = true;
            this.overDay.Location = new System.Drawing.Point(914, 123);
            this.overDay.Name = "overDay";
            this.overDay.Size = new System.Drawing.Size(20, 16);
            this.overDay.TabIndex = 91;
            this.overDay.Text = "日";
            // 
            // overMonth
            // 
            this.overMonth.AutoSize = true;
            this.overMonth.Location = new System.Drawing.Point(838, 123);
            this.overMonth.Name = "overMonth";
            this.overMonth.Size = new System.Drawing.Size(20, 16);
            this.overMonth.TabIndex = 90;
            this.overMonth.Text = "月";
            // 
            // overYear
            // 
            this.overYear.AutoSize = true;
            this.overYear.Location = new System.Drawing.Point(762, 123);
            this.overYear.Name = "overYear";
            this.overYear.Size = new System.Drawing.Size(20, 16);
            this.overYear.TabIndex = 89;
            this.overYear.Text = "年";
            // 
            // comboBoxOverDay
            // 
            this.comboBoxOverDay.FormattingEnabled = true;
            this.comboBoxOverDay.Location = new System.Drawing.Point(864, 120);
            this.comboBoxOverDay.Name = "comboBoxOverDay";
            this.comboBoxOverDay.Size = new System.Drawing.Size(44, 24);
            this.comboBoxOverDay.TabIndex = 88;
            // 
            // comboBoxOverMonth
            // 
            this.comboBoxOverMonth.FormattingEnabled = true;
            this.comboBoxOverMonth.Location = new System.Drawing.Point(789, 120);
            this.comboBoxOverMonth.Name = "comboBoxOverMonth";
            this.comboBoxOverMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxOverMonth.TabIndex = 87;
            // 
            // comboBoxOverYear
            // 
            this.comboBoxOverYear.FormattingEnabled = true;
            this.comboBoxOverYear.Location = new System.Drawing.Point(662, 120);
            this.comboBoxOverYear.Name = "comboBoxOverYear";
            this.comboBoxOverYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxOverYear.TabIndex = 86;
            // 
            // underDay
            // 
            this.underDay.AutoSize = true;
            this.underDay.Location = new System.Drawing.Point(590, 123);
            this.underDay.Name = "underDay";
            this.underDay.Size = new System.Drawing.Size(20, 16);
            this.underDay.TabIndex = 85;
            this.underDay.Text = "日";
            // 
            // underMonth
            // 
            this.underMonth.AutoSize = true;
            this.underMonth.Location = new System.Drawing.Point(514, 123);
            this.underMonth.Name = "underMonth";
            this.underMonth.Size = new System.Drawing.Size(20, 16);
            this.underMonth.TabIndex = 84;
            this.underMonth.Text = "月";
            // 
            // underYear
            // 
            this.underYear.AutoSize = true;
            this.underYear.Location = new System.Drawing.Point(438, 123);
            this.underYear.Name = "underYear";
            this.underYear.Size = new System.Drawing.Size(20, 16);
            this.underYear.TabIndex = 83;
            this.underYear.Text = "年";
            // 
            // comboBoxUnderDay
            // 
            this.comboBoxUnderDay.FormattingEnabled = true;
            this.comboBoxUnderDay.Location = new System.Drawing.Point(540, 120);
            this.comboBoxUnderDay.Name = "comboBoxUnderDay";
            this.comboBoxUnderDay.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderDay.TabIndex = 82;
            // 
            // comboBoxUnderMonth
            // 
            this.comboBoxUnderMonth.FormattingEnabled = true;
            this.comboBoxUnderMonth.Location = new System.Drawing.Point(465, 120);
            this.comboBoxUnderMonth.Name = "comboBoxUnderMonth";
            this.comboBoxUnderMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderMonth.TabIndex = 81;
            // 
            // comboBoxUnderYear
            // 
            this.comboBoxUnderYear.FormattingEnabled = true;
            this.comboBoxUnderYear.Location = new System.Drawing.Point(338, 120);
            this.comboBoxUnderYear.Name = "comboBoxUnderYear";
            this.comboBoxUnderYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxUnderYear.TabIndex = 80;
            // 
            // searchDate
            // 
            this.searchDate.AutoSize = true;
            this.searchDate.Location = new System.Drawing.Point(264, 123);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(56, 16);
            this.searchDate.TabIndex = 79;
            this.searchDate.Text = "受注期間";
            // 
            // searchTextOrderNo
            // 
            this.searchTextOrderNo.Location = new System.Drawing.Point(338, 44);
            this.searchTextOrderNo.Name = "searchTextOrderNo";
            this.searchTextOrderNo.Size = new System.Drawing.Size(193, 27);
            this.searchTextOrderNo.TabIndex = 78;
            // 
            // searchOrderNo
            // 
            this.searchOrderNo.AutoSize = true;
            this.searchOrderNo.Location = new System.Drawing.Point(264, 47);
            this.searchOrderNo.Name = "searchOrderNo";
            this.searchOrderNo.Size = new System.Drawing.Size(56, 16);
            this.searchOrderNo.TabIndex = 77;
            this.searchOrderNo.Text = "受注番号";
            // 
            // searchTextClient
            // 
            this.searchTextClient.Location = new System.Drawing.Point(662, 82);
            this.searchTextClient.Name = "searchTextClient";
            this.searchTextClient.Size = new System.Drawing.Size(182, 27);
            this.searchTextClient.TabIndex = 76;
            // 
            // searchClient
            // 
            this.searchClient.AutoSize = true;
            this.searchClient.Location = new System.Drawing.Point(597, 85);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(45, 16);
            this.searchClient.TabIndex = 75;
            this.searchClient.Text = "顧客ID";
            // 
            // searchEmployeeName
            // 
            this.searchEmployeeName.AutoSize = true;
            this.searchEmployeeName.Location = new System.Drawing.Point(252, 85);
            this.searchEmployeeName.Name = "searchEmployeeName";
            this.searchEmployeeName.Size = new System.Drawing.Size(68, 16);
            this.searchEmployeeName.TabIndex = 74;
            this.searchEmployeeName.Text = "営業担当者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 98;
            this.label1.Text = "個別　追加選択";
            // 
            // IndividualSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonOrderTypeAll);
            this.Controls.Add(this.radioButtonOrderTypeBuy);
            this.Controls.Add(this.radioButtonOrderTypeSell);
            this.Controls.Add(this.searchOrderType);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.whiler);
            this.Controls.Add(this.overDay);
            this.Controls.Add(this.overMonth);
            this.Controls.Add(this.overYear);
            this.Controls.Add(this.comboBoxOverDay);
            this.Controls.Add(this.comboBoxOverMonth);
            this.Controls.Add(this.comboBoxOverYear);
            this.Controls.Add(this.underDay);
            this.Controls.Add(this.underMonth);
            this.Controls.Add(this.underYear);
            this.Controls.Add(this.comboBoxUnderDay);
            this.Controls.Add(this.comboBoxUnderMonth);
            this.Controls.Add(this.comboBoxUnderYear);
            this.Controls.Add(this.searchDate);
            this.Controls.Add(this.searchTextOrderNo);
            this.Controls.Add(this.searchOrderNo);
            this.Controls.Add(this.searchTextClient);
            this.Controls.Add(this.searchClient);
            this.Controls.Add(this.searchEmployeeName);
            this.Controls.Add(this.retrievalButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataList);
            this.Name = "IndividualSelectForm";
            this.Text = "IndividualClaimSelectForm";
            this.Controls.SetChildIndex(this.dataList, 0);
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.retrievalButton, 0);
            this.Controls.SetChildIndex(this.searchEmployeeName, 0);
            this.Controls.SetChildIndex(this.searchClient, 0);
            this.Controls.SetChildIndex(this.searchTextClient, 0);
            this.Controls.SetChildIndex(this.searchOrderNo, 0);
            this.Controls.SetChildIndex(this.searchTextOrderNo, 0);
            this.Controls.SetChildIndex(this.searchDate, 0);
            this.Controls.SetChildIndex(this.comboBoxUnderYear, 0);
            this.Controls.SetChildIndex(this.comboBoxUnderMonth, 0);
            this.Controls.SetChildIndex(this.comboBoxUnderDay, 0);
            this.Controls.SetChildIndex(this.underYear, 0);
            this.Controls.SetChildIndex(this.underMonth, 0);
            this.Controls.SetChildIndex(this.underDay, 0);
            this.Controls.SetChildIndex(this.comboBoxOverYear, 0);
            this.Controls.SetChildIndex(this.comboBoxOverMonth, 0);
            this.Controls.SetChildIndex(this.comboBoxOverDay, 0);
            this.Controls.SetChildIndex(this.overYear, 0);
            this.Controls.SetChildIndex(this.overMonth, 0);
            this.Controls.SetChildIndex(this.overDay, 0);
            this.Controls.SetChildIndex(this.whiler, 0);
            this.Controls.SetChildIndex(this.comboBox7, 0);
            this.Controls.SetChildIndex(this.searchOrderType, 0);
            this.Controls.SetChildIndex(this.radioButtonOrderTypeSell, 0);
            this.Controls.SetChildIndex(this.radioButtonOrderTypeBuy, 0);
            this.Controls.SetChildIndex(this.radioButtonOrderTypeAll, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button retrievalButton;
        private System.Windows.Forms.RadioButton radioButtonOrderTypeAll;
        private System.Windows.Forms.RadioButton radioButtonOrderTypeBuy;
        private System.Windows.Forms.RadioButton radioButtonOrderTypeSell;
        private System.Windows.Forms.Label searchOrderType;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label whiler;
        private System.Windows.Forms.Label overDay;
        private System.Windows.Forms.Label overMonth;
        private System.Windows.Forms.Label overYear;
        private System.Windows.Forms.ComboBox comboBoxOverDay;
        private System.Windows.Forms.ComboBox comboBoxOverMonth;
        private System.Windows.Forms.ComboBox comboBoxOverYear;
        private System.Windows.Forms.Label underDay;
        private System.Windows.Forms.Label underMonth;
        private System.Windows.Forms.Label underYear;
        private System.Windows.Forms.ComboBox comboBoxUnderDay;
        private System.Windows.Forms.ComboBox comboBoxUnderMonth;
        private System.Windows.Forms.ComboBox comboBoxUnderYear;
        private System.Windows.Forms.Label searchDate;
        private System.Windows.Forms.TextBox searchTextOrderNo;
        private System.Windows.Forms.Label searchOrderNo;
        private System.Windows.Forms.TextBox searchTextClient;
        private System.Windows.Forms.Label searchClient;
        private System.Windows.Forms.Label searchEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_year_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn claim_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.Label label1;

    }
}
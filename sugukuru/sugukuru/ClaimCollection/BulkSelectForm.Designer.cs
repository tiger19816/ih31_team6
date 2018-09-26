namespace sugukuru.ClaimCollection
{
    partial class BulkSelectForm
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
            this.order_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.retrievalButton = new System.Windows.Forms.Button();
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
            this.radioButtonOrderTypeSell = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderTypeBuy = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderTypeAll = new System.Windows.Forms.RadioButton();
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
            this.order_name,
            this.order_date,
            this.order_type,
            this.select});
            this.dataList.Location = new System.Drawing.Point(20, 200);
            this.dataList.Name = "dataList";
            this.dataList.RowTemplate.Height = 21;
            this.dataList.Size = new System.Drawing.Size(1224, 344);
            this.dataList.TabIndex = 5;
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
            // order_name
            // 
            this.order_name.HeaderText = "車名";
            this.order_name.Name = "order_name";
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
            this.addButton.TabIndex = 6;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // retrievalButton
            // 
            this.retrievalButton.Location = new System.Drawing.Point(966, 109);
            this.retrievalButton.Name = "retrievalButton";
            this.retrievalButton.Size = new System.Drawing.Size(100, 40);
            this.retrievalButton.TabIndex = 22;
            this.retrievalButton.Text = "検索";
            this.retrievalButton.UseVisualStyleBackColor = true;
            // 
            // searchOrderType
            // 
            this.searchOrderType.AutoSize = true;
            this.searchOrderType.Location = new System.Drawing.Point(574, 45);
            this.searchOrderType.Name = "searchOrderType";
            this.searchOrderType.Size = new System.Drawing.Size(56, 16);
            this.searchOrderType.TabIndex = 70;
            this.searchOrderType.Text = "受注種別";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(315, 80);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(149, 24);
            this.comboBox7.TabIndex = 69;
            // 
            // whiler
            // 
            this.whiler.AutoSize = true;
            this.whiler.Location = new System.Drawing.Point(602, 121);
            this.whiler.Name = "whiler";
            this.whiler.Size = new System.Drawing.Size(17, 16);
            this.whiler.TabIndex = 68;
            this.whiler.Text = "~";
            // 
            // overDay
            // 
            this.overDay.AutoSize = true;
            this.overDay.Location = new System.Drawing.Point(891, 121);
            this.overDay.Name = "overDay";
            this.overDay.Size = new System.Drawing.Size(20, 16);
            this.overDay.TabIndex = 67;
            this.overDay.Text = "日";
            // 
            // overMonth
            // 
            this.overMonth.AutoSize = true;
            this.overMonth.Location = new System.Drawing.Point(815, 121);
            this.overMonth.Name = "overMonth";
            this.overMonth.Size = new System.Drawing.Size(20, 16);
            this.overMonth.TabIndex = 66;
            this.overMonth.Text = "月";
            // 
            // overYear
            // 
            this.overYear.AutoSize = true;
            this.overYear.Location = new System.Drawing.Point(739, 121);
            this.overYear.Name = "overYear";
            this.overYear.Size = new System.Drawing.Size(20, 16);
            this.overYear.TabIndex = 65;
            this.overYear.Text = "年";
            // 
            // comboBoxOverDay
            // 
            this.comboBoxOverDay.FormattingEnabled = true;
            this.comboBoxOverDay.Location = new System.Drawing.Point(841, 118);
            this.comboBoxOverDay.Name = "comboBoxOverDay";
            this.comboBoxOverDay.Size = new System.Drawing.Size(44, 24);
            this.comboBoxOverDay.TabIndex = 64;
            // 
            // comboBoxOverMonth
            // 
            this.comboBoxOverMonth.FormattingEnabled = true;
            this.comboBoxOverMonth.Location = new System.Drawing.Point(766, 118);
            this.comboBoxOverMonth.Name = "comboBoxOverMonth";
            this.comboBoxOverMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxOverMonth.TabIndex = 63;
            // 
            // comboBoxOverYear
            // 
            this.comboBoxOverYear.FormattingEnabled = true;
            this.comboBoxOverYear.Location = new System.Drawing.Point(639, 118);
            this.comboBoxOverYear.Name = "comboBoxOverYear";
            this.comboBoxOverYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxOverYear.TabIndex = 62;
            // 
            // underDay
            // 
            this.underDay.AutoSize = true;
            this.underDay.Location = new System.Drawing.Point(567, 121);
            this.underDay.Name = "underDay";
            this.underDay.Size = new System.Drawing.Size(20, 16);
            this.underDay.TabIndex = 61;
            this.underDay.Text = "日";
            // 
            // underMonth
            // 
            this.underMonth.AutoSize = true;
            this.underMonth.Location = new System.Drawing.Point(491, 121);
            this.underMonth.Name = "underMonth";
            this.underMonth.Size = new System.Drawing.Size(20, 16);
            this.underMonth.TabIndex = 60;
            this.underMonth.Text = "月";
            // 
            // underYear
            // 
            this.underYear.AutoSize = true;
            this.underYear.Location = new System.Drawing.Point(415, 121);
            this.underYear.Name = "underYear";
            this.underYear.Size = new System.Drawing.Size(20, 16);
            this.underYear.TabIndex = 59;
            this.underYear.Text = "年";
            // 
            // comboBoxUnderDay
            // 
            this.comboBoxUnderDay.FormattingEnabled = true;
            this.comboBoxUnderDay.Location = new System.Drawing.Point(517, 118);
            this.comboBoxUnderDay.Name = "comboBoxUnderDay";
            this.comboBoxUnderDay.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderDay.TabIndex = 58;
            // 
            // comboBoxUnderMonth
            // 
            this.comboBoxUnderMonth.FormattingEnabled = true;
            this.comboBoxUnderMonth.Location = new System.Drawing.Point(442, 118);
            this.comboBoxUnderMonth.Name = "comboBoxUnderMonth";
            this.comboBoxUnderMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderMonth.TabIndex = 57;
            // 
            // comboBoxUnderYear
            // 
            this.comboBoxUnderYear.FormattingEnabled = true;
            this.comboBoxUnderYear.Location = new System.Drawing.Point(315, 118);
            this.comboBoxUnderYear.Name = "comboBoxUnderYear";
            this.comboBoxUnderYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxUnderYear.TabIndex = 56;
            // 
            // searchDate
            // 
            this.searchDate.AutoSize = true;
            this.searchDate.Location = new System.Drawing.Point(241, 121);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(56, 16);
            this.searchDate.TabIndex = 55;
            this.searchDate.Text = "受注期間";
            // 
            // searchTextOrderNo
            // 
            this.searchTextOrderNo.Location = new System.Drawing.Point(315, 42);
            this.searchTextOrderNo.Name = "searchTextOrderNo";
            this.searchTextOrderNo.Size = new System.Drawing.Size(193, 27);
            this.searchTextOrderNo.TabIndex = 54;
            // 
            // searchOrderNo
            // 
            this.searchOrderNo.AutoSize = true;
            this.searchOrderNo.Location = new System.Drawing.Point(241, 45);
            this.searchOrderNo.Name = "searchOrderNo";
            this.searchOrderNo.Size = new System.Drawing.Size(56, 16);
            this.searchOrderNo.TabIndex = 53;
            this.searchOrderNo.Text = "受注番号";
            // 
            // searchTextClient
            // 
            this.searchTextClient.Location = new System.Drawing.Point(639, 80);
            this.searchTextClient.Name = "searchTextClient";
            this.searchTextClient.Size = new System.Drawing.Size(182, 27);
            this.searchTextClient.TabIndex = 52;
            // 
            // searchClient
            // 
            this.searchClient.AutoSize = true;
            this.searchClient.Location = new System.Drawing.Point(574, 83);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(45, 16);
            this.searchClient.TabIndex = 51;
            this.searchClient.Text = "顧客ID";
            // 
            // searchEmployeeName
            // 
            this.searchEmployeeName.AutoSize = true;
            this.searchEmployeeName.Location = new System.Drawing.Point(229, 83);
            this.searchEmployeeName.Name = "searchEmployeeName";
            this.searchEmployeeName.Size = new System.Drawing.Size(68, 16);
            this.searchEmployeeName.TabIndex = 50;
            this.searchEmployeeName.Text = "営業担当者";
            // 
            // radioButtonOrderTypeSell
            // 
            this.radioButtonOrderTypeSell.AutoSize = true;
            this.radioButtonOrderTypeSell.Location = new System.Drawing.Point(697, 43);
            this.radioButtonOrderTypeSell.Name = "radioButtonOrderTypeSell";
            this.radioButtonOrderTypeSell.Size = new System.Drawing.Size(62, 20);
            this.radioButtonOrderTypeSell.TabIndex = 71;
            this.radioButtonOrderTypeSell.TabStop = true;
            this.radioButtonOrderTypeSell.Text = "売注文";
            this.radioButtonOrderTypeSell.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrderTypeBuy
            // 
            this.radioButtonOrderTypeBuy.AutoSize = true;
            this.radioButtonOrderTypeBuy.Location = new System.Drawing.Point(766, 43);
            this.radioButtonOrderTypeBuy.Name = "radioButtonOrderTypeBuy";
            this.radioButtonOrderTypeBuy.Size = new System.Drawing.Size(62, 20);
            this.radioButtonOrderTypeBuy.TabIndex = 72;
            this.radioButtonOrderTypeBuy.TabStop = true;
            this.radioButtonOrderTypeBuy.Text = "買注文";
            this.radioButtonOrderTypeBuy.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrderTypeAll
            // 
            this.radioButtonOrderTypeAll.AutoSize = true;
            this.radioButtonOrderTypeAll.Location = new System.Drawing.Point(639, 43);
            this.radioButtonOrderTypeAll.Name = "radioButtonOrderTypeAll";
            this.radioButtonOrderTypeAll.Size = new System.Drawing.Size(50, 20);
            this.radioButtonOrderTypeAll.TabIndex = 73;
            this.radioButtonOrderTypeAll.TabStop = true;
            this.radioButtonOrderTypeAll.Text = "全て";
            this.radioButtonOrderTypeAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "一括　追加選択";
            // 
            // BulkSelectForm
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
            this.Name = "BulkSelectForm";
            this.Text = "BulkClaimSelectForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.Button retrievalButton;
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
        private System.Windows.Forms.RadioButton radioButtonOrderTypeSell;
        private System.Windows.Forms.RadioButton radioButtonOrderTypeBuy;
        private System.Windows.Forms.RadioButton radioButtonOrderTypeAll;
        private System.Windows.Forms.Label label1;
    }
}
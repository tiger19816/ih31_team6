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
            this.searchTextOrderDate = new System.Windows.Forms.TextBox();
            this.searchTextClientName = new System.Windows.Forms.TextBox();
            this.searchTextCarName = new System.Windows.Forms.TextBox();
            this.searchTextEmployeeName = new System.Windows.Forms.TextBox();
            this.retrievalButton = new System.Windows.Forms.Button();
            this.searchOrderDate = new System.Windows.Forms.Label();
            this.searchCarName = new System.Windows.Forms.Label();
            this.searchClientName = new System.Windows.Forms.Label();
            this.searchEmployeeName = new System.Windows.Forms.Label();
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
            // searchTextOrderDate
            // 
            this.searchTextOrderDate.Location = new System.Drawing.Point(525, 117);
            this.searchTextOrderDate.Name = "searchTextOrderDate";
            this.searchTextOrderDate.Size = new System.Drawing.Size(281, 27);
            this.searchTextOrderDate.TabIndex = 26;
            // 
            // searchTextClientName
            // 
            this.searchTextClientName.Location = new System.Drawing.Point(525, 57);
            this.searchTextClientName.Name = "searchTextClientName";
            this.searchTextClientName.Size = new System.Drawing.Size(281, 27);
            this.searchTextClientName.TabIndex = 25;
            // 
            // searchTextCarName
            // 
            this.searchTextCarName.Location = new System.Drawing.Point(125, 117);
            this.searchTextCarName.Name = "searchTextCarName";
            this.searchTextCarName.Size = new System.Drawing.Size(281, 27);
            this.searchTextCarName.TabIndex = 24;
            // 
            // searchTextEmployeeName
            // 
            this.searchTextEmployeeName.Location = new System.Drawing.Point(125, 57);
            this.searchTextEmployeeName.Name = "searchTextEmployeeName";
            this.searchTextEmployeeName.Size = new System.Drawing.Size(281, 27);
            this.searchTextEmployeeName.TabIndex = 23;
            // 
            // retrievalButton
            // 
            this.retrievalButton.Location = new System.Drawing.Point(950, 100);
            this.retrievalButton.Name = "retrievalButton";
            this.retrievalButton.Size = new System.Drawing.Size(100, 40);
            this.retrievalButton.TabIndex = 22;
            this.retrievalButton.Text = "検索";
            this.retrievalButton.UseVisualStyleBackColor = true;
            // 
            // searchOrderDate
            // 
            this.searchOrderDate.AutoSize = true;
            this.searchOrderDate.Location = new System.Drawing.Point(460, 120);
            this.searchOrderDate.Name = "searchOrderDate";
            this.searchOrderDate.Size = new System.Drawing.Size(56, 16);
            this.searchOrderDate.TabIndex = 21;
            this.searchOrderDate.Text = "受注日付";
            // 
            // searchCarName
            // 
            this.searchCarName.AutoSize = true;
            this.searchCarName.Location = new System.Drawing.Point(60, 120);
            this.searchCarName.Name = "searchCarName";
            this.searchCarName.Size = new System.Drawing.Size(32, 16);
            this.searchCarName.TabIndex = 20;
            this.searchCarName.Text = "車名";
            // 
            // searchClientName
            // 
            this.searchClientName.AutoSize = true;
            this.searchClientName.Location = new System.Drawing.Point(460, 60);
            this.searchClientName.Name = "searchClientName";
            this.searchClientName.Size = new System.Drawing.Size(44, 16);
            this.searchClientName.TabIndex = 19;
            this.searchClientName.Text = "顧客名";
            // 
            // searchEmployeeName
            // 
            this.searchEmployeeName.AutoSize = true;
            this.searchEmployeeName.Location = new System.Drawing.Point(60, 60);
            this.searchEmployeeName.Name = "searchEmployeeName";
            this.searchEmployeeName.Size = new System.Drawing.Size(56, 16);
            this.searchEmployeeName.TabIndex = 18;
            this.searchEmployeeName.Text = "担当者名";
            // 
            // BulkSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.searchTextOrderDate);
            this.Controls.Add(this.searchTextClientName);
            this.Controls.Add(this.searchTextCarName);
            this.Controls.Add(this.searchTextEmployeeName);
            this.Controls.Add(this.retrievalButton);
            this.Controls.Add(this.searchOrderDate);
            this.Controls.Add(this.searchCarName);
            this.Controls.Add(this.searchClientName);
            this.Controls.Add(this.searchEmployeeName);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataList);
            this.Name = "BulkSelectForm";
            this.Text = "BulkClaimSelectForm";
            this.Controls.SetChildIndex(this.dataList, 0);
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.searchEmployeeName, 0);
            this.Controls.SetChildIndex(this.searchClientName, 0);
            this.Controls.SetChildIndex(this.searchCarName, 0);
            this.Controls.SetChildIndex(this.searchOrderDate, 0);
            this.Controls.SetChildIndex(this.retrievalButton, 0);
            this.Controls.SetChildIndex(this.searchTextEmployeeName, 0);
            this.Controls.SetChildIndex(this.searchTextCarName, 0);
            this.Controls.SetChildIndex(this.searchTextClientName, 0);
            this.Controls.SetChildIndex(this.searchTextOrderDate, 0);
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
        private System.Windows.Forms.TextBox searchTextOrderDate;
        private System.Windows.Forms.TextBox searchTextClientName;
        private System.Windows.Forms.TextBox searchTextCarName;
        private System.Windows.Forms.TextBox searchTextEmployeeName;
        private System.Windows.Forms.Button retrievalButton;
        private System.Windows.Forms.Label searchOrderDate;
        private System.Windows.Forms.Label searchCarName;
        private System.Windows.Forms.Label searchClientName;
        private System.Windows.Forms.Label searchEmployeeName;
    }
}
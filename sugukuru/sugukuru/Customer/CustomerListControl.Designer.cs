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
            this.searchCharge = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formal_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formal_name_read = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviation_read = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefectures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthly_trading_estimated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recovery_condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closing_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collection_month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collection_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financial_institution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financial_institution_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_account_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_account_holder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.formal_name,
            this.formal_name_read,
            this.abbreviation,
            this.abbreviation_read,
            this.postal_code,
            this.prefectures,
            this.municipality,
            this.client_division,
            this.client_rep,
            this.phone_number,
            this.fax,
            this.mail_address,
            this.monthly_trading_estimated,
            this.recovery_condition,
            this.closing_date,
            this.collection_month,
            this.collection_date,
            this.financial_institution,
            this.financial_institution_code,
            this.branch_name,
            this.branch_code,
            this.bank_account_number,
            this.bank_account_holder,
            this.file_info,
            this.create_at,
            this.create_rep,
            this.update_at,
            this.update_rep});
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
            // searchCharge
            // 
            this.searchCharge.FormattingEnabled = true;
            this.searchCharge.Location = new System.Drawing.Point(420, 125);
            this.searchCharge.Name = "searchCharge";
            this.searchCharge.Size = new System.Drawing.Size(121, 24);
            this.searchCharge.TabIndex = 44;
            // 
            // id
            // 
            this.id.HeaderText = "顧客ID";
            this.id.MinimumWidth = 75;
            this.id.Name = "id";
            this.id.Width = 75;
            // 
            // formal_name
            // 
            this.formal_name.HeaderText = "正式名称";
            this.formal_name.MinimumWidth = 150;
            this.formal_name.Name = "formal_name";
            this.formal_name.Width = 150;
            // 
            // formal_name_read
            // 
            this.formal_name_read.HeaderText = "正式名称カナ";
            this.formal_name_read.MinimumWidth = 150;
            this.formal_name_read.Name = "formal_name_read";
            this.formal_name_read.Width = 150;
            // 
            // abbreviation
            // 
            this.abbreviation.HeaderText = "略称";
            this.abbreviation.MinimumWidth = 200;
            this.abbreviation.Name = "abbreviation";
            this.abbreviation.Width = 200;
            // 
            // abbreviation_read
            // 
            this.abbreviation_read.HeaderText = "略称読み";
            this.abbreviation_read.MinimumWidth = 200;
            this.abbreviation_read.Name = "abbreviation_read";
            this.abbreviation_read.Width = 200;
            // 
            // postal_code
            // 
            this.postal_code.HeaderText = "郵便番号";
            this.postal_code.MinimumWidth = 100;
            this.postal_code.Name = "postal_code";
            // 
            // prefectures
            // 
            this.prefectures.HeaderText = "都道府県";
            this.prefectures.Name = "prefectures";
            // 
            // municipality
            // 
            this.municipality.HeaderText = "市町村以下";
            this.municipality.Name = "municipality";
            // 
            // client_division
            // 
            this.client_division.HeaderText = "取引先部署";
            this.client_division.Name = "client_division";
            // 
            // client_rep
            // 
            this.client_rep.HeaderText = "取引先担当者";
            this.client_rep.Name = "client_rep";
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "電話番号";
            this.phone_number.Name = "phone_number";
            // 
            // fax
            // 
            this.fax.HeaderText = "ファックス";
            this.fax.Name = "fax";
            // 
            // mail_address
            // 
            this.mail_address.HeaderText = "メールアドレス";
            this.mail_address.Name = "mail_address";
            // 
            // monthly_trading_estimated
            // 
            this.monthly_trading_estimated.HeaderText = "月間取引見込み";
            this.monthly_trading_estimated.Name = "monthly_trading_estimated";
            // 
            // recovery_condition
            // 
            this.recovery_condition.HeaderText = "回収条件";
            this.recovery_condition.Name = "recovery_condition";
            // 
            // closing_date
            // 
            this.closing_date.HeaderText = "締日";
            this.closing_date.Name = "closing_date";
            // 
            // collection_month
            // 
            this.collection_month.HeaderText = "回収月";
            this.collection_month.Name = "collection_month";
            // 
            // collection_date
            // 
            this.collection_date.HeaderText = "回収日";
            this.collection_date.Name = "collection_date";
            // 
            // financial_institution
            // 
            this.financial_institution.HeaderText = "金融機関名";
            this.financial_institution.Name = "financial_institution";
            // 
            // financial_institution_code
            // 
            this.financial_institution_code.HeaderText = "金融機関コード";
            this.financial_institution_code.Name = "financial_institution_code";
            // 
            // branch_name
            // 
            this.branch_name.HeaderText = "支店名";
            this.branch_name.Name = "branch_name";
            // 
            // branch_code
            // 
            this.branch_code.HeaderText = "支店コード";
            this.branch_code.Name = "branch_code";
            // 
            // bank_account_number
            // 
            this.bank_account_number.HeaderText = "口座番号";
            this.bank_account_number.Name = "bank_account_number";
            // 
            // bank_account_holder
            // 
            this.bank_account_holder.HeaderText = "口座名義";
            this.bank_account_holder.Name = "bank_account_holder";
            // 
            // file_info
            // 
            this.file_info.HeaderText = "微細情報";
            this.file_info.Name = "file_info";
            // 
            // create_at
            // 
            this.create_at.HeaderText = "登録日";
            this.create_at.Name = "create_at";
            // 
            // create_rep
            // 
            this.create_rep.HeaderText = "登録担当者";
            this.create_rep.Name = "create_rep";
            // 
            // update_at
            // 
            this.update_at.HeaderText = "変更日";
            this.update_at.Name = "update_at";
            // 
            // update_rep
            // 
            this.update_rep.HeaderText = "変更担当者";
            this.update_rep.Name = "update_rep";
            // 
            // CustomerListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchCharge);
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
        private System.Windows.Forms.ComboBox searchCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn formal_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn formal_name_read;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviation_read;
        private System.Windows.Forms.DataGridViewTextBoxColumn postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefectures;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipality;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_division;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthly_trading_estimated;
        private System.Windows.Forms.DataGridViewTextBoxColumn recovery_condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn closing_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn collection_month;
        private System.Windows.Forms.DataGridViewTextBoxColumn collection_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn financial_institution;
        private System.Windows.Forms.DataGridViewTextBoxColumn financial_institution_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank_account_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank_account_holder;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_rep;
    }
}

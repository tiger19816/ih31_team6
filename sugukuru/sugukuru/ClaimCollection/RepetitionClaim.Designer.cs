namespace sugukuru.ClaimCollection
{
    partial class RepetitionClaim
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.btFix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRepetition = new System.Windows.Forms.DataGridView();
            this.tblCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.lbRep = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbPostal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDif = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbLimitDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBillDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbClaim = new System.Windows.Forms.GroupBox();
            this.rbAfter = new System.Windows.Forms.RadioButton();
            this.rbDunning = new System.Windows.Forms.RadioButton();
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
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepetition)).BeginInit();
            this.tblCustomer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbClaim.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFix
            // 
            this.btFix.Enabled = false;
            this.btFix.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFix.Location = new System.Drawing.Point(1040, 573);
            this.btFix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(117, 53);
            this.btFix.TabIndex = 10;
            this.btFix.Text = "確定";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "未決済請求処理";
            // 
            // dgvRepetition
            // 
            this.dgvRepetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepetition.Location = new System.Drawing.Point(17, 153);
            this.dgvRepetition.Name = "dgvRepetition";
            this.dgvRepetition.RowTemplate.Height = 21;
            this.dgvRepetition.Size = new System.Drawing.Size(1120, 289);
            this.dgvRepetition.TabIndex = 101;
            this.dgvRepetition.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRepetition_CellMouseClick);
            // 
            // tblCustomer
            // 
            this.tblCustomer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCustomer.ColumnCount = 2;
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblCustomer.Controls.Add(this.lbRep, 1, 4);
            this.tblCustomer.Controls.Add(this.lbDivision, 1, 3);
            this.tblCustomer.Controls.Add(this.lbAddress, 1, 2);
            this.tblCustomer.Controls.Add(this.label3, 0, 0);
            this.tblCustomer.Controls.Add(this.label12, 0, 2);
            this.tblCustomer.Controls.Add(this.label11, 0, 1);
            this.tblCustomer.Controls.Add(this.lbCustomerName, 1, 0);
            this.tblCustomer.Controls.Add(this.label17, 0, 3);
            this.tblCustomer.Controls.Add(this.label18, 0, 4);
            this.tblCustomer.Controls.Add(this.lbPostal, 1, 1);
            this.tblCustomer.Location = new System.Drawing.Point(15, 448);
            this.tblCustomer.Name = "tblCustomer";
            this.tblCustomer.RowCount = 5;
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCustomer.Size = new System.Drawing.Size(379, 168);
            this.tblCustomer.TabIndex = 102;
            // 
            // lbRep
            // 
            this.lbRep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRep.AutoSize = true;
            this.lbRep.Location = new System.Drawing.Point(117, 142);
            this.lbRep.Name = "lbRep";
            this.lbRep.Size = new System.Drawing.Size(0, 16);
            this.lbRep.TabIndex = 133;
            // 
            // lbDivision
            // 
            this.lbDivision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDivision.AutoSize = true;
            this.lbDivision.Location = new System.Drawing.Point(117, 108);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(0, 16);
            this.lbDivision.TabIndex = 133;
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(117, 75);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(0, 16);
            this.lbAddress.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "顧客名";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(4, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "住所";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(4, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "所在地〒";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(117, 9);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(0, 16);
            this.lbCustomerName.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(4, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "取引先部署";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(4, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 16);
            this.label18.TabIndex = 8;
            this.label18.Text = "取引先担当者";
            // 
            // lbPostal
            // 
            this.lbPostal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPostal.AutoSize = true;
            this.lbPostal.Location = new System.Drawing.Point(117, 42);
            this.lbPostal.Name = "lbPostal";
            this.lbPostal.Size = new System.Drawing.Size(0, 16);
            this.lbPostal.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lbDif, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbAmount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbLimitDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBillDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(400, 448);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 168);
            this.tableLayoutPanel1.TabIndex = 103;
            // 
            // lbDif
            // 
            this.lbDif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDif.AutoSize = true;
            this.lbDif.Location = new System.Drawing.Point(117, 142);
            this.lbDif.Name = "lbDif";
            this.lbDif.Size = new System.Drawing.Size(0, 16);
            this.lbDif.TabIndex = 133;
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(117, 108);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(0, 16);
            this.lbAmount.TabIndex = 133;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(117, 75);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(0, 16);
            this.lbPrice.TabIndex = 133;
            // 
            // lbLimitDate
            // 
            this.lbLimitDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLimitDate.AutoSize = true;
            this.lbLimitDate.Location = new System.Drawing.Point(117, 42);
            this.lbLimitDate.Name = "lbLimitDate";
            this.lbLimitDate.Size = new System.Drawing.Size(0, 16);
            this.lbLimitDate.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "請求日";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(4, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "請求額";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "入金日";
            // 
            // lbBillDate
            // 
            this.lbBillDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBillDate.AutoSize = true;
            this.lbBillDate.Location = new System.Drawing.Point(117, 9);
            this.lbBillDate.Name = "lbBillDate";
            this.lbBillDate.Size = new System.Drawing.Size(0, 16);
            this.lbBillDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(4, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "入金額";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(4, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "差額";
            // 
            // gbClaim
            // 
            this.gbClaim.Controls.Add(this.rbAfter);
            this.gbClaim.Controls.Add(this.rbDunning);
            this.gbClaim.Enabled = false;
            this.gbClaim.Location = new System.Drawing.Point(846, 448);
            this.gbClaim.Name = "gbClaim";
            this.gbClaim.Size = new System.Drawing.Size(224, 116);
            this.gbClaim.TabIndex = 104;
            this.gbClaim.TabStop = false;
            this.gbClaim.Text = "手続内容";
            // 
            // rbAfter
            // 
            this.rbAfter.AutoSize = true;
            this.rbAfter.Location = new System.Drawing.Point(24, 77);
            this.rbAfter.Name = "rbAfter";
            this.rbAfter.Size = new System.Drawing.Size(146, 20);
            this.rbAfter.TabIndex = 1;
            this.rbAfter.Text = "翌月の請求に繰り越す";
            this.rbAfter.UseVisualStyleBackColor = true;
            // 
            // rbDunning
            // 
            this.rbDunning.AutoSize = true;
            this.rbDunning.Checked = true;
            this.rbDunning.Location = new System.Drawing.Point(24, 33);
            this.rbDunning.Name = "rbDunning";
            this.rbDunning.Size = new System.Drawing.Size(158, 20);
            this.rbDunning.TabIndex = 0;
            this.rbDunning.TabStop = true;
            this.rbDunning.Text = "直ちに請求する（督促）";
            this.rbDunning.UseVisualStyleBackColor = true;
            // 
            // whiler
            // 
            this.whiler.AutoSize = true;
            this.whiler.Location = new System.Drawing.Point(380, 51);
            this.whiler.Name = "whiler";
            this.whiler.Size = new System.Drawing.Size(17, 16);
            this.whiler.TabIndex = 118;
            this.whiler.Text = "~";
            // 
            // overDay
            // 
            this.overDay.AutoSize = true;
            this.overDay.Location = new System.Drawing.Point(669, 51);
            this.overDay.Name = "overDay";
            this.overDay.Size = new System.Drawing.Size(20, 16);
            this.overDay.TabIndex = 117;
            this.overDay.Text = "日";
            // 
            // overMonth
            // 
            this.overMonth.AutoSize = true;
            this.overMonth.Location = new System.Drawing.Point(593, 51);
            this.overMonth.Name = "overMonth";
            this.overMonth.Size = new System.Drawing.Size(20, 16);
            this.overMonth.TabIndex = 116;
            this.overMonth.Text = "月";
            // 
            // overYear
            // 
            this.overYear.AutoSize = true;
            this.overYear.Location = new System.Drawing.Point(517, 51);
            this.overYear.Name = "overYear";
            this.overYear.Size = new System.Drawing.Size(20, 16);
            this.overYear.TabIndex = 115;
            this.overYear.Text = "年";
            // 
            // comboBoxOverDay
            // 
            this.comboBoxOverDay.FormattingEnabled = true;
            this.comboBoxOverDay.Location = new System.Drawing.Point(619, 48);
            this.comboBoxOverDay.Name = "comboBoxOverDay";
            this.comboBoxOverDay.Size = new System.Drawing.Size(44, 24);
            this.comboBoxOverDay.TabIndex = 114;
            // 
            // comboBoxOverMonth
            // 
            this.comboBoxOverMonth.FormattingEnabled = true;
            this.comboBoxOverMonth.Location = new System.Drawing.Point(544, 48);
            this.comboBoxOverMonth.Name = "comboBoxOverMonth";
            this.comboBoxOverMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxOverMonth.TabIndex = 113;
            // 
            // comboBoxOverYear
            // 
            this.comboBoxOverYear.FormattingEnabled = true;
            this.comboBoxOverYear.Location = new System.Drawing.Point(417, 48);
            this.comboBoxOverYear.Name = "comboBoxOverYear";
            this.comboBoxOverYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxOverYear.TabIndex = 112;
            // 
            // underDay
            // 
            this.underDay.AutoSize = true;
            this.underDay.Location = new System.Drawing.Point(345, 51);
            this.underDay.Name = "underDay";
            this.underDay.Size = new System.Drawing.Size(20, 16);
            this.underDay.TabIndex = 111;
            this.underDay.Text = "日";
            // 
            // underMonth
            // 
            this.underMonth.AutoSize = true;
            this.underMonth.Location = new System.Drawing.Point(269, 51);
            this.underMonth.Name = "underMonth";
            this.underMonth.Size = new System.Drawing.Size(20, 16);
            this.underMonth.TabIndex = 110;
            this.underMonth.Text = "月";
            // 
            // underYear
            // 
            this.underYear.AutoSize = true;
            this.underYear.Location = new System.Drawing.Point(193, 51);
            this.underYear.Name = "underYear";
            this.underYear.Size = new System.Drawing.Size(20, 16);
            this.underYear.TabIndex = 109;
            this.underYear.Text = "年";
            // 
            // comboBoxUnderDay
            // 
            this.comboBoxUnderDay.FormattingEnabled = true;
            this.comboBoxUnderDay.Location = new System.Drawing.Point(295, 48);
            this.comboBoxUnderDay.Name = "comboBoxUnderDay";
            this.comboBoxUnderDay.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderDay.TabIndex = 108;
            // 
            // comboBoxUnderMonth
            // 
            this.comboBoxUnderMonth.FormattingEnabled = true;
            this.comboBoxUnderMonth.Location = new System.Drawing.Point(220, 48);
            this.comboBoxUnderMonth.Name = "comboBoxUnderMonth";
            this.comboBoxUnderMonth.Size = new System.Drawing.Size(44, 24);
            this.comboBoxUnderMonth.TabIndex = 107;
            // 
            // comboBoxUnderYear
            // 
            this.comboBoxUnderYear.FormattingEnabled = true;
            this.comboBoxUnderYear.Location = new System.Drawing.Point(93, 48);
            this.comboBoxUnderYear.Name = "comboBoxUnderYear";
            this.comboBoxUnderYear.Size = new System.Drawing.Size(94, 24);
            this.comboBoxUnderYear.TabIndex = 106;
            // 
            // searchDate
            // 
            this.searchDate.AutoSize = true;
            this.searchDate.Location = new System.Drawing.Point(19, 51);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(44, 16);
            this.searchDate.TabIndex = 105;
            this.searchDate.Text = "入金日";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 119;
            this.label10.Text = "請求額";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 27);
            this.textBox1.TabIndex = 121;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(417, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 27);
            this.textBox2.TabIndex = 122;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(417, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 27);
            this.textBox3.TabIndex = 126;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 27);
            this.textBox4.TabIndex = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 123;
            this.label14.Text = "差額";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(269, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 127;
            this.label16.Text = "円以上";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 128;
            this.label9.Text = "円以上";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(594, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 129;
            this.label13.Text = "円以下";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(593, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 16);
            this.label19.TabIndex = 130;
            this.label19.Text = "円以下";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(781, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 100);
            this.groupBox2.TabIndex = 132;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索オプション";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 20);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "AND検索";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(21, 27);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "OR検索";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(940, 118);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 131;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // RepetitionClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.gbClaim);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tblCustomer);
            this.Controls.Add(this.dgvRepetition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFix);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "RepetitionClaim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepetition)).EndInit();
            this.tblCustomer.ResumeLayout(false);
            this.tblCustomer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbClaim.ResumeLayout(false);
            this.gbClaim.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRepetition;
        private System.Windows.Forms.TableLayoutPanel tblCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBillDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbClaim;
        private System.Windows.Forms.RadioButton rbAfter;
        private System.Windows.Forms.RadioButton rbDunning;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbRep;
        private System.Windows.Forms.Label lbDivision;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPostal;
        private System.Windows.Forms.Label lbDif;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbLimitDate;
    }
}

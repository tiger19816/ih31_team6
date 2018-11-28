namespace sugukuru.ClaimCollection
{
    partial class IndividualReconciliation
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDif = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbClaimDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbClaimNo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.lbClientRep = new System.Windows.Forms.Label();
            this.lbClientDivision = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPostalCode = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.btCustomerSearch = new System.Windows.Forms.Button();
            this.dgvRecon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btFix = new System.Windows.Forms.Button();
            this.dtpBill = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.lbDif, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbAmount, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbPrice, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbClaimDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbClaimNo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(754, 259);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 168);
            this.tableLayoutPanel2.TabIndex = 128;
            this.tableLayoutPanel2.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblCustomer_CellPaint);
            // 
            // lbDif
            // 
            this.lbDif.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDif.AutoSize = true;
            this.lbDif.Location = new System.Drawing.Point(375, 142);
            this.lbDif.Name = "lbDif";
            this.lbDif.Size = new System.Drawing.Size(0, 16);
            this.lbDif.TabIndex = 133;
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(375, 108);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(0, 16);
            this.lbAmount.TabIndex = 133;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(375, 75);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(0, 16);
            this.lbPrice.TabIndex = 133;
            // 
            // lbClaimDate
            // 
            this.lbClaimDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbClaimDate.AutoSize = true;
            this.lbClaimDate.Location = new System.Drawing.Point(117, 42);
            this.lbClaimDate.Name = "lbClaimDate";
            this.lbClaimDate.Size = new System.Drawing.Size(0, 16);
            this.lbClaimDate.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "請求書番号";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(4, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "請求額";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(4, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "請求日";
            // 
            // lbClaimNo
            // 
            this.lbClaimNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbClaimNo.AutoSize = true;
            this.lbClaimNo.Location = new System.Drawing.Point(117, 9);
            this.lbClaimNo.Name = "lbClaimNo";
            this.lbClaimNo.Size = new System.Drawing.Size(0, 16);
            this.lbClaimNo.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(4, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "入金額";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(4, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "差額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 127;
            this.label4.Text = "入金区分";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "現金",
            "小切手",
            "銀行振込"});
            this.comboBox1.Location = new System.Drawing.Point(874, 438);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 126;
            // 
            // tblCustomer
            // 
            this.tblCustomer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCustomer.ColumnCount = 2;
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblCustomer.Controls.Add(this.lbClientRep, 1, 4);
            this.tblCustomer.Controls.Add(this.lbClientDivision, 1, 3);
            this.tblCustomer.Controls.Add(this.lbAddress, 1, 2);
            this.tblCustomer.Controls.Add(this.lbPostalCode, 1, 1);
            this.tblCustomer.Controls.Add(this.label12, 0, 0);
            this.tblCustomer.Controls.Add(this.label13, 0, 2);
            this.tblCustomer.Controls.Add(this.label14, 0, 1);
            this.tblCustomer.Controls.Add(this.lbName, 1, 0);
            this.tblCustomer.Controls.Add(this.label17, 0, 3);
            this.tblCustomer.Controls.Add(this.label18, 0, 4);
            this.tblCustomer.Location = new System.Drawing.Point(754, 85);
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
            this.tblCustomer.TabIndex = 125;
            this.tblCustomer.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblCustomer_CellPaint);
            // 
            // lbClientRep
            // 
            this.lbClientRep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbClientRep.AutoSize = true;
            this.lbClientRep.BackColor = System.Drawing.Color.Transparent;
            this.lbClientRep.Location = new System.Drawing.Point(117, 142);
            this.lbClientRep.Name = "lbClientRep";
            this.lbClientRep.Size = new System.Drawing.Size(0, 16);
            this.lbClientRep.TabIndex = 130;
            // 
            // lbClientDivision
            // 
            this.lbClientDivision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbClientDivision.AutoSize = true;
            this.lbClientDivision.BackColor = System.Drawing.Color.Transparent;
            this.lbClientDivision.Location = new System.Drawing.Point(117, 108);
            this.lbClientDivision.Name = "lbClientDivision";
            this.lbClientDivision.Size = new System.Drawing.Size(0, 16);
            this.lbClientDivision.TabIndex = 129;
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Location = new System.Drawing.Point(117, 75);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(0, 16);
            this.lbAddress.TabIndex = 128;
            // 
            // lbPostalCode
            // 
            this.lbPostalCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPostalCode.AutoSize = true;
            this.lbPostalCode.BackColor = System.Drawing.Color.Transparent;
            this.lbPostalCode.Location = new System.Drawing.Point(117, 42);
            this.lbPostalCode.Name = "lbPostalCode";
            this.lbPostalCode.Size = new System.Drawing.Size(0, 16);
            this.lbPostalCode.TabIndex = 128;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(4, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "顧客名";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(4, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "住所";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(4, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "所在地〒";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(117, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 16);
            this.lbName.TabIndex = 5;
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
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(661, 515);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(87, 31);
            this.btnSelect.TabIndex = 123;
            this.btnSelect.Text = "選択";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(874, 519);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(100, 27);
            this.tbPayment.TabIndex = 121;
            this.tbPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "入金額";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 114;
            this.label7.Text = "入金日";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 47);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 110;
            this.button2.Text = "絞り込む";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 109;
            this.label2.Text = "顧客ID";
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(127, 49);
            this.tbClientId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(116, 27);
            this.tbClientId.TabIndex = 108;
            // 
            // btCustomerSearch
            // 
            this.btCustomerSearch.Location = new System.Drawing.Point(261, 47);
            this.btCustomerSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCustomerSearch.Name = "btCustomerSearch";
            this.btCustomerSearch.Size = new System.Drawing.Size(87, 31);
            this.btCustomerSearch.TabIndex = 107;
            this.btCustomerSearch.Text = "検索";
            this.btCustomerSearch.UseVisualStyleBackColor = true;
            this.btCustomerSearch.Click += new System.EventHandler(this.btCustomerSearch_Click);
            // 
            // dgvRecon
            // 
            this.dgvRecon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecon.Location = new System.Drawing.Point(20, 85);
            this.dgvRecon.Name = "dgvRecon";
            this.dgvRecon.RowTemplate.Height = 21;
            this.dgvRecon.Size = new System.Drawing.Size(728, 423);
            this.dgvRecon.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "個別消込一覧";
            // 
            // btFix
            // 
            this.btFix.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFix.Location = new System.Drawing.Point(1040, 569);
            this.btFix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(117, 53);
            this.btFix.TabIndex = 5;
            this.btFix.Text = "消込";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // dtpBill
            // 
            this.dtpBill.Location = new System.Drawing.Point(874, 479);
            this.dtpBill.Name = "dtpBill";
            this.dtpBill.Size = new System.Drawing.Size(171, 27);
            this.dtpBill.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(980, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "円";
            // 
            // IndividualReconciliation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBill);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tblCustomer);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbPayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClientId);
            this.Controls.Add(this.btCustomerSearch);
            this.Controls.Add(this.dgvRecon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFix);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "IndividualReconciliation";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblCustomer.ResumeLayout(false);
            this.tblCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRecon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.Button btCustomerSearch;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TableLayoutPanel tblCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbClientRep;
        private System.Windows.Forms.Label lbClientDivision;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPostalCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbDif;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbClaimDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbClaimNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpBill;
        private System.Windows.Forms.Label label3;
    }
}

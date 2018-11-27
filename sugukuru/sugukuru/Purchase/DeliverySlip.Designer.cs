namespace sugukuru.Purchase
{
    partial class DeliverySlip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.taxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btCustomerSearch = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tblCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.clientRepLabel = new System.Windows.Forms.Label();
            this.clientDivisionLabel = new System.Windows.Forms.Label();
            this.clientAddressLabel = new System.Windows.Forms.Label();
            this.clientPostalLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btEstimateDelete = new System.Windows.Forms.Button();
            this.btEstimateAdd = new System.Windows.Forms.Button();
            this.btEstimateChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(27, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(251, 79);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "発行方法選択";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(141, 37);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "個別入力";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "見積書から選択";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "見積書番号";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 195);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 27);
            this.textBox4.TabIndex = 104;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(271, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 103;
            this.button1.Text = "選択";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(1035, 569);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 53);
            this.button2.TabIndex = 85;
            this.button2.Text = "印刷";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // clientNameLabel
            // 
            this.clientNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(117, 9);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(0, 16);
            this.clientNameLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "納品書発行";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.taxLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.subTotalLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.totalLabel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(869, 460);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 102);
            this.tableLayoutPanel1.TabIndex = 94;
            // 
            // taxLabel
            // 
            this.taxLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Location = new System.Drawing.Point(86, 42);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 16);
            this.taxLabel.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "小計";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(4, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "合計金額";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(86, 9);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(0, 16);
            this.subTotalLabel.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(4, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 16);
            this.label20.TabIndex = 6;
            this.label20.Text = "消費税";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Location = new System.Drawing.Point(86, 76);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 16);
            this.totalLabel.TabIndex = 108;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 494);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "顧客ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 27);
            this.textBox1.TabIndex = 87;
            // 
            // btCustomerSearch
            // 
            this.btCustomerSearch.Location = new System.Drawing.Point(271, 56);
            this.btCustomerSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCustomerSearch.Name = "btCustomerSearch";
            this.btCustomerSearch.Size = new System.Drawing.Size(87, 31);
            this.btCustomerSearch.TabIndex = 86;
            this.btCustomerSearch.Text = "検索";
            this.btCustomerSearch.UseVisualStyleBackColor = true;
            this.btCustomerSearch.Click += new System.EventHandler(this.btCustomerSearch_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(24, 497);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 91;
            this.label21.Text = "納品担当者";
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
            // tblCustomer
            // 
            this.tblCustomer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCustomer.ColumnCount = 2;
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblCustomer.Controls.Add(this.clientRepLabel, 1, 4);
            this.tblCustomer.Controls.Add(this.clientDivisionLabel, 1, 3);
            this.tblCustomer.Controls.Add(this.clientAddressLabel, 1, 2);
            this.tblCustomer.Controls.Add(this.clientPostalLabel, 1, 1);
            this.tblCustomer.Controls.Add(this.label3, 0, 0);
            this.tblCustomer.Controls.Add(this.label12, 0, 2);
            this.tblCustomer.Controls.Add(this.label11, 0, 1);
            this.tblCustomer.Controls.Add(this.clientNameLabel, 1, 0);
            this.tblCustomer.Controls.Add(this.label17, 0, 3);
            this.tblCustomer.Controls.Add(this.label18, 0, 4);
            this.tblCustomer.Location = new System.Drawing.Point(27, 263);
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
            this.tblCustomer.TabIndex = 89;
            // 
            // clientRepLabel
            // 
            this.clientRepLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientRepLabel.AutoSize = true;
            this.clientRepLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientRepLabel.Location = new System.Drawing.Point(117, 142);
            this.clientRepLabel.Name = "clientRepLabel";
            this.clientRepLabel.Size = new System.Drawing.Size(0, 16);
            this.clientRepLabel.TabIndex = 111;
            // 
            // clientDivisionLabel
            // 
            this.clientDivisionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientDivisionLabel.AutoSize = true;
            this.clientDivisionLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientDivisionLabel.Location = new System.Drawing.Point(117, 108);
            this.clientDivisionLabel.Name = "clientDivisionLabel";
            this.clientDivisionLabel.Size = new System.Drawing.Size(0, 16);
            this.clientDivisionLabel.TabIndex = 110;
            // 
            // clientAddressLabel
            // 
            this.clientAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientAddressLabel.AutoSize = true;
            this.clientAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientAddressLabel.Location = new System.Drawing.Point(117, 75);
            this.clientAddressLabel.Name = "clientAddressLabel";
            this.clientAddressLabel.Size = new System.Drawing.Size(0, 16);
            this.clientAddressLabel.TabIndex = 109;
            // 
            // clientPostalLabel
            // 
            this.clientPostalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientPostalLabel.AutoSize = true;
            this.clientPostalLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientPostalLabel.Location = new System.Drawing.Point(117, 42);
            this.clientPostalLabel.Name = "clientPostalLabel";
            this.clientPostalLabel.Size = new System.Drawing.Size(0, 16);
            this.clientPostalLabel.TabIndex = 108;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(421, 471);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 91);
            this.textBox3.TabIndex = 101;
            // 
            // btEstimateDelete
            // 
            this.btEstimateDelete.Location = new System.Drawing.Point(1055, 65);
            this.btEstimateDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEstimateDelete.Name = "btEstimateDelete";
            this.btEstimateDelete.Size = new System.Drawing.Size(87, 31);
            this.btEstimateDelete.TabIndex = 100;
            this.btEstimateDelete.Text = "削除";
            this.btEstimateDelete.UseVisualStyleBackColor = true;
            // 
            // btEstimateAdd
            // 
            this.btEstimateAdd.Location = new System.Drawing.Point(869, 65);
            this.btEstimateAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEstimateAdd.Name = "btEstimateAdd";
            this.btEstimateAdd.Size = new System.Drawing.Size(87, 31);
            this.btEstimateAdd.TabIndex = 99;
            this.btEstimateAdd.Text = "追加";
            this.btEstimateAdd.UseVisualStyleBackColor = true;
            // 
            // btEstimateChange
            // 
            this.btEstimateChange.Location = new System.Drawing.Point(962, 65);
            this.btEstimateChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEstimateChange.Name = "btEstimateChange";
            this.btEstimateChange.Size = new System.Drawing.Size(87, 31);
            this.btEstimateChange.TabIndex = 98;
            this.btEstimateChange.Text = "変更";
            this.btEstimateChange.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(721, 328);
            this.dataGridView1.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "発行日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "備考";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 454);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 27);
            this.dateTimePicker1.TabIndex = 107;
            // 
            // DeliverySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btCustomerSearch);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tblCustomer);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btEstimateDelete);
            this.Controls.Add(this.btEstimateAdd);
            this.Controls.Add(this.btEstimateChange);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "DeliverySlip";
            this.Load += new System.EventHandler(this.DeliverySlip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblCustomer.ResumeLayout(false);
            this.tblCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btCustomerSearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tblCustomer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btEstimateDelete;
        private System.Windows.Forms.Button btEstimateAdd;
        private System.Windows.Forms.Button btEstimateChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label clientRepLabel;
        private System.Windows.Forms.Label clientDivisionLabel;
        private System.Windows.Forms.Label clientAddressLabel;
        private System.Windows.Forms.Label clientPostalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}

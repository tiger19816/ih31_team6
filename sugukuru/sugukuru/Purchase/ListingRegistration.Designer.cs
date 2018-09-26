namespace sugukuru.Purchase
{
    partial class ListingRegistration
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
            this.tbModelYear = new System.Windows.Forms.TextBox();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRep = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "出品車両登録";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbModelYear
            // 
            this.tbModelYear.Location = new System.Drawing.Point(714, 49);
            this.tbModelYear.Name = "tbModelYear";
            this.tbModelYear.Size = new System.Drawing.Size(100, 19);
            this.tbModelYear.TabIndex = 100;
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(413, 83);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(171, 19);
            this.tbCarName.TabIndex = 99;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(413, 49);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(171, 19);
            this.tbModel.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 97;
            this.label5.Text = "年式";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(333, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 96;
            this.label13.Text = "車名";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 95;
            this.label14.Text = "型式";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(207, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 94;
            this.button4.Text = "業者検索";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(93, 83);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(100, 19);
            this.tbCustomerID.TabIndex = 93;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(93, 49);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(100, 19);
            this.tbOrderID.TabIndex = 92;
            this.tbOrderID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 12);
            this.label7.TabIndex = 91;
            this.label7.Text = "顧客ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 90;
            this.label2.Text = "受注ID";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(297, 110);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 19);
            this.dtpEnd.TabIndex = 104;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(70, 112);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 19);
            this.dtpStart.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 102;
            this.label3.Text = "～";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 101;
            this.label4.Text = "受注日付";
            // 
            // cbRep
            // 
            this.cbRep.FormattingEnabled = true;
            this.cbRep.Location = new System.Drawing.Point(84, 142);
            this.cbRep.Name = "cbRep";
            this.cbRep.Size = new System.Drawing.Size(121, 20);
            this.cbRep.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 105;
            this.label12.Text = "営業担当者";
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(1053, 140);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(75, 23);
            this.btRegistration.TabIndex = 107;
            this.btRegistration.Text = "確定";
            this.btRegistration.UseVisualStyleBackColor = true;
            // 
            // ListingRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.cbRep);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbModelYear);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListingRegistration";
            this.Size = new System.Drawing.Size(1160, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbModelYear;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btRegistration;
    }
}

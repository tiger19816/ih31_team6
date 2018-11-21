namespace sugukuru.Purchase
{
    partial class Transport
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbTransport = new System.Windows.Forms.ComboBox();
            this.btConfirmation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbDeparturePost = new System.Windows.Forms.TextBox();
            this.tbArrivalPost = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbSlip = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tblCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.lbCustomerId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbDeparture = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbArrival = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbOrderRep = new System.Windows.Forms.ComboBox();
            this.tblCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "陸送業者";
            // 
            // cbTransport
            // 
            this.cbTransport.FormattingEnabled = true;
            this.cbTransport.Location = new System.Drawing.Point(76, 141);
            this.cbTransport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTransport.Name = "cbTransport";
            this.cbTransport.Size = new System.Drawing.Size(140, 24);
            this.cbTransport.TabIndex = 2;
            // 
            // btConfirmation
            // 
            this.btConfirmation.Font = new System.Drawing.Font("游ゴシック", 12F);
            this.btConfirmation.Location = new System.Drawing.Point(1040, 573);
            this.btConfirmation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConfirmation.Name = "btConfirmation";
            this.btConfirmation.Size = new System.Drawing.Size(117, 53);
            this.btConfirmation.TabIndex = 3;
            this.btConfirmation.Text = "登録";
            this.btConfirmation.UseVisualStyleBackColor = true;
            this.btConfirmation.Click += new System.EventHandler(this.btConfirmation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "陸送情報登録";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "受注ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "出発地";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "到着地";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "料金";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "依頼日";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "伝票番号";
            // 
            // tbOrderId
            // 
            this.tbOrderId.Location = new System.Drawing.Point(74, 72);
            this.tbOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(116, 27);
            this.tbOrderId.TabIndex = 19;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(207, 72);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(87, 31);
            this.btSearch.TabIndex = 20;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbDeparturePost
            // 
            this.tbDeparturePost.Location = new System.Drawing.Point(88, 291);
            this.tbDeparturePost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDeparturePost.Name = "tbDeparturePost";
            this.tbDeparturePost.Size = new System.Drawing.Size(116, 27);
            this.tbDeparturePost.TabIndex = 22;
            // 
            // tbArrivalPost
            // 
            this.tbArrivalPost.Location = new System.Drawing.Point(266, 294);
            this.tbArrivalPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbArrivalPost.Name = "tbArrivalPost";
            this.tbArrivalPost.Size = new System.Drawing.Size(116, 27);
            this.tbArrivalPost.TabIndex = 23;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(88, 346);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(116, 27);
            this.tbPrice.TabIndex = 24;
            // 
            // tbSlip
            // 
            this.tbSlip.Location = new System.Drawing.Point(88, 436);
            this.tbSlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSlip.Name = "tbSlip";
            this.tbSlip.Size = new System.Drawing.Size(116, 27);
            this.tbSlip.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 393);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 27);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // tblCustomer
            // 
            this.tblCustomer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCustomer.ColumnCount = 2;
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblCustomer.Controls.Add(this.label25, 0, 0);
            this.tblCustomer.Controls.Add(this.lbCustomerId, 1, 0);
            this.tblCustomer.Location = new System.Drawing.Point(320, 72);
            this.tblCustomer.Name = "tblCustomer";
            this.tblCustomer.RowCount = 1;
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblCustomer.Size = new System.Drawing.Size(379, 39);
            this.tblCustomer.TabIndex = 35;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(4, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 16);
            this.label25.TabIndex = 10;
            this.label25.Text = "顧客ID";
            // 
            // lbCustomerId
            // 
            this.lbCustomerId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCustomerId.AutoSize = true;
            this.lbCustomerId.Location = new System.Drawing.Point(117, 12);
            this.lbCustomerId.Name = "lbCustomerId";
            this.lbCustomerId.Size = new System.Drawing.Size(0, 16);
            this.lbCustomerId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "郵便番号";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 294);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 16);
            this.label21.TabIndex = 37;
            this.label21.Text = "住所";
            // 
            // tbDeparture
            // 
            this.tbDeparture.Location = new System.Drawing.Point(88, 256);
            this.tbDeparture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDeparture.Name = "tbDeparture";
            this.tbDeparture.Size = new System.Drawing.Size(116, 27);
            this.tbDeparture.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(204, 256);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 39;
            this.label22.Text = "郵便番号";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(204, 294);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 16);
            this.label23.TabIndex = 40;
            this.label23.Text = "住所";
            // 
            // tbArrival
            // 
            this.tbArrival.Location = new System.Drawing.Point(266, 256);
            this.tbArrival.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbArrival.Name = "tbArrival";
            this.tbArrival.Size = new System.Drawing.Size(116, 27);
            this.tbArrival.TabIndex = 41;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 482);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 16);
            this.label24.TabIndex = 43;
            this.label24.Text = "受注担当者";
            // 
            // cbOrderRep
            // 
            this.cbOrderRep.FormattingEnabled = true;
            this.cbOrderRep.Location = new System.Drawing.Point(88, 479);
            this.cbOrderRep.Name = "cbOrderRep";
            this.cbOrderRep.Size = new System.Drawing.Size(121, 24);
            this.cbOrderRep.TabIndex = 42;
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbOrderRep);
            this.Controls.Add(this.tbArrival);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tbDeparture);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblCustomer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbSlip);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbArrivalPost);
            this.Controls.Add(this.tbDeparturePost);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbOrderId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btConfirmation);
            this.Controls.Add(this.cbTransport);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Transport";
            this.tblCustomer.ResumeLayout(false);
            this.tblCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTransport;
        private System.Windows.Forms.Button btConfirmation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbDeparturePost;
        private System.Windows.Forms.TextBox tbArrivalPost;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbSlip;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tblCustomer;
        private System.Windows.Forms.Label lbCustomerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbDeparture;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbArrival;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbOrderRep;
        private System.Windows.Forms.Label label25;
    }
}

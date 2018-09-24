namespace sugukuru.FormMaster
{
    partial class BaseFormMST
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNoticeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNoticeCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUserLabel,
            this.tsUserName,
            this.tsNoticeLabel,
            this.tsNoticeCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsUserLabel
            // 
            this.tsUserLabel.Name = "tsUserLabel";
            this.tsUserLabel.Size = new System.Drawing.Size(67, 17);
            this.tsUserLabel.Text = "ユーザー名：";
            // 
            // tsUserName
            // 
            this.tsUserName.Name = "tsUserName";
            this.tsUserName.Size = new System.Drawing.Size(55, 17);
            this.tsUserName.Text = "山田太郎";
            // 
            // tsNoticeLabel
            // 
            this.tsNoticeLabel.Name = "tsNoticeLabel";
            this.tsNoticeLabel.Size = new System.Drawing.Size(1157, 17);
            this.tsNoticeLabel.Spring = true;
            this.tsNoticeLabel.Text = "新着通知：";
            this.tsNoticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsNoticeCount
            // 
            this.tsNoticeCount.Name = "tsNoticeCount";
            this.tsNoticeCount.Size = new System.Drawing.Size(25, 17);
            this.tsNoticeCount.Text = "0件";
            // 
            // BaseFormMST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BaseFormMST";
            this.Text = "BaseFormMST";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsUserLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsNoticeLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsNoticeCount;
    }
}
namespace sugukuru.Purchase
{
    partial class BitCarList
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
            this.dgvBulk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBulk
            // 
            this.dgvBulk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBulk.Location = new System.Drawing.Point(17, 59);
            this.dgvBulk.Name = "dgvBulk";
            this.dgvBulk.RowTemplate.Height = 21;
            this.dgvBulk.Size = new System.Drawing.Size(1120, 504);
            this.dgvBulk.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 111;
            this.label1.Text = "落札車両一覧";
            // 
            // btSelect
            // 
            this.btSelect.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSelect.Location = new System.Drawing.Point(1037, 570);
            this.btSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(117, 53);
            this.btSelect.TabIndex = 110;
            this.btSelect.Text = "選択";
            this.btSelect.UseVisualStyleBackColor = true;
            // 
            // BitCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBulk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSelect);
            this.Name = "BitCarList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBulk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelect;
    }
}

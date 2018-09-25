namespace sugukuru.FormMaster
{
    partial class FormMST
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.inheritableFlowLayoutPanel1 = new sugukuru.InheritableFlowLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(104, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 630);
            this.panel1.TabIndex = 3;
            // 
            // inheritableFlowLayoutPanel1
            // 
            this.inheritableFlowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.inheritableFlowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.inheritableFlowLayoutPanel1.Name = "inheritableFlowLayoutPanel1";
            this.inheritableFlowLayoutPanel1.Size = new System.Drawing.Size(100, 630);
            this.inheritableFlowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(67, 20);
            this.miFile.Text = "ファイル(&F)";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.終了ToolStripMenuItem.Text = "終了(&X)";
            // 
            // FormMST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.inheritableFlowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMST";
            this.Text = "FormMST";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.inheritableFlowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        protected InheritableFlowLayoutPanel inheritableFlowLayoutPanel1;
    }
}
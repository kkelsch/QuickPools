namespace QuickPools
{
    partial class PoolSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolSheet));
            this.tabPoolCollection = new System.Windows.Forms.TabControl();
            this.psMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPoolCollection
            // 
            this.tabPoolCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPoolCollection.Location = new System.Drawing.Point(0, 24);
            this.tabPoolCollection.Name = "tabPoolCollection";
            this.tabPoolCollection.SelectedIndex = 0;
            this.tabPoolCollection.Size = new System.Drawing.Size(956, 562);
            this.tabPoolCollection.TabIndex = 0;
            // 
            // psMenuStrip
            // 
            this.psMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.psMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.psMenuStrip.Name = "psMenuStrip";
            this.psMenuStrip.Size = new System.Drawing.Size(956, 24);
            this.psMenuStrip.TabIndex = 1;
            this.psMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateSelectedPoolToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // duplicateSelectedPoolToolStripMenuItem
            // 
            this.duplicateSelectedPoolToolStripMenuItem.Name = "duplicateSelectedPoolToolStripMenuItem";
            this.duplicateSelectedPoolToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.duplicateSelectedPoolToolStripMenuItem.Text = "Duplicate Selected Pool";
            this.duplicateSelectedPoolToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedPoolToolStripMenuItem_Click);
            // 
            // PoolSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 586);
            this.Controls.Add(this.tabPoolCollection);
            this.Controls.Add(this.psMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PoolSheet";
            this.Text = "PoolSheet";
            this.Load += new System.EventHandler(this.PoolSheet_Load);
            this.psMenuStrip.ResumeLayout(false);
            this.psMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPoolCollection;
        private System.Windows.Forms.MenuStrip psMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedPoolToolStripMenuItem;

    }
}

namespace trInit {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.MenuItem = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTrInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTrInitRun = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpViewReadme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpViewWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItem
            // 
            this.MenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemTrInit,
            this.MenuItemHelp});
            this.MenuItem.Location = new System.Drawing.Point(0, 0);
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(800, 24);
            this.MenuItem.TabIndex = 0;
            this.MenuItem.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemTrInit
            // 
            this.MenuItemTrInit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTrInitRun});
            this.MenuItemTrInit.Name = "MenuItemTrInit";
            this.MenuItemTrInit.Size = new System.Drawing.Size(44, 20);
            this.MenuItemTrInit.Text = "trInit";
            this.MenuItemTrInit.ToolTipText = "trInit Core";
            // 
            // MenuItemTrInitRun
            // 
            this.MenuItemTrInitRun.Name = "MenuItemTrInitRun";
            this.MenuItemTrInitRun.Size = new System.Drawing.Size(180, 22);
            this.MenuItemTrInitRun.Text = "Run...";
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelpAbout,
            this.MenuItemHelpView,
            this.toolStripSeparator1,
            this.MenuItemHelpVersion});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp.Text = "Help";
            // 
            // MenuItemHelpAbout
            // 
            this.MenuItemHelpAbout.Name = "MenuItemHelpAbout";
            this.MenuItemHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHelpAbout.Text = "About";
            this.MenuItemHelpAbout.Click += new System.EventHandler(this.MenuItemHelpAbout_Click);
            // 
            // MenuItemHelpView
            // 
            this.MenuItemHelpView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelpViewReadme,
            this.MenuItemHelpViewWebsite});
            this.MenuItemHelpView.Name = "MenuItemHelpView";
            this.MenuItemHelpView.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHelpView.Text = "View...";
            // 
            // MenuItemHelpViewReadme
            // 
            this.MenuItemHelpViewReadme.Name = "MenuItemHelpViewReadme";
            this.MenuItemHelpViewReadme.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHelpViewReadme.Text = "README.txt";
            // 
            // MenuItemHelpViewWebsite
            // 
            this.MenuItemHelpViewWebsite.Name = "MenuItemHelpViewWebsite";
            this.MenuItemHelpViewWebsite.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHelpViewWebsite.Text = "Website";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemHelpVersion
            // 
            this.MenuItemHelpVersion.Name = "MenuItemHelpVersion";
            this.MenuItemHelpVersion.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHelpVersion.Text = "Version Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuItem);
            this.HelpButton = true;
            this.MainMenuStrip = this.MenuItem;
            this.Name = "Form1";
            this.Text = "Window - trInit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuItem.ResumeLayout(false);
            this.MenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTrInit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTrInitRun;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpViewReadme;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpViewWebsite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpVersion;
    }
}


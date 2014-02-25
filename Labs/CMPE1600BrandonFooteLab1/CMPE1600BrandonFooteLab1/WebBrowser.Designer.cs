namespace CMPE1600BrandonFooteLab1
{
    partial class frmWebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebBrowser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnBackButton = new System.Windows.Forms.ToolStripButton();
            this.tsbtnForwardButton = new System.Windows.Forms.ToolStripButton();
            this.tslblAddress = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnGoButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbxBookmarks = new System.Windows.Forms.ListBox();
            this.wbbBrowserWindow = new System.Windows.Forms.WebBrowser();
            this.tsbtnHomeButton = new System.Windows.Forms.ToolStripButton();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.bookmarksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookmarkToolStripMenuItem,
            this.removeBookmarkToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            // 
            // addBookmarkToolStripMenuItem
            // 
            this.addBookmarkToolStripMenuItem.Name = "addBookmarkToolStripMenuItem";
            this.addBookmarkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addBookmarkToolStripMenuItem.Text = "Add Bookmark";
            this.addBookmarkToolStripMenuItem.Click += new System.EventHandler(this.addBookmarkToolStripMenuItem_Click);
            // 
            // removeBookmarkToolStripMenuItem
            // 
            this.removeBookmarkToolStripMenuItem.Name = "removeBookmarkToolStripMenuItem";
            this.removeBookmarkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeBookmarkToolStripMenuItem.Text = "Remove Bookmark";
            this.removeBookmarkToolStripMenuItem.Click += new System.EventHandler(this.removeBookmarkToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnHomeButton,
            this.tsbtnBackButton,
            this.tsbtnForwardButton,
            this.tslblAddress,
            this.toolStripComboBox1,
            this.tsbtnGoButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnBackButton
            // 
            this.tsbtnBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBackButton.Name = "tsbtnBackButton";
            this.tsbtnBackButton.Size = new System.Drawing.Size(27, 22);
            this.tsbtnBackButton.Tag = "Back";
            this.tsbtnBackButton.Text = "<<";
            this.tsbtnBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtnBackButton.ToolTipText = "Move back one page";
            this.tsbtnBackButton.Click += new System.EventHandler(this.tsbtnBackButton_Click);
            // 
            // tsbtnForwardButton
            // 
            this.tsbtnForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnForwardButton.Image")));
            this.tsbtnForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnForwardButton.Name = "tsbtnForwardButton";
            this.tsbtnForwardButton.Size = new System.Drawing.Size(27, 22);
            this.tsbtnForwardButton.Text = ">>";
            this.tsbtnForwardButton.ToolTipText = "Move forward one page";
            this.tsbtnForwardButton.Click += new System.EventHandler(this.tsbtnForwardButton_Click);
            // 
            // tslblAddress
            // 
            this.tslblAddress.Name = "tslblAddress";
            this.tslblAddress.Size = new System.Drawing.Size(52, 22);
            this.tslblAddress.Text = "Address:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.MaxDropDownItems = 100;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(600, 25);
            this.toolStripComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox1_KeyDown);
            // 
            // tsbtnGoButton
            // 
            this.tsbtnGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnGoButton.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGoButton.Image")));
            this.tsbtnGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGoButton.Name = "tsbtnGoButton";
            this.tsbtnGoButton.Size = new System.Drawing.Size(26, 22);
            this.tsbtnGoButton.Text = "Go";
            this.tsbtnGoButton.ToolTipText = "Navigate to selected URL";
            this.tsbtnGoButton.Click += new System.EventHandler(this.tsbtnGoButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lstbxBookmarks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wbbBrowserWindow);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 513);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bookmarks";
            // 
            // lstbxBookmarks
            // 
            this.lstbxBookmarks.FormattingEnabled = true;
            this.lstbxBookmarks.Location = new System.Drawing.Point(3, 21);
            this.lstbxBookmarks.Name = "lstbxBookmarks";
            this.lstbxBookmarks.Size = new System.Drawing.Size(163, 485);
            this.lstbxBookmarks.TabIndex = 0;
            // 
            // wbbBrowserWindow
            // 
            this.wbbBrowserWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbbBrowserWindow.Location = new System.Drawing.Point(0, 0);
            this.wbbBrowserWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbbBrowserWindow.Name = "wbbBrowserWindow";
            this.wbbBrowserWindow.Size = new System.Drawing.Size(1007, 511);
            this.wbbBrowserWindow.TabIndex = 0;
            this.wbbBrowserWindow.Url = new System.Uri("http://www.nait.ca", System.UriKind.Absolute);
            this.wbbBrowserWindow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbbBrowserWindow_DocumentCompleted);
            // 
            // tsbtnHomeButton
            // 
            this.tsbtnHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHomeButton.Image")));
            this.tsbtnHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHomeButton.Name = "tsbtnHomeButton";
            this.tsbtnHomeButton.Size = new System.Drawing.Size(44, 22);
            this.tsbtnHomeButton.Text = "Home";
            this.tsbtnHomeButton.Click += new System.EventHandler(this.tsbtnHomeButton_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // frmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmWebBrowser";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.frmWebBrowser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnBackButton;
        private System.Windows.Forms.ToolStripButton tsbtnForwardButton;
        private System.Windows.Forms.ToolStripLabel tslblAddress;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser wbbBrowserWindow;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnGoButton;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookmarkToolStripMenuItem;
        private System.Windows.Forms.ListBox lstbxBookmarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton tsbtnHomeButton;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;

    }
}


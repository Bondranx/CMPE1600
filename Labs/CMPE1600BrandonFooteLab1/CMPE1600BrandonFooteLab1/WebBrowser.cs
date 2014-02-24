using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteLab1
{
    public struct Bookmark
    {
        public string _SiteName;
        public Uri _URL;

        public Bookmark(string SiteName, Uri URL)
        {
            _SiteName = SiteName;
            _URL = URL;
        }
        public override string ToString()
        {
            return string.Format(_URL.ToString());
        }
    }
    public partial class frmWebBrowser : Form
    {

        public List<Bookmark> Bookmarks = new List<Bookmark>();


        public frmWebBrowser()
        {
            InitializeComponent();
        }

        private void tsbtnBackButton_Click(object sender, EventArgs e)
        {
            wbbBrowserWindow.GoBack();
        }

        private void tsbtnGoButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://" + tstbxAddressBar.Text);
            wbbBrowserWindow.Url = uri;
        }

        private void tstbxAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Uri uri = new Uri("http://" + tstbxAddressBar.Text);
                wbbBrowserWindow.Url = uri;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmark newBookmark = new Bookmark(wbbBrowserWindow.DocumentTitle, wbbBrowserWindow.Url);
            Bookmarks.Add(newBookmark);
            lstbxBookmarks.Items.Add(newBookmark._SiteName);
        }

        private void wbbBrowserWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = wbbBrowserWindow.DocumentTitle;
        }

        private void tsbtnForwardButton_Click(object sender, EventArgs e)
        {
            wbbBrowserWindow.GoForward();
        }
    }
}

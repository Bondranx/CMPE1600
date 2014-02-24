using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; 

namespace CMPE1600BrandonFooteLab1
{
    [Serializable]
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
    [Serializable]
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

            try
            {
                FileStream newBookmarks = new FileStream("Bookmarks.bin", FileMode.Append, FileAccess.Write);
                BinaryFormatter fileCreater = new BinaryFormatter();

                fileCreater.Serialize(newBookmarks, Bookmarks);
                newBookmarks.Close();
            }
            catch (Exception i)
            {
                Console.WriteLine(i);
            }
        }

        private void wbbBrowserWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = wbbBrowserWindow.DocumentTitle;
        }

        private void tsbtnForwardButton_Click(object sender, EventArgs e)
        {
            wbbBrowserWindow.GoForward();
        }

        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream readBookmarks = new FileStream("Bookmarks.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter reader = new BinaryFormatter();
                Bookmarks = (List<Bookmark>)reader.Deserialize(readBookmarks);
                readBookmarks.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BinaryReaderExample");
            }
            foreach (Bookmark i in Bookmarks)
            {
                lstbxBookmarks.Items.Add(i._SiteName);
            }
        }

    }
}

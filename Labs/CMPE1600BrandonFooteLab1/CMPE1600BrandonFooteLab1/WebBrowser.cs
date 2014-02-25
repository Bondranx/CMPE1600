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
        //Public list structure to store user defined bookmarks
        public List<Bookmark> Bookmarks = new List<Bookmark>();

        
        public void Bookmarking()
        {
            try
            {
                FileStream newBookmarks = new FileStream("Bookmarks.bin", FileMode.Create, FileAccess.Write);
                BinaryFormatter fileCreater = new BinaryFormatter();

                fileCreater.Serialize(newBookmarks, Bookmarks);
                newBookmarks.Close();
            }
            catch (Exception i)
            {
                Console.WriteLine(i);
            }
        }

        public frmWebBrowser()
        {
            //Initializes form
            InitializeComponent();
        }

        private void tsbtnBackButton_Click(object sender, EventArgs e)
        {
            //returns user to last page visited, if possible
            wbbBrowserWindow.GoBack();
        }

        private void tsbtnForwardButton_Click(object sender, EventArgs e)
        {
            //Sends user forward to the previous page, if available
            wbbBrowserWindow.GoForward();
        }       
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes program if menu option selected
            Application.Exit();
        }
        private void tsbtnGoButton_Click(object sender, EventArgs e)
        {
            if (!wbbBrowserWindow.Url.ToString().Contains("https://"))
            {
                Uri uri = new Uri("http://" + toolStripComboBox1.Text);
                wbbBrowserWindow.Url = uri;
            }
            else
            {
                Uri uri = new Uri(toolStripComboBox1.Text);
                wbbBrowserWindow.Url = uri;
            }
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmark newBookmark = new Bookmark(wbbBrowserWindow.DocumentTitle, wbbBrowserWindow.Url);
            
            Bookmarks.Add(newBookmark);
            lstbxBookmarks.Items.Add(newBookmark._SiteName);

            Bookmarking();
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
                Console.WriteLine(ex);
            }
            foreach (Bookmark i in Bookmarks)
            {
                lstbxBookmarks.Items.Add(i._SiteName);
            }
            toolStripComboBox1.Text = "http://www.nait.ca";
            toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
        }

        private void removeBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbxBookmarks.SelectedIndex >= 0)
            {
                Bookmarks.RemoveAt(lstbxBookmarks.SelectedIndex);
                Bookmarking();
                lstbxBookmarks.Items.RemoveAt(lstbxBookmarks.SelectedIndex);
            }
        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Uri uri = new Uri("http://" + toolStripComboBox1.Text);
                    wbbBrowserWindow.Url = uri;
                }
                catch (Exception i)
                {
                    MessageBox.Show("That is an invalid URL", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
        }

        private void tsbtnHomeButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.nait.ca");
            wbbBrowserWindow.Url = uri;
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstbxBookmarks.Items.Clear();
            Bookmarks.Clear();
            Bookmarking();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uri uri = new Uri(toolStripComboBox1.SelectedItem.ToString());
            wbbBrowserWindow.Url = uri;
        }

        private void wbbBrowserWindow_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            int index = 0;
            if (!wbbBrowserWindow.Url.ToString().Contains("http://www.nait.ca") && !toolStripComboBox1.Items.Contains(wbbBrowserWindow.Url))
            {
                this.Text = wbbBrowserWindow.DocumentTitle;
                toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
                toolStripComboBox1.Items.Insert(0, wbbBrowserWindow.Url);
            }
            if (toolStripComboBox1.Items.Contains(wbbBrowserWindow.Url) == true)
            {
                index = toolStripComboBox1.Items.IndexOf(wbbBrowserWindow.Url);
                toolStripComboBox1.Items.RemoveAt(index);
                toolStripComboBox1.Items.Insert(0, wbbBrowserWindow.Url);
            }
            
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            wbbBrowserWindow.Refresh();
        }

        private void tsbtnStop_Click(object sender, EventArgs e)
        {
            wbbBrowserWindow.Stop();
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.gmail.com");
            wbbBrowserWindow.Url = uri;
        }

        private void hotmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.hotmail.com");
            wbbBrowserWindow.Url = uri;
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.facebook.com");
            wbbBrowserWindow.Url = uri;
        }

    }
}

//***********************************************************************************
//Program: WebBrowser.cs
//Description: A functional program that can be used to browse the web
//Date: Feb. 28, 2013
//Author: Brandon Foote
//Course: CNT1600
//Class: CNT 2D
//***********************************************************************************

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

        //********************************************************************************************
        //Method: public void Bookmarking(
        //Purpose: Adds bookmarks to a list and saves the list to a file when a bookmark is added
        //Parameters: None
        //Returns: Nothing
        //*********************************************************************************************
        public void Bookmarking()
        {
            try
            {
                //Opens a Filestream and creates a new binary file named 'Bookmarks.bin'
                FileStream newBookmarks = new FileStream("Bookmarks.bin", FileMode.Create, FileAccess.Write);
                //Creates a Binary formatter to write to the filestream
                BinaryFormatter fileCreater = new BinaryFormatter();

                //Serializes a list of bookmarks to the file specified by the filestream
                fileCreater.Serialize(newBookmarks, Bookmarks);
                //CLoses the filestream
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

        //********************************************************************************************
        //Method: private void tsbtnBackButton_Click(object sender, EventArgs e)
        //Purpose: Takes the user back one web page when back button is clicked (Event handler)
        //*********************************************************************************************
        private void tsbtnBackButton_Click(object sender, EventArgs e)
        {
            //returns user to last page visited, if possible
            wbbBrowserWindow.GoBack();
        }

        //********************************************************************************************
        //Method: tsbtnForwardButton_Click(object sender, EventArgs e)
        //Purpose: Takes the user forward one web page when forward button is clicked (Event handler)
        //*********************************************************************************************
        private void tsbtnForwardButton_Click(object sender, EventArgs e)
        {
            //Sends user forward to the previous page, if available
            wbbBrowserWindow.GoForward();
        }

        //********************************************************************************************
        //Method: exitToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Closes the program when Exit option is selected (Event handler)
        //*********************************************************************************************
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes program if menu option selected
            Application.Exit();
        }

        //********************************************************************************************
        //Method: tsbtnGoButton_Click(object sender, EventArgs e)
        //Purpose: Navigates to web page defined by user in the address bar when go button is clicked (Event handler)
        //*********************************************************************************************
        private void tsbtnGoButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(toolStripComboBox1.Text);
            //Navigates to specified URL
            wbbBrowserWindow.Url = uri;
        }

        //********************************************************************************************
        //Method: addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Adds the selected web page to the list of bookmarks when clicked (Event handler)
        //*********************************************************************************************
        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmark newBookmark = new Bookmark(tbxBookmarkName.Text, wbbBrowserWindow.Url);
            
            //Adds a new bookmark to the list of stored bookmarks
            Bookmarks.Add(newBookmark);
            //Adds new bookmark to the listbox display
            lstbxBookmarks.Items.Add(newBookmark._SiteName);

            //Saves list of bookmarks to the file using bookmarking method
            Bookmarking();
            tbxBookmarkName.Text = null;
            btnAddBookmark.Enabled = false;
            addBookmarkToolStripMenuItem.Enabled = false;
        }

        //********************************************************************************************
        //Method: frmWebBrowser_Load(object sender, EventArgs e)
        //Purpose: Loads the WebBrowser form when the program is loaded (Event handler)
        //*********************************************************************************************
        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                //Read a list of bookmarks from a predefined file
                FileStream readBookmarks = new FileStream("Bookmarks.bin", FileMode.Open, FileAccess.Read);
                //Reads binary list of bookmarks
                BinaryFormatter reader = new BinaryFormatter();
                //Stores bookmarks in a list of bookmark objects
                Bookmarks = (List<Bookmark>)reader.Deserialize(readBookmarks);
                //closes bookmarks filestream
                readBookmarks.Close();
            }
            catch (Exception ex)
            {
                //catches and diplay any bookmark reading errors
                Console.WriteLine(ex);
            }
            foreach (Bookmark i in Bookmarks)
            {
                //displays all bookmarks to the bookmarks list
                lstbxBookmarks.Items.Add(i._SiteName);
            }
            toolStripComboBox1.Text = "http://www.nait.ca/";
            toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
        }

        //********************************************************************************************
        //Method: removeBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Removes selected bookmark from the bookmark list when (Event handler)
        //*********************************************************************************************
        private void removeBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbxBookmarks.SelectedIndex >= 0)
            {
                //Removes selected bookmark from thelist of bookmarks
                Bookmarks.RemoveAt(lstbxBookmarks.SelectedIndex);
                //Saves updated list of bookmarks
                Bookmarking();
                //Removes bookmark from listbox
                lstbxBookmarks.Items.RemoveAt(lstbxBookmarks.SelectedIndex);
            }
        }

        //********************************************************************************************
        //Method: toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        //Purpose: Navigates to web site defined by user in address bar when enter key is pressed (Event handler)
        //*********************************************************************************************
        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Checks if user presed enter key
            if (e.KeyCode == Keys.Enter)
            {
                //stores URL as a Uri variable
                Uri temp = new Uri("http://" + toolStripComboBox1.Text);
                //Checks if webbrowser is currently on selected URL
                if (wbbBrowserWindow.Url != temp)
                {
                    //Displays URL as a tring in the combo box
                    try
                    {
                        Uri uri = new Uri("http://" + toolStripComboBox1.Text);
                        wbbBrowserWindow.Url = uri;
                        toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("That is an invalid URL", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Displays URL in the combo box
                    toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
                }
            }
        }

        //********************************************************************************************
        //Method: clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Clears current browser history from the address bar drop down (Event handler)
        //*********************************************************************************************
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears all visited pages from the combo box
            toolStripComboBox1.Items.Clear();
        }

        //********************************************************************************************
        //Method: tsbtnHomeButton_Click(object sender, EventArgs e)
        //Purpose: Returns user to home page when Home button is clicked (Event handler)
        //*********************************************************************************************
        private void tsbtnHomeButton_Click(object sender, EventArgs e)
        {
            //Predefined page for home page
            Uri uri = new Uri("http://www.nait.ca");
            wbbBrowserWindow.Url = uri;
        }

        //********************************************************************************************
        //Method: clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Clears all bookmarks from the list box display and from stored bookmarks when clicked (Event handler)
        //*********************************************************************************************
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears all bookmarks from the list of bookmarks
            lstbxBookmarks.Items.Clear();
            //Clears all bookmarks from the Bookmarks listbox
            Bookmarks.Clear();
            //Saves updated bookmarks list
            Bookmarking();
        }

        //********************************************************************************************
        //Method: toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //Purpose: Navigates to defined page in browser history when a stored web page is selected (Event handler)
        //*********************************************************************************************
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uri temp = new Uri(toolStripComboBox1.Text);
            if (wbbBrowserWindow.Url != temp)
            {
                Uri uri = new Uri(toolStripComboBox1.SelectedItem.ToString());
                wbbBrowserWindow.Url = uri;
                toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
            }
            else
            {
                toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
            }
        }

        //********************************************************************************************
        //Method: wbbBrowserWindow_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        //Purpose: Adds or removes items from the stored list of web pages in the address bar when a new page is navigated to (Event handler
        //*********************************************************************************************
        private void wbbBrowserWindow_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //web browser navigation error checking
            int index = 0;
            //Checks if browser URL is NOT homepage
            if (!wbbBrowserWindow.Url.ToString().Contains("http://www.nait.ca/"))
            {
                //Sets current web page name as the form name
                this.Text = wbbBrowserWindow.DocumentTitle;
                //Sets browser window URL as the diplayed combo box item
                toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
                //Inserts current page URL into the combo box items
                toolStripComboBox1.Items.Insert(0, wbbBrowserWindow.Url);
            }
            //Checks if web browser URL is NOT currently in the combo box items
            if (!toolStripComboBox1.Items.Contains(wbbBrowserWindow.Url))
            {
                //Sets current web page name as the form name
                this.Text = wbbBrowserWindow.DocumentTitle;
                //Sets browser window URL as the diplayed combo box item
                toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
                //Inserts current page URL into the combo box items
                toolStripComboBox1.Items.Insert(0, wbbBrowserWindow.Url);
            }
            //Checks if web browser URL IS in the combo box items
            if (toolStripComboBox1.Items.Contains(wbbBrowserWindow.Url) == true)
            {
                //Sets currwnt web age name as the form name
                this.Text = wbbBrowserWindow.DocumentTitle;
                //Finds index of previous instance of this items in combo box
                index = toolStripComboBox1.Items.IndexOf(wbbBrowserWindow.Url);
                //Removes previous instance of this item from the combo box
                toolStripComboBox1.Items.RemoveAt(index);
                //Insterts new instance of item at the top of the combo box items
                toolStripComboBox1.Items.Insert(0, wbbBrowserWindow.Url);
                //Sets browser window URL as the diplayed combo box item
                toolStripComboBox1.Text = wbbBrowserWindow.Url.ToString();
            }
            
            
        }

        //********************************************************************************************
        //Method: tsbtnRefresh_Click(object sender, EventArgs e)
        //Purpose: Refreshes the current web page when the refresh button is clicked (Event handler)
        //*********************************************************************************************
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            //Refreshes the current web page
            wbbBrowserWindow.Refresh();
        }
        
        //********************************************************************************************
        //Method: tsbtnStop_Click(object sender, EventArgs e)
        //Purpose: Stops all actions on current web page when stop button is clicked. (Event handler)
        //*********************************************************************************************
        private void tsbtnStop_Click(object sender, EventArgs e)
        {
            //Stop all events on current page
            wbbBrowserWindow.Stop();
        }

        //********************************************************************************************
        //Method: gmailToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Navigates to www.gmail.com when Gmail is clicked (Event handler)
        //*********************************************************************************************
        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.gmail.com");
            wbbBrowserWindow.Url = uri;
        }

        //********************************************************************************************
        //Method: hotmailToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Navigates to www.hotmail.com when hotmail button is clicked (Event handler)
        //*********************************************************************************************
        private void hotmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.hotmail.com");
            wbbBrowserWindow.Url = uri;
        }

        //********************************************************************************************
        //Method: facebookToolStripMenuItem_Click(object sender, EventArgs e)
        //Purpose: Navigates to www.facebook.com when faqcebook button is clicked (Event handler)
        //*********************************************************************************************
        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.facebook.com");
            wbbBrowserWindow.Url = uri;
        }

        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            if (tbxBookmarkName.Text != null && tbxBookmarkName.Text != "")
            {
                btnAddBookmark.Enabled = true;
                addBookmarkToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnAddBookmark.Enabled = false;
                addBookmarkToolStripMenuItem.Enabled = false;
            }

            Bookmark newBookmark = new Bookmark(tbxBookmarkName.Text, wbbBrowserWindow.Url);

            //Adds a new bookmark to the list of stored bookmarks
            Bookmarks.Add(newBookmark);
            //Adds new bookmark to the listbox display
            lstbxBookmarks.Items.Add(newBookmark._SiteName);

            //Saves list of bookmarks to the file using bookmarking method
            Bookmarking();
            tbxBookmarkName.Text = null;
            btnAddBookmark.Enabled = false;
            addBookmarkToolStripMenuItem.Enabled = false;
        }

        private void tbxBookmarkName_TextChanged(object sender, EventArgs e)
        {
            if (tbxBookmarkName.Text != null && tbxBookmarkName.Text != "")
            {
                btnAddBookmark.Enabled = true;
                addBookmarkToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnAddBookmark.Enabled = false;
                addBookmarkToolStripMenuItem.Enabled = false;
            }
        }

        private void lstbxBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstbxBookmarks.SelectedIndex == 1)
                wbbBrowserWindow.Url = Bookmarks[(lstbxBookmarks.SelectedIndex)]._URL;
        }
    }
}

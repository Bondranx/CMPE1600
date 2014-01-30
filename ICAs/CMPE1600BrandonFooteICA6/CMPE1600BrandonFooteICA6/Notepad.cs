using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CMPE1600BrandonFooteICA6
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                this.Text = ofdOpen.SafeFileName;
                StreamReader SROpen;
                try
                {
                    SROpen = new StreamReader(ofdOpen.FileName);
                    tbxMain.Text = SROpen.ReadToEnd();
                    SROpen.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = null;
            string[] FilePath = null;
            sfdSaveAs.Filter = "Text Files (.txt)|*.txt";
            if (sfdSaveAs.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SRWrite;
                FileName = sfdSaveAs.FileName;
                FilePath = FileName.Split('\\');
                Text = FilePath[FilePath.Length - 1];
                try
                {
                    SRWrite = new StreamWriter(sfdSaveAs.FileName );
                    SRWrite.Write(tbxMain.Text);
                    SRWrite.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}

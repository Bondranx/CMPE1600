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
    public partial class frmNotepad : Form
    {
        bool exit = false;
        bool saved = false;
        public void Saving()
        {
            if (sfdSaveAs.ShowDialog() == DialogResult.OK)
            {
                string FileName = null;
                string[] FilePath = null;
                sfdSaveAs.Filter = "Text Files (.txt)|*.txt";
                StreamWriter SRWrite;
                FileName = sfdSaveAs.FileName;
                FilePath = FileName.Split('\\');
                Text = FilePath[FilePath.Length - 1];
                try
                {
                    SRWrite = new StreamWriter(sfdSaveAs.FileName);
                    SRWrite.Write(tbxMain.Text);
                    SRWrite.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                saved = true;
            }
        }
        public frmNotepad()
        {
            InitializeComponent();
            saved = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = new DialogResult();
            if (saved == true)
            {
                tbxMain.Text = "";
                Text = "new.txt";
                saved = true;
            }
            else
            {
                Result = MessageBox.Show("You have not saved your work would you like to save?", "Work not saved",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(Result == DialogResult.OK)
                {
                    Saving();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = new DialogResult();
            if(saved == true)
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
                    saved = false;
                }
                else if (saved == false)
                {
                    Result = MessageBox.Show("You have not saved your work would you like to save?", "Work not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result == DialogResult.OK)
                    {
                        Saving();
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saving(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = new DialogResult();
            Result = MessageBox.Show("You have not saved your work would you like to save?", "Work not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.OK)
            {
                Saving();
            }
            exit = true;
            Application.Exit();
            
        }

        private void frmNotepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit == false)
            {
                DialogResult Result = new DialogResult();
                Result = MessageBox.Show("You have not saved your work would you like to save?", "Work not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                {
                    Saving();
                }
            }
        }
        
    }
}

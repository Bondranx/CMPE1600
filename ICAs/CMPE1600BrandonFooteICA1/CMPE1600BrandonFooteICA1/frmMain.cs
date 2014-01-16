using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA1
{
    public partial class frmMain : Form
    {   
        private int count = 1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form1 has loaded");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form1 has been shown");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            System.Diagnostics.Trace.WriteLine("Form1 was painted");
            Text = "frmMain Paints: " + count.ToString();
            count++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form1 is closing");
            e.Cancel = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form1 has closed");
        }
    }
}


//1) Form is constructed, form loads, form is painted,
//2) Uncovering a covered window, making the window larger in any direction
//3) set e.Cancel equal to true
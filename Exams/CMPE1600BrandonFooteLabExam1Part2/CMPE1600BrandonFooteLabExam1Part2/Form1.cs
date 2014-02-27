using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteLabExam1Part2
{
    public partial class Form1 : Form
    {
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            tmrAdd.Interval = 1000;
            tmrAdd.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            tmrAdd.Enabled = false;
            count = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstbxCount.Items.Clear();
            lblDisplay.Visible = false;
        }

        private void tmrAdd_Tick(object sender, EventArgs e)
        {
            count += 1;
            lstbxCount.Items.Add(count + " seconds");
        }

        private void lstbxCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplay.Visible = true;
            lblDisplay.Text = lstbxCount.SelectedItem.ToString();
        }
    }
}

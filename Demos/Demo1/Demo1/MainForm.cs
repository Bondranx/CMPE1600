using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button!");
            lblText.Visible = true;
            tbText.Text = "You follow directions well.";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("I am loading. BOW BEFORE ZOD!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

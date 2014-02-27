using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600LabExam1Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius = 0;
            if(!double.TryParse(tbxRadius.Text, out radius))
            {
                MessageBox.Show("You must input a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdbtnCircumference.Checked == true)
                {
                    double.TryParse(tbxRadius.Text, out radius);
                    lblResultDisplay.Text = (2 * Math.PI * radius).ToString();
                    lblResultDisplay.Visible = true;
                }
                if (rdbtnArea.Checked == true)
                {
                    double.TryParse(tbxRadius.Text, out radius);
                    lblResultDisplay.Text = (Math.PI * (radius * radius)).ToString();
                    lblResultDisplay.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbtnCircumference.Checked = true;
            tbxRadius.Focus();
        }

        private void tbxRadius_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double radius = 0;
                if (!double.TryParse(tbxRadius.Text, out radius))
                {
                    MessageBox.Show("You must input a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rdbtnCircumference.Checked == true)
                    {
                        double.TryParse(tbxRadius.Text, out radius);
                        lblResultDisplay.Text = (2 * Math.PI * radius).ToString();
                        lblResultDisplay.Visible = true;
                    }
                    if (rdbtnArea.Checked == true)
                    {
                        double.TryParse(tbxRadius.Text, out radius);
                        lblResultDisplay.Text = (Math.PI * (radius * radius)).ToString();
                        lblResultDisplay.Visible = true;
                    }
                }
            }
        }


    }
}

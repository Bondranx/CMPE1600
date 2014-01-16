using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA2
{
    public partial class frmMain : Form
    {
        private int hoursWorked = 0;
        private int hourlyRate = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbxHourlyRate_TextChanged(object sender, EventArgs e)
        {
            lblOvertimeHoursOutput.Text = "0.0";
            lblRegHoursOutput.Text = "0.0";
            lblPayDueTotal.Text = "$0.00";
            lblRegPayTotal.Text = "$0.00";
            lblOvertimePayTotal.Text = "$0.00";
        }

        private void lbxHourlyRate_TextChanged(object sender, EventArgs e)
        {
            lblOvertimeHoursOutput.Text = "0.0";
            lblRegHoursOutput.Text = "0.0";
            lblPayDueTotal.Text = "$0.00";
            lblRegPayTotal.Text = "$0.00";
            lblOvertimePayTotal.Text = "$0.00";
        }
    }
}

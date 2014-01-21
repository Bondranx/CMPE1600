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
            if (tbxHourlyRate.Text == "" && tbxHoursWorked.Text == "")
                btnCalculate.Enabled = false;
            else
                btnCalculate.Enabled = true;
        }

        private void lbxHourlyRate_TextChanged(object sender, EventArgs e)
        {
            lblOvertimeHoursOutput.Text = "0.0";
            lblRegHoursOutput.Text = "0.0";
            lblPayDueTotal.Text = "$0.00";
            lblRegPayTotal.Text = "$0.00";
            lblOvertimePayTotal.Text = "$0.00";
            if (tbxHourlyRate.Text == "" && tbxHoursWorked.Text == "")
                btnCalculate.Enabled = false;
            else
                btnCalculate.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int hoursWorked = 0;
            int regHours = 0;
            int hourlyRate = 0;
            int totalPay = 0;
            int overtimeHours = 0;
            int totalHourlyPay = 0;
            bool workedInput = false;
            bool rateInput = false;
            workedInput = int.TryParse(tbxHoursWorked.Text, out hoursWorked);
            rateInput = int.TryParse(tbxHourlyRate.Text, out hourlyRate);
            if (workedInput == false)
            {
                MessageBox.Show("Invalid hours worked input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rateInput == false)
            {
                MessageBox.Show("Invalid hourly rate value.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hoursWorked < 40)
                {
                    regHours = hoursWorked;
                    overtimeHours = 0;
                    totalPay = totalHourlyPay;
                }
                else
                {
                    regHours = 40;
                    overtimeHours = hoursWorked - 40;
                }

                lblRegHoursOutput.Text = regHours.ToString();
                lblOvertimeHoursOutput.Text = overtimeHours.ToString();
                lblRegPayTotal.Text = (regHours * hourlyRate).ToString();
                lblOvertimePayTotal.Text = (overtimeHours * (hourlyRate * 1.5)).ToString();
                lblPayDueTotal.Text = ((regHours * hourlyRate) + (overtimeHours * (hourlyRate * 1.5))).ToString();
            }
        }
    }
}

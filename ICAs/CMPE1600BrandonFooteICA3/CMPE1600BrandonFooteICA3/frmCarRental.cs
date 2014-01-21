using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA3
{
    public partial class frmCarRental : Form
    {
        public double finalTotal = 0;
        public double carCost = 0;
        public double discount = 0;
        public double insurance = 0;
        public double numOfDays = 0;
        public double Calculate (double cost, double discount, double insurance, double numOfDays)
        {
            double finalTotal = (cost + insurance) * numOfDays - discount;
            return finalTotal;
        }
        public frmCarRental()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                gbxCarType.Enabled = true;
                rdbSmallCar.Enabled = true;
                rdbMediumCar.Enabled = true;
                rdbSportsCar.Enabled = true;
                chbInsurance.Enabled = true;
                chbDiscount.Enabled = true;
                lblNumOfDays.Enabled = true;
                nudNumOfDays.Enabled = true;
                lblTotal.Enabled = true;
                lblFinalTotal.Enabled = true;
            }
        }

        private void rdbSmallCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSmallCar.Checked == true)
                carCost = 40;
            lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            if (chbDiscount.Checked == true)
            {
                discount = (carCost + insurance) * (double)nudNumOfDays.Value * .10;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            }
        }

        private void lblFinalTotal_Click(object sender, EventArgs e)
        {

        }

        private void rdbMediumCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMediumCar.Checked == true)
                carCost = 50;
            lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            if (chbDiscount.Checked == true)
            {
                discount = (carCost + insurance) * (double)nudNumOfDays.Value * .10;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            }
        }

        private void rdbSportsCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSportsCar.Checked == true)
                carCost = 60;
            lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            if (chbDiscount.Checked == true)
            {
                discount = (carCost + insurance) * (double)nudNumOfDays.Value * .10;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            }
        }

        private void chbInsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (chbInsurance.Checked == true)
            {
                insurance = 15;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
                if (chbDiscount.Checked == true)
                {
                    discount = (carCost + insurance) * (double)nudNumOfDays.Value * .10;
                    lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
                }
            }
            else
            {
                insurance = 0;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
                if (chbDiscount.Checked == true)
                {
                    discount = (carCost + insurance) * (double)nudNumOfDays.Value * .10;
                    lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
                }
            }
        }

        private void nudNumOfDays_ValueChanged(object sender, EventArgs e)
        {
            lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            if (chbDiscount.Checked == true)
            {
                discount = (carCost + insurance) * (double)nudNumOfDays.Value * .10;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            }
        }

        private void chbDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDiscount.Checked == true)
            {
                discount = (carCost + insurance) * (double)nudNumOfDays.Value * .10;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            }
            else
            {
                discount = 0;
                lblFinalTotal.Text = Calculate(carCost, discount, insurance, (double)nudNumOfDays.Value).ToString("C2");
            }
        }
    }
}

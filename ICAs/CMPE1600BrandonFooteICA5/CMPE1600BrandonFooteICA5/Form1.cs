using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA5
{
    public partial class Form1 : Form
    {
        string num = "";
        int number = 0;
        int count = 0;
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultsDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartButton_Click(object sender, EventArgs e)
        {
            number = 0;
            count = 0;
            num = "";
            tmrGame.Enabled = true;
            lblNumDisplay.Enabled = true;
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {

            tmrGame.Interval = 500;
            count++;
            lblNumDisplay.Text = generator.Next(0, 10).ToString();
            num += lblNumDisplay.Text;
            
            Console.WriteLine(number);

            if (count <= 3)
            {
                int.TryParse(num, out number);
            }
            else if (count >= 3)
            {
                tmrGame.Enabled = false;
                lblNumDisplay.Text = "";
            }
        }
    }
}

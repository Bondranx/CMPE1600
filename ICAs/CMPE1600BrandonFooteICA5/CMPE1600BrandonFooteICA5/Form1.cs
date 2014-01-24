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
        int waitCount = 0;
        int playerInput = 0;
        string num = "";
        int number = 0;
        int count = 0;
        int playerCounter = 0;
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
            pgbNumber.Value = 0;
            pgbInput.Value = 0;
            pgbClear.Value = 0;
            waitCount = 0;
            playerCounter = 0;
            number = 0;
            count = 0;
            num = "";
            tmrGame.Enabled = true;
            lblNumDisplay.Enabled = true;
            tmrGame.Interval = 500;
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            
            count++;
            lblNumDisplay.Text = generator.Next(0, 10).ToString();
            num += lblNumDisplay.Text;
            
            Console.WriteLine(number);

            if (count <= 3)
            {
                pgbNumber.Value++;
                int.TryParse(num, out number);
            }
            else if (count >= 3)
            {
                lblNumDisplay.Text = "";
                btnStartButton.Enabled = false;
                tbxUserInput.Enabled = true;
                playerCounter++;
                if (playerCounter <= 6)
                {
                    pgbInput.Value++;
                    Console.WriteLine(playerCounter);
                    tbxUserInput.Focus();
                    int.TryParse(tbxUserInput.Text, out playerInput);
                }
                else if (playerCounter >= 6)
                {
                    pgbClear.Value++;
                    if (playerInput == number)
                    {
                        lblResultsDisplay.Visible = true;
                        lblResultsDisplay.Text = "Correct! Computer's Number: " + number + ", Your Number: " + playerInput;
                    }
                    else
                    {
                        lblResultsDisplay.Visible = true;
                        lblResultsDisplay.Text = "Incorrect! Computer's Number: " + number + ", Your Number: " + playerInput;
                    }
                    waitCount++;
                    if (waitCount == 10)
                    {
                        pgbClear.Value = 10;
                        tmrGame.Enabled = false;
                        btnStartButton.Enabled = true;
                        lblResultsDisplay.Visible = false;
                        tbxUserInput.Clear();
                        tbxUserInput.Enabled = false;
                    }
                }
            }
        }
    }
}

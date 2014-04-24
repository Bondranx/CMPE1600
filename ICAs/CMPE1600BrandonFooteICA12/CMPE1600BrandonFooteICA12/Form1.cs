using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CMPE1600BrandonFooteICA12
{
    public delegate void newDelegate(int Passed);

    public partial class ICA12 : Form
    {
        public static int[] numberArray = new int[50000];
        public static int PassCount = 0;

        public ICA12()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random newRandom = new Random();
            int count = 0;
            for (int a = 0; a < 50000; a++)
            {
                numberArray[a] = newRandom.Next(0, 50001);
            }
            foreach (int value in numberArray)
            {
                lstbxNumbers.Items.Add(numberArray[count]);
                count ++;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(BubbleSort));
            newThread.Start();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstbxNumbers.Items.Clear();
            numberArray.Initialize();
        }

        public void BubbleSort()
        {
            int iPass = 0, 
            iScan = 0, 
            iTemp = 0;

            for (iPass = 0; iPass < numberArray.Length - 1; iPass++)
            {
                Invoke(new newDelegate(UpdateBar), PassCount);
                PassCount++;
                for (iScan = 0; iScan < numberArray.Length - 1; iScan++)
                {
                    if (numberArray[iScan] > numberArray[iScan + 1])
                    {
                        iTemp = numberArray[iScan];
                        numberArray[iScan] = numberArray[iScan + 1];
                        numberArray[iScan + 1] = iTemp;
                    }
                }
            }

            PassCount = 0;
            Invoke(new newDelegate(ClearList), PassCount);
            foreach (int value in numberArray)
            {
                Invoke(new newDelegate(Filling), PassCount);
                PassCount++;
            }

            Invoke(new newDelegate(UpdateButtons), PassCount);
            return;
        }

        public void UpdateBar(int CBPassed)
        {
            brgbrProgress.Value = CBPassed;
            btnClear.Enabled = false;
            btnGenerate.Enabled = false;
            btnSort.Enabled = false;

            lblProgress.Text = "Sorting...";
            lblProgress.Visible = true;
        }

        public void Filling(int CBPassed)
        {
            lstbxNumbers.Items.Add(numberArray[CBPassed]);
            brgbrProgress.Value = CBPassed;
            lblProgress.Text = "Filling Listbox";
            lblProgress.Visible = true;
        }

        public void ClearList(int CBPassed)
        {
            lstbxNumbers.Items.Clear();
            brgbrProgress.Value = CBPassed;
            brgbrProgress.Update();
        }

        public void UpdateButtons(int CBPassed)
        {
            btnClear.Enabled = true;
            btnGenerate.Enabled = true;
            btnSort.Enabled = true;
            brgbrProgress.Value = 0;
            brgbrProgress.Update();
            lblProgress.Text = "Done";
        }
    }
}

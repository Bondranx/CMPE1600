using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600LAB2TheGameOfLifeBrandonFoote
{
    public partial class Form1 : Form
    {
        public int count = 1;
        public static Random generator = new Random();  //Generates random nubmers where needed
        public static byte[,] lifeArrayOne = new byte[60, 80];
        public static int numberOfCells = 0;
        public static Color drawColor = new Color();
        public static int CycleSpeedRead = 200;
        public static CycleSpeed newCycleSpeed = new CycleSpeed();

        static void CreateLife(byte[,] lifeArray)
        {
            int count = 0;                  //Counting variable
            int heightPosition = 0;         //Holds a random height value
            int widthPosition = 0;          //Holds a random width valule
            //Generates random positions for 1000 cells
            for (int a = 0; a < numberOfCells; a++)
            {
                //Generates new values if there is already a cell in the specified index
                do
                {
                    heightPosition = generator.Next(1, lifeArray.GetLength(0) - 1);   //Generates a random height value
                    widthPosition = generator.Next(1, lifeArray.GetLength(1) - 1);    //Generates a random width value
                }
                while (lifeArray[heightPosition, widthPosition] == 1);
                //If loop evaluates that there is no cell in specified index, places a cell in that index
                lifeArray[heightPosition, widthPosition] = 1;
                //counts number of cells placed
                count++;
            }
        }

        public static void DisplayLife(CDrawer lifeField, byte[,] lifeArray)
        {
            //Loops once for each row in the array
            for (int a = 0; a < lifeArray.GetLength(0); a++)
            {
                //Loops once for each column in each row
                for (int b = 0; b < lifeArray.GetLength(1); b++)
                {
                    //Draws a live cell in specified location if index is 1
                    if (lifeArray[a, b] == 1)
                    {
                        lifeField.SetBBScaledPixel(b, a, drawColor);
                    }
                    //Draws a Dead cell in each index if index is 0
                    else if (lifeArray[a, b] == 0)
                    {
                        lifeField.SetBBScaledPixel(b, a, Color.Black);
                    }
                    //Draws a gray border around entire field
                    if (lifeArray[a, b] != 1 && lifeArray[a, b] != 0)
                    {
                        lifeField.SetBBScaledPixel(b, a, Color.Gray);
                    }
                }
            }
        }

        public static byte[,] CycleLife(byte[,] lifeArray)
        {
            //Generates the editable array
            byte[,] editedLifeArray = new byte[60, 80];

            //Loops once for each row in the array
            for (int a = 0; a < lifeArray.GetLength(0); a++)
            {
                //Loops once for each column in the row
                for (int b = 0; b < lifeArray.GetLength(1); b++)
                {
                    //Initializes the counting value
                    int count = 0;
                    //Determines if cell is in a valid location in the array
                    if (a > 0 && a < lifeArray.GetLength(0) - 1 && b > 0 && b < lifeArray.GetLength(1) - 1)
                    {
                        //determines if surrounding cells are alive and counts number of live surrounding cells
                        if (lifeArray[a - 1, b - 1] == 1)
                            count++;
                        if (lifeArray[a - 1, b] == 1)
                            count++;
                        if (lifeArray[a - 1, b + 1] == 1)
                            count++;
                        if (lifeArray[a, b - 1] == 1)
                            count++;
                        if (lifeArray[a, b + 1] == 1)
                            count++;
                        if (lifeArray[a + 1, b - 1] == 1)
                            count++;
                        if (lifeArray[a + 1, b] == 1)
                            count++;
                        if (lifeArray[a + 1, b + 1] == 1)
                            count++;
                    }
                    //If index is out of valid field range evaluates to 2 to create border
                    else if (a == 0 || b == 0 || a == lifeArray.GetLength(0) - 1 || b == lifeArray.GetLength(1) - 1)
                        editedLifeArray[a, b] = 2;
                    //Kills cell if too many or too few surrounding live cells
                    if ((count < 2 || count > 3) && lifeArray[a, b] == 1)
                        editedLifeArray[a, b] = 0;
                    //Keeps cell alive if 2 or 3 surrounding cells
                    if ((count == 2 || count == 3) && lifeArray[a, b] == 1)
                        editedLifeArray[a, b] = 1;
                    //Generates live cell if dead cell is surrounded by exactly 3 live cells
                    if (count == 3 && lifeArray[a, b] == 0)
                        editedLifeArray[a, b] = 1;
                }
            }
            //returns the new array
            return editedLifeArray;
        }

        CDrawer Canvas = null;
        int CycleCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas = new CDrawer();
            Canvas.ContinuousUpdate = false;
        }

        private void btnNewPattern_Click(object sender, EventArgs e)
        {
            NewPattern newNewPattern = new NewPattern();
            if (DialogResult.OK == newNewPattern.ShowDialog())
            {
                drawColor = newNewPattern.newColor;
                numberOfCells = newNewPattern.newNumber;
                lifeArrayOne = new byte[60, 80];
                Canvas.Clear();
                lblCycleDisplay.Text = "";
                count = 1;
                
            }
            DisplayLife(Canvas, lifeArrayOne);
            Canvas.Render();
            CycleCounter = 0;
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            btnStop.Enabled = false;
            btnCycle.Enabled = false;
            btnNewPattern.Enabled = false;
            GameTimer.Enabled = true;
            GameTimer.Interval = CycleSpeedRead;
            GameTimer.Start();
            Canvas.Render();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            newCycleSpeed.SpeedSentNew = new SendSpeed(CallBackSpeedChanged);
            GameTimer.Interval = CycleSpeedRead;
            if (count == 1)
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                lifeArrayOne = new byte[60, 80];
                Canvas.BBColour = Color.Black;
                Canvas.Clear();
                Canvas.Scale = 10;
                CreateLife(lifeArrayOne);
                DisplayLife(Canvas, lifeArrayOne);
            }
            lifeArrayOne = CycleLife(lifeArrayOne);
            DisplayLife(Canvas, lifeArrayOne);
            Canvas.Render();
            showCycleSpeedWindow();
            lblCycleDisplay.Text = count.ToString();
            count++;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            btnStart.Enabled = true;
            btnCycle.Enabled = true;
            btnNewPattern.Enabled = true;
            btnStop.Enabled = false;
            newCycleSpeed.Close();
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            lifeArrayOne = CycleLife(lifeArrayOne);
            DisplayLife(Canvas, lifeArrayOne);
            Canvas.Render();
            count++;
            lblCycleDisplay.Text = count.ToString();
        }
        public static void showCycleSpeedWindow()
        {
            newCycleSpeed.Show();
        }
        private void CallBackSpeedChanged(int newCallBackSpeed)
        {
            CycleSpeedRead = newCallBackSpeed;
        }
    }
}

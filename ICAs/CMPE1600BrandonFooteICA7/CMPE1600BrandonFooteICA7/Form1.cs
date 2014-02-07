using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600BrandonFooteICA7
{
    
    public partial class Form1 : Form
    {
        public int xPos = 15;
        public int yPos = 15;
        CDrawer canvas = new CDrawer(600, 600);
        public Color newColor = new Color();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.Scale = 20;
            canvas.AddCenteredEllipse(xPos, yPos, 1, 1, Color.Red);
            newColor = Color.Red;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.B)
            {
                newColor = Color.Blue;
            }
            else if (e.KeyCode == Keys.R)
            {
                newColor = Color.Red;
            }
            else if (e.KeyCode == Keys.G)
            {
                newColor = Color.Green;
            }

            if (e.KeyCode == Keys.Up)
            {
                yPos -=1;
                if (yPos < 0)
                    yPos = 30;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor);
            }
            else if (e.KeyCode == Keys.Down)
            {
                yPos += 1;
                if (yPos > 30)
                    yPos = 0;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor);
            }
            else if (e.KeyCode == Keys.Right)
            {
                xPos += 1;
                if (xPos > 30)
                    xPos = 0;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor);
            }
            else if (e.KeyCode == Keys.Left)
            {
                xPos -= 1;
                if (xPos < 0)
                    xPos = 30;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor);
            }
        }
    }
}

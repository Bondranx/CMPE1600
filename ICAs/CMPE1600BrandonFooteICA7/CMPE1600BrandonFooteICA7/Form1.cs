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
        public int mover = 1;
        CDrawer canvas = new CDrawer(600, 600);
        public Color newColor = new Color();
        public Color borderColor = new Color();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.Scale = 20;
            borderColor = Color.Black;
            canvas.AddCenteredEllipse(xPos, yPos, 1, 1, Color.Red, 1, borderColor);
            newColor = Color.Red;
            
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.F1)
                borderColor = Color.White;

            if (e.KeyCode == Keys.ShiftKey)
                mover = 2;

            if (e.KeyCode == Keys.ControlKey)
                mover = 3;

            if (e.Handled = e.Alt)
                mover = 4;

            if (e.KeyCode == Keys.B)
                newColor = Color.Blue;
            else if (e.KeyCode == Keys.R)
                newColor = Color.Red;
            else if (e.KeyCode == Keys.G)
                newColor = Color.Green;

            if (e.KeyCode == Keys.Up)
            {
                yPos -=mover;
                if (yPos < 0)
                    yPos = 30;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor, 1, borderColor);
            }
            else if (e.KeyCode == Keys.Down)
            {
                yPos += mover;
                if (yPos > 30)
                    yPos = 0;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor, 1, borderColor);
            }
            else if (e.KeyCode == Keys.Right)
            {
                xPos += mover;
                if (xPos > 30)
                    xPos = 0;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor, 1, borderColor);
            }
            else if (e.KeyCode == Keys.Left)
            {
                xPos -= mover;
                if (xPos < 0)
                    xPos = 30;
                canvas.AddCenteredEllipse(xPos, yPos, 1, 1, newColor, 1, borderColor);
            }

            if (e.KeyCode == Keys.X)
                Application.Exit();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                mover = 1;
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                mover = 1;
            }

            if (e.Handled = e.Alt)
            {
                mover = 1;
            }
            if (e.KeyCode == Keys.F1)
            {
                borderColor = Color.Black;
            }
        }
    }
}

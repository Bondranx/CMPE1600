using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600BrandonFooteICA8
{
    public partial class ShapeDrawer : Form
    {
        CDrawer Canvas = new CDrawer();
        public ShapeDrawer()
        {
            InitializeComponent();
            lblColor.Text = "";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblColor.BackColor = colorDialog1.Color;
        }

        private void ShapeDrawer_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color Border = new Color();
            Point Coords;
            bool clicked = false;
            clicked = Canvas.GetLastMouseLeftClick(out Coords);
            if (rbtnCircle.Checked == true && clicked == true)
            {
                if (chbxBorder.Checked == true)
                    Border = Color.White;
                else
                    Border = Color.Black;
                Console.WriteLine("You picked circle");
                Canvas.AddCenteredEllipse(Coords.X, Coords.Y, tbSize.Value,tbSize.Value, colorDialog1.Color, 2, Border);
            }
            else if (rbtnSquare.Checked == true && clicked == true)
            {
                if (chbxBorder.Checked == true)
                    Border = Color.White;
                else
                    Border = Color.Black;
                Console.WriteLine("You picked square");
                Canvas.AddCenteredRectangle(Coords.X, Coords.Y, tbSize.Value, tbSize.Value, colorDialog1.Color, 2, Border);
            }
        }
    }
}

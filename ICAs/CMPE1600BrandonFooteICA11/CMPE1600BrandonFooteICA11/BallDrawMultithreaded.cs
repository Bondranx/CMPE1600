using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using GDIDrawer;

namespace CMPE1600BrandonFooteICA11
{
    public partial class BallDrawMultithreaded : Form
    {
        public static CDrawer canvas = null;
        public static Random newRandom = new Random();
        public static int ballSize = 1;

        public BallDrawMultithreaded()
        {
            InitializeComponent();
            canvas = new CDrawer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            canvas.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(BallDraw));
            newThread.Start();
        }

        static void BallDraw()
        {
            Color newColor = new Color();
            int x = 0;
            int y = 0;
            
            for (int a = 0; a < 500; a++)
            {
                newColor = Color.FromArgb(newRandom.Next(0, 256), newRandom.Next(0, 256), newRandom.Next(0, 256));
                x = newRandom.Next(0, 801);
                y = newRandom.Next(0, 601);
                canvas.AddCenteredEllipse(x, y, ballSize, ballSize, newColor);
                Thread.Sleep(50);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ballSize = trackBar1.Value;
        }
    }
}

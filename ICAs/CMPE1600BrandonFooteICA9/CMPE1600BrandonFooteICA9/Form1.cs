using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600BrandonFooteICA9
{
    public partial class frmMain : Form
    {
        public static CDrawer Canvas = new CDrawer();
        public static Color DrawColor = new Color();
        public static int NewSize = 10;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Canvas.ContinuousUpdate = false;
            DrawColor = Color.Red;
            tmrMouseClicks.Interval = 50;
            tmrMouseClicks.Start();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            frmSize SizeDialog = new frmSize();

            if (DialogResult.OK == SizeDialog.ShowDialog())
            {
                NewSize = SizeDialog.ShapeSize;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            frmColor ColorDialog = new frmColor();

            if (DialogResult.OK == ColorDialog.ShowDialog())
            {
                DrawColor = ColorDialog.newColor;
            }
        }

        private void tmrMouseClicks_Tick(object sender, EventArgs e)
        {
            Point newPoint = new Point();
            bool success = false;
            success = Canvas.GetLastMouseLeftClick(out newPoint);
            if (success == true)
            {
                Canvas.AddCenteredEllipse(newPoint.X, newPoint.Y, NewSize, NewSize, DrawColor);
                Canvas.Render();
            }
        }
    }
}

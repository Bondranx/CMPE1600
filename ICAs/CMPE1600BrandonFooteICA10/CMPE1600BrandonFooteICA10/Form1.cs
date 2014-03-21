using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600BrandonFooteICA10
{
    public partial class Form1 : Form
    {
        public CDrawer Canvas = new CDrawer();
        public SizeDialog NewSizeDialog = new SizeDialog();
        public ColorDialog NewColorDialog = new ColorDialog();
        public static Color NewColor = new Color();
        public static int CircleSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void chbxShowColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowColor.Checked == true)
            {
                NewColorDialog.Show();
                NewColorDialog.NewColor = new SendColor(CallBackColorChanged);
                NewColorDialog.FormClosingNew = new FormClosed(CallBackFormClosing);
            }
            else
            {
                NewColorDialog.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrDrawTimer.Interval = 50;
            tmrDrawTimer.Start();
        }

        private void chbxShowSize_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowSize.Checked == true)
            {
                NewSizeDialog.Show();
                NewSizeDialog.FormClosingNew = new FormClosed(CallBackFormClosingSize);
                NewSizeDialog.SizeSentNew = new SendSize(CallBackSizeChanged);
            }
            else if (chbxShowSize.Checked == false)
            {
                NewSizeDialog.Hide();
            }
        }

        private void CallBackColorChanged(Color newCallBackColor)
        {
            lblDisplayDrawColor.BackColor = newCallBackColor;
            NewColor = newCallBackColor;
        }

        private void CallBackFormClosing()
        {
            chbxShowColor.Checked = false;
        }

        private void CallBackFormClosingSize()
        {
            chbxShowSize.Checked = false;
        }

        private void CallBackSizeChanged(int newCallBackSize)
        {
            lblCircleSizeDisplay.Text = newCallBackSize.ToString();
            CircleSize = newCallBackSize;
            lblCircleSizeDisplay.Visible = true;
        }

        private void tmrDrawTimer_Tick(object sender, EventArgs e)
        {
            Point newPoint = new Point();
            bool success = false;
            success = Canvas.GetLastMouseLeftClick(out newPoint);
            if (success == true)
            {
                Canvas.AddCenteredEllipse(newPoint.X, newPoint.Y, CircleSize, CircleSize, NewColor);
                Canvas.Render();
            }
        }
    }
}

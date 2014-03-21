using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA10
{
    public delegate void SendColor(Color ColorSent);
    public delegate void FormClosed();
   
    public partial class ColorDialog : Form
    {
        public static Color color = new Color();
        public SendColor NewColor = null;
        public FormClosed FormClosingNew = null;

        public ColorDialog()
        {
            InitializeComponent();
        }

        private void tckbrRed_Scroll(object sender, EventArgs e)
        {
            color = Color.FromArgb(tckbrRed.Value, tckbrGreen.Value, tckbrBlue.Value);
            lblColorDisplay.BackColor = color;

            if (null != NewColor)
            {
                NewColor.Invoke(color);
            }
        }

        private void tckbrGreen_Scroll(object sender, EventArgs e)
        {
            color = Color.FromArgb(tckbrRed.Value, tckbrGreen.Value, tckbrBlue.Value);
            lblColorDisplay.BackColor = color;
            if (null != NewColor)
            {
                NewColor.Invoke(color);
            }
        }

        private void tckbrBlue_Scroll(object sender, EventArgs e)
        {
            color = Color.FromArgb(tckbrRed.Value, tckbrGreen.Value, tckbrBlue.Value);
            lblColorDisplay.BackColor = color;
            if (null != NewColor)
            {
                NewColor.Invoke(color);
            }
        }

        private void ColorDialog_Load(object sender, EventArgs e)
        {
            color = Color.FromArgb(tckbrRed.Value, tckbrGreen.Value, tckbrBlue.Value);
            lblColorDisplay.BackColor = color;
            if (null != NewColor)
            {
                NewColor.Invoke(color);
            }
        }

        private void ColorDialog_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (null != FormClosingNew)
            {
                FormClosingNew();
            }
            e.Cancel = true;
            Hide();
        }
    }
}

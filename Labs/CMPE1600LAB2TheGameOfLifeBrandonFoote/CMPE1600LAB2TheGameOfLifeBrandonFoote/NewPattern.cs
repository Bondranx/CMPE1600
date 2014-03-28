using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600LAB2TheGameOfLifeBrandonFoote
{
    public partial class NewPattern : Form
    {
        public Color newColor = new Color();
        public int newNumber = 0;

        public NewPattern()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void rdbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRed.Checked == true)
                newColor = Color.Red;
        }

        private void rdbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnGreen.Checked == true)
                newColor = Color.Green;
        }

        private void rdbtnGray_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnGray.Checked == true)
                newColor = Color.Gray;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            newNumber = trackBar1.Value;
        }
    }
}

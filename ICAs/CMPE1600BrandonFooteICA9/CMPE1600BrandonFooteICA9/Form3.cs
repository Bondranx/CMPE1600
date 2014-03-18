using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA9
{
    public partial class frmColor : Form
    {
        public Color newColor = new Color();
        public frmColor()
        {
            InitializeComponent();
        }

        private void rdbRed_CheckedChanged(object sender, EventArgs e)
        {
            newColor = Color.Red;
        }

        private void rdbGreen_CheckedChanged(object sender, EventArgs e)
        {
            newColor = Color.Green;
        }

        private void rdbBlue_CheckedChanged(object sender, EventArgs e)
        {
            newColor = Color.Blue;
        }

        private void frmColor_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

﻿using System;
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
        public static Color newColor = new Color();
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
    }
}

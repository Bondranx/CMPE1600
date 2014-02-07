﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA8
{
    public partial class ShapeDrawer : Form
    {
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
    }
}
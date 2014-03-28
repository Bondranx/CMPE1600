using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600LAB2TheGameOfLifeBrandonFoote
{
    public partial class Form1 : Form
    {
        CDrawer Canvas = null;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas = new CDrawer();
            Canvas.ContinuousUpdate = false;

        }
    }
}

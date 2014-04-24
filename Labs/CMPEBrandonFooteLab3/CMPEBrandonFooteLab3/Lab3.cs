using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPEBrandonFooteLab3
{
    public partial class Lab3 : Form
    {
        CDrawer newCanvas = new CDrawer();
        public Lab3()
        {
            InitializeComponent();
        }

        private void Lab3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            //newFileOpenDialog.ShowDialog();
            newFileOpenDialog.Filter = "Jpeg files|*.jpg|Gif files|*.gif|Png files|*.png|Bmpfiles|*.bmp|All files|*.*"; 
            if (newFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = newFileOpenDialog.SafeFileName;
            }
        }
    }
}

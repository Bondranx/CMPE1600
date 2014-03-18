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
    public partial class frmSize : Form
    {
        public int ShapeSize = 0;

        public frmSize()
        {
            InitializeComponent();
        }

        private void frmSize_Load(object sender, EventArgs e)
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

        private void tkbrSizeSelect_Scroll(object sender, EventArgs e)
        {
            ShapeSize = tkbrSizeSelect.Value;
        }
    }
}

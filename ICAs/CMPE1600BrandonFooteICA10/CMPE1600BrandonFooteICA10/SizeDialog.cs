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
    public delegate void SendSize(int SizeSent);
    public partial class SizeDialog : Form
    {
        public FormClosed FormClosingNew = null;
        public SendSize SizeSentNew = null;
        public static int newSize;

        public SizeDialog()
        {
            InitializeComponent();
        }

        private void SizeDialog_Load(object sender, EventArgs e)
        {

        }

        private void SizeDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormClosingNew)
            {
                FormClosingNew();
            }
            e.Cancel = true;
            Hide();
        }

        private void tckbrSize_Scroll(object sender, EventArgs e)
        {
            newSize = tckbrSize.Value;
            if (null != SizeSentNew)
            {
                SizeSentNew(newSize);
            }
        }
    }
}

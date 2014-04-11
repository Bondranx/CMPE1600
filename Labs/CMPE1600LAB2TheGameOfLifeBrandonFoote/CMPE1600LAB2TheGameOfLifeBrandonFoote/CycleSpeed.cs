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
    public delegate void SendSpeed(int SpeedSent);
    public delegate void FormClosed();
    public partial class CycleSpeed : Form
    {
        public FormClosed FormClosingNew = null;
        public SendSpeed SpeedSentNew = null;
        public static int newSpeed;

        public CycleSpeed()
        {
            InitializeComponent();
        }

        private void tckbrCycleSpeed_Scroll(object sender, EventArgs e)
        {
            newSpeed = tckbrCycleSpeed.Value;
            if (null != SpeedSentNew)
            {
                SpeedSentNew.Invoke(newSpeed);
            }
        }

        private void CycleSpeed_FormClosing(object sender, FormClosingEventArgs e)
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

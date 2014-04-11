using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LABEXAM2
{

    public delegate void NumTransfer(int n);
    public delegate void CloseTransfer(string TF);

    public partial class QuestionTwoForm : Form
    {
        public NumTransfer NewTransfer = null;
        public CloseTransfer NewCloseTransfer = null;
        public QuestionTwoForm()
        {
            InitializeComponent();
        }

        private void QuestionTwoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int NewNum = (int)numericUpDown1.Value;
            if (NewTransfer != null)
                NewTransfer(NewNum);
        }

        private void QuestionTwoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewCloseTransfer != null)
                NewCloseTransfer("true");
            e.Cancel = true;
        }
    }
}

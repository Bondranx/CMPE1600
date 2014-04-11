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
    public partial class QuestionOneDialog : Form
    {

        public string newQuestion = "";

        public QuestionOneDialog()
        {
            InitializeComponent();
        }

        private void tbxQuestionOne_TextChanged(object sender, EventArgs e)
        {
            newQuestion = tbxQuestionOne.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuestionOneDialog_Load(object sender, EventArgs e)
        {
            tbxQuestionOne.Text = Form1.QuestionOne1;
            tbxQuestionOne.SelectionStart = 0;
        }
    }
}

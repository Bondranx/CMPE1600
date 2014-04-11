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
    public partial class Form1 : Form
    {

        public static string QuestionOne1 = "";
        public QuestionTwoForm QuestionTwo = new QuestionTwoForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuestionOne_Click(object sender, EventArgs e)
        {
            QuestionOneDialog QuestionOne = new QuestionOneDialog();
            if (DialogResult.OK == QuestionOne.ShowDialog())
            {
                lblQuestion1.Text = QuestionOne.newQuestion;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionOne1 = lblQuestion1.Text;

        }

        private void btnQuestionTwo_Click(object sender, EventArgs e)
        {
            
            btnQuestionTwo.Enabled = false;
            QuestionTwo.Show();
            QuestionTwo.NewTransfer = new NumTransfer(CallBackNumber);
            QuestionTwo.NewCloseTransfer = new CloseTransfer(CallBackResult);
        }
        private void CallBackNumber(int n)
        {
            lblQuestion2.Text = n.ToString();
        }
        private void CallBackResult(string TF)
        {
            if (TF == "true")
            {
                btnQuestionTwo.Enabled = true;
                QuestionTwo.Hide();
            }
        }
    }
}

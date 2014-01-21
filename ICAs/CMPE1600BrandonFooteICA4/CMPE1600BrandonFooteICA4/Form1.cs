using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPE1600BrandonFooteICA4
{
    public partial class frmICA4 : Form
    {
        public frmICA4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstbxMain.Items.Add(tbxInput.Text);
            tbxInput.Clear();
            lstbxMain.SetSelected((int)nudSelection.Value, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbxMain.SelectedItem == null)
            {
                MessageBox.Show("No Item Selected", "Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            lstbxMain.Items.Remove(lstbxMain.SelectedItem);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int iFoundAt = lstbxMain.FindString(tbxInput.Text,0);
            if (iFoundAt == ListBox.NoMatches)
            {
                lblFoundLocation.Text = "Not Found!";
                lblSelectionItem.Visible = true;
            }
            else
            {
                lblFoundLocation.Text = iFoundAt.ToString();
                lblSelectionItem.Visible = true;
            }
        }

        private void tbxInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbxInput_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstbxMain.Items.Add(tbxInput.Text);
                tbxInput.Clear();
                lstbxMain.SetSelected((int)nudSelection.Value, true);
                lblSelectionItem.Text = lstbxMain.SelectedItem.ToString();
                lblSelectionItem.Visible = true;
            }
        }

        private void nudSelection_ValueChanged(object sender, EventArgs e)
        {
            lstbxMain.SetSelected((int)nudSelection.Value,true);
            lblSelectionItem.Text = lstbxMain.SelectedItem.ToString();
            lblSelectionItem.Visible = true;
        }

        private void lstbxMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmICA4_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace CMPE1600BrandonFooteICA4
{
    partial class frmICA4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nudSelection = new System.Windows.Forms.NumericUpDown();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lstbxMain = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSelectionItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFoundLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(12, 12);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(100, 20);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            this.tbxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            this.tbxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(20, 67);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nudSelection
            // 
            this.nudSelection.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nudSelection.Location = new System.Drawing.Point(69, 129);
            this.nudSelection.Name = "nudSelection";
            this.nudSelection.Size = new System.Drawing.Size(43, 20);
            this.nudSelection.TabIndex = 4;
            this.nudSelection.ValueChanged += new System.EventHandler(this.nudSelection_ValueChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(12, 131);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(51, 13);
            this.lblSelection.TabIndex = 5;
            this.lblSelection.Text = "Selection";
            // 
            // lstbxMain
            // 
            this.lstbxMain.FormattingEnabled = true;
            this.lstbxMain.Location = new System.Drawing.Point(132, 12);
            this.lstbxMain.Name = "lstbxMain";
            this.lstbxMain.Size = new System.Drawing.Size(135, 95);
            this.lstbxMain.TabIndex = 6;
            this.lstbxMain.SelectedIndexChanged += new System.EventHandler(this.lstbxMain_SelectedIndexChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(129, 120);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(75, 13);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "Selected Item:";
            this.lblSelected.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSelectionItem
            // 
            this.lblSelectionItem.AutoSize = true;
            this.lblSelectionItem.Location = new System.Drawing.Point(210, 120);
            this.lblSelectionItem.Name = "lblSelectionItem";
            this.lblSelectionItem.Size = new System.Drawing.Size(44, 13);
            this.lblSelectionItem.TabIndex = 8;
            this.lblSelectionItem.Text = "Tracker";
            this.lblSelectionItem.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Found At:";
            // 
            // lblFoundLocation
            // 
            this.lblFoundLocation.AutoSize = true;
            this.lblFoundLocation.Location = new System.Drawing.Point(214, 140);
            this.lblFoundLocation.Name = "lblFoundLocation";
            this.lblFoundLocation.Size = new System.Drawing.Size(40, 13);
            this.lblFoundLocation.TabIndex = 10;
            this.lblFoundLocation.Text = "tracker";
            this.lblFoundLocation.Visible = false;
            // 
            // frmICA4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 160);
            this.Controls.Add(this.lblFoundLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectionItem);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstbxMain);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.nudSelection);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxInput);
            this.Name = "frmICA4";
            this.Text = "ICA4";
            this.Load += new System.EventHandler(this.frmICA4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nudSelection;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ListBox lstbxMain;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblSelectionItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFoundLocation;
    }
}


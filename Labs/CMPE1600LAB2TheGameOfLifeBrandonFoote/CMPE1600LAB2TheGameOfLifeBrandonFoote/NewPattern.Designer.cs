namespace CMPE1600LAB2TheGameOfLifeBrandonFoote
{
    partial class NewPattern
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
            this.grpbxColor = new System.Windows.Forms.GroupBox();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.rdbtnGreen = new System.Windows.Forms.RadioButton();
            this.rdbtnGray = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblNumOfCells = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbxColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxColor
            // 
            this.grpbxColor.Controls.Add(this.rdbtnRed);
            this.grpbxColor.Controls.Add(this.rdbtnGreen);
            this.grpbxColor.Controls.Add(this.rdbtnGray);
            this.grpbxColor.Location = new System.Drawing.Point(12, 12);
            this.grpbxColor.Name = "grpbxColor";
            this.grpbxColor.Size = new System.Drawing.Size(108, 89);
            this.grpbxColor.TabIndex = 0;
            this.grpbxColor.TabStop = false;
            this.grpbxColor.Text = "Color";
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.Location = new System.Drawing.Point(6, 19);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(45, 17);
            this.rdbtnRed.TabIndex = 1;
            this.rdbtnRed.TabStop = true;
            this.rdbtnRed.Text = "Red";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            this.rdbtnRed.CheckedChanged += new System.EventHandler(this.rdbtnRed_CheckedChanged);
            // 
            // rdbtnGreen
            // 
            this.rdbtnGreen.AutoSize = true;
            this.rdbtnGreen.Location = new System.Drawing.Point(6, 42);
            this.rdbtnGreen.Name = "rdbtnGreen";
            this.rdbtnGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbtnGreen.TabIndex = 2;
            this.rdbtnGreen.TabStop = true;
            this.rdbtnGreen.Text = "Green";
            this.rdbtnGreen.UseVisualStyleBackColor = true;
            this.rdbtnGreen.CheckedChanged += new System.EventHandler(this.rdbtnGreen_CheckedChanged);
            // 
            // rdbtnGray
            // 
            this.rdbtnGray.AutoSize = true;
            this.rdbtnGray.Location = new System.Drawing.Point(6, 65);
            this.rdbtnGray.Name = "rdbtnGray";
            this.rdbtnGray.Size = new System.Drawing.Size(47, 17);
            this.rdbtnGray.TabIndex = 3;
            this.rdbtnGray.TabStop = true;
            this.rdbtnGray.Text = "Gray";
            this.rdbtnGray.UseVisualStyleBackColor = true;
            this.rdbtnGray.CheckedChanged += new System.EventHandler(this.rdbtnGray_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 130);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(260, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblNumOfCells
            // 
            this.lblNumOfCells.AutoSize = true;
            this.lblNumOfCells.Location = new System.Drawing.Point(102, 111);
            this.lblNumOfCells.Name = "lblNumOfCells";
            this.lblNumOfCells.Size = new System.Drawing.Size(81, 13);
            this.lblNumOfCells.TabIndex = 2;
            this.lblNumOfCells.Text = "Number of Cells";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(9, 162);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(25, 13);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "100";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(237, 162);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(31, 13);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "2000";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 181);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblNumOfCells);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.grpbxColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPattern";
            this.Text = "NewPattern";
            this.grpbxColor.ResumeLayout(false);
            this.grpbxColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxColor;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.RadioButton rdbtnGreen;
        private System.Windows.Forms.RadioButton rdbtnGray;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblNumOfCells;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
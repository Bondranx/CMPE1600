namespace CMPE1600LAB2TheGameOfLifeBrandonFoote
{
    partial class CycleSpeed
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
            this.tckbrCycleSpeed = new System.Windows.Forms.TrackBar();
            this.lblFast = new System.Windows.Forms.Label();
            this.lblSlow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tckbrCycleSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tckbrCycleSpeed
            // 
            this.tckbrCycleSpeed.Location = new System.Drawing.Point(12, 12);
            this.tckbrCycleSpeed.Maximum = 2000;
            this.tckbrCycleSpeed.Minimum = 200;
            this.tckbrCycleSpeed.Name = "tckbrCycleSpeed";
            this.tckbrCycleSpeed.Size = new System.Drawing.Size(280, 45);
            this.tckbrCycleSpeed.TabIndex = 0;
            this.tckbrCycleSpeed.TickFrequency = 200;
            this.tckbrCycleSpeed.Value = 200;
            // 
            // lblFast
            // 
            this.lblFast.AutoSize = true;
            this.lblFast.Location = new System.Drawing.Point(9, 44);
            this.lblFast.Name = "lblFast";
            this.lblFast.Size = new System.Drawing.Size(27, 13);
            this.lblFast.TabIndex = 1;
            this.lblFast.Text = "Fast";
            // 
            // lblSlow
            // 
            this.lblSlow.AutoSize = true;
            this.lblSlow.Location = new System.Drawing.Point(257, 44);
            this.lblSlow.Name = "lblSlow";
            this.lblSlow.Size = new System.Drawing.Size(30, 13);
            this.lblSlow.TabIndex = 2;
            this.lblSlow.Text = "Slow";
            // 
            // CycleSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 70);
            this.Controls.Add(this.lblSlow);
            this.Controls.Add(this.lblFast);
            this.Controls.Add(this.tckbrCycleSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CycleSpeed";
            this.Text = "CycleSpeed";
            ((System.ComponentModel.ISupportInitialize)(this.tckbrCycleSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tckbrCycleSpeed;
        private System.Windows.Forms.Label lblFast;
        private System.Windows.Forms.Label lblSlow;
    }
}
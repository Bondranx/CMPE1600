namespace CMPE1600BrandonFooteICA10
{
    partial class SizeDialog
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
            this.tckbrSize = new System.Windows.Forms.TrackBar();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tckbrSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tckbrSize
            // 
            this.tckbrSize.Location = new System.Drawing.Point(12, 12);
            this.tckbrSize.Maximum = 100;
            this.tckbrSize.Minimum = 10;
            this.tckbrSize.Name = "tckbrSize";
            this.tckbrSize.Size = new System.Drawing.Size(284, 45);
            this.tckbrSize.TabIndex = 0;
            this.tckbrSize.TickFrequency = 10;
            this.tckbrSize.Value = 10;
            this.tckbrSize.Scroll += new System.EventHandler(this.tckbrSize_Scroll);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(9, 44);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(19, 13);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "10";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(261, 44);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(25, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "100";
            // 
            // SizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 74);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.tckbrSize);
            this.Name = "SizeDialog";
            this.Text = "SizeDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SizeDialog_FormClosing);
            this.Load += new System.EventHandler(this.SizeDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tckbrSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tckbrSize;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
    }
}
namespace CMPE1600BrandonFooteICA13
{
    partial class Form1
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
            this.trkbrIterations = new System.Windows.Forms.TrackBar();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // trkbrIterations
            // 
            this.trkbrIterations.Location = new System.Drawing.Point(12, 13);
            this.trkbrIterations.Maximum = 5000;
            this.trkbrIterations.Minimum = 100;
            this.trkbrIterations.Name = "trkbrIterations";
            this.trkbrIterations.Size = new System.Drawing.Size(284, 45);
            this.trkbrIterations.TabIndex = 0;
            this.trkbrIterations.TickFrequency = 100;
            this.trkbrIterations.Value = 100;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(9, 45);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(25, 13);
            this.lblMinimum.TabIndex = 1;
            this.lblMinimum.Text = "100";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(265, 45);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(31, 13);
            this.lblMaximum.TabIndex = 2;
            this.lblMaximum.Text = "5000";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(103, 45);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(102, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Number of Iterations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 74);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.trkbrIterations);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkbrIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkbrIterations;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblMessage;
    }
}


namespace CMPE1600LAB2TheGameOfLifeBrandonFoote
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
            this.btnNewPattern = new System.Windows.Forms.Button();
            this.lblCycle = new System.Windows.Forms.Label();
            this.lblCycleDisplay = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewPattern
            // 
            this.btnNewPattern.Location = new System.Drawing.Point(122, 41);
            this.btnNewPattern.Name = "btnNewPattern";
            this.btnNewPattern.Size = new System.Drawing.Size(75, 23);
            this.btnNewPattern.TabIndex = 0;
            this.btnNewPattern.Text = "New Pattern";
            this.btnNewPattern.UseVisualStyleBackColor = true;
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCycle.Location = new System.Drawing.Point(90, 99);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(51, 20);
            this.lblCycle.TabIndex = 1;
            this.lblCycle.Text = "Cycle:";
            // 
            // lblCycleDisplay
            // 
            this.lblCycleDisplay.AutoSize = true;
            this.lblCycleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCycleDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCycleDisplay.Location = new System.Drawing.Point(147, 99);
            this.lblCycleDisplay.MinimumSize = new System.Drawing.Size(67, 0);
            this.lblCycleDisplay.Name = "lblCycleDisplay";
            this.lblCycleDisplay.Size = new System.Drawing.Size(67, 22);
            this.lblCycleDisplay.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(122, 157);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(232, 157);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(75, 23);
            this.btnCycle.TabIndex = 5;
            this.btnCycle.Text = "Cycle";
            this.btnCycle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 192);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCycleDisplay);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.btnNewPattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPattern;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Label lblCycleDisplay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCycle;
    }
}


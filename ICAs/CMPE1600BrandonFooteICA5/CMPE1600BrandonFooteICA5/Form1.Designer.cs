namespace CMPE1600BrandonFooteICA5
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
            this.components = new System.ComponentModel.Container();
            this.btnStartButton = new System.Windows.Forms.Button();
            this.tbxUserInput = new System.Windows.Forms.TextBox();
            this.lblNumDisplay = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblResultsDisplay = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStartButton
            // 
            this.btnStartButton.Location = new System.Drawing.Point(143, 243);
            this.btnStartButton.Name = "btnStartButton";
            this.btnStartButton.Size = new System.Drawing.Size(88, 33);
            this.btnStartButton.TabIndex = 0;
            this.btnStartButton.Text = "Start";
            this.btnStartButton.UseVisualStyleBackColor = true;
            this.btnStartButton.Click += new System.EventHandler(this.btnStartButton_Click);
            // 
            // tbxUserInput
            // 
            this.tbxUserInput.Location = new System.Drawing.Point(127, 207);
            this.tbxUserInput.Name = "tbxUserInput";
            this.tbxUserInput.Size = new System.Drawing.Size(121, 20);
            this.tbxUserInput.TabIndex = 1;
            // 
            // lblNumDisplay
            // 
            this.lblNumDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDisplay.Location = new System.Drawing.Point(124, 38);
            this.lblNumDisplay.Name = "lblNumDisplay";
            this.lblNumDisplay.Size = new System.Drawing.Size(127, 135);
            this.lblNumDisplay.TabIndex = 2;
            this.lblNumDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(36, 301);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(67, 20);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "Results:";
            // 
            // lblResultsDisplay
            // 
            this.lblResultsDisplay.AutoSize = true;
            this.lblResultsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsDisplay.Location = new System.Drawing.Point(112, 301);
            this.lblResultsDisplay.Name = "lblResultsDisplay";
            this.lblResultsDisplay.Size = new System.Drawing.Size(62, 20);
            this.lblResultsDisplay.TabIndex = 4;
            this.lblResultsDisplay.Text = "Tracker";
            this.lblResultsDisplay.Visible = false;
            this.lblResultsDisplay.Click += new System.EventHandler(this.lblResultsDisplay_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 355);
            this.Controls.Add(this.lblResultsDisplay);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblNumDisplay);
            this.Controls.Add(this.tbxUserInput);
            this.Controls.Add(this.btnStartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartButton;
        private System.Windows.Forms.TextBox tbxUserInput;
        private System.Windows.Forms.Label lblNumDisplay;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblResultsDisplay;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Timer timer2;
    }
}


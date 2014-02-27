namespace CMPE1600LabExam1Part1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultDisplay = new System.Windows.Forms.Label();
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.rdbtnCircumference = new System.Windows.Forms.RadioButton();
            this.rdbtnArea = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(129, 93);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(36, 35);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(39, 63);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            // 
            // lblResultDisplay
            // 
            this.lblResultDisplay.AutoSize = true;
            this.lblResultDisplay.Location = new System.Drawing.Point(85, 63);
            this.lblResultDisplay.Name = "lblResultDisplay";
            this.lblResultDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblResultDisplay.TabIndex = 3;
            this.lblResultDisplay.Text = "label3";
            this.lblResultDisplay.Visible = false;
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(85, 32);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 20);
            this.tbxRadius.TabIndex = 0;
            this.tbxRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRadius_KeyDown);
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Location = new System.Drawing.Point(202, 19);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(59, 13);
            this.lblCalculation.TabIndex = 5;
            this.lblCalculation.Text = "Calculation";
            // 
            // rdbtnCircumference
            // 
            this.rdbtnCircumference.AutoSize = true;
            this.rdbtnCircumference.Location = new System.Drawing.Point(205, 35);
            this.rdbtnCircumference.Name = "rdbtnCircumference";
            this.rdbtnCircumference.Size = new System.Drawing.Size(93, 17);
            this.rdbtnCircumference.TabIndex = 6;
            this.rdbtnCircumference.TabStop = true;
            this.rdbtnCircumference.Text = "Circumference";
            this.rdbtnCircumference.UseVisualStyleBackColor = true;
            // 
            // rdbtnArea
            // 
            this.rdbtnArea.AutoSize = true;
            this.rdbtnArea.Location = new System.Drawing.Point(205, 58);
            this.rdbtnArea.Name = "rdbtnArea";
            this.rdbtnArea.Size = new System.Drawing.Size(47, 17);
            this.rdbtnArea.TabIndex = 7;
            this.rdbtnArea.TabStop = true;
            this.rdbtnArea.Text = "Area";
            this.rdbtnArea.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 130);
            this.Controls.Add(this.rdbtnArea);
            this.Controls.Add(this.rdbtnCircumference);
            this.Controls.Add(this.lblCalculation);
            this.Controls.Add(this.tbxRadius);
            this.Controls.Add(this.lblResultDisplay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultDisplay;
        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.RadioButton rdbtnCircumference;
        private System.Windows.Forms.RadioButton rdbtnArea;
    }
}


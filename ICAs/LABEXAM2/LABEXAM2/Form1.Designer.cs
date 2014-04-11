namespace LABEXAM2
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
            this.btnQuestionOne = new System.Windows.Forms.Button();
            this.btnQuestionTwo = new System.Windows.Forms.Button();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuestionOne
            // 
            this.btnQuestionOne.Location = new System.Drawing.Point(12, 12);
            this.btnQuestionOne.Name = "btnQuestionOne";
            this.btnQuestionOne.Size = new System.Drawing.Size(95, 30);
            this.btnQuestionOne.TabIndex = 0;
            this.btnQuestionOne.Text = "Question 1";
            this.btnQuestionOne.UseVisualStyleBackColor = true;
            this.btnQuestionOne.Click += new System.EventHandler(this.btnQuestionOne_Click);
            // 
            // btnQuestionTwo
            // 
            this.btnQuestionTwo.Location = new System.Drawing.Point(12, 48);
            this.btnQuestionTwo.Name = "btnQuestionTwo";
            this.btnQuestionTwo.Size = new System.Drawing.Size(95, 30);
            this.btnQuestionTwo.TabIndex = 1;
            this.btnQuestionTwo.Text = "Question 2";
            this.btnQuestionTwo.UseVisualStyleBackColor = true;
            this.btnQuestionTwo.Click += new System.EventHandler(this.btnQuestionTwo_Click);
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Location = new System.Drawing.Point(113, 21);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(47, 13);
            this.lblQuestion1.TabIndex = 2;
            this.lblQuestion1.Text = "Q1Label";
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Location = new System.Drawing.Point(113, 57);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(47, 13);
            this.lblQuestion2.TabIndex = 3;
            this.lblQuestion2.Text = "Q2Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 94);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.btnQuestionTwo);
            this.Controls.Add(this.btnQuestionOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionOne;
        private System.Windows.Forms.Button btnQuestionTwo;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Label lblQuestion2;
    }
}


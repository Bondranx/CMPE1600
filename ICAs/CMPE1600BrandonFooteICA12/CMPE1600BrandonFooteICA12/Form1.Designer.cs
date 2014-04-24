namespace CMPE1600BrandonFooteICA12
{
    partial class ICA12
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstbxNumbers = new System.Windows.Forms.ListBox();
            this.brgbrProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 41);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstbxNumbers
            // 
            this.lstbxNumbers.FormattingEnabled = true;
            this.lstbxNumbers.Location = new System.Drawing.Point(93, 12);
            this.lstbxNumbers.Name = "lstbxNumbers";
            this.lstbxNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstbxNumbers.TabIndex = 3;
            // 
            // brgbrProgress
            // 
            this.brgbrProgress.Location = new System.Drawing.Point(12, 115);
            this.brgbrProgress.Maximum = 50000;
            this.brgbrProgress.Name = "brgbrProgress";
            this.brgbrProgress.Size = new System.Drawing.Size(201, 23);
            this.brgbrProgress.Step = 1;
            this.brgbrProgress.TabIndex = 4;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 151);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(63, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Placeholder";
            this.lblProgress.Visible = false;
            // 
            // ICA12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 173);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.brgbrProgress);
            this.Controls.Add(this.lstbxNumbers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnGenerate);
            this.Name = "ICA12";
            this.Text = "ICA12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstbxNumbers;
        private System.Windows.Forms.Label lblProgress;
        public System.Windows.Forms.ProgressBar brgbrProgress;
    }
}


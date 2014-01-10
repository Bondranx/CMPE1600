namespace Demo1
{
    partial class MainForm
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
            this.btnMain = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(105, 63);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Click Me!";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(124, 27);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 105);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnMain);
            this.Name = "MainForm";
            this.Text = "Demo1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblText;
    }
}


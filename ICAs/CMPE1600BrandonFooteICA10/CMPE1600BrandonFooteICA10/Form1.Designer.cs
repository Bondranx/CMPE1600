namespace CMPE1600BrandonFooteICA10
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
            this.lblDisplayDrawColor = new System.Windows.Forms.Label();
            this.lblCircleSizeDisplay = new System.Windows.Forms.Label();
            this.lblCircleSize = new System.Windows.Forms.Label();
            this.lblDrawingColor = new System.Windows.Forms.Label();
            this.chbxShowSize = new System.Windows.Forms.CheckBox();
            this.chbxShowColor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDisplayDrawColor
            // 
            this.lblDisplayDrawColor.AutoSize = true;
            this.lblDisplayDrawColor.BackColor = System.Drawing.Color.Red;
            this.lblDisplayDrawColor.Location = new System.Drawing.Point(213, 13);
            this.lblDisplayDrawColor.Name = "lblDisplayDrawColor";
            this.lblDisplayDrawColor.Size = new System.Drawing.Size(37, 13);
            this.lblDisplayDrawColor.TabIndex = 11;
            this.lblDisplayDrawColor.Text = "          ";
            this.lblDisplayDrawColor.Visible = false;
            // 
            // lblCircleSizeDisplay
            // 
            this.lblCircleSizeDisplay.AutoSize = true;
            this.lblCircleSizeDisplay.Location = new System.Drawing.Point(213, 35);
            this.lblCircleSizeDisplay.Name = "lblCircleSizeDisplay";
            this.lblCircleSizeDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblCircleSizeDisplay.TabIndex = 10;
            this.lblCircleSizeDisplay.Text = "label3";
            this.lblCircleSizeDisplay.Visible = false;
            // 
            // lblCircleSize
            // 
            this.lblCircleSize.AutoSize = true;
            this.lblCircleSize.Location = new System.Drawing.Point(131, 35);
            this.lblCircleSize.Name = "lblCircleSize";
            this.lblCircleSize.Size = new System.Drawing.Size(59, 13);
            this.lblCircleSize.TabIndex = 9;
            this.lblCircleSize.Text = "Circle Size:";
            // 
            // lblDrawingColor
            // 
            this.lblDrawingColor.AutoSize = true;
            this.lblDrawingColor.Location = new System.Drawing.Point(131, 13);
            this.lblDrawingColor.Name = "lblDrawingColor";
            this.lblDrawingColor.Size = new System.Drawing.Size(76, 13);
            this.lblDrawingColor.TabIndex = 8;
            this.lblDrawingColor.Text = "Drawing Color:";
            // 
            // chbxShowSize
            // 
            this.chbxShowSize.AutoSize = true;
            this.chbxShowSize.Location = new System.Drawing.Point(12, 35);
            this.chbxShowSize.Name = "chbxShowSize";
            this.chbxShowSize.Size = new System.Drawing.Size(109, 17);
            this.chbxShowSize.TabIndex = 7;
            this.chbxShowSize.Text = "Show Size Dialog";
            this.chbxShowSize.UseVisualStyleBackColor = true;
            // 
            // chbxShowColor
            // 
            this.chbxShowColor.AutoSize = true;
            this.chbxShowColor.Location = new System.Drawing.Point(12, 12);
            this.chbxShowColor.Name = "chbxShowColor";
            this.chbxShowColor.Size = new System.Drawing.Size(113, 17);
            this.chbxShowColor.TabIndex = 6;
            this.chbxShowColor.Text = "Show Color Dialog";
            this.chbxShowColor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 59);
            this.Controls.Add(this.lblDisplayDrawColor);
            this.Controls.Add(this.lblCircleSizeDisplay);
            this.Controls.Add(this.lblCircleSize);
            this.Controls.Add(this.lblDrawingColor);
            this.Controls.Add(this.chbxShowSize);
            this.Controls.Add(this.chbxShowColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayDrawColor;
        private System.Windows.Forms.Label lblCircleSizeDisplay;
        private System.Windows.Forms.Label lblCircleSize;
        private System.Windows.Forms.Label lblDrawingColor;
        private System.Windows.Forms.CheckBox chbxShowSize;
        private System.Windows.Forms.CheckBox chbxShowColor;
    }
}


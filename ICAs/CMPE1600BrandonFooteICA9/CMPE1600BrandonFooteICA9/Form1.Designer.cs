﻿namespace CMPE1600BrandonFooteICA9
{
    partial class frmMain
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
            this.btnSize = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.tmrMouseClicks = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(12, 12);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(75, 23);
            this.btnSize.TabIndex = 0;
            this.btnSize.Text = "Size";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 41);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tmrMouseClicks
            // 
            this.tmrMouseClicks.Interval = 50;
            this.tmrMouseClicks.Tick += new System.EventHandler(this.tmrMouseClicks_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 78);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnSize);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Timer tmrMouseClicks;
    }
}


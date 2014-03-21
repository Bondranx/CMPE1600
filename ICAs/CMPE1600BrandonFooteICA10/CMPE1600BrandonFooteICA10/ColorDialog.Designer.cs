namespace CMPE1600BrandonFooteICA10
{
    partial class ColorDialog
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
            this.tckbrRed = new System.Windows.Forms.TrackBar();
            this.tckbrBlue = new System.Windows.Forms.TrackBar();
            this.tckbrGreen = new System.Windows.Forms.TrackBar();
            this.lblColorDisplay = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tckbrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbrBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbrGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // tckbrRed
            // 
            this.tckbrRed.Location = new System.Drawing.Point(12, 54);
            this.tckbrRed.Maximum = 255;
            this.tckbrRed.Name = "tckbrRed";
            this.tckbrRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tckbrRed.Size = new System.Drawing.Size(45, 227);
            this.tckbrRed.TabIndex = 0;
            this.tckbrRed.TickFrequency = 15;
            this.tckbrRed.Value = 122;
            this.tckbrRed.Scroll += new System.EventHandler(this.tckbrRed_Scroll);
            // 
            // tckbrBlue
            // 
            this.tckbrBlue.Location = new System.Drawing.Point(154, 54);
            this.tckbrBlue.Maximum = 255;
            this.tckbrBlue.Name = "tckbrBlue";
            this.tckbrBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tckbrBlue.Size = new System.Drawing.Size(45, 227);
            this.tckbrBlue.TabIndex = 1;
            this.tckbrBlue.TickFrequency = 15;
            this.tckbrBlue.Value = 122;
            this.tckbrBlue.Scroll += new System.EventHandler(this.tckbrBlue_Scroll);
            // 
            // tckbrGreen
            // 
            this.tckbrGreen.Location = new System.Drawing.Point(83, 54);
            this.tckbrGreen.Maximum = 255;
            this.tckbrGreen.Name = "tckbrGreen";
            this.tckbrGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tckbrGreen.Size = new System.Drawing.Size(45, 227);
            this.tckbrGreen.TabIndex = 2;
            this.tckbrGreen.TickFrequency = 15;
            this.tckbrGreen.Value = 122;
            this.tckbrGreen.Scroll += new System.EventHandler(this.tckbrGreen_Scroll);
            // 
            // lblColorDisplay
            // 
            this.lblColorDisplay.BackColor = System.Drawing.Color.Red;
            this.lblColorDisplay.Location = new System.Drawing.Point(228, 134);
            this.lblColorDisplay.Name = "lblColorDisplay";
            this.lblColorDisplay.Size = new System.Drawing.Size(100, 45);
            this.lblColorDisplay.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(227, 114);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(12, 31);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(39, 20);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(74, 31);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(54, 20);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(150, 31);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(41, 20);
            this.lblBlue.TabIndex = 7;
            this.lblBlue.Text = "Blue";
            // 
            // ColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 293);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblColorDisplay);
            this.Controls.Add(this.tckbrGreen);
            this.Controls.Add(this.tckbrBlue);
            this.Controls.Add(this.tckbrRed);
            this.Name = "ColorDialog";
            this.Text = "ColorDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorDialog_FormClosing_1);
            this.Load += new System.EventHandler(this.ColorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tckbrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbrBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbrGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tckbrRed;
        private System.Windows.Forms.TrackBar tckbrBlue;
        private System.Windows.Forms.TrackBar tckbrGreen;
        private System.Windows.Forms.Label lblColorDisplay;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
    }
}
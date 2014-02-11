namespace CMPE1600BrandonFooteICA8
{
    partial class ShapeDrawer
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
            this.gbxShape = new System.Windows.Forms.GroupBox();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnSquare = new System.Windows.Forms.RadioButton();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.chbxBorder = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblMinSize = new System.Windows.Forms.Label();
            this.lblMaxSize = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbxShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxShape
            // 
            this.gbxShape.Controls.Add(this.rbtnCircle);
            this.gbxShape.Controls.Add(this.rbtnSquare);
            this.gbxShape.Location = new System.Drawing.Point(12, 12);
            this.gbxShape.Name = "gbxShape";
            this.gbxShape.Size = new System.Drawing.Size(97, 72);
            this.gbxShape.TabIndex = 0;
            this.gbxShape.TabStop = false;
            this.gbxShape.Text = "Shape";
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Location = new System.Drawing.Point(6, 19);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(51, 17);
            this.rbtnCircle.TabIndex = 1;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "Circle";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            // 
            // rbtnSquare
            // 
            this.rbtnSquare.AutoSize = true;
            this.rbtnSquare.Location = new System.Drawing.Point(6, 42);
            this.rbtnSquare.Name = "rbtnSquare";
            this.rbtnSquare.Size = new System.Drawing.Size(59, 17);
            this.rbtnSquare.TabIndex = 2;
            this.rbtnSquare.TabStop = true;
            this.rbtnSquare.Text = "Square";
            this.rbtnSquare.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(115, 28);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(196, 28);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(75, 23);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Holder";
            // 
            // chbxBorder
            // 
            this.chbxBorder.AutoSize = true;
            this.chbxBorder.Location = new System.Drawing.Point(115, 67);
            this.chbxBorder.Name = "chbxBorder";
            this.chbxBorder.Size = new System.Drawing.Size(88, 17);
            this.chbxBorder.TabIndex = 3;
            this.chbxBorder.Text = "White Border";
            this.chbxBorder.UseVisualStyleBackColor = true;
            // 
            // tbSize
            // 
            this.tbSize.LargeChange = 10;
            this.tbSize.Location = new System.Drawing.Point(12, 111);
            this.tbSize.Maximum = 100;
            this.tbSize.Minimum = 10;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(259, 45);
            this.tbSize.TabIndex = 4;
            this.tbSize.TickFrequency = 10;
            this.tbSize.Value = 10;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(128, 95);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // lblMinSize
            // 
            this.lblMinSize.AutoSize = true;
            this.lblMinSize.Location = new System.Drawing.Point(15, 143);
            this.lblMinSize.Name = "lblMinSize";
            this.lblMinSize.Size = new System.Drawing.Size(19, 13);
            this.lblMinSize.TabIndex = 6;
            this.lblMinSize.Text = "10";
            // 
            // lblMaxSize
            // 
            this.lblMaxSize.AutoSize = true;
            this.lblMaxSize.Location = new System.Drawing.Point(246, 143);
            this.lblMaxSize.Name = "lblMaxSize";
            this.lblMaxSize.Size = new System.Drawing.Size(25, 13);
            this.lblMaxSize.TabIndex = 7;
            this.lblMaxSize.Text = "100";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShapeDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 178);
            this.Controls.Add(this.lblMaxSize);
            this.Controls.Add(this.lblMinSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.chbxBorder);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.gbxShape);
            this.Name = "ShapeDrawer";
            this.Text = "ICA8";
            this.Load += new System.EventHandler(this.ShapeDrawer_Load);
            this.gbxShape.ResumeLayout(false);
            this.gbxShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxShape;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnSquare;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.CheckBox chbxBorder;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblMinSize;
        private System.Windows.Forms.Label lblMaxSize;
        private System.Windows.Forms.Timer timer1;
    }
}


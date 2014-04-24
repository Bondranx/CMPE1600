namespace CMPEBrandonFooteLab3
{
    partial class Lab3
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
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.grpbxTransform = new System.Windows.Forms.GroupBox();
            this.rdbtnOriginal = new System.Windows.Forms.RadioButton();
            this.rdbtnBlackandWhite = new System.Windows.Forms.RadioButton();
            this.rdbtnFlipUpsidedown = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.newFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpbxTransform.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(12, 12);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPicture.TabIndex = 0;
            this.btnLoadPicture.Text = "Load Picture";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(12, 41);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(75, 23);
            this.btnTransform.TabIndex = 1;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            // 
            // grpbxTransform
            // 
            this.grpbxTransform.Controls.Add(this.rdbtnOriginal);
            this.grpbxTransform.Controls.Add(this.rdbtnBlackandWhite);
            this.grpbxTransform.Controls.Add(this.rdbtnFlipUpsidedown);
            this.grpbxTransform.Location = new System.Drawing.Point(102, 12);
            this.grpbxTransform.Name = "grpbxTransform";
            this.grpbxTransform.Size = new System.Drawing.Size(137, 96);
            this.grpbxTransform.TabIndex = 2;
            this.grpbxTransform.TabStop = false;
            this.grpbxTransform.Text = "Transform";
            // 
            // rdbtnOriginal
            // 
            this.rdbtnOriginal.AutoSize = true;
            this.rdbtnOriginal.Location = new System.Drawing.Point(3, 62);
            this.rdbtnOriginal.Name = "rdbtnOriginal";
            this.rdbtnOriginal.Size = new System.Drawing.Size(60, 17);
            this.rdbtnOriginal.TabIndex = 2;
            this.rdbtnOriginal.TabStop = true;
            this.rdbtnOriginal.Text = "Original";
            this.rdbtnOriginal.UseVisualStyleBackColor = true;
            // 
            // rdbtnBlackandWhite
            // 
            this.rdbtnBlackandWhite.AutoSize = true;
            this.rdbtnBlackandWhite.Location = new System.Drawing.Point(3, 39);
            this.rdbtnBlackandWhite.Name = "rdbtnBlackandWhite";
            this.rdbtnBlackandWhite.Size = new System.Drawing.Size(104, 17);
            this.rdbtnBlackandWhite.TabIndex = 1;
            this.rdbtnBlackandWhite.TabStop = true;
            this.rdbtnBlackandWhite.Text = "Black and White";
            this.rdbtnBlackandWhite.UseVisualStyleBackColor = true;
            // 
            // rdbtnFlipUpsidedown
            // 
            this.rdbtnFlipUpsidedown.AutoSize = true;
            this.rdbtnFlipUpsidedown.Location = new System.Drawing.Point(3, 16);
            this.rdbtnFlipUpsidedown.Name = "rdbtnFlipUpsidedown";
            this.rdbtnFlipUpsidedown.Size = new System.Drawing.Size(103, 17);
            this.rdbtnFlipUpsidedown.TabIndex = 0;
            this.rdbtnFlipUpsidedown.TabStop = true;
            this.rdbtnFlipUpsidedown.Text = "Flip Upsidedown";
            this.rdbtnFlipUpsidedown.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // newFileOpenDialog
            // 
            this.newFileOpenDialog.FileName = "openFileDialog1";
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 156);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grpbxTransform);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnLoadPicture);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Lab3_Load);
            this.grpbxTransform.ResumeLayout(false);
            this.grpbxTransform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.GroupBox grpbxTransform;
        private System.Windows.Forms.RadioButton rdbtnOriginal;
        private System.Windows.Forms.RadioButton rdbtnBlackandWhite;
        private System.Windows.Forms.RadioButton rdbtnFlipUpsidedown;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog newFileOpenDialog;
    }
}


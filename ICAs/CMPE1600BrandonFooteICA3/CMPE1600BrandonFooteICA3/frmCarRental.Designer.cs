namespace CMPE1600BrandonFooteICA3
{
    partial class frmCarRental
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxCarType = new System.Windows.Forms.GroupBox();
            this.rdbSmallCar = new System.Windows.Forms.RadioButton();
            this.rdbMediumCar = new System.Windows.Forms.RadioButton();
            this.rdbSportsCar = new System.Windows.Forms.RadioButton();
            this.chbInsurance = new System.Windows.Forms.CheckBox();
            this.chbDiscount = new System.Windows.Forms.CheckBox();
            this.nudNumOfDays = new System.Windows.Forms.NumericUpDown();
            this.lblNumOfDays = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.gbxCarType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(94, 40);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(243, 20);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbxCarType
            // 
            this.gbxCarType.Controls.Add(this.rdbSportsCar);
            this.gbxCarType.Controls.Add(this.rdbMediumCar);
            this.gbxCarType.Controls.Add(this.rdbSmallCar);
            this.gbxCarType.Enabled = false;
            this.gbxCarType.Location = new System.Drawing.Point(17, 98);
            this.gbxCarType.Name = "gbxCarType";
            this.gbxCarType.Size = new System.Drawing.Size(197, 91);
            this.gbxCarType.TabIndex = 2;
            this.gbxCarType.TabStop = false;
            this.gbxCarType.Text = "Car Type";
            // 
            // rdbSmallCar
            // 
            this.rdbSmallCar.AutoSize = true;
            this.rdbSmallCar.Enabled = false;
            this.rdbSmallCar.Location = new System.Drawing.Point(6, 19);
            this.rdbSmallCar.Name = "rdbSmallCar";
            this.rdbSmallCar.Size = new System.Drawing.Size(108, 17);
            this.rdbSmallCar.TabIndex = 2;
            this.rdbSmallCar.TabStop = true;
            this.rdbSmallCar.Text = "Small $40.00/day";
            this.rdbSmallCar.UseVisualStyleBackColor = true;
            this.rdbSmallCar.CheckedChanged += new System.EventHandler(this.rdbSmallCar_CheckedChanged);
            // 
            // rdbMediumCar
            // 
            this.rdbMediumCar.AutoSize = true;
            this.rdbMediumCar.Enabled = false;
            this.rdbMediumCar.Location = new System.Drawing.Point(6, 42);
            this.rdbMediumCar.Name = "rdbMediumCar";
            this.rdbMediumCar.Size = new System.Drawing.Size(120, 17);
            this.rdbMediumCar.TabIndex = 3;
            this.rdbMediumCar.TabStop = true;
            this.rdbMediumCar.Text = "Medium $50.00/day";
            this.rdbMediumCar.UseVisualStyleBackColor = true;
            this.rdbMediumCar.CheckedChanged += new System.EventHandler(this.rdbMediumCar_CheckedChanged);
            // 
            // rdbSportsCar
            // 
            this.rdbSportsCar.AutoSize = true;
            this.rdbSportsCar.Enabled = false;
            this.rdbSportsCar.Location = new System.Drawing.Point(6, 65);
            this.rdbSportsCar.Name = "rdbSportsCar";
            this.rdbSportsCar.Size = new System.Drawing.Size(113, 17);
            this.rdbSportsCar.TabIndex = 4;
            this.rdbSportsCar.TabStop = true;
            this.rdbSportsCar.Text = "Sports $60.00/day";
            this.rdbSportsCar.UseVisualStyleBackColor = true;
            this.rdbSportsCar.CheckedChanged += new System.EventHandler(this.rdbSportsCar_CheckedChanged);
            // 
            // chbInsurance
            // 
            this.chbInsurance.AutoSize = true;
            this.chbInsurance.Enabled = false;
            this.chbInsurance.Location = new System.Drawing.Point(238, 118);
            this.chbInsurance.Name = "chbInsurance";
            this.chbInsurance.Size = new System.Drawing.Size(131, 17);
            this.chbInsurance.TabIndex = 5;
            this.chbInsurance.Text = "Insurance $15.00/day";
            this.chbInsurance.UseVisualStyleBackColor = true;
            this.chbInsurance.CheckedChanged += new System.EventHandler(this.chbInsurance_CheckedChanged);
            // 
            // chbDiscount
            // 
            this.chbDiscount.AutoSize = true;
            this.chbDiscount.Enabled = false;
            this.chbDiscount.Location = new System.Drawing.Point(238, 141);
            this.chbDiscount.Name = "chbDiscount";
            this.chbDiscount.Size = new System.Drawing.Size(120, 17);
            this.chbDiscount.TabIndex = 6;
            this.chbDiscount.Text = "AMA Discount -10%";
            this.chbDiscount.UseVisualStyleBackColor = true;
            this.chbDiscount.CheckedChanged += new System.EventHandler(this.chbDiscount_CheckedChanged);
            // 
            // nudNumOfDays
            // 
            this.nudNumOfDays.Enabled = false;
            this.nudNumOfDays.Location = new System.Drawing.Point(324, 169);
            this.nudNumOfDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudNumOfDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOfDays.Name = "nudNumOfDays";
            this.nudNumOfDays.Size = new System.Drawing.Size(44, 20);
            this.nudNumOfDays.TabIndex = 7;
            this.nudNumOfDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOfDays.ValueChanged += new System.EventHandler(this.nudNumOfDays_ValueChanged);
            // 
            // lblNumOfDays
            // 
            this.lblNumOfDays.AutoSize = true;
            this.lblNumOfDays.Enabled = false;
            this.lblNumOfDays.Location = new System.Drawing.Point(235, 171);
            this.lblNumOfDays.Name = "lblNumOfDays";
            this.lblNumOfDays.Size = new System.Drawing.Size(83, 13);
            this.lblNumOfDays.TabIndex = 7;
            this.lblNumOfDays.Text = "Number of Days";
            this.lblNumOfDays.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(127, 223);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Enabled = false;
            this.lblFinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.Location = new System.Drawing.Point(193, 223);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(66, 25);
            this.lblFinalTotal.TabIndex = 9;
            this.lblFinalTotal.Text = "$0.00";
            this.lblFinalTotal.Click += new System.EventHandler(this.lblFinalTotal_Click);
            // 
            // frmCarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 289);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNumOfDays);
            this.Controls.Add(this.nudNumOfDays);
            this.Controls.Add(this.chbDiscount);
            this.Controls.Add(this.chbInsurance);
            this.Controls.Add(this.gbxCarType);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Name = "frmCarRental";
            this.Text = "Car Rental";
            this.gbxCarType.ResumeLayout(false);
            this.gbxCarType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox gbxCarType;
        private System.Windows.Forms.RadioButton rdbSportsCar;
        private System.Windows.Forms.RadioButton rdbMediumCar;
        private System.Windows.Forms.RadioButton rdbSmallCar;
        private System.Windows.Forms.CheckBox chbInsurance;
        private System.Windows.Forms.CheckBox chbDiscount;
        private System.Windows.Forms.NumericUpDown nudNumOfDays;
        private System.Windows.Forms.Label lblNumOfDays;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFinalTotal;
    }
}


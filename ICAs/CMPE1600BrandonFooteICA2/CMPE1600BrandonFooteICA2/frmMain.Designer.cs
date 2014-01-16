namespace CMPE1600BrandonFooteICA2
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
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblRegHours = new System.Windows.Forms.Label();
            this.lblOvertimeHours = new System.Windows.Forms.Label();
            this.lblRegPay = new System.Windows.Forms.Label();
            this.lblOvertimePay = new System.Windows.Forms.Label();
            this.lblPayDue = new System.Windows.Forms.Label();
            this.tbxHourlyRate = new System.Windows.Forms.TextBox();
            this.lbxHourlyRate = new System.Windows.Forms.TextBox();
            this.lblRegHoursOutput = new System.Windows.Forms.Label();
            this.lblOvertimeHoursOutput = new System.Windows.Forms.Label();
            this.lblRegPayTotal = new System.Windows.Forms.Label();
            this.lblOvertimePayTotal = new System.Windows.Forms.Label();
            this.lblPayDueTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(81, 30);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.lblHourlyRate.TabIndex = 1;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(68, 56);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(76, 13);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // lblRegHours
            // 
            this.lblRegHours.AutoSize = true;
            this.lblRegHours.Location = new System.Drawing.Point(104, 110);
            this.lblRegHours.Name = "lblRegHours";
            this.lblRegHours.Size = new System.Drawing.Size(75, 13);
            this.lblRegHours.TabIndex = 3;
            this.lblRegHours.Text = "Regular Hours";
            // 
            // lblOvertimeHours
            // 
            this.lblOvertimeHours.AutoSize = true;
            this.lblOvertimeHours.Location = new System.Drawing.Point(99, 133);
            this.lblOvertimeHours.Name = "lblOvertimeHours";
            this.lblOvertimeHours.Size = new System.Drawing.Size(80, 13);
            this.lblOvertimeHours.TabIndex = 4;
            this.lblOvertimeHours.Text = "Overtime Hours";
            // 
            // lblRegPay
            // 
            this.lblRegPay.AutoSize = true;
            this.lblRegPay.Location = new System.Drawing.Point(114, 163);
            this.lblRegPay.Name = "lblRegPay";
            this.lblRegPay.Size = new System.Drawing.Size(65, 13);
            this.lblRegPay.TabIndex = 5;
            this.lblRegPay.Text = "Regular Pay";
            // 
            // lblOvertimePay
            // 
            this.lblOvertimePay.AutoSize = true;
            this.lblOvertimePay.Location = new System.Drawing.Point(109, 186);
            this.lblOvertimePay.Name = "lblOvertimePay";
            this.lblOvertimePay.Size = new System.Drawing.Size(70, 13);
            this.lblOvertimePay.TabIndex = 6;
            this.lblOvertimePay.Text = "Overtime Pay";
            // 
            // lblPayDue
            // 
            this.lblPayDue.AutoSize = true;
            this.lblPayDue.Location = new System.Drawing.Point(131, 215);
            this.lblPayDue.Name = "lblPayDue";
            this.lblPayDue.Size = new System.Drawing.Size(48, 13);
            this.lblPayDue.TabIndex = 7;
            this.lblPayDue.Text = "Pay Due";
            // 
            // tbxHourlyRate
            // 
            this.tbxHourlyRate.Location = new System.Drawing.Point(161, 27);
            this.tbxHourlyRate.Name = "tbxHourlyRate";
            this.tbxHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.tbxHourlyRate.TabIndex = 8;
            // 
            // lbxHourlyRate
            // 
            this.lbxHourlyRate.Location = new System.Drawing.Point(161, 53);
            this.lbxHourlyRate.Name = "lbxHourlyRate";
            this.lbxHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.lbxHourlyRate.TabIndex = 9;
            // 
            // lblRegHoursOutput
            // 
            this.lblRegHoursOutput.AutoSize = true;
            this.lblRegHoursOutput.Location = new System.Drawing.Point(185, 110);
            this.lblRegHoursOutput.Name = "lblRegHoursOutput";
            this.lblRegHoursOutput.Size = new System.Drawing.Size(35, 13);
            this.lblRegHoursOutput.TabIndex = 10;
            this.lblRegHoursOutput.Text = "label1";
            this.lblRegHoursOutput.Visible = false;
            // 
            // lblOvertimeHoursOutput
            // 
            this.lblOvertimeHoursOutput.AutoSize = true;
            this.lblOvertimeHoursOutput.Location = new System.Drawing.Point(185, 133);
            this.lblOvertimeHoursOutput.Name = "lblOvertimeHoursOutput";
            this.lblOvertimeHoursOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOvertimeHoursOutput.TabIndex = 11;
            this.lblOvertimeHoursOutput.Text = "label9";
            this.lblOvertimeHoursOutput.Visible = false;
            // 
            // lblRegPayTotal
            // 
            this.lblRegPayTotal.AutoSize = true;
            this.lblRegPayTotal.Location = new System.Drawing.Point(185, 163);
            this.lblRegPayTotal.Name = "lblRegPayTotal";
            this.lblRegPayTotal.Size = new System.Drawing.Size(41, 13);
            this.lblRegPayTotal.TabIndex = 12;
            this.lblRegPayTotal.Text = "label10";
            this.lblRegPayTotal.Visible = false;
            // 
            // lblOvertimePayTotal
            // 
            this.lblOvertimePayTotal.AutoSize = true;
            this.lblOvertimePayTotal.Location = new System.Drawing.Point(185, 186);
            this.lblOvertimePayTotal.Name = "lblOvertimePayTotal";
            this.lblOvertimePayTotal.Size = new System.Drawing.Size(41, 13);
            this.lblOvertimePayTotal.TabIndex = 13;
            this.lblOvertimePayTotal.Text = "label11";
            this.lblOvertimePayTotal.Visible = false;
            // 
            // lblPayDueTotal
            // 
            this.lblPayDueTotal.AutoSize = true;
            this.lblPayDueTotal.Location = new System.Drawing.Point(185, 215);
            this.lblPayDueTotal.Name = "lblPayDueTotal";
            this.lblPayDueTotal.Size = new System.Drawing.Size(41, 13);
            this.lblPayDueTotal.TabIndex = 14;
            this.lblPayDueTotal.Text = "label12";
            this.lblPayDueTotal.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(134, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 296);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPayDueTotal);
            this.Controls.Add(this.lblOvertimePayTotal);
            this.Controls.Add(this.lblRegPayTotal);
            this.Controls.Add(this.lblOvertimeHoursOutput);
            this.Controls.Add(this.lblRegHoursOutput);
            this.Controls.Add(this.lbxHourlyRate);
            this.Controls.Add(this.tbxHourlyRate);
            this.Controls.Add(this.lblPayDue);
            this.Controls.Add(this.lblOvertimePay);
            this.Controls.Add(this.lblRegPay);
            this.Controls.Add(this.lblOvertimeHours);
            this.Controls.Add(this.lblRegHours);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHourlyRate);
            this.Name = "frmMain";
            this.Text = "Pay Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblRegHours;
        private System.Windows.Forms.Label lblOvertimeHours;
        private System.Windows.Forms.Label lblRegPay;
        private System.Windows.Forms.Label lblOvertimePay;
        private System.Windows.Forms.Label lblPayDue;
        private System.Windows.Forms.TextBox tbxHourlyRate;
        private System.Windows.Forms.TextBox lbxHourlyRate;
        private System.Windows.Forms.Label lblRegHoursOutput;
        private System.Windows.Forms.Label lblOvertimeHoursOutput;
        private System.Windows.Forms.Label lblRegPayTotal;
        private System.Windows.Forms.Label lblOvertimePayTotal;
        private System.Windows.Forms.Label lblPayDueTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}


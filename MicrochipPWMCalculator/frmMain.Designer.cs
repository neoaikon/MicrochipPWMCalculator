namespace MicrochipPWMCalculator
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
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.txtPWMFreq = new System.Windows.Forms.TextBox();
            this.txtDivs = new System.Windows.Forms.TextBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblPWMFreq = new System.Windows.Forms.Label();
            this.lblDivs = new System.Windows.Forms.Label();
            this.txtCountsP = new System.Windows.Forms.TextBox();
            this.lblCountsP = new System.Windows.Forms.Label();
            this.lblCountsD = new System.Windows.Forms.Label();
            this.txtCountsD = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(146, 12);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(100, 20);
            this.txtFreq.TabIndex = 0;
            this.txtFreq.Text = "1000000";
            this.txtFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPWMFreq
            // 
            this.txtPWMFreq.Location = new System.Drawing.Point(146, 38);
            this.txtPWMFreq.Name = "txtPWMFreq";
            this.txtPWMFreq.Size = new System.Drawing.Size(100, 20);
            this.txtPWMFreq.TabIndex = 1;
            this.txtPWMFreq.Text = "10000";
            this.txtPWMFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDivs
            // 
            this.txtDivs.Location = new System.Drawing.Point(146, 64);
            this.txtDivs.Name = "txtDivs";
            this.txtDivs.Size = new System.Drawing.Size(100, 20);
            this.txtDivs.TabIndex = 2;
            this.txtDivs.Text = "100";
            this.txtDivs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(33, 15);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(107, 13);
            this.lblFreq.TabIndex = 3;
            this.lblFreq.Text = "Processor Frequency";
            // 
            // lblPWMFreq
            // 
            this.lblPWMFreq.AutoSize = true;
            this.lblPWMFreq.Location = new System.Drawing.Point(53, 41);
            this.lblPWMFreq.Name = "lblPWMFreq";
            this.lblPWMFreq.Size = new System.Drawing.Size(87, 13);
            this.lblPWMFreq.TabIndex = 4;
            this.lblPWMFreq.Text = "PWM Frequency";
            // 
            // lblDivs
            // 
            this.lblDivs.AutoSize = true;
            this.lblDivs.Location = new System.Drawing.Point(83, 67);
            this.lblDivs.Name = "lblDivs";
            this.lblDivs.Size = new System.Drawing.Size(49, 13);
            this.lblDivs.TabIndex = 5;
            this.lblDivs.Text = "Divisions";
            // 
            // txtCountsP
            // 
            this.txtCountsP.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountsP.Location = new System.Drawing.Point(146, 90);
            this.txtCountsP.Name = "txtCountsP";
            this.txtCountsP.ReadOnly = true;
            this.txtCountsP.Size = new System.Drawing.Size(100, 20);
            this.txtCountsP.TabIndex = 6;
            this.txtCountsP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCountsP
            // 
            this.lblCountsP.AutoSize = true;
            this.lblCountsP.Location = new System.Drawing.Point(19, 93);
            this.lblCountsP.Name = "lblCountsP";
            this.lblCountsP.Size = new System.Drawing.Size(121, 13);
            this.lblCountsP.TabIndex = 7;
            this.lblCountsP.Text = "Timer Counts Per Period";
            // 
            // lblCountsD
            // 
            this.lblCountsD.AutoSize = true;
            this.lblCountsD.Location = new System.Drawing.Point(12, 119);
            this.lblCountsD.Name = "lblCountsD";
            this.lblCountsD.Size = new System.Drawing.Size(128, 13);
            this.lblCountsD.TabIndex = 8;
            this.lblCountsD.Text = "Timer Counts Per Division";
            // 
            // txtCountsD
            // 
            this.txtCountsD.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountsD.Location = new System.Drawing.Point(146, 116);
            this.txtCountsD.Name = "txtCountsD";
            this.txtCountsD.ReadOnly = true;
            this.txtCountsD.Size = new System.Drawing.Size(100, 20);
            this.txtCountsD.TabIndex = 9;
            this.txtCountsD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(146, 168);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.Window;
            this.txtError.Location = new System.Drawing.Point(146, 142);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(100, 20);
            this.txtError.TabIndex = 12;
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Error %";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::MicrochipPWMCalculator.Properties.Resources.contentbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(256, 198);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtCountsD);
            this.Controls.Add(this.lblCountsD);
            this.Controls.Add(this.lblCountsP);
            this.Controls.Add(this.txtCountsP);
            this.Controls.Add(this.lblDivs);
            this.Controls.Add(this.lblPWMFreq);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.txtDivs);
            this.Controls.Add(this.txtPWMFreq);
            this.Controls.Add(this.txtFreq);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Microchip PWM Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.TextBox txtPWMFreq;
        private System.Windows.Forms.TextBox txtDivs;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label lblPWMFreq;
        private System.Windows.Forms.Label lblDivs;
        private System.Windows.Forms.TextBox txtCountsP;
        private System.Windows.Forms.Label lblCountsP;
        private System.Windows.Forms.Label lblCountsD;
        private System.Windows.Forms.TextBox txtCountsD;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label1;
    }
}


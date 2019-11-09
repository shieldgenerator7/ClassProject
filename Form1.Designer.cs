namespace ClassProject
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbTipType = new System.Windows.Forms.ComboBox();
            this.lstChecks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumTotal = new System.Windows.Forms.Label();
            this.rdbDineIn = new System.Windows.Forms.RadioButton();
            this.rdbFastFood = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(94, 46);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(97, 72);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(52, 20);
            this.txtSubtotal.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(97, 103);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(61, 19);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(97, 163);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "$0.00";
            // 
            // cmbTipType
            // 
            this.cmbTipType.FormattingEnabled = true;
            this.cmbTipType.Location = new System.Drawing.Point(181, 72);
            this.cmbTipType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipType.Name = "cmbTipType";
            this.cmbTipType.Size = new System.Drawing.Size(62, 21);
            this.cmbTipType.TabIndex = 5;
            // 
            // lstChecks
            // 
            this.lstChecks.FormattingEnabled = true;
            this.lstChecks.Location = new System.Drawing.Point(270, 48);
            this.lstChecks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstChecks.Name = "lstChecks";
            this.lstChecks.Size = new System.Drawing.Size(180, 147);
            this.lstChecks.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(478, 72);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(88, 20);
            this.txtLocation.TabIndex = 8;
            this.txtLocation.Text = "Columbus, OH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sum Total";
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.Location = new System.Drawing.Point(273, 229);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Size = new System.Drawing.Size(34, 13);
            this.lblSumTotal.TabIndex = 10;
            this.lblSumTotal.Text = "$0.00";
            // 
            // rdbDineIn
            // 
            this.rdbDineIn.AutoSize = true;
            this.rdbDineIn.Checked = true;
            this.rdbDineIn.Location = new System.Drawing.Point(181, 103);
            this.rdbDineIn.Name = "rdbDineIn";
            this.rdbDineIn.Size = new System.Drawing.Size(59, 17);
            this.rdbDineIn.TabIndex = 11;
            this.rdbDineIn.TabStop = true;
            this.rdbDineIn.Text = "Dine In";
            this.rdbDineIn.UseVisualStyleBackColor = true;
            // 
            // rdbFastFood
            // 
            this.rdbFastFood.AutoSize = true;
            this.rdbFastFood.Location = new System.Drawing.Point(181, 126);
            this.rdbFastFood.Name = "rdbFastFood";
            this.rdbFastFood.Size = new System.Drawing.Size(72, 17);
            this.rdbFastFood.TabIndex = 12;
            this.rdbFastFood.Text = "Fast Food";
            this.rdbFastFood.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 318);
            this.Controls.Add(this.rdbFastFood);
            this.Controls.Add(this.rdbDineIn);
            this.Controls.Add(this.lblSumTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstChecks);
            this.Controls.Add(this.cmbTipType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbTipType;
        private System.Windows.Forms.ListBox lstChecks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumTotal;
        private System.Windows.Forms.RadioButton rdbDineIn;
        private System.Windows.Forms.RadioButton rdbFastFood;
    }
}


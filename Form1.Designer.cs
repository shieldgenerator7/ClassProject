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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(188, 88);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(91, 25);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(194, 138);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 31);
            this.txtSubtotal.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(194, 198);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 37);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(194, 313);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "$0.00";
            // 
            // cmbTipType
            // 
            this.cmbTipType.FormattingEnabled = true;
            this.cmbTipType.Location = new System.Drawing.Point(362, 138);
            this.cmbTipType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipType.Name = "cmbTipType";
            this.cmbTipType.Size = new System.Drawing.Size(120, 33);
            this.cmbTipType.TabIndex = 5;
            // 
            // lstChecks
            // 
            this.lstChecks.FormattingEnabled = true;
            this.lstChecks.ItemHeight = 25;
            this.lstChecks.Location = new System.Drawing.Point(578, 88);
            this.lstChecks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstChecks.Name = "lstChecks";
            this.lstChecks.Size = new System.Drawing.Size(356, 279);
            this.lstChecks.TabIndex = 6;
            this.lstChecks.SelectedIndexChanged += new System.EventHandler(this.lstChecks_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(360, 340);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(172, 31);
            this.txtLocation.TabIndex = 8;
            this.txtLocation.Text = "Columbus, OH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sum Total";
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.Location = new System.Drawing.Point(584, 436);
            this.lblSumTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Size = new System.Drawing.Size(66, 25);
            this.lblSumTotal.TabIndex = 10;
            this.lblSumTotal.Text = "$0.00";
            // 
            // rdbDineIn
            // 
            this.rdbDineIn.AutoSize = true;
            this.rdbDineIn.Checked = true;
            this.rdbDineIn.Location = new System.Drawing.Point(362, 198);
            this.rdbDineIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbDineIn.Name = "rdbDineIn";
            this.rdbDineIn.Size = new System.Drawing.Size(110, 29);
            this.rdbDineIn.TabIndex = 11;
            this.rdbDineIn.TabStop = true;
            this.rdbDineIn.Text = "Dine In";
            this.rdbDineIn.UseVisualStyleBackColor = true;
            // 
            // rdbFastFood
            // 
            this.rdbFastFood.AutoSize = true;
            this.rdbFastFood.Location = new System.Drawing.Point(362, 242);
            this.rdbFastFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbFastFood.Name = "rdbFastFood";
            this.rdbFastFood.Size = new System.Drawing.Size(140, 29);
            this.rdbFastFood.TabIndex = 12;
            this.rdbFastFood.Text = "Fast Food";
            this.rdbFastFood.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1483, 44);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(985, 88);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(356, 279);
            this.txtDisplay.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 533);
            this.Controls.Add(this.txtDisplay);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}


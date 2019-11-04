using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float total = 0;
            //Get the subtotal from the textbox
            float subtotal = float.Parse(txtSubtotal.Text);
            //Calculate the tip
            float tip = subtotal * 0.15f;
            //Calculate the total
            total = subtotal + tip;
            //Display the total to the user
            lblTotal.Text = ""+total;
        }
    }
}

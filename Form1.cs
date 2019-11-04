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

        public enum TipType
        {
            EXCELLENT,
            GOOD,
            POOR
        }
        public TipType tipType = TipType.GOOD;

        public List<float> totals = new List<float>();

        public Form1()
        {
            InitializeComponent();

            foreach(var item in Enum.GetValues(typeof(TipType)))
            {
                cmbTipType.Items.Add(item);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float total = 0;
            //Get the subtotal from the textbox
            float subtotal = float.Parse(txtSubtotal.Text);
            //Get the tip percentage
            float tipPercentage = 0;
            //tipType = (TipType)cmbTipType.Text;
            //tipType = TipType.POOR;
            tipType = (TipType)cmbTipType.SelectedItem;
            switch (tipType)
            {
                case TipType.EXCELLENT:
                    tipPercentage = 0.15f;
                    break;
                case TipType.GOOD:
                    tipPercentage = 0.10f;
                    break;
                case TipType.POOR:
                    tipPercentage = 0;
                    break;
            }
            //Calculate the tip
            float tip = subtotal * tipPercentage;
            //Calculate the total
            total = subtotal + tip;
            //Display the total to the user
            lblTotal.Text = ""+total;
            //Refresh bill list
            totals.Add(total);
            refreshList();
        }

        public void refreshList()
        {
            //Clear list box
            lstChecks.Items.Clear();
            //Add all items to the list box
            foreach(float f in totals)
            {
                lstChecks.Items.Add(f);
            }
        }
    }
}

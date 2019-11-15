using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

        public List<Check> checks = new List<Check>();

        public Form1()
        {
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(TipType)))
            {
                cmbTipType.Items.Add(item);
            }
            cmbTipType.SelectedIndex = 0;
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
            //Create check object
            Check check = null;
            if (rdbDineIn.Checked == true)
            {
                check = new Check(total, txtLocation.Text);
            }
            else if (rdbFastFood.Checked == true)
            {
                check = new FastFoodCheck(total, txtLocation.Text);
            }
            total = check.calculateTotal(subtotal);
            //Display the total to the user
            lblTotal.Text = "" + total;
            //Add check to list
            checks.Add(check);
            //Refresh check list
            refreshList();
        }

        public void refreshList()
        {
            //Clear list box
            lstChecks.Items.Clear();
            //Add all items to the list box
            foreach (Check check in checks)
            {
                lstChecks.Items.Add(check);
            }
        }

        public void updateTotal()
        {
            //loop over all checks
            float sum = 0;
            foreach (Check check in checks)
            {
                sum += check.total;
            }
            //Update UI
            lblSumTotal.Text = "" + sum;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt";
            saveDialog.FilterIndex = 0;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;
                FileStream buffer = File.Create(filePath);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(buffer, checks);
                buffer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "txt files (*.txt)|*.txt";
            openDialog.FilterIndex = 0;
            openDialog.RestoreDirectory = true;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openDialog.FileName;
                IFormatter formatter = new BinaryFormatter();
                FileStream buffer = File.OpenRead(filePath);
                checks = (List<Check>)formatter.Deserialize(buffer);
                buffer.Close();
                refreshList();
                updateTotal();
            }
        }

        private void lstChecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check selectedCheck = (Check)lstChecks.SelectedItem;
            txtDisplay.Text = selectedCheck.displayInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class MainForm : Form
    {
        private string name = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            //Begin my work

            InitializeGUI();
          
        }

        private void InitializeGUI()
        {
            this.Text += " Camilo Chavez";
            lblBMI.Text = string.Empty;
            lblWeightCat.Text = string.Empty;
            lblNormalBMI.Text = "Normal Weight";
            rbtnMetric.Checked = true;

        }

        private void UpdateHeightText()
        {
            if (rbtnMetric.Checked )
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
            }
            else 
            { 
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbls)";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grpResults_Enter(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 1 read input
            bool ok = ReadInput();

            // 2 Calculate
            // 3 show results

        }

        private bool ReadInput()
        {
            ReadName();
            bool HeightOk = ReadHeight();
            bool WeightOk = ReadWeight();

            return HeightOk && WeightOk;
        }

        private void ReadName() {
            name = txtName.Text.Trim();
            grpResults.Text = name;

        }
        private bool ReadHeight() {
            double height = 0.0;
            
            double inch = 0.0;

            //try parse

            bool ok = double.TryParse(txtCentimeter.Text, out height);
            if (!ok)
            {
                MessageBox.Show("The height value is invalid.", "Error!");
            }

            if (rbtnImperial.Checked)
            {
                ok = ok && double.TryParse(txtInch.Text, out height);
                if (!ok)
                {
                    MessageBox.Show("The inch value is invalid.", "Error!");
                }
            }
            return ok;
        }

        private bool ReadWeight() { 

            double weight = 0.0;
            bool ok = double.TryParse(txtKg.Text, out weight);
            if (!ok)
            {
                MessageBox.Show("The weight value is invalid.", "Error!");
            }

            return ok;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

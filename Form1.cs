using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height, weight, bmi;
            height = double.Parse (txtHeight.Text);
            weight = double.Parse (txtWeight.Text);
            bmi = weight / (height * height);
            txtBMI.Text=bmi.ToString();


            if (bmi > 18.5)
            {
                textBox2.Text = "Under Weighnt";
                txtIndicator.BackColor = Color.Red;
            }
            else if (bmi < 25)
            {
                textBox2.Text = "Normal";
                txtIndicator.BackColor = Color.Blue;
            }
            else if (bmi < 30)
            {
                textBox2.Text =  "Obesity class I";
                txtIndicator.BackColor = Color.Orange;
            }
            else if (bmi < 40)
            {
                textBox2.Text = "Obesity class II";
                txtIndicator.BackColor = Color.Pink;
            }
            else 
            {
                textBox2.Text = "Obesity class III";
                txtIndicator.BackColor = Color.Brown;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            txtWeight.Clear();
            txtIndicator.BackColor = Color.White;
            txtHeight.Clear();
            txtBMI.Clear();

        }
    }
}

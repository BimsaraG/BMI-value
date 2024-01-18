using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}

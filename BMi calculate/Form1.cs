using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMi_calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(textBox2.Text);
            double weight = Convert.ToDouble(textBox1.Text);

            double result = BMI(height, weight);

            if (result <= 18.5)
            {
                MessageBox.Show(" Underweight");
            }

            else if (result >= 18.6 && result <= 24.9)
            {

                MessageBox.Show(" Normal");

            }

            else if (result >= 25 && result <= 29.9)
            {
                MessageBox.Show("Overweight");
            }

            else if (result >= 30)
            {
                MessageBox.Show("Obese");
            }
        }
        private double BMI(double weight, double height)
        {
            return weight / (height * height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

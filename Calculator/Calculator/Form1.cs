using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                double numsum1 = Convert.ToDouble(textBox1.Text);
                double numsum2 = Convert.ToDouble(textBox2.Text);
                double sum = numsum1 + numsum2;
                MessageBox.Show("resul is = " + sum);
            }
            else
            {
                MessageBox.Show("Please enter the required values !");
            }
           
        }

        private void mines_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double nummines1 = Convert.ToDouble(textBox1.Text);
                double nummines2 = Convert.ToDouble(textBox2.Text);
                double mines = nummines1 - nummines2;
                MessageBox.Show("resul is = " + mines);
            }
            else
            {
                MessageBox.Show("Please enter the required values !");
            }
        }

        private void multy_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double nummulty1 = Convert.ToDouble(textBox1.Text);
                double nummulty2 = Convert.ToDouble(textBox2.Text);
                double multy = nummulty1 * nummulty2;
                MessageBox.Show("resul is = " + multy);
            }
            else
            {
                MessageBox.Show("Please enter the required values !");
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double numDivision1 = Convert.ToDouble(textBox1.Text);
                double numDivision2 = Convert.ToDouble(textBox2.Text);
                double Division = numDivision1 / numDivision2;
                MessageBox.Show("resul is = " + Division);
            }
            else
            {
                MessageBox.Show("Please enter the required values !");
            }
        }

        private void modulus_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text != "")
            {
                double digit = double.Parse(textBox1.Text);
                double endmodulus = Math.Abs(digit);
                MessageBox.Show("resul is = " + endmodulus);
            }
            else
            {
                MessageBox.Show("Please enter the required amount !");
            }
        }

        private void power2_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {
                double power2 = double.Parse(textBox1.Text);
                double endpower2 = Math.Pow(power2, 2);
                MessageBox.Show("resul is = " + endpower2);
            }
            else
            {
                MessageBox.Show("Please enter the required amount !");
            }
        }

        private void radical_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {
                double radical = double.Parse(textBox1.Text);
                double endradical = Math.Sqrt(radical);
                MessageBox.Show("resul is = " + endradical);
            }
            else
            {
                MessageBox.Show("Please enter the required amount !");
            }
        }
        private void factorial_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {
                double factorial = 1, digitfactorial;
                digitfactorial = double.Parse(textBox1.Text);
                for (int i = 1; i <= digitfactorial; i++)
                {
                    factorial *= i;
                }
                MessageBox.Show("resul is : " + factorial);
            }
            else
            {
                MessageBox.Show("Please enter the required amount !");
            }
        }

        private void power_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double power = double.Parse(textBox1.Text);
                double powerr = double.Parse(textBox2.Text);
                double endpower = Math.Pow(power, powerr);
                MessageBox.Show("resul is = " + endpower);
            }
            else
            {
                MessageBox.Show("Please enter the required values !");
            }
        }

        private void logarithm_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text != "")
            {
                double digitlogarithm = double.Parse(textBox1.Text);
                double resullogarithm = Math.Log(digitlogarithm, 10);
                MessageBox.Show($"The logarithm of the number {digitlogarithm} is equal to {resullogarithm}");
            }
            else
            {
                MessageBox.Show("Please enter the required amount !");
            }
        }

        private void lnlog_Click(object sender, EventArgs e)
        {

          
            if (textBox1.Text != "")
            {
                double digitlnlog = double.Parse(textBox1.Text);
                double resullnlog = Math.Log(digitlnlog);
                MessageBox.Show("resul is : " + resullnlog);
            }
            else
            {
                MessageBox.Show("Please enter the required amount !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Note: Text box number one has priority for operations such as logarithms and powers of 2!");
        }
    }
}

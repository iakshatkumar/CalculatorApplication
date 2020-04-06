using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApplication
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operator;
        bool Click = false;



        public Form1()
        {
            InitializeComponent();
        }

       
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("."))
            {
                Click = true;
                            
            }
        }
        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else
            textBox.Text = textBox.Text + "0";
            
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "1";
            }
            else
                textBox.Text = textBox.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "2";
            }
            else
                textBox.Text = textBox.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "3";
            }
            else
                textBox.Text = textBox.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "4";
            }
            else
                textBox.Text = textBox.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "5";
            }
            else
                textBox.Text = textBox.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "6";
            }
            else
                textBox.Text = textBox.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "7";
            }
            else
                textBox.Text = textBox.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "8";
            }
            else
                textBox.Text = textBox.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "9";
            }
            else
                textBox.Text = textBox.Text + "9";
        }

        

        private void add_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operator = "+";
            label.Text = Convert.ToDouble(FirstNumber) + " " + Operator;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operator = "-";
            label.Text = Convert.ToDouble(FirstNumber) + " " + Operator;

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operator = "*";
            label.Text = Convert.ToDouble(FirstNumber) + " " + Operator;

        }

        private void division_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operator = "/";
            label.Text = Convert.ToDouble(FirstNumber) + " " + Operator;
        }
        private void dotOperator_Click(object sender, EventArgs e)
        {

            if (Click == true)
            {

            }
            else
            textBox.Text = textBox.Text + ".";
        }
        private void evaluate_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox.Text);

            if (Operator == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }


            if (Operator == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }


            if (Operator == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }


            if (Operator == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox.Text = "Not Defined";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }



        }

        private void label_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            label.Text = null;
        }
    }

}

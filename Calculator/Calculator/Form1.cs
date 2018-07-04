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

        double FirstNumber;
        string Operation;
        double SecondNumber;
        double Result;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button_1_Click_1(object sender, EventArgs e)
        {
            Return_One();

        }
        private void Return_One()
        {
            textBox_calculator.Text += "1";
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            Return_Two();
        }
        private void Return_Two()
        {
            textBox_calculator.Text +="2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Return_Three();
        }

        private void Return_Three()
        {
            textBox_calculator.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            Return_Four();
        }

        private void Return_Four()
        {
            textBox_calculator.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            Return_Five();
        }

        private void Return_Five()
        {
            textBox_calculator.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            Return_Six();
        }

        private void Return_Six()
        {
            textBox_calculator.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            Return_Seven();
        }

        private void Return_Seven()
        {
            textBox_calculator.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            Return_Eight();
        }

        private void Return_Eight()
        {
            textBox_calculator.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            Return_Nine();
        }

        private void Return_Nine()
        {
            textBox_calculator.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Return_Zero();
        }

        private void Return_Zero()
        {
            textBox_calculator.Text += "0";
        }
       

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_calculator.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_calculator.Text);
            textBox_calculator.Text=string.Empty;
            Operation = "+";
            
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_calculator.Text);
            textBox_calculator.Text = string.Empty;
            Operation = "-";

        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_calculator.Text);
            textBox_calculator.Text = string.Empty;
            Operation = "*";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_calculator.Text);
            textBox_calculator.Text = string.Empty;
            Operation = "/";
        }

       

        private void button_equal_Click_1(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(textBox_calculator.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox_calculator.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox_calculator.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox_calculator.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                Result = (FirstNumber / SecondNumber);
                textBox_calculator.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_calculator.Text += ".";
        }
    }
}

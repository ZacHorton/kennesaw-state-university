using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3B
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char operand;
        double results;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void display_Click_1(object sender, EventArgs e)
        { }

        private void button10_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "0";
            this.display.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "1";
            this.display.Text += input;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "2";
            this.display.Text += input;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "3";
            this.display.Text += input;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "4";
            this.display.Text += input;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "5";
            this.display.Text += input;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "6";
            this.display.Text += input;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "7";
            this.display.Text += input;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "8";
            this.display.Text += input;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "9";
            this.display.Text += input;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            op1 = input;
            operand = '+';
            input = string.Empty;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            op1 = input;
            operand = '-';
            input = string.Empty;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            op1 = input;
            operand = 'x';
            input = string.Empty;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            op1 = input;
            operand = '/';
            input = string.Empty;
        }

        private void button11_Click_1(object sender, EventArgs e)
            // EQUALS
        {
            op2 = input;
            double number1, number2;
            double.TryParse(op1, out number1);
            double.TryParse(op2, out number2);

            if (operand == '+')
            {
                results = number1 + number2;
                display.Text = results.ToString();
            }
            else if (operand == '-')
            {
                results = number1 - number2;
                display.Text = results.ToString();
            }
            else if (operand == 'x')
            {
                results = number1 * number2;
                display.Text = results.ToString();
            }
            else if (operand == '/')
            {
                if (number2 != 0)
                {
                    results = number1 / number2;
                    display.Text = results.ToString();
                }
                else
                {
                    display.Text = "Cannot divide by 0.";
                }
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        // CLEAR
        {
            this.display.Text = "0";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3B
{
    public partial class Form1 : Form
    {
        double op1, op2;
        double results;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(textBox1.Text);
            op2 = Convert.ToDouble(textBox2.Text);
            results = op1 + op2;
            display.Text = results.ToString();
        }
    }
}
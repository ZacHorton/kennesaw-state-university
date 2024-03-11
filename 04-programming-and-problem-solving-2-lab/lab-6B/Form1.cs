using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_6B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            StreamWriter sw = new StreamWriter("example.txt");
            sw.Write(text);
            sw.Close();
            MessageBox.Show("Lab 6B > Bin > Debug folder > \nexample.txt has been saved!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"example.txt";
            textBox1.Text = File.ReadAllText(path);
            MessageBox.Show("Lab 6B > Bin > Debug folder > \nexample.txt has been opened!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
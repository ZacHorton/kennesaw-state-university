using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = button1.Text;
            MessageBox.Show(name + " was clicked.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = button2.Text;
            MessageBox.Show(name + " was clicked.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = button3.Text;
            MessageBox.Show(name + " was clicked.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = button4.Text;
            MessageBox.Show(name + " was clicked.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = button5.Text;
            MessageBox.Show(name + " was clicked.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = button6.Text;
            MessageBox.Show(name + " was clicked.");
        }
    }
}

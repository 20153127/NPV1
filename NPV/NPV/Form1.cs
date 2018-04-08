using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t0 = Convert.ToDouble(textBox7.Text);
            double t1 = Convert.ToDouble(textBox1.Text);
            double t2 = Convert.ToDouble(textBox2.Text);
            double t3 = Convert.ToDouble(textBox3.Text);
            double t4 = Convert.ToDouble(textBox4.Text);
            double t5 = Convert.ToDouble(textBox5.Text);
            double t6=Convert.ToDouble(textBox6.Text);
            double t7 = (t1 / (1 + 0.01 * t6)) + (t2 / ((1 + 0.01 * t6) * (1 + 0.01 * t6))) + (t3 / ((1 + 0.01 * t6) * (1 + 0.01 * t6) * (1 + 0.01 * t6))) + (t4 / ((1 + 0.01 * t6) * (1 + 0.01 * t6) * (1 + 0.01 * t6) * (1 + 0.01 * t6))) + (t5 / ((1 + 0.01 * t6) * (1 + 0.01 * t6) * (1 + 0.01 * t6) * (1 + 0.01 * t6) * (1 + 0.01 * t6)))-t0;
            textBox8.Text = "" + t7;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

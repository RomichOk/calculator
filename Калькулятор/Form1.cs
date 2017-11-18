using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool minus = false;
        bool ymnogit = false;
        bool delet = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            plus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            minus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            delet = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ymnogit = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                decimal del = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = del.ToString();
            }
            if (minus)
            {
                decimal del = Convert.ToDecimal(textBox1.Text) - Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = del.ToString();
            }
            if (ymnogit)
            {
                decimal del = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = del.ToString();
            }
            if (delet)
            {
                decimal del = Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = del.ToString();
            }
        }
    }
}

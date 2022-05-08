using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormSimpleCalculaor
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

        private void btn_mltply_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            label1.Text = (a * b).ToString();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = (a / b);
            label1.Text = c.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            label1.Text = (a + b).ToString();
        }

        private void btn_sbstrct_Click(object sender, EventArgs e)
        {
          double  a = double.Parse(textBox1.Text);
          double b = double.Parse(textBox2.Text);
          label1.Text = (a - b).ToString();
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "";
        }
    }
}

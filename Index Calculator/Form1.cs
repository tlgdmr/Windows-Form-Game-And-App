using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormIndexCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           lbl_height.Text="Enter Your Height(m)";
           lbl_weight.Text="Enter Your Weight";
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_box1.Text);
            double b = double.Parse(txt_box2.Text);
            double result = (a / (b * b));
            lbl_1.Text =Math.Round(result ,1).ToString();
            if (result > 18.5 && result < 24.9)
            {
                lbl_1.ForeColor = Color.Green;
            }
            else if(result < 18.5)
            {
                lbl_1.ForeColor = Color.Pink;
            }
            else if(result >=25 && result <= 29.9)
            {
                lbl_1.ForeColor = Color.DarkOrange;
            }
            else if (result >= 30 && result <= 39.9)
            {
                lbl_1.ForeColor = Color.OrangeRed;
            }
            else if (result >= 40)
            {
                lbl_1.ForeColor = Color.Red;
            }
           

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IdealWeight open = new IdealWeight();
            open.Show();
        }
    }
}

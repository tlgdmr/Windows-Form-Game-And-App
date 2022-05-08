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
    public partial class IdealWeight : Form
    {
        public IdealWeight()
        {
            InitializeComponent();
        }

        private void btn_check2_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            weight = double.Parse(txt_box2_weight.Text);
            height = double.Parse(txt_box_height.Text);
            double resultWoman = (2.3 * (height / 2.54 - 60)) + 45.5;
            double resulMan = (2.3 * (height / 2.54 - 60)) + 50;

            if (check_box_Man.Checked)
            {
                lbl_result2.Text = Math.Round(resulMan , 0).ToString();
            }
            if (check_box_woman.Checked)
            {
                lbl_result2.Text = Math.Round(resultWoman, 0).ToString();
            }
            lbl_show.Text = "Your Ideal Weight is:";


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 getBack = new Form1();
            getBack.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindwsFormGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_1.Text = "Guess the Number";
            lbl_computer.Text = "Computer's Choose:";
            lbl_human.Text = "Your Choose:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            int nmbr = number.Next(1, 10);
            int a = int.Parse(textBox1.Text);

            listBox1.Items.Add(a);
            listBox2.Items.Add(nmbr);
            if (a == nmbr)
            {
                lbl_2.Text = $"{nmbr} Congrats you found it ";
                listBox1.Items.Clear();
                textBox1.Clear();
                listBox2.Items.Clear();
                lbl_1.Text = "Let's Find it Again";
            }
            else if (a != nmbr)
            {
                lbl_2.Text = String.Format("No It Was {0}", nmbr);
                lbl_1.Text = @"Computer Choose different number
in every round.Do Not Forget (:";
                textBox1.Clear();
             }

        }
         private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

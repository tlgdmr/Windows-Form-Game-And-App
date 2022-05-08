using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormRockPaperScissors
{
    public partial class Form1 : Form
    {
        int you = 0;
        int cmpter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random computer = new Random();
            int choosen = computer.Next(1,4);
            switch (choosen)
            {
                case 1:
                    {
                        
                        label1.Text = "Computer Choose Rock";
                        you++;
                        txt_you.Text = you.ToString();
                        if (you == 10)
                        {
                            BackColor = Color.Cyan;
                            label1.Text = "You Won Press Clear";
                            txt_cmptr.Clear();
                            txt_you.Clear();
                            you = 0;
                            cmpter = 0;
                        }
                        break;
                    }
                    
                case 2:
                    {
                       
                        label1.Text = "Computer Choose Paper"+ " DRAW";
                        break;
                    }
                case 3:
                    {
                       
                        label1.Text = "Computer Choose Scissors";
                        cmpter++;
                        txt_cmptr.Text = cmpter.ToString();
                        if (cmpter == 10)
                        {
                            BackColor = Color.Red;
                            label1.Text = "Computer Won Press Clear";
                            txt_cmptr.Clear();
                            txt_you.Clear();
                            cmpter = 0;
                            you = 0;
                        }
                        break;
                    }

                default:
                    break;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            Random computer = new Random();
            int choosen = computer.Next(1, 4);
            switch (choosen)
            {
                case 1:
                    {
                        
                        label1.Text = "Computer Choose Rock" + " DRAW";
                        break;
                    }
                case 2:
                    {
                        
                        label1.Text = "Computer Choose Paper";
                        cmpter++;
                        txt_cmptr.Text = cmpter.ToString();
                        if (cmpter == 10)
                        {
                            BackColor = Color.Red;
                            label1.Text = "Computer Won Press Clear";
                            txt_cmptr.Clear();
                            txt_you.Clear();
                            cmpter = 0;
                            you = 0;
                        }
                        break;
                    }
                case 3:
                    {
                        
                        label1.Text = "Computer Choose Scissors";
                        you++;
                        txt_you.Text = you.ToString();
                        if (you == 10)
                        {
                            BackColor = Color.Cyan;
                            label1.Text = "You Won Press Clear";
                            txt_cmptr.Clear();
                            txt_you.Clear();
                            you = 0;
                            cmpter = 0;
                        }
                        break;
                    }

                default:
                    break;

            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            Random computer = new Random();
            int choosen = computer.Next(1, 4);
            switch (choosen)
            {
                case 1:
                    {
                        
                        label1.Text = "Computer Choose Rock";
                        cmpter++;
                        txt_cmptr.Text = cmpter.ToString();
                        if (cmpter == 10)
                        {
                            BackColor = Color.Red;
                            label1.Text = "Computer Won Press Clear";
                            txt_cmptr.Clear();
                            txt_you.Clear();
                            cmpter = 0;
                            you = 0;
                        }
                        break;
                    }
                case 2:
                    {
                        
                        label1.Text = "Computer Choose Paper";
                        you++;
                        txt_you.Text = you.ToString();
                        if (you == 10)
                        {
                            BackColor = Color.Cyan;
                            label1.Text = "You Won Press Clear";
                            txt_cmptr.Clear();
                            txt_you.Clear();
                            you = 0;
                            cmpter = 0;
                        }
                        break;
                    }
                case 3:
                    {
                        
                        label1.Text = "Computer Choose Scissors" +" DRAW";
                        
                        break;
                    }
                    default:
                    break;
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            txt_you.Clear();
            txt_cmptr.Clear();
            you = 0;
            cmpter = 0;
            BackColor = Color.White;
        }

        
        

        
    }
}

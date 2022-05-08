using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTicTacToe
{
    public partial class Form1 : Form
    {
        int turn = 0;
        public Form1()
        {
            InitializeComponent();
            lbl_move.Text ="Player1 = X " + "Player2 = O" +
                " - Player1 Move";
        }
        private void button_Click(object sender, EventArgs e)
        {
            foreach (Control btn in Controls)
            {
                if (btn is Button && (string)btn.Tag == "button")
                {
                    if (BackColor == Color.Red)
                    {
                        turn++;
                        btn.Enabled = false;
                    }
                }
            }
            Button clickedbutton = (Button)sender;
            clickedbutton.Text = turn % 2 == 0 ? "X" : "O";
            turn++;
            lbl_move.Text = turn % 2 == 0 ? "Player 1 Move" : "Player 2 Move";
            
            if (clickedbutton.Text != null)
            {
                clickedbutton.Enabled = false;
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                lbl_move.Text = turn % 2 == 1 ? "Player 1 Win" : "Player 2 Win";
                BackColor = Color.Red;
            }
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

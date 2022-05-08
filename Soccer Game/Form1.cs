using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormSoccerGame
{
    public partial class Form1 : Form
    {
        int ballSpeedTop = 15;
        int ballSpeedLeft = 15;
        bool up1 = false;
        bool up2 = false;
        bool down1 = false;
        bool down2 = false;
        int cyan = 7;
        int red = 7;
        int scoreCyan = 1;
        int scoreRed = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimer(object sender, EventArgs e)
        {
            if (picture_red.Top < 9)
            {
                up2 = false;
            }
            if (picture_red.Bottom > 418)
            {
                down2 = false;
            }
            if (picture_cyan.Top < 9)
            {
                up1 = false;
            }
            if (picture_cyan.Bottom > 418)
            {
                down1 = false;
            }
            if (up1 == true)
            {
                picture_cyan.Top -= cyan;
            }
            if (down1 == true)
            {
                picture_cyan.Top += cyan;
            }
            if (up2 == true)
            {
                picture_red.Top -= red;
            }
            if (down2 == true)
            {
                picture_red.Top += red;
            }
            picture_ball.Top += ballSpeedTop;
            picture_ball.Left += ballSpeedLeft;
            if (picture_ball.Top < -1)
            {
                ballSpeedTop *= -1;
            }
            if (picture_ball.Bottom > 423 )
            {
                ballSpeedTop *= -1;
            }
            if (picture_ball.Left < -2)
            {
                ballSpeedLeft *= -1;
                lbl_lionel.Text = "Lionel " + scoreRed++;
            }
            if (picture_ball.Right > 640)
            {
                ballSpeedLeft *= -1;
                lbl_cristiano.Text = "Cristiano " + scoreCyan++;
            }
            if (picture_ball.Bounds.IntersectsWith(picture_red.Bounds))
            {
                ballSpeedLeft *= -1;
            }
            if (picture_ball.Bounds.IntersectsWith(picture_cyan.Bounds))
            {
                ballSpeedLeft *= -1;
            }
            if (scoreRed == 11 || scoreCyan == 11)
            {
                btn_exit.Visible = true;
                btn_restart.Visible = true;
                timer1.Stop();
                if ( scoreRed == 11)
                {
                    lbl_gameEnd.Visible = true;
                    lbl_gameEnd.Text = "Game Ended Lionel Won !";
                }
                if (scoreCyan == 11)
                {
                    lbl_gameEnd.Visible = true;
                    lbl_gameEnd.Text = "Game Ended Cristiano Won !";
                }
            }
        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                down1 = true;
            }
            if (e.KeyCode == Keys.W)
            {
                up1 = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                up2 = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down2 = true;
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            foreach (Control game in Controls)
            {
                if (game is Label && (string)game.Tag == "AfterStart")
                {
                    game.Visible = true;
                }
                if (game is PictureBox && (string)game.Tag == "AfterStart")
                {
                    game.Visible = true;
                }
            }
            btn_start.Visible = false;
            picture_backGround.Visible = false;
            btn_start.Enabled = false;
            timer1.Enabled = true;
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                down1 = false;
            }
            if (e.KeyCode == Keys.W)
            {
                up1 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down2 = false;
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

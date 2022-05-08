using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormBouncingBall
{
    public partial class Form1 : Form
    {
        int ballSpeedLastTop = 15;
        int ballSpeedLastLeft = 15;
        int ballSpeedTop = 10;
        int ballSpeedLeft = 10;
        int ballSpeedTopTennis = 10;
        int ballSpeedLeftTennis = 10;
        int squareSpeed = 5;
        int score = 1;
        bool right = false;
        bool left = false;
        bool up = false;
        bool down = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimer(object sender, EventArgs e)
        {
            foreach (Control obstacle in Controls)
            {
                if (obstacle is PictureBox && (string)obstacle.Tag == "Ball")
                {
                    if (obstacle.Visible == true)
                    {
                        if (picture_Square.Bounds.IntersectsWith(obstacle.Bounds))
                        {
                            timer1.Stop();
                            btn_restart.Visible = true;
                            lbl_endGame.Visible = true;
                            lbl_endGame.Text = "Game Over !! Score: " + score;
                        }
                    }
                   
                }
            }
            if (score > 50)
            {
                picture_lastBall.Visible = true;
                if (picture_lastBall.Visible == true)
                {
                    squareSpeed = 12;
                    picture_lastBall.Top += ballSpeedLastTop;
                    picture_lastBall.Left += ballSpeedLastLeft;
                }
                if (picture_lastBall.Right > 590)
                {
                    ballSpeedLastLeft *= -1;
                    score++;
                }
                if (picture_lastBall.Left < 2)
                {
                    ballSpeedLastLeft *= -1;
                    score++;
                }
                if (picture_lastBall.Top < 0)
                {
                    ballSpeedLastTop *= -1;
                    score++;
                }
                if (picture_lastBall.Bottom > 408)
                {
                    ballSpeedLastTop *= -1;
                    score++;
                }
            }
            if (score > 20)
            {
                picture_tennisBall.Visible = true;
                if (picture_tennisBall.Visible == true)
                {
                    squareSpeed = 10;
                    picture_tennisBall.Top += ballSpeedTopTennis;
                    picture_tennisBall.Left += ballSpeedLeftTennis;
                }
                if (picture_tennisBall.Right > 590)
                {
                    ballSpeedLeftTennis *= -1;
                    score++;
                }
                if (picture_tennisBall.Left < 2)
                {
                    ballSpeedLeftTennis *= -1;
                    score++;
                }
                if (picture_tennisBall.Top < 0)
                {
                    ballSpeedTopTennis *= -1;
                    score++;
                }
                if (picture_tennisBall.Bottom > 408)
                {
                    ballSpeedTopTennis *= -1;
                    score++;
                }
            }
            if (picture_Square.Right > 590)
            {
                right = false;
            }
            if (picture_Square.Left < 2)
            {
                left = false;
            }
            if (picture_Square.Top < 0)
            {
                up = false;
            }
            if (picture_Square.Bottom > 403)
            {
                down = false;
            }
            if ( up ==true)
            {
                picture_Square.Top -= squareSpeed; 
            }
            if (down == true)
            {
                picture_Square.Top += squareSpeed;
            }
            if (left == true)
            {
                picture_Square.Left -= squareSpeed;
            }
            if (right == true)
            {
                picture_Square.Left += squareSpeed; 
            }
            picture_ball.Top += ballSpeedTop;
            picture_ball.Left += ballSpeedLeft;
            if (picture_ball.Right > 590)
            {
                BackColor = Color.Green;
                ballSpeedLeft *= -1;
                score++;
            }
            if (picture_ball.Left < 2)
            {
                BackColor = Color.Blue;
                ballSpeedLeft *= -1;
                score++;
            }
            if (picture_ball.Top < 0)
            {
                BackColor = Color.Yellow;
                ballSpeedTop *= -1;
                score++;
            }
            if (picture_ball.Bottom > 408)
            {
                BackColor = Color.Orange;
                ballSpeedTop *= -1;
                score++;
            }
            lbl_score.Text = "Score: " + score;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Visible = false;
            btn_start.Enabled = false;
            timer1.Enabled = true;
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
        }
    }
}

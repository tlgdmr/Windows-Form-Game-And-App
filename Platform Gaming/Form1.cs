using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_PlatformGaming
{
    public partial class Platform : Form
    {
        int rightLeftSpeed = 12;
        int stickSpeed = 1;
        int cloudMoonSpeed = 1;
        int justJump;
        int jumpTime = 28;
        int score = 1;
        bool jump = false;
        bool rightSide = false;
        bool leftSide = false;
        public Platform()
        {
            InitializeComponent();
        }
        private void gameTimer(object sender, EventArgs e)
        {
            if (score > 5)
            {
                stickSpeed = 3;
            }
            if (score > 40 )
            {
                stickSpeed = 7;
            }
            if (leftSide == true)
            {
                picture_square.Left -= rightLeftSpeed;
            }
            if (rightSide == true)
            {
                picture_square.Left += rightLeftSpeed;
            }
            if (jump == true)
            {
                picture_square.Top -= jumpTime;
                jumpTime -= 2;
            }
            if (jump == false)
            {
                picture_square.Top += jumpTime;
            }
            if (picture_square.Bottom > 400)
            {
                btn_restart.Visible = true;
                timer1.Stop();
                lbl_gameOver.Visible = true;
                lbl_gameOver.Text = "Score is: " + (score - 1);
            }
            foreach (Control image in Controls)
            {
                if (image is PictureBox && (string)image.Tag == "BackGround")
                {
                    image.Top += cloudMoonSpeed;
                    if (image.Top > 450)
                    {
                        Random newLocation = new Random();
                        int newLocation2 = newLocation.Next(-300, -5);
                        image.Top = newLocation2;
                        Random newLocation3 = new Random();
                        int newLocation4 = newLocation.Next(39, 480);
                        image.Left = newLocation4;
                    }
                }
            }
            foreach (Control item in Controls)
            {
                if (item is PictureBox && (string)item.Tag == "Stick")
                {
                    if (picture_square.Bounds.IntersectsWith(item.Bounds))
                    {
                        jump = false;
                        jumpTime = 20;
                        picture_square.Top = item.Top - picture_square.Height;
                    }
                    item.Top += stickSpeed;
                    if (item.Bottom > 370)
                    {
                        Random newLocation = new Random();
                        int nextLocationImage = newLocation.Next(-10, -5);
                        item.Top = nextLocationImage;
                        Random newLocation2 = new Random();
                        int nextLocationImage2 = newLocation.Next(39, 505);
                        item.Left = nextLocationImage2;
                        lbl_score.Text = "Score:  " + score++;
                    }
                }
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                leftSide = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                rightSide = true;
            }
            if (jump == false)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    justJump = jumpTime;
                }
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rightSide = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                leftSide = false;
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btn_start.Visible = false;
            btn_start.Enabled = false;
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

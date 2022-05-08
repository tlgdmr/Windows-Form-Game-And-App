using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormT_Rex_Game
{
    public partial class Form1 : Form
    {
        int pictureSpeed = 5;
        int birdSpeed = 8;
        int obstacleSpeed = 12;
        bool jump = false;
        int score = 0;
        int jumpSpeed = 10;
        int jumpTime = 12;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimer(object sender, EventArgs e)
        {
            
            foreach (Control pic in Controls)
            {
                if (pic is PictureBox && (string)pic.Tag =="Things")
                {
                    pic.Left -= pictureSpeed;
                    if (pic.Left < 0)
                    {
                        Random nextPic = new Random();
                        int nextLocation = nextPic.Next(1000, 1500);
                        pic.Left = nextLocation;
                    }
                }
            }
            if (score > 1000)
            {
                birdSpeed = 12;
                obstacleSpeed = 18;
                jumpSpeed = 14;
            }
            picture_bird.Left -= birdSpeed;
            if (picture_dinasor.Bounds.IntersectsWith(picture_bird.Bounds))
            {
                timer1.Stop();
                btn_restart.Visible = true;
                lbl_gameOver.Visible = true;
                lbl_gameOver.Text = "Game Over! -Score: " + score.ToString();
            }
            if (picture_bird.Left < -50)
            {
                Random nextBird = new Random();
                int nextBirdLocation = nextBird.Next(1500, 2000);
                picture_bird.Left = nextBirdLocation;
            }
            if (timer1.Interval > 39)
            {
                label1.Text = "Score: " + score++.ToString();
            }
            if (jumpTime < 0)
            {
                jump = false;
            }
            if (jump == true)
            {
                picture_dinasor.Top -= jumpSpeed;
            }
            if (jump == false)
            {
                picture_dinasor.Top += jumpSpeed;
            }
            if (picture_dinasor.Bounds.IntersectsWith(picture_ground.Bounds))
            {
               jump = false;
               picture_dinasor.Top = picture_ground.Top - picture_dinasor.Height;
               jumpTime = 12;
            }
            foreach (Control item in Controls)
            {
                if (item is PictureBox && (string)item.Tag =="Obstacle" )
                {
                    if (picture_dinasor.Bounds.IntersectsWith(item.Bounds))
                    {
                        btn_restart.Show();
                        timer1.Stop();
                        lbl_gameOver.Visible = true;
                        lbl_gameOver.Text = "Game Over!! -Score: " + score.ToString();
                    }
                    item.Left -= obstacleSpeed;
                    if (item.Left < -15)
                    {
                        Random rnd = new Random();
                        int newObstacle = rnd.Next(740, 1500);
                        item.Left = newObstacle;
                    }
                }
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jump = true;
                jumpTime -= 8;
            }
            if (e.KeyCode == Keys.Down)
            {
                jump = false;
            }
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
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jumpTime -= 8;
            }
        }
    }
}

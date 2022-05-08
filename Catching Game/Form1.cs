using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCatchingGame
{
    public partial class Form1 : Form
    {
        int score = 1;
        int backgroundPicture = 20;
        int eggSpeed = 23;
        bool startEgg = false;
        int basketSpeed = 18;
        bool startObstacle = false;
        int obstacleSpeed = 18;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimer(object sender, EventArgs e)
        {
           
            foreach ( Control obstacle in Controls)
            {
                if (obstacle is PictureBox && (string)obstacle.Tag =="obstacle")
                {
                    if (obstacle.Top > 370)
                    {
                        Random newObstacle = new Random();
                        int newObstacleLocation = newObstacle.Next(39, 440);
                        obstacle.Top = -28;
                        obstacle.Left = newObstacleLocation;
                    }
                    if (picture_elipseBasket.Bounds.IntersectsWith(obstacle.Bounds))
                    {
                        btn_restart.Visible = true;
                        timer1.Stop();
                    }
                    if (startObstacle == true)
                    {
                        obstacle.Top += obstacleSpeed;
                    }
                }
            }
            foreach (Control item in Controls)
            {
                if (item is PictureBox && (string)item.Tag == "Egg")
                {
                    if (picture_elipseBasket.Bounds.IntersectsWith(item.Bounds))
                    {
                        lbl_score.Text = "Score: " + score++.ToString();
                        Random newItem = new Random();
                        int newLocation = newItem.Next(39, 440);
                        item.Top = -28;
                        item.Left = newLocation;
                    }
                    if (startEgg == true)
                    {
                        item.Top += eggSpeed;
                    }
                    if (item.Top > 380)
                    {
                        Random newItem = new Random();
                        int newLocation = newItem.Next(39, 440);
                        item.Top = -28;
                        item.Left = newLocation;
                    }
                }
            }
            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Planet")
                {
                    x.Top += backgroundPicture;
                    if (x.Top > 370)
                    {
                        Random location = new Random();
                        int loc = location.Next(39, 440);

                        x.Left = loc;
                        x.Top = -25;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control obstacle in Controls)
            {
                if (obstacle is PictureBox && (string)obstacle.Tag == "obstacle")
                {
                    obstacle.Visible = true;
                }
            }
            startEgg = true;
            startObstacle = true;
            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Planet")
                {
                    x.Visible = false;
                }
                foreach (Control item in Controls)
                {
                    if (item is PictureBox && (string)item.Tag == "Egg")
                    {
                        item.Visible = true;
                    }
                }
                picture_elipseBasket.Visible = true;
                button1.Visible = false;
                // if you have button and keydown use this fornmat otherwise keydown does not start.
                button1.Enabled = false;
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            
            int x = picture_elipseBasket.Location.X;
            int y = picture_elipseBasket.Location.Y;
            if (e.KeyCode == Keys.Left)
            {
                x -= basketSpeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                x += basketSpeed;
            }
            picture_elipseBasket.Location = new Point(x, y);
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

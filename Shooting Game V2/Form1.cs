using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormShootingGameV2
{
    public partial class Form1 : Form
    {
        int enemyBulletSpeed = 18;
        int enemySpeed = 13;
        int speedBullet = 10;
        int friendSpeed = 12;
        bool up = false;
        bool down = false;
        bool timer = false;
        int ballLeft = 13;
        int ballTop = 10;
        public Form1()
        {
            InitializeComponent();
        }
        private void bullet5()
        {
            PictureBox bullet5 = new PictureBox();
            bullet5.Height = 5;
            bullet5.Width = 10;
            bullet5.Tag = "bullet2";
            bullet5.BackColor = Color.Red;
            bullet5.Top = picture_enemy4.Top + 3;
            bullet5.Left = picture_enemy4.Left + picture_enemy4.Width;
            this.Controls.Add(bullet5);
        }
        private void bullet4()
        {
            PictureBox bullet4 = new PictureBox();
            bullet4.Height = 5;
            bullet4.Width = 10;
            bullet4.Tag = "bullet2";
            bullet4.BackColor = Color.Red;
            bullet4.Top = picture_enemy3.Top + 3;
            bullet4.Left = picture_enemy3.Left + picture_enemy3.Width;
            this.Controls.Add(bullet4);
        }
        private void bullet3()
        {
            PictureBox bullet3 = new PictureBox();
            bullet3.Height = 5;
            bullet3.Width = 10;
            bullet3.Tag = "bullet2";
            bullet3.BackColor = Color.Red;
            bullet3.Top = picture_enemy2.Top + 3;
            bullet3.Left = picture_enemy2.Left + picture_enemy2.Width;
            this.Controls.Add(bullet3);
        }
        private void bullet2()
        {
            PictureBox bullet2 = new PictureBox();
            bullet2.Height = 5;
            bullet2.Width = 10;
            bullet2.Tag = "bullet2";
            bullet2.BackColor = Color.Red;
            bullet2.Top = picture_enemy1.Top + 3;
            bullet2.Left = picture_enemy1.Left + picture_enemy1.Width;
            this.Controls.Add(bullet2);
        }
        private void bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Height = 5;
            bullet.Width = 10;
            bullet.Tag = "bullet";
            bullet.BackColor = Color.LimeGreen;
            bullet.Top = picture_friend.Top + 3;
            bullet.Left = picture_friend.Left + picture_friend.Width;
            this.Controls.Add(bullet);
        }
        private void gameTimer(object sender, EventArgs e)
        {
            
            if (timer == false)
            {
                picture_ball.Left -= ballLeft;
                picture_ball.Top += ballTop;
                if (picture_ball.Left < 0)
                {
                    picture_backgorund.BackColor = Color.Red;
                    ballLeft *= -1;
                    ballLeft = ballLeft - 1;
                }
                if (picture_ball.Left > 610)
                {
                    picture_backgorund.BackColor = Color.Blue;
                    ballLeft *= -1;
                    ballLeft = ballLeft + 1;
                }
                if (picture_ball.Top < 0)
                {
                    picture_backgorund.BackColor = Color.Yellow;
                    ballTop *= -1;
                }
                if (picture_ball.Top > 300)
                {
                    picture_backgorund.BackColor = Color.HotPink;
                    ballTop *= -1;
                }
                if (picture_ball.Bounds.IntersectsWith(btn_start.Bounds))
                {
                    ballLeft *= -1;
                    ballTop *= -1;
                }
            }
            if (timer == true)
            {
                if (picture_friend.Top < 3)
                {
                    up = false;
                }
                if (picture_friend.Top > 330)
                {
                    down = false;
                }
                if (progress_health.Value > 200)
                {
                    lbl_gameOver.Visible = true;
                    lbl_gameOver.Text = "Game Over !";
                    btn_restart.Visible = true;
                    timer1.Stop();
                    timer1.Enabled = false;
                }  
                if (picture_enemy1.Left < 700 && picture_enemy1.Left > 675)
                {
                    bullet2();
                    bullet3();
                    bullet4();
                    bullet5();
                }
                foreach (Control X in Controls)
                {
                    if (X is PictureBox && (string)X.Tag == "bullet2")
                    {
                        X.Left -= enemyBulletSpeed;
                        if (X.Left < 0)
                        {
                            X.Dispose();
                            this.Controls.Remove(X);
                        }
                        if (X.Bounds.IntersectsWith(picture_friend.Bounds))
                        {
                            progress_health.Value += 5;
                        }
                    }
                }
                foreach (Control Y in Controls)
                {
                    if (Y is PictureBox && (string)Y.Tag == "enemy")
                    {
                        Y.Left -= enemySpeed;
                        foreach (Control X in Controls)
                        {
                            if (X is PictureBox && (string)X.Tag == "bullet")
                            {
                                if (Y.Bounds.IntersectsWith(X.Bounds))
                                {
                                    Random rnd2 = new Random();
                                    int newLocation2 = rnd2.Next(0, 330);
                                    Y.Top = newLocation2;
                                    Random rnd = new Random();
                                    int newLocation = rnd.Next(900, 2000);
                                    Y.Left = newLocation;
                                    X.Dispose();
                                    X.Controls.Remove(X);
                                }
                            }
                        }

                     }
                    if (Y.Left < 0)
                    {
                        Random rnd2 = new Random();
                        int newLocation2 = rnd2.Next(0, 330);
                        Y.Top = newLocation2;
                        Random rnd = new Random();
                        int newLocation = rnd.Next(900, 2000);
                        Y.Left = newLocation;
                        progress_health.Value += 3;
                    }
                    
                }
                if (down == true)
                {
                    picture_friend.Top += friendSpeed;
                }
                if (up == true)
                {
                    picture_friend.Top -= friendSpeed;
                }
                foreach (Control X in Controls)
                {
                    if (X is PictureBox && (string)X.Tag == "bullet")
                    {
                        X.Left += speedBullet;
                        if (X.Left > 700)
                        {
                            X.Dispose();
                            this.Controls.Remove(X);
                        }
                    }
                }
            }
           
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                bullet();
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
        private void btn_start_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is PictureBox && (string)item.Tag == "enemy")
                {
                    item.Visible = true;
                }
            }
            timer = true;
            btn_start.Visible = false;
            btn_start.Enabled = false;
            picture_backgorund.Visible = false;
            picture_ball.Visible = false;
            picture_friend.Visible = true;
            progress_health.Visible = true;
        }

        private void btn_restart_click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFoırmShootingGame
{
    public partial class Form1 : Form
    {
        int dinasorSpeed = 25;
        int ballSpeed = 30;
        bool shoot = false; 
        int ballShootSpeed = 150;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                picture_ball.Top -= 50;
                shoot = true;
            }
            int x = picture_dinasor.Location.X;
            int y = picture_dinasor.Location.Y;
            if (e.KeyCode == Keys.Up)
            {
                y -= dinasorSpeed;
            }
            if (e.KeyCode == Keys.Down)
            {
                y += dinasorSpeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                x += dinasorSpeed;
            }
            if (e.KeyCode == Keys.Left)
            {
                x -= dinasorSpeed;
            }
            picture_dinasor.Location = new Point(x, y);

            int a = picture_ball.Location.X;
            int b = picture_ball.Location.Y;
            if (e.KeyCode == Keys.W)
            {
                b -= ballSpeed;
            }
            if (e.KeyCode == Keys.S)
            {
                b += ballSpeed;
            }
            if (e.KeyCode == Keys.D)
            {
                a += ballSpeed;
            }
            if (e.KeyCode == Keys.A)
            {
                a -= ballSpeed;
            }
            picture_ball.Location = new Point(a, b);
        }
        private void gameTimer(object sender, EventArgs e)
        {
            if (shoot == true)
            {
                picture_ball.Top -= ballShootSpeed;
            }
            if (picture_ball.Bounds.IntersectsWith(picture_dinasor.Bounds)) 
            {
                picture_ball.Top = 500;
                shoot = false;
                progressBar1.Value += 10;
            }
            if (picture_ball.Bounds.IntersectsWith(picture_box.Bounds) || picture_ball.Bounds.IntersectsWith(picture_box2.Bounds))
            {
                picture_ball.Top = 500;
                shoot = false;
            }
             if (progressBar1.Value == 100)
            {
                endGame();
            }
            if (picture_ball.Top < -25)
            {
                picture_ball.Top = 500;
                shoot = false;
            }
        }
        private void endGame()
        {
            button1.Visible = true;
            label1.Visible = true;
            timer1.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

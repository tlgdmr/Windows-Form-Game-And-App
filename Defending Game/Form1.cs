using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDefendingGame
{
    public partial class Form1 : Form
    {
        int ballSpeed = 22;
        int stickSpeed = 20;
        bool shoot = false;
        int scoreBall = 1;
        int scoreStick = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            int x = picture_ball.Location.X;
            int y = picture_ball.Location.Y;
            if (e.KeyCode == Keys.Right)
            {
                x += ballSpeed;
            }
            if (e.KeyCode == Keys.Left)
            {
                x -= ballSpeed;
            }
            picture_ball.Location = new Point(x ,y);
            int a = picture_stick.Location.X;
            int b = picture_stick.Location.Y;
            if (e.KeyCode == Keys.D)
            {
                a += stickSpeed;
            }
            if (e.KeyCode == Keys.A)
            {
                a -= ballSpeed;
            }
            picture_stick.Location = new Point(a , b);
            if (e.KeyCode == Keys.Space)
            {
                shoot = true;
            }
        }
        private void gameTimer(object sender, EventArgs e)
        {
            if (shoot == true)
            {
                picture_ball.Top -= ballSpeed;
            }
            if (picture_ball.Top < -25)
            {
                picture_ball.Top = 360;
                lbl_score.Text ="Ball: " + scoreBall++.ToString();
                shoot = false;
            }
            if (picture_ball.Bounds.IntersectsWith(picture_stick.Bounds))
            {
                ballSpeed = -25; 
                lbl_stick.Text = "Stick: " + scoreStick++.ToString();
            }
            if (picture_ball.Bounds.IntersectsWith(picture_grass.Bounds))
            {
                picture_ball.Top = 360;
                shoot = false;
                ballSpeed = 20;
            }
            
            
        }
    }
}

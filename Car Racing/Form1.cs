using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCarRacing
{
    public partial class Form1 : Form
    {
        int roadSpeed = 20;
        int coinSpeed = 20;
        int ambulanceSpeed = 10;
        int carSpeed = 25;
        int score = 1;
        int orangeCarSpeed =15;
        int pinkCarSpeed = 13;
       public Form1()
        {
            InitializeComponent();
        }
        private void gameTimer(object sender, EventArgs e)
        {
            picture_road.Top += roadSpeed;
            if (picture_road.Top > 80)
            {
                picture_road.Top = -150;
            }
            picture_pinkCar.Top += pinkCarSpeed;
            if (picture_pinkCar.Top > 714)
            {
                Random pinkCar= new Random();
                var pinkCarX = pinkCar.Next(1, 4);
                if (pinkCarX == 2)
                {
                    picture_pinkCar.Top = -100;
                    picture_pinkCar.Left = 413;
                }
                else if (pinkCarX == 3)
                {
                    picture_pinkCar.Top = -50;
                    picture_pinkCar.Left = 121;
                }
            }
            picture_orangeCar.Top += orangeCarSpeed;
            if (picture_orangeCar.Top > 714)
            {
                Random CarLocationX = new Random();
                var orangeCarDirection = CarLocationX.Next(1, 3);
                if (orangeCarDirection == 2)
                {
                    picture_orangeCar.Top = -100;
                    picture_orangeCar.Left = 432;
                }
                else
                {
                    picture_orangeCar.Top = -50;
                    picture_orangeCar.Left = 174;
                }
            }
            if (picture_car.Bounds.IntersectsWith(picture_Coin.Bounds))
            {
                picture_Coin.BackColor = Color.Black;
                Random coin2 = new Random();
                var nextCoin2 = coin2.Next(-400, -350);
                picture_Coin.Top = nextCoin2;

                Random coin = new Random();
                var nextCoin = coin.Next(84, 632);
                picture_Coin.Left = nextCoin;

                lbl_score.Text = "Score: " + score++.ToString();
            }
            picture_Coin.Top += coinSpeed;
            picture_amblance.Top += ambulanceSpeed;
            if (picture_amblance.Top > 714)
            {
                Random CarLocationX = new Random();
                var ambulanceDirection = CarLocationX.Next(1, 3);
                if (ambulanceDirection == 2)
                {
                    picture_amblance.Top = -100;
                    picture_amblance.Left = 432;
                }
                else
                {
                    picture_amblance.Top = -50;
                    picture_amblance.Left = 174;
                }
            }
            if (picture_Coin.Top > 714 )
            {
                Random coin2 = new Random();
                var nextCoin2 = coin2.Next(-400,-350);
                picture_Coin.Top = nextCoin2;

                Random coin = new Random();
                var nextCoin = coin.Next(84, 632);
                picture_Coin.Left = nextCoin;
            }
            if ((picture_car.Bounds.IntersectsWith(picture_amblance.Bounds) || picture_car.Bounds.IntersectsWith(picture_orangeCar.Bounds) 
                || picture_car.Bounds.IntersectsWith(picture_pinkCar.Bounds)))
            {
                 gameOver();
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            btn_restart.Visible = true;
            btn_exit.Visible = true;
            lbl_endGame.Visible = true;
        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            int x = picture_car.Location.X;
            int y = picture_car.Location.Y;
            if (e.KeyCode == Keys.Right)
            {
                x += carSpeed;
            }
            if (e.KeyCode == Keys.Left)
            {
                x -= carSpeed;
            }
            if (e.KeyCode == Keys.Up)
            {
                y -= carSpeed;
            }
            if (e.KeyCode == Keys.Down)
            {
                y += carSpeed;
            }
            picture_car.Location = new Point(x, y);
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

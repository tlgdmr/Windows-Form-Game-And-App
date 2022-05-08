
namespace WinFormCarRacing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture_road = new System.Windows.Forms.PictureBox();
            this.picture_car = new System.Windows.Forms.PictureBox();
            this.picture_amblance = new System.Windows.Forms.PictureBox();
            this.picture_Coin = new WinFormCarRacing.ElipsePictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.picture_orangeCar = new System.Windows.Forms.PictureBox();
            this.picture_pinkCar = new System.Windows.Forms.PictureBox();
            this.lbl_endGame = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_amblance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_orangeCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pinkCar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // picture_road
            // 
            this.picture_road.Image = ((System.Drawing.Image)(resources.GetObject("picture_road.Image")));
            this.picture_road.Location = new System.Drawing.Point(-1, -4);
            this.picture_road.Name = "picture_road";
            this.picture_road.Size = new System.Drawing.Size(756, 879);
            this.picture_road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_road.TabIndex = 0;
            this.picture_road.TabStop = false;
            // 
            // picture_car
            // 
            this.picture_car.Image = ((System.Drawing.Image)(resources.GetObject("picture_car.Image")));
            this.picture_car.Location = new System.Drawing.Point(174, 722);
            this.picture_car.Name = "picture_car";
            this.picture_car.Size = new System.Drawing.Size(74, 143);
            this.picture_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_car.TabIndex = 1;
            this.picture_car.TabStop = false;
            // 
            // picture_amblance
            // 
            this.picture_amblance.Image = ((System.Drawing.Image)(resources.GetObject("picture_amblance.Image")));
            this.picture_amblance.Location = new System.Drawing.Point(601, 66);
            this.picture_amblance.Name = "picture_amblance";
            this.picture_amblance.Size = new System.Drawing.Size(89, 164);
            this.picture_amblance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_amblance.TabIndex = 3;
            this.picture_amblance.TabStop = false;
            // 
            // picture_Coin
            // 
            this.picture_Coin.BackColor = System.Drawing.Color.Green;
            this.picture_Coin.Image = ((System.Drawing.Image)(resources.GetObject("picture_Coin.Image")));
            this.picture_Coin.Location = new System.Drawing.Point(141, 240);
            this.picture_Coin.Name = "picture_Coin";
            this.picture_Coin.Size = new System.Drawing.Size(85, 76);
            this.picture_Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Coin.TabIndex = 2;
            this.picture_Coin.TabStop = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_score.Location = new System.Drawing.Point(12, 12);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(94, 28);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score : ";
            // 
            // picture_orangeCar
            // 
            this.picture_orangeCar.Image = ((System.Drawing.Image)(resources.GetObject("picture_orangeCar.Image")));
            this.picture_orangeCar.Location = new System.Drawing.Point(266, 22);
            this.picture_orangeCar.Name = "picture_orangeCar";
            this.picture_orangeCar.Size = new System.Drawing.Size(74, 143);
            this.picture_orangeCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_orangeCar.TabIndex = 5;
            this.picture_orangeCar.TabStop = false;
            // 
            // picture_pinkCar
            // 
            this.picture_pinkCar.Image = ((System.Drawing.Image)(resources.GetObject("picture_pinkCar.Image")));
            this.picture_pinkCar.Location = new System.Drawing.Point(452, 325);
            this.picture_pinkCar.Name = "picture_pinkCar";
            this.picture_pinkCar.Size = new System.Drawing.Size(74, 143);
            this.picture_pinkCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pinkCar.TabIndex = 6;
            this.picture_pinkCar.TabStop = false;
            // 
            // lbl_endGame
            // 
            this.lbl_endGame.AutoSize = true;
            this.lbl_endGame.Font = new System.Drawing.Font("Kristen ITC", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_endGame.Location = new System.Drawing.Point(232, 240);
            this.lbl_endGame.Name = "lbl_endGame";
            this.lbl_endGame.Size = new System.Drawing.Size(296, 58);
            this.lbl_endGame.TabIndex = 7;
            this.lbl_endGame.Text = "Game Over !";
            this.lbl_endGame.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_restart.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Location = new System.Drawing.Point(321, 303);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(116, 49);
            this.btn_restart.TabIndex = 8;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Kristen ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(335, 358);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 41);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(716, 877);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.lbl_endGame);
            this.Controls.Add(this.picture_pinkCar);
            this.Controls.Add(this.picture_orangeCar);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.picture_amblance);
            this.Controls.Add(this.picture_Coin);
            this.Controls.Add(this.picture_car);
            this.Controls.Add(this.picture_road);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture_road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_amblance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_orangeCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pinkCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picture_road;
        private System.Windows.Forms.PictureBox picture_car;
        private ElipsePictureBox picture_Coin;
        private System.Windows.Forms.PictureBox picture_amblance;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox picture_orangeCar;
        private System.Windows.Forms.PictureBox picture_pinkCar;
        private System.Windows.Forms.Label lbl_endGame;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_exit;
    }
}


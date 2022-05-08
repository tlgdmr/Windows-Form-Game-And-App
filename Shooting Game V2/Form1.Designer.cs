
namespace WindowsFormShootingGameV2
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
            this.picture_friend = new System.Windows.Forms.PictureBox();
            this.picture_enemy2 = new System.Windows.Forms.PictureBox();
            this.picture_enemy3 = new System.Windows.Forms.PictureBox();
            this.picture_enemy4 = new System.Windows.Forms.PictureBox();
            this.picture_enemy5 = new System.Windows.Forms.PictureBox();
            this.picture_enemy1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progress_health = new System.Windows.Forms.ProgressBar();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.picture_backgorund = new System.Windows.Forms.PictureBox();
            this.picture_ball = new WindowsFormShootingGameV2.ElipsePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_friend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_backgorund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_friend
            // 
            this.picture_friend.BackColor = System.Drawing.Color.Lime;
            this.picture_friend.Location = new System.Drawing.Point(12, 195);
            this.picture_friend.Name = "picture_friend";
            this.picture_friend.Size = new System.Drawing.Size(10, 27);
            this.picture_friend.TabIndex = 0;
            this.picture_friend.TabStop = false;
            // 
            // picture_enemy2
            // 
            this.picture_enemy2.BackColor = System.Drawing.Color.Red;
            this.picture_enemy2.Location = new System.Drawing.Point(995, 33);
            this.picture_enemy2.Name = "picture_enemy2";
            this.picture_enemy2.Size = new System.Drawing.Size(10, 27);
            this.picture_enemy2.TabIndex = 1;
            this.picture_enemy2.TabStop = false;
            this.picture_enemy2.Tag = "enemy";
            // 
            // picture_enemy3
            // 
            this.picture_enemy3.BackColor = System.Drawing.Color.Red;
            this.picture_enemy3.Location = new System.Drawing.Point(1170, 195);
            this.picture_enemy3.Name = "picture_enemy3";
            this.picture_enemy3.Size = new System.Drawing.Size(10, 27);
            this.picture_enemy3.TabIndex = 2;
            this.picture_enemy3.TabStop = false;
            this.picture_enemy3.Tag = "enemy";
            // 
            // picture_enemy4
            // 
            this.picture_enemy4.BackColor = System.Drawing.Color.Red;
            this.picture_enemy4.Location = new System.Drawing.Point(1061, 278);
            this.picture_enemy4.Name = "picture_enemy4";
            this.picture_enemy4.Size = new System.Drawing.Size(10, 27);
            this.picture_enemy4.TabIndex = 3;
            this.picture_enemy4.TabStop = false;
            this.picture_enemy4.Tag = "enemy";
            // 
            // picture_enemy5
            // 
            this.picture_enemy5.BackColor = System.Drawing.Color.Red;
            this.picture_enemy5.Location = new System.Drawing.Point(876, 411);
            this.picture_enemy5.Name = "picture_enemy5";
            this.picture_enemy5.Size = new System.Drawing.Size(10, 27);
            this.picture_enemy5.TabIndex = 4;
            this.picture_enemy5.TabStop = false;
            this.picture_enemy5.Tag = "enemy";
            // 
            // picture_enemy1
            // 
            this.picture_enemy1.BackColor = System.Drawing.Color.Red;
            this.picture_enemy1.Location = new System.Drawing.Point(806, 123);
            this.picture_enemy1.Name = "picture_enemy1";
            this.picture_enemy1.Size = new System.Drawing.Size(10, 27);
            this.picture_enemy1.TabIndex = 5;
            this.picture_enemy1.TabStop = false;
            this.picture_enemy1.Tag = "enemy";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // progress_health
            // 
            this.progress_health.Location = new System.Drawing.Point(13, 13);
            this.progress_health.Maximum = 215;
            this.progress_health.Name = "progress_health";
            this.progress_health.Size = new System.Drawing.Size(100, 23);
            this.progress_health.TabIndex = 6;
            this.progress_health.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Lime;
            this.btn_start.Location = new System.Drawing.Point(374, 171);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(99, 35);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Yellow;
            this.btn_restart.Location = new System.Drawing.Point(374, 241);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(99, 35);
            this.btn_restart.TabIndex = 8;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_click);
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.AutoSize = true;
            this.lbl_gameOver.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver.ForeColor = System.Drawing.Color.Red;
            this.lbl_gameOver.Location = new System.Drawing.Point(355, 172);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Size = new System.Drawing.Size(144, 28);
            this.lbl_gameOver.TabIndex = 9;
            this.lbl_gameOver.Text = "Game Over !";
            this.lbl_gameOver.Visible = false;
            // 
            // picture_backgorund
            // 
            this.picture_backgorund.BackColor = System.Drawing.Color.Goldenrod;
            this.picture_backgorund.Location = new System.Drawing.Point(-9, 0);
            this.picture_backgorund.Name = "picture_backgorund";
            this.picture_backgorund.Size = new System.Drawing.Size(900, 457);
            this.picture_backgorund.TabIndex = 10;
            this.picture_backgorund.TabStop = false;
            // 
            // picture_ball
            // 
            this.picture_ball.BackColor = System.Drawing.Color.Red;
            this.picture_ball.Image = ((System.Drawing.Image)(resources.GetObject("picture_ball.Image")));
            this.picture_ball.Location = new System.Drawing.Point(163, 111);
            this.picture_ball.Name = "picture_ball";
            this.picture_ball.Size = new System.Drawing.Size(63, 61);
            this.picture_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ball.TabIndex = 11;
            this.picture_ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.picture_ball);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picture_backgorund);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.progress_health);
            this.Controls.Add(this.picture_enemy1);
            this.Controls.Add(this.picture_enemy5);
            this.Controls.Add(this.picture_enemy4);
            this.Controls.Add(this.picture_enemy3);
            this.Controls.Add(this.picture_enemy2);
            this.Controls.Add(this.picture_friend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picture_friend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_backgorund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_friend;
        private System.Windows.Forms.PictureBox picture_enemy2;
        private System.Windows.Forms.PictureBox picture_enemy3;
        private System.Windows.Forms.PictureBox picture_enemy4;
        private System.Windows.Forms.PictureBox picture_enemy5;
        private System.Windows.Forms.PictureBox picture_enemy1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progress_health;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.PictureBox picture_backgorund;
        private ElipsePictureBox picture_ball;
    }
}


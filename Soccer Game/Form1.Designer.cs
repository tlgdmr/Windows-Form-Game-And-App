
namespace WindowsFormSoccerGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_cristiano = new System.Windows.Forms.Label();
            this.lbl_lionel = new System.Windows.Forms.Label();
            this.picture_cyan = new System.Windows.Forms.PictureBox();
            this.picture_red = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture_backGround = new System.Windows.Forms.PictureBox();
            this.picture_ball = new WindowsFormSoccerGame.ElipsePictureBox();
            this.lbl_gameEnd = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_backGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "AfterStart";
            this.pictureBox1.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_start.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(379, 245);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(96, 35);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Gold;
            this.btn_restart.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Location = new System.Drawing.Point(379, 245);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(105, 35);
            this.btn_restart.TabIndex = 2;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_cristiano
            // 
            this.lbl_cristiano.AutoSize = true;
            this.lbl_cristiano.BackColor = System.Drawing.Color.Gold;
            this.lbl_cristiano.Location = new System.Drawing.Point(13, 13);
            this.lbl_cristiano.Name = "lbl_cristiano";
            this.lbl_cristiano.Size = new System.Drawing.Size(79, 17);
            this.lbl_cristiano.TabIndex = 3;
            this.lbl_cristiano.Tag = "AfterStart";
            this.lbl_cristiano.Text = "Cristiano: 0";
            this.lbl_cristiano.Visible = false;
            // 
            // lbl_lionel
            // 
            this.lbl_lionel.AutoSize = true;
            this.lbl_lionel.BackColor = System.Drawing.Color.Gold;
            this.lbl_lionel.Location = new System.Drawing.Point(758, 13);
            this.lbl_lionel.Name = "lbl_lionel";
            this.lbl_lionel.Size = new System.Drawing.Size(62, 17);
            this.lbl_lionel.TabIndex = 4;
            this.lbl_lionel.Tag = "AfterStart";
            this.lbl_lionel.Text = "Lionel: 0";
            this.lbl_lionel.Visible = false;
            // 
            // picture_cyan
            // 
            this.picture_cyan.BackColor = System.Drawing.Color.Aqua;
            this.picture_cyan.Location = new System.Drawing.Point(51, 218);
            this.picture_cyan.Name = "picture_cyan";
            this.picture_cyan.Size = new System.Drawing.Size(14, 90);
            this.picture_cyan.TabIndex = 5;
            this.picture_cyan.TabStop = false;
            this.picture_cyan.Tag = "AfterStart";
            this.picture_cyan.Visible = false;
            // 
            // picture_red
            // 
            this.picture_red.BackColor = System.Drawing.Color.Red;
            this.picture_red.Location = new System.Drawing.Point(787, 218);
            this.picture_red.Name = "picture_red";
            this.picture_red.Size = new System.Drawing.Size(14, 90);
            this.picture_red.TabIndex = 6;
            this.picture_red.TabStop = false;
            this.picture_red.Tag = "AfterStart";
            this.picture_red.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // picture_backGround
            // 
            this.picture_backGround.Image = ((System.Drawing.Image)(resources.GetObject("picture_backGround.Image")));
            this.picture_backGround.Location = new System.Drawing.Point(-1, -3);
            this.picture_backGround.Name = "picture_backGround";
            this.picture_backGround.Size = new System.Drawing.Size(851, 527);
            this.picture_backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_backGround.TabIndex = 8;
            this.picture_backGround.TabStop = false;
            // 
            // picture_ball
            // 
            this.picture_ball.BackColor = System.Drawing.Color.Blue;
            this.picture_ball.Image = ((System.Drawing.Image)(resources.GetObject("picture_ball.Image")));
            this.picture_ball.Location = new System.Drawing.Point(406, 245);
            this.picture_ball.Name = "picture_ball";
            this.picture_ball.Size = new System.Drawing.Size(38, 37);
            this.picture_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ball.TabIndex = 7;
            this.picture_ball.TabStop = false;
            this.picture_ball.Tag = "AfterStart";
            this.picture_ball.Visible = false;
            // 
            // lbl_gameEnd
            // 
            this.lbl_gameEnd.AutoSize = true;
            this.lbl_gameEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_gameEnd.Font = new System.Drawing.Font("Kristen ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameEnd.Location = new System.Drawing.Point(178, 194);
            this.lbl_gameEnd.Name = "lbl_gameEnd";
            this.lbl_gameEnd.Size = new System.Drawing.Size(201, 39);
            this.lbl_gameEnd.TabIndex = 9;
            this.lbl_gameEnd.Text = "Game Ended";
            this.lbl_gameEnd.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Kristen ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(379, 297);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 40);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 527);
            this.Controls.Add(this.lbl_gameEnd);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picture_backGround);
            this.Controls.Add(this.picture_ball);
            this.Controls.Add(this.picture_red);
            this.Controls.Add(this.picture_cyan);
            this.Controls.Add(this.lbl_lionel);
            this.Controls.Add(this.lbl_cristiano);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_backGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_cristiano;
        private System.Windows.Forms.Label lbl_lionel;
        private System.Windows.Forms.PictureBox picture_cyan;
        private System.Windows.Forms.PictureBox picture_red;
        private System.Windows.Forms.Timer timer1;
        private ElipsePictureBox picture_ball;
        private System.Windows.Forms.PictureBox picture_backGround;
        private System.Windows.Forms.Label lbl_gameEnd;
        private System.Windows.Forms.Button btn_exit;
    }
}


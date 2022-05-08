
namespace WindowsFormT_Rex_Game
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
            this.picture_ground = new System.Windows.Forms.PictureBox();
            this.picture_dinasor = new System.Windows.Forms.PictureBox();
            this.picture_obstacle = new System.Windows.Forms.PictureBox();
            this.picture_obstacle2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.picture_obstacle3 = new System.Windows.Forms.PictureBox();
            this.picture_bird = new System.Windows.Forms.PictureBox();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.picture_pig = new System.Windows.Forms.PictureBox();
            this.picture_pilot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dinasor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pilot)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_ground
            // 
            this.picture_ground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picture_ground.Location = new System.Drawing.Point(-1, 388);
            this.picture_ground.Name = "picture_ground";
            this.picture_ground.Size = new System.Drawing.Size(803, 62);
            this.picture_ground.TabIndex = 0;
            this.picture_ground.TabStop = false;
            // 
            // picture_dinasor
            // 
            this.picture_dinasor.Image = ((System.Drawing.Image)(resources.GetObject("picture_dinasor.Image")));
            this.picture_dinasor.Location = new System.Drawing.Point(12, 336);
            this.picture_dinasor.Name = "picture_dinasor";
            this.picture_dinasor.Size = new System.Drawing.Size(42, 50);
            this.picture_dinasor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_dinasor.TabIndex = 1;
            this.picture_dinasor.TabStop = false;
            // 
            // picture_obstacle
            // 
            this.picture_obstacle.BackColor = System.Drawing.Color.SkyBlue;
            this.picture_obstacle.Image = ((System.Drawing.Image)(resources.GetObject("picture_obstacle.Image")));
            this.picture_obstacle.Location = new System.Drawing.Point(336, 337);
            this.picture_obstacle.Name = "picture_obstacle";
            this.picture_obstacle.Size = new System.Drawing.Size(32, 51);
            this.picture_obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_obstacle.TabIndex = 2;
            this.picture_obstacle.TabStop = false;
            this.picture_obstacle.Tag = "Obstacle";
            // 
            // picture_obstacle2
            // 
            this.picture_obstacle2.Image = ((System.Drawing.Image)(resources.GetObject("picture_obstacle2.Image")));
            this.picture_obstacle2.Location = new System.Drawing.Point(727, 338);
            this.picture_obstacle2.Name = "picture_obstacle2";
            this.picture_obstacle2.Size = new System.Drawing.Size(44, 50);
            this.picture_obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_obstacle2.TabIndex = 3;
            this.picture_obstacle2.TabStop = false;
            this.picture_obstacle2.Tag = "Obstacle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_start.Location = new System.Drawing.Point(322, 116);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(95, 33);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_restart.Location = new System.Drawing.Point(322, 155);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(95, 33);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // picture_obstacle3
            // 
            this.picture_obstacle3.Image = ((System.Drawing.Image)(resources.GetObject("picture_obstacle3.Image")));
            this.picture_obstacle3.Location = new System.Drawing.Point(1123, 339);
            this.picture_obstacle3.Name = "picture_obstacle3";
            this.picture_obstacle3.Size = new System.Drawing.Size(36, 51);
            this.picture_obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_obstacle3.TabIndex = 7;
            this.picture_obstacle3.TabStop = false;
            this.picture_obstacle3.Tag = "Obstacle";
            // 
            // picture_bird
            // 
            this.picture_bird.Image = ((System.Drawing.Image)(resources.GetObject("picture_bird.Image")));
            this.picture_bird.Location = new System.Drawing.Point(693, 232);
            this.picture_bird.Name = "picture_bird";
            this.picture_bird.Size = new System.Drawing.Size(44, 29);
            this.picture_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_bird.TabIndex = 8;
            this.picture_bird.TabStop = false;
            this.picture_bird.Tag = "";
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.AutoSize = true;
            this.lbl_gameOver.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gameOver.Location = new System.Drawing.Point(182, 121);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Size = new System.Drawing.Size(0, 40);
            this.lbl_gameOver.TabIndex = 9;
            this.lbl_gameOver.Visible = false;
            // 
            // picture_pig
            // 
            this.picture_pig.Image = ((System.Drawing.Image)(resources.GetObject("picture_pig.Image")));
            this.picture_pig.Location = new System.Drawing.Point(501, 12);
            this.picture_pig.Name = "picture_pig";
            this.picture_pig.Size = new System.Drawing.Size(118, 90);
            this.picture_pig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pig.TabIndex = 10;
            this.picture_pig.TabStop = false;
            this.picture_pig.Tag = "Things";
            // 
            // picture_pilot
            // 
            this.picture_pilot.Image = ((System.Drawing.Image)(resources.GetObject("picture_pilot.Image")));
            this.picture_pilot.Location = new System.Drawing.Point(173, 46);
            this.picture_pilot.Name = "picture_pilot";
            this.picture_pilot.Size = new System.Drawing.Size(100, 90);
            this.picture_pilot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pilot.TabIndex = 11;
            this.picture_pilot.TabStop = false;
            this.picture_pilot.Tag = "Things";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_pilot);
            this.Controls.Add(this.picture_pig);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.picture_bird);
            this.Controls.Add(this.picture_obstacle3);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picture_obstacle2);
            this.Controls.Add(this.picture_obstacle);
            this.Controls.Add(this.picture_dinasor);
            this.Controls.Add(this.picture_ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dinasor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pilot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_ground;
        private System.Windows.Forms.PictureBox picture_dinasor;
        private System.Windows.Forms.PictureBox picture_obstacle;
        private System.Windows.Forms.PictureBox picture_obstacle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.PictureBox picture_obstacle3;
        private System.Windows.Forms.PictureBox picture_bird;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.PictureBox picture_pig;
        private System.Windows.Forms.PictureBox picture_pilot;
    }
}


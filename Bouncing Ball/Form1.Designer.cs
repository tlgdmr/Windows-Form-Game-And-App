
namespace WindowsFormBouncingBall
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
            this.picture_Square = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture_lastBall = new WindowsFormBouncingBall.ElipsePictureBox();
            this.picture_tennisBall = new WindowsFormBouncingBall.ElipsePictureBox();
            this.picture_ball = new WindowsFormBouncingBall.ElipsePictureBox();
            this.lbl_endGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lastBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tennisBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Square
            // 
            this.picture_Square.BackColor = System.Drawing.Color.DeepPink;
            this.picture_Square.Location = new System.Drawing.Point(347, 106);
            this.picture_Square.Name = "picture_Square";
            this.picture_Square.Size = new System.Drawing.Size(53, 51);
            this.picture_Square.TabIndex = 1;
            this.picture_Square.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_start.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(317, 186);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(116, 36);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Crimson;
            this.btn_restart.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Location = new System.Drawing.Point(317, 228);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(116, 36);
            this.btn_restart.TabIndex = 3;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Kristen ITC", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(13, 13);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(70, 24);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // picture_lastBall
            // 
            this.picture_lastBall.BackColor = System.Drawing.Color.Red;
            this.picture_lastBall.Image = ((System.Drawing.Image)(resources.GetObject("picture_lastBall.Image")));
            this.picture_lastBall.Location = new System.Drawing.Point(154, 171);
            this.picture_lastBall.Name = "picture_lastBall";
            this.picture_lastBall.Size = new System.Drawing.Size(53, 51);
            this.picture_lastBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_lastBall.TabIndex = 6;
            this.picture_lastBall.TabStop = false;
            this.picture_lastBall.Tag = "Ball";
            this.picture_lastBall.Visible = false;
            // 
            // picture_tennisBall
            // 
            this.picture_tennisBall.BackColor = System.Drawing.Color.Red;
            this.picture_tennisBall.Image = ((System.Drawing.Image)(resources.GetObject("picture_tennisBall.Image")));
            this.picture_tennisBall.Location = new System.Drawing.Point(557, 171);
            this.picture_tennisBall.Name = "picture_tennisBall";
            this.picture_tennisBall.Size = new System.Drawing.Size(53, 51);
            this.picture_tennisBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_tennisBall.TabIndex = 5;
            this.picture_tennisBall.TabStop = false;
            this.picture_tennisBall.Tag = "Ball";
            this.picture_tennisBall.Visible = false;
            // 
            // picture_ball
            // 
            this.picture_ball.BackColor = System.Drawing.Color.Red;
            this.picture_ball.Image = ((System.Drawing.Image)(resources.GetObject("picture_ball.Image")));
            this.picture_ball.Location = new System.Drawing.Point(347, 291);
            this.picture_ball.Name = "picture_ball";
            this.picture_ball.Size = new System.Drawing.Size(53, 51);
            this.picture_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ball.TabIndex = 0;
            this.picture_ball.TabStop = false;
            this.picture_ball.Tag = "Ball";
            // 
            // lbl_endGame
            // 
            this.lbl_endGame.AutoSize = true;
            this.lbl_endGame.Font = new System.Drawing.Font("Kristen ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endGame.Location = new System.Drawing.Point(274, 150);
            this.lbl_endGame.Name = "lbl_endGame";
            this.lbl_endGame.Size = new System.Drawing.Size(0, 33);
            this.lbl_endGame.TabIndex = 7;
            this.lbl_endGame.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.lbl_endGame);
            this.Controls.Add(this.picture_lastBall);
            this.Controls.Add(this.picture_tennisBall);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picture_Square);
            this.Controls.Add(this.picture_ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lastBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tennisBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElipsePictureBox picture_ball;
        private System.Windows.Forms.PictureBox picture_Square;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Timer timer1;
        private ElipsePictureBox picture_tennisBall;
        private ElipsePictureBox picture_lastBall;
        private System.Windows.Forms.Label lbl_endGame;
    }
}


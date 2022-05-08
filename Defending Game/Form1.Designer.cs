
namespace WinFormDefendingGame
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
            this.picture_stick = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_stick = new System.Windows.Forms.Label();
            this.picture_grass = new System.Windows.Forms.PictureBox();
            this.picture_ball = new WinFormDefendingGame.ElipsePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_stick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_stick
            // 
            this.picture_stick.Image = ((System.Drawing.Image)(resources.GetObject("picture_stick.Image")));
            this.picture_stick.Location = new System.Drawing.Point(334, 44);
            this.picture_stick.Name = "picture_stick";
            this.picture_stick.Size = new System.Drawing.Size(84, 24);
            this.picture_stick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_stick.TabIndex = 0;
            this.picture_stick.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Kristen ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(92, 33);
            this.lbl_score.TabIndex = 2;
            this.lbl_score.Text = "Ball: 0";
            // 
            // lbl_stick
            // 
            this.lbl_stick.AutoSize = true;
            this.lbl_stick.Font = new System.Drawing.Font("Kristen ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stick.Location = new System.Drawing.Point(652, 0);
            this.lbl_stick.Name = "lbl_stick";
            this.lbl_stick.Size = new System.Drawing.Size(120, 33);
            this.lbl_stick.TabIndex = 3;
            this.lbl_stick.Text = " Stick: 0";
            // 
            // picture_grass
            // 
            this.picture_grass.Image = ((System.Drawing.Image)(resources.GetObject("picture_grass.Image")));
            this.picture_grass.Location = new System.Drawing.Point(-2, 499);
            this.picture_grass.Name = "picture_grass";
            this.picture_grass.Size = new System.Drawing.Size(804, 81);
            this.picture_grass.TabIndex = 4;
            this.picture_grass.TabStop = false;
            // 
            // picture_ball
            // 
            this.picture_ball.BackColor = System.Drawing.Color.Red;
            this.picture_ball.Image = ((System.Drawing.Image)(resources.GetObject("picture_ball.Image")));
            this.picture_ball.Location = new System.Drawing.Point(364, 452);
            this.picture_ball.Name = "picture_ball";
            this.picture_ball.Size = new System.Drawing.Size(45, 44);
            this.picture_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ball.TabIndex = 1;
            this.picture_ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.picture_grass);
            this.Controls.Add(this.lbl_stick);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.picture_ball);
            this.Controls.Add(this.picture_stick);
            this.Name = "Form1";
            this.Text = "Defending Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture_stick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_stick;
        private ElipsePictureBox picture_ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_stick;
        private System.Windows.Forms.PictureBox picture_grass;
    }
}



namespace WinFoırmShootingGame
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
            this.picture_dinasor = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.picture_ball = new WinFoırmShootingGame.ElipsePictureBox();
            this.picture_box2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dinasor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box2)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_dinasor
            // 
            this.picture_dinasor.Image = ((System.Drawing.Image)(resources.GetObject("picture_dinasor.Image")));
            this.picture_dinasor.Location = new System.Drawing.Point(332, 12);
            this.picture_dinasor.Name = "picture_dinasor";
            this.picture_dinasor.Size = new System.Drawing.Size(69, 60);
            this.picture_dinasor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_dinasor.TabIndex = 2;
            this.picture_dinasor.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(154, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(313, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(268, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Game Over !";
            this.label1.Visible = false;
            // 
            // picture_box
            // 
            this.picture_box.Image = ((System.Drawing.Image)(resources.GetObject("picture_box.Image")));
            this.picture_box.Location = new System.Drawing.Point(661, 199);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(44, 42);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 7;
            this.picture_box.TabStop = false;
            // 
            // picture_ball
            // 
            this.picture_ball.BackColor = System.Drawing.Color.DarkGray;
            this.picture_ball.Image = ((System.Drawing.Image)(resources.GetObject("picture_ball.Image")));
            this.picture_ball.Location = new System.Drawing.Point(332, 582);
            this.picture_ball.Name = "picture_ball";
            this.picture_ball.Size = new System.Drawing.Size(69, 75);
            this.picture_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ball.TabIndex = 6;
            this.picture_ball.TabStop = false;
            // 
            // picture_box2
            // 
            this.picture_box2.Image = ((System.Drawing.Image)(resources.GetObject("picture_box2.Image")));
            this.picture_box2.Location = new System.Drawing.Point(104, 199);
            this.picture_box2.Name = "picture_box2";
            this.picture_box2.Size = new System.Drawing.Size(44, 42);
            this.picture_box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box2.TabIndex = 8;
            this.picture_box2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.picture_box2);
            this.Controls.Add(this.picture_box);
            this.Controls.Add(this.picture_ball);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picture_dinasor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture_dinasor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_dinasor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private ElipsePictureBox picture_ball;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.PictureBox picture_box2;
    }
}


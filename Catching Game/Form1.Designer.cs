
namespace WinFormCatchingGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture_Sun = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.elipse4 = new WinFormCatchingGame.elipse();
            this.elipse3 = new WinFormCatchingGame.elipse();
            this.elipse2 = new WinFormCatchingGame.elipse();
            this.elipse1 = new WinFormCatchingGame.elipse();
            this.picture_elipseBasket = new WinFormCatchingGame.elipse();
            this.picture_mars = new WinFormCatchingGame.elipse();
            this.picture_World = new WinFormCatchingGame.elipse();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Sun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_elipseBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_mars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_World)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // picture_Sun
            // 
            this.picture_Sun.Image = ((System.Drawing.Image)(resources.GetObject("picture_Sun.Image")));
            this.picture_Sun.Location = new System.Drawing.Point(260, 32);
            this.picture_Sun.Name = "picture_Sun";
            this.picture_Sun.Size = new System.Drawing.Size(114, 116);
            this.picture_Sun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Sun.TabIndex = 4;
            this.picture_Sun.TabStop = false;
            this.picture_Sun.Tag = "Planet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(210, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Egg";
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(89, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Egg";
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(418, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Egg";
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(566, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Egg";
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(669, 271);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Egg";
            this.pictureBox6.Visible = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Black;
            this.lbl_score.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_score.Location = new System.Drawing.Point(13, 13);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(74, 24);
            this.lbl_score.TabIndex = 11;
            this.lbl_score.Text = "Score:  0";
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Red;
            this.btn_restart.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_restart.Location = new System.Drawing.Point(317, 233);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(110, 33);
            this.btn_restart.TabIndex = 17;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // elipse4
            // 
            this.elipse4.BackColor = System.Drawing.Color.Black;
            this.elipse4.Image = ((System.Drawing.Image)(resources.GetObject("elipse4.Image")));
            this.elipse4.Location = new System.Drawing.Point(17, 108);
            this.elipse4.Name = "elipse4";
            this.elipse4.Size = new System.Drawing.Size(50, 56);
            this.elipse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elipse4.TabIndex = 16;
            this.elipse4.TabStop = false;
            this.elipse4.Tag = "obstacle";
            this.elipse4.Visible = false;
            // 
            // elipse3
            // 
            this.elipse3.BackColor = System.Drawing.Color.Black;
            this.elipse3.Image = ((System.Drawing.Image)(resources.GetObject("elipse3.Image")));
            this.elipse3.Location = new System.Drawing.Point(669, 71);
            this.elipse3.Name = "elipse3";
            this.elipse3.Size = new System.Drawing.Size(50, 56);
            this.elipse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elipse3.TabIndex = 15;
            this.elipse3.TabStop = false;
            this.elipse3.Tag = "obstacle";
            this.elipse3.Visible = false;
            // 
            // elipse2
            // 
            this.elipse2.BackColor = System.Drawing.Color.Black;
            this.elipse2.Image = ((System.Drawing.Image)(resources.GetObject("elipse2.Image")));
            this.elipse2.Location = new System.Drawing.Point(435, 49);
            this.elipse2.Name = "elipse2";
            this.elipse2.Size = new System.Drawing.Size(50, 56);
            this.elipse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elipse2.TabIndex = 14;
            this.elipse2.TabStop = false;
            this.elipse2.Tag = "obstacle";
            this.elipse2.Visible = false;
            // 
            // elipse1
            // 
            this.elipse1.BackColor = System.Drawing.Color.Black;
            this.elipse1.Image = ((System.Drawing.Image)(resources.GetObject("elipse1.Image")));
            this.elipse1.Location = new System.Drawing.Point(184, 71);
            this.elipse1.Name = "elipse1";
            this.elipse1.Size = new System.Drawing.Size(50, 56);
            this.elipse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elipse1.TabIndex = 13;
            this.elipse1.TabStop = false;
            this.elipse1.Tag = "obstacle";
            this.elipse1.Visible = false;
            // 
            // picture_elipseBasket
            // 
            this.picture_elipseBasket.BackColor = System.Drawing.Color.Black;
            this.picture_elipseBasket.Image = ((System.Drawing.Image)(resources.GetObject("picture_elipseBasket.Image")));
            this.picture_elipseBasket.Location = new System.Drawing.Point(317, 358);
            this.picture_elipseBasket.Name = "picture_elipseBasket";
            this.picture_elipseBasket.Size = new System.Drawing.Size(83, 73);
            this.picture_elipseBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_elipseBasket.TabIndex = 12;
            this.picture_elipseBasket.TabStop = false;
            this.picture_elipseBasket.Visible = false;
            // 
            // picture_mars
            // 
            this.picture_mars.BackColor = System.Drawing.Color.Black;
            this.picture_mars.Image = ((System.Drawing.Image)(resources.GetObject("picture_mars.Image")));
            this.picture_mars.Location = new System.Drawing.Point(595, 124);
            this.picture_mars.Name = "picture_mars";
            this.picture_mars.Size = new System.Drawing.Size(114, 116);
            this.picture_mars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_mars.TabIndex = 3;
            this.picture_mars.TabStop = false;
            this.picture_mars.Tag = "Planet";
            // 
            // picture_World
            // 
            this.picture_World.BackColor = System.Drawing.Color.Black;
            this.picture_World.Image = ((System.Drawing.Image)(resources.GetObject("picture_World.Image")));
            this.picture_World.Location = new System.Drawing.Point(40, 233);
            this.picture_World.Name = "picture_World";
            this.picture_World.Size = new System.Drawing.Size(114, 116);
            this.picture_World.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_World.TabIndex = 2;
            this.picture_World.TabStop = false;
            this.picture_World.Tag = "Planet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(750, 443);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.elipse4);
            this.Controls.Add(this.elipse3);
            this.Controls.Add(this.elipse2);
            this.Controls.Add(this.elipse1);
            this.Controls.Add(this.picture_elipseBasket);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture_Sun);
            this.Controls.Add(this.picture_mars);
            this.Controls.Add(this.picture_World);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Sun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_elipseBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_mars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_World)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private elipse picture_World;
        private elipse picture_mars;
        private System.Windows.Forms.PictureBox picture_Sun;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_score;
        private elipse picture_elipseBasket;
        private elipse elipse1;
        private elipse elipse2;
        private elipse elipse3;
        private elipse elipse4;
        private System.Windows.Forms.Button btn_restart;
    }
}


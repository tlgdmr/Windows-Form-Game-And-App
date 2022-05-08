
namespace WindowsFormIndexCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_box1 = new System.Windows.Forms.TextBox();
            this.txt_box2 = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_check.Location = new System.Drawing.Point(313, 254);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(113, 44);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txt_box1
            // 
            this.txt_box1.Location = new System.Drawing.Point(235, 141);
            this.txt_box1.Name = "txt_box1";
            this.txt_box1.Size = new System.Drawing.Size(113, 22);
            this.txt_box1.TabIndex = 1;
            // 
            // txt_box2
            // 
            this.txt_box2.Location = new System.Drawing.Point(405, 141);
            this.txt_box2.Name = "txt_box2";
            this.txt_box2.Size = new System.Drawing.Size(113, 22);
            this.txt_box2.TabIndex = 2;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_1.Location = new System.Drawing.Point(330, 202);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(0, 20);
            this.lbl_1.TabIndex = 3;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.BackColor = System.Drawing.Color.Transparent;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_weight.Location = new System.Drawing.Point(232, 121);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(0, 17);
            this.lbl_weight.TabIndex = 4;
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.BackColor = System.Drawing.Color.Transparent;
            this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_height.Location = new System.Drawing.Point(402, 121);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(0, 17);
            this.lbl_height.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "- Under 18.5  Is Weak",
            "- Between 18.5-24.9 Is Normal",
            "- Between 25-29.9 Overweight",
            "- Between 30-39.9 Obese",
            "- Above 40 Morbidly Obese ",
            " "});
            this.listBox1.Location = new System.Drawing.Point(569, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 132);
            this.listBox1.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(619, 353);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 59);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(289, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Your Ideal Weight\r\n➜➜➜\r\n\r\n\r\n\r\n\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txt_box2);
            this.Controls.Add(this.txt_box1);
            this.Controls.Add(this.btn_check);
            this.Name = "Form1";
            this.Text = "Index_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_box1;
        private System.Windows.Forms.TextBox txt_box2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
    }
}


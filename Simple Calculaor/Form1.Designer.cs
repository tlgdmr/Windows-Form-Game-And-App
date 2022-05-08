
namespace WindowsFormSimpleCalculaor
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
            this.btn_mltply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_sbstrct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_leave = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mltply
            // 
            this.btn_mltply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_mltply.Location = new System.Drawing.Point(12, 134);
            this.btn_mltply.Name = "btn_mltply";
            this.btn_mltply.Size = new System.Drawing.Size(100, 42);
            this.btn_mltply.TabIndex = 0;
            this.btn_mltply.Text = "Multiply";
            this.btn_mltply.UseVisualStyleBackColor = false;
            this.btn_mltply.Click += new System.EventHandler(this.btn_mltply_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.Location = new System.Drawing.Point(75, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.Location = new System.Drawing.Point(293, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.Location = new System.Drawing.Point(281, 134);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 42);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_divide.Location = new System.Drawing.Point(136, 134);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(115, 42);
            this.btn_divide.TabIndex = 4;
            this.btn_divide.Text = "Divide";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_sbstrct
            // 
            this.btn_sbstrct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sbstrct.Location = new System.Drawing.Point(416, 134);
            this.btn_sbstrct.Name = "btn_sbstrct";
            this.btn_sbstrct.Size = new System.Drawing.Size(113, 42);
            this.btn_sbstrct.TabIndex = 5;
            this.btn_sbstrct.Text = "Substract";
            this.btn_sbstrct.UseVisualStyleBackColor = false;
            this.btn_sbstrct.Click += new System.EventHandler(this.btn_sbstrct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(190, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.Red;
            this.btn_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_leave.Location = new System.Drawing.Point(379, 204);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(140, 51);
            this.btn_leave.TabIndex = 7;
            this.btn_leave.Text = "Exit";
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(53, 204);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 51);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(566, 269);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_leave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sbstrct);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_mltply);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Calculator.exe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mltply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_sbstrct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Button btn_clear;
    }
}


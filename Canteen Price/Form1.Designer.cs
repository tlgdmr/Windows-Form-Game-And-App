
namespace WindowsFormCanteenPrice
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
            this.txt_toast_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numeric_toast = new System.Windows.Forms.NumericUpDown();
            this.lbl_toast = new System.Windows.Forms.Label();
            this.lbl_Sandwich = new System.Windows.Forms.Label();
            this.lbl_HotDog = new System.Windows.Forms.Label();
            this.lbl_Nuggets = new System.Windows.Forms.Label();
            this.numeric_sandwich = new System.Windows.Forms.NumericUpDown();
            this.numeric_HotDog = new System.Windows.Forms.NumericUpDown();
            this.numeric_Nuggets = new System.Windows.Forms.NumericUpDown();
            this.txt_sandwich = new System.Windows.Forms.TextBox();
            this.txt_hotDog = new System.Windows.Forms.TextBox();
            this.txt_nugggets = new System.Windows.Forms.TextBox();
            this.lbl_Doner = new System.Windows.Forms.Label();
            this.lbl_FrenchFries = new System.Windows.Forms.Label();
            this.lbl_Vegan = new System.Windows.Forms.Label();
            this.numeric_Doner = new System.Windows.Forms.NumericUpDown();
            this.numeric_FrenchFries = new System.Windows.Forms.NumericUpDown();
            this.numeric_Vegan = new System.Windows.Forms.NumericUpDown();
            this.txt_Doner = new System.Windows.Forms.TextBox();
            this.txt_FrechFries = new System.Windows.Forms.TextBox();
            this.txt_vegan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Coke = new System.Windows.Forms.Label();
            this.lbl_fanta = new System.Windows.Forms.Label();
            this.lbl_Sprite = new System.Windows.Forms.Label();
            this.lbl_Link = new System.Windows.Forms.Label();
            this.lbl_Ayran = new System.Windows.Forms.Label();
            this.numeric_Coke = new System.Windows.Forms.NumericUpDown();
            this.numeric_Fanta = new System.Windows.Forms.NumericUpDown();
            this.numeric_Sprite = new System.Windows.Forms.NumericUpDown();
            this.numeric_Link = new System.Windows.Forms.NumericUpDown();
            this.numeric_Ayran = new System.Windows.Forms.NumericUpDown();
            this.txt_Coke = new System.Windows.Forms.TextBox();
            this.txt_Fanta = new System.Windows.Forms.TextBox();
            this.txt_Sprite = new System.Windows.Forms.TextBox();
            this.txt_Link = new System.Windows.Forms.TextBox();
            this.txt_Ayran = new System.Windows.Forms.TextBox();
            this.txt_totalResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_toast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_sandwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_HotDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Nuggets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Doner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_FrenchFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Vegan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Coke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Fanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Ayran)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_toast_result
            // 
            this.txt_toast_result.Location = new System.Drawing.Point(231, 46);
            this.txt_toast_result.Name = "txt_toast_result";
            this.txt_toast_result.Size = new System.Drawing.Size(100, 22);
            this.txt_toast_result.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(354, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check Total";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeric_toast
            // 
            this.numeric_toast.Location = new System.Drawing.Point(133, 44);
            this.numeric_toast.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_toast.Name = "numeric_toast";
            this.numeric_toast.Size = new System.Drawing.Size(48, 22);
            this.numeric_toast.TabIndex = 4;
            this.numeric_toast.ValueChanged += new System.EventHandler(this.numeric_toast_ValueChanged);
            // 
            // lbl_toast
            // 
            this.lbl_toast.AutoSize = true;
            this.lbl_toast.Location = new System.Drawing.Point(12, 46);
            this.lbl_toast.Name = "lbl_toast";
            this.lbl_toast.Size = new System.Drawing.Size(46, 17);
            this.lbl_toast.TabIndex = 5;
            this.lbl_toast.Text = "label1";
            // 
            // lbl_Sandwich
            // 
            this.lbl_Sandwich.AutoSize = true;
            this.lbl_Sandwich.Location = new System.Drawing.Point(12, 101);
            this.lbl_Sandwich.Name = "lbl_Sandwich";
            this.lbl_Sandwich.Size = new System.Drawing.Size(46, 17);
            this.lbl_Sandwich.TabIndex = 6;
            this.lbl_Sandwich.Text = "label1";
            // 
            // lbl_HotDog
            // 
            this.lbl_HotDog.AutoSize = true;
            this.lbl_HotDog.Location = new System.Drawing.Point(12, 149);
            this.lbl_HotDog.Name = "lbl_HotDog";
            this.lbl_HotDog.Size = new System.Drawing.Size(46, 17);
            this.lbl_HotDog.TabIndex = 7;
            this.lbl_HotDog.Text = "label2";
            // 
            // lbl_Nuggets
            // 
            this.lbl_Nuggets.AutoSize = true;
            this.lbl_Nuggets.Location = new System.Drawing.Point(12, 206);
            this.lbl_Nuggets.Name = "lbl_Nuggets";
            this.lbl_Nuggets.Size = new System.Drawing.Size(46, 17);
            this.lbl_Nuggets.TabIndex = 8;
            this.lbl_Nuggets.Text = "label3";
            // 
            // numeric_sandwich
            // 
            this.numeric_sandwich.Location = new System.Drawing.Point(133, 97);
            this.numeric_sandwich.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_sandwich.Name = "numeric_sandwich";
            this.numeric_sandwich.Size = new System.Drawing.Size(48, 22);
            this.numeric_sandwich.TabIndex = 9;
            this.numeric_sandwich.ValueChanged += new System.EventHandler(this.numeric_sandwich_ValueChanged);
            // 
            // numeric_HotDog
            // 
            this.numeric_HotDog.Location = new System.Drawing.Point(133, 147);
            this.numeric_HotDog.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_HotDog.Name = "numeric_HotDog";
            this.numeric_HotDog.Size = new System.Drawing.Size(48, 22);
            this.numeric_HotDog.TabIndex = 10;
            this.numeric_HotDog.ValueChanged += new System.EventHandler(this.numeric_HotDog_ValueChanged);
            // 
            // numeric_Nuggets
            // 
            this.numeric_Nuggets.Location = new System.Drawing.Point(133, 204);
            this.numeric_Nuggets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Nuggets.Name = "numeric_Nuggets";
            this.numeric_Nuggets.Size = new System.Drawing.Size(48, 22);
            this.numeric_Nuggets.TabIndex = 11;
            this.numeric_Nuggets.ValueChanged += new System.EventHandler(this.numeric_Nuggets_ValueChanged);
            // 
            // txt_sandwich
            // 
            this.txt_sandwich.Location = new System.Drawing.Point(231, 96);
            this.txt_sandwich.Name = "txt_sandwich";
            this.txt_sandwich.Size = new System.Drawing.Size(100, 22);
            this.txt_sandwich.TabIndex = 12;
            // 
            // txt_hotDog
            // 
            this.txt_hotDog.Location = new System.Drawing.Point(231, 152);
            this.txt_hotDog.Name = "txt_hotDog";
            this.txt_hotDog.Size = new System.Drawing.Size(100, 22);
            this.txt_hotDog.TabIndex = 13;
            // 
            // txt_nugggets
            // 
            this.txt_nugggets.Location = new System.Drawing.Point(231, 206);
            this.txt_nugggets.Name = "txt_nugggets";
            this.txt_nugggets.Size = new System.Drawing.Size(100, 22);
            this.txt_nugggets.TabIndex = 14;
            // 
            // lbl_Doner
            // 
            this.lbl_Doner.AutoSize = true;
            this.lbl_Doner.Location = new System.Drawing.Point(12, 266);
            this.lbl_Doner.Name = "lbl_Doner";
            this.lbl_Doner.Size = new System.Drawing.Size(46, 17);
            this.lbl_Doner.TabIndex = 15;
            this.lbl_Doner.Text = "label4";
            // 
            // lbl_FrenchFries
            // 
            this.lbl_FrenchFries.AutoSize = true;
            this.lbl_FrenchFries.Location = new System.Drawing.Point(12, 324);
            this.lbl_FrenchFries.Name = "lbl_FrenchFries";
            this.lbl_FrenchFries.Size = new System.Drawing.Size(46, 17);
            this.lbl_FrenchFries.TabIndex = 16;
            this.lbl_FrenchFries.Text = "label5";
            // 
            // lbl_Vegan
            // 
            this.lbl_Vegan.AutoSize = true;
            this.lbl_Vegan.Location = new System.Drawing.Point(13, 375);
            this.lbl_Vegan.Name = "lbl_Vegan";
            this.lbl_Vegan.Size = new System.Drawing.Size(46, 17);
            this.lbl_Vegan.TabIndex = 17;
            this.lbl_Vegan.Text = "label6";
            // 
            // numeric_Doner
            // 
            this.numeric_Doner.Location = new System.Drawing.Point(133, 265);
            this.numeric_Doner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Doner.Name = "numeric_Doner";
            this.numeric_Doner.Size = new System.Drawing.Size(48, 22);
            this.numeric_Doner.TabIndex = 18;
            this.numeric_Doner.ValueChanged += new System.EventHandler(this.numeric_Doner_ValueChanged);
            // 
            // numeric_FrenchFries
            // 
            this.numeric_FrenchFries.Location = new System.Drawing.Point(133, 319);
            this.numeric_FrenchFries.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_FrenchFries.Name = "numeric_FrenchFries";
            this.numeric_FrenchFries.Size = new System.Drawing.Size(48, 22);
            this.numeric_FrenchFries.TabIndex = 19;
            this.numeric_FrenchFries.ValueChanged += new System.EventHandler(this.numeric_FrenchFries_ValueChanged);
            // 
            // numeric_Vegan
            // 
            this.numeric_Vegan.Location = new System.Drawing.Point(133, 370);
            this.numeric_Vegan.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Vegan.Name = "numeric_Vegan";
            this.numeric_Vegan.Size = new System.Drawing.Size(48, 22);
            this.numeric_Vegan.TabIndex = 20;
            this.numeric_Vegan.ValueChanged += new System.EventHandler(this.numeric_Vegan_ValueChanged);
            // 
            // txt_Doner
            // 
            this.txt_Doner.Location = new System.Drawing.Point(231, 263);
            this.txt_Doner.Name = "txt_Doner";
            this.txt_Doner.Size = new System.Drawing.Size(100, 22);
            this.txt_Doner.TabIndex = 21;
            // 
            // txt_FrechFries
            // 
            this.txt_FrechFries.Location = new System.Drawing.Point(231, 318);
            this.txt_FrechFries.Name = "txt_FrechFries";
            this.txt_FrechFries.Size = new System.Drawing.Size(100, 22);
            this.txt_FrechFries.TabIndex = 22;
            // 
            // txt_vegan
            // 
            this.txt_vegan.Location = new System.Drawing.Point(231, 372);
            this.txt_vegan.Name = "txt_vegan";
            this.txt_vegan.Size = new System.Drawing.Size(100, 22);
            this.txt_vegan.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "FOOD;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(478, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "BEVERAGE;";
            // 
            // lbl_Coke
            // 
            this.lbl_Coke.AutoSize = true;
            this.lbl_Coke.Location = new System.Drawing.Point(482, 50);
            this.lbl_Coke.Name = "lbl_Coke";
            this.lbl_Coke.Size = new System.Drawing.Size(46, 17);
            this.lbl_Coke.TabIndex = 26;
            this.lbl_Coke.Text = "label3";
            // 
            // lbl_fanta
            // 
            this.lbl_fanta.AutoSize = true;
            this.lbl_fanta.Location = new System.Drawing.Point(479, 101);
            this.lbl_fanta.Name = "lbl_fanta";
            this.lbl_fanta.Size = new System.Drawing.Size(46, 17);
            this.lbl_fanta.TabIndex = 27;
            this.lbl_fanta.Text = "label4";
            // 
            // lbl_Sprite
            // 
            this.lbl_Sprite.AutoSize = true;
            this.lbl_Sprite.Location = new System.Drawing.Point(479, 152);
            this.lbl_Sprite.Name = "lbl_Sprite";
            this.lbl_Sprite.Size = new System.Drawing.Size(46, 17);
            this.lbl_Sprite.TabIndex = 28;
            this.lbl_Sprite.Text = "label5";
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Location = new System.Drawing.Point(479, 206);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(46, 17);
            this.lbl_Link.TabIndex = 29;
            this.lbl_Link.Text = "label6";
            // 
            // lbl_Ayran
            // 
            this.lbl_Ayran.AutoSize = true;
            this.lbl_Ayran.Location = new System.Drawing.Point(479, 265);
            this.lbl_Ayran.Name = "lbl_Ayran";
            this.lbl_Ayran.Size = new System.Drawing.Size(46, 17);
            this.lbl_Ayran.TabIndex = 30;
            this.lbl_Ayran.Text = "label3";
            // 
            // numeric_Coke
            // 
            this.numeric_Coke.Location = new System.Drawing.Point(581, 45);
            this.numeric_Coke.Name = "numeric_Coke";
            this.numeric_Coke.Size = new System.Drawing.Size(50, 22);
            this.numeric_Coke.TabIndex = 31;
            this.numeric_Coke.ValueChanged += new System.EventHandler(this.numeric_Coke_ValueChanged);
            // 
            // numeric_Fanta
            // 
            this.numeric_Fanta.Location = new System.Drawing.Point(581, 101);
            this.numeric_Fanta.Name = "numeric_Fanta";
            this.numeric_Fanta.Size = new System.Drawing.Size(50, 22);
            this.numeric_Fanta.TabIndex = 32;
            this.numeric_Fanta.ValueChanged += new System.EventHandler(this.numeric_Fanta_ValueChanged);
            // 
            // numeric_Sprite
            // 
            this.numeric_Sprite.Location = new System.Drawing.Point(581, 151);
            this.numeric_Sprite.Name = "numeric_Sprite";
            this.numeric_Sprite.Size = new System.Drawing.Size(50, 22);
            this.numeric_Sprite.TabIndex = 33;
            this.numeric_Sprite.ValueChanged += new System.EventHandler(this.numeric_Sprite_ValueChanged);
            // 
            // numeric_Link
            // 
            this.numeric_Link.Location = new System.Drawing.Point(581, 205);
            this.numeric_Link.Name = "numeric_Link";
            this.numeric_Link.Size = new System.Drawing.Size(50, 22);
            this.numeric_Link.TabIndex = 34;
            this.numeric_Link.ValueChanged += new System.EventHandler(this.numeric_Link_ValueChanged);
            // 
            // numeric_Ayran
            // 
            this.numeric_Ayran.Location = new System.Drawing.Point(581, 261);
            this.numeric_Ayran.Name = "numeric_Ayran";
            this.numeric_Ayran.Size = new System.Drawing.Size(50, 22);
            this.numeric_Ayran.TabIndex = 35;
            this.numeric_Ayran.ValueChanged += new System.EventHandler(this.numeric_Ayran_ValueChanged);
            // 
            // txt_Coke
            // 
            this.txt_Coke.Location = new System.Drawing.Point(663, 44);
            this.txt_Coke.Name = "txt_Coke";
            this.txt_Coke.Size = new System.Drawing.Size(100, 22);
            this.txt_Coke.TabIndex = 36;
            // 
            // txt_Fanta
            // 
            this.txt_Fanta.Location = new System.Drawing.Point(663, 101);
            this.txt_Fanta.Name = "txt_Fanta";
            this.txt_Fanta.Size = new System.Drawing.Size(100, 22);
            this.txt_Fanta.TabIndex = 37;
            // 
            // txt_Sprite
            // 
            this.txt_Sprite.Location = new System.Drawing.Point(663, 151);
            this.txt_Sprite.Name = "txt_Sprite";
            this.txt_Sprite.Size = new System.Drawing.Size(100, 22);
            this.txt_Sprite.TabIndex = 38;
            // 
            // txt_Link
            // 
            this.txt_Link.Location = new System.Drawing.Point(663, 205);
            this.txt_Link.Name = "txt_Link";
            this.txt_Link.Size = new System.Drawing.Size(100, 22);
            this.txt_Link.TabIndex = 39;
            // 
            // txt_Ayran
            // 
            this.txt_Ayran.Location = new System.Drawing.Point(663, 260);
            this.txt_Ayran.Name = "txt_Ayran";
            this.txt_Ayran.Size = new System.Drawing.Size(100, 22);
            this.txt_Ayran.TabIndex = 40;
            // 
            // txt_totalResult
            // 
            this.txt_totalResult.Location = new System.Drawing.Point(526, 347);
            this.txt_totalResult.Name = "txt_totalResult";
            this.txt_totalResult.Size = new System.Drawing.Size(105, 22);
            this.txt_totalResult.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(523, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total :";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Location = new System.Drawing.Point(663, 404);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(103, 34);
            this.btn_Exit.TabIndex = 43;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Orange;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clear.Location = new System.Drawing.Point(663, 335);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 34);
            this.btn_Clear.TabIndex = 44;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_totalResult);
            this.Controls.Add(this.txt_Ayran);
            this.Controls.Add(this.txt_Link);
            this.Controls.Add(this.txt_Sprite);
            this.Controls.Add(this.txt_Fanta);
            this.Controls.Add(this.txt_Coke);
            this.Controls.Add(this.numeric_Ayran);
            this.Controls.Add(this.numeric_Link);
            this.Controls.Add(this.numeric_Sprite);
            this.Controls.Add(this.numeric_Fanta);
            this.Controls.Add(this.numeric_Coke);
            this.Controls.Add(this.lbl_Ayran);
            this.Controls.Add(this.lbl_Link);
            this.Controls.Add(this.lbl_Sprite);
            this.Controls.Add(this.lbl_fanta);
            this.Controls.Add(this.lbl_Coke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vegan);
            this.Controls.Add(this.txt_FrechFries);
            this.Controls.Add(this.txt_Doner);
            this.Controls.Add(this.numeric_Vegan);
            this.Controls.Add(this.numeric_FrenchFries);
            this.Controls.Add(this.numeric_Doner);
            this.Controls.Add(this.lbl_Vegan);
            this.Controls.Add(this.lbl_FrenchFries);
            this.Controls.Add(this.lbl_Doner);
            this.Controls.Add(this.txt_nugggets);
            this.Controls.Add(this.txt_hotDog);
            this.Controls.Add(this.txt_sandwich);
            this.Controls.Add(this.numeric_Nuggets);
            this.Controls.Add(this.numeric_HotDog);
            this.Controls.Add(this.numeric_sandwich);
            this.Controls.Add(this.lbl_Nuggets);
            this.Controls.Add(this.lbl_HotDog);
            this.Controls.Add(this.lbl_Sandwich);
            this.Controls.Add(this.lbl_toast);
            this.Controls.Add(this.numeric_toast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_toast_result);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_toast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_sandwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_HotDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Nuggets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Doner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_FrenchFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Vegan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Coke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Fanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Ayran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_toast_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numeric_toast;
        private System.Windows.Forms.Label lbl_toast;
        private System.Windows.Forms.Label lbl_Sandwich;
        private System.Windows.Forms.Label lbl_HotDog;
        private System.Windows.Forms.Label lbl_Nuggets;
        private System.Windows.Forms.NumericUpDown numeric_sandwich;
        private System.Windows.Forms.NumericUpDown numeric_HotDog;
        private System.Windows.Forms.NumericUpDown numeric_Nuggets;
        private System.Windows.Forms.TextBox txt_sandwich;
        private System.Windows.Forms.TextBox txt_hotDog;
        private System.Windows.Forms.TextBox txt_nugggets;
        private System.Windows.Forms.Label lbl_Doner;
        private System.Windows.Forms.Label lbl_FrenchFries;
        private System.Windows.Forms.Label lbl_Vegan;
        private System.Windows.Forms.NumericUpDown numeric_Doner;
        private System.Windows.Forms.NumericUpDown numeric_FrenchFries;
        private System.Windows.Forms.NumericUpDown numeric_Vegan;
        private System.Windows.Forms.TextBox txt_Doner;
        private System.Windows.Forms.TextBox txt_FrechFries;
        private System.Windows.Forms.TextBox txt_vegan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Coke;
        private System.Windows.Forms.Label lbl_fanta;
        private System.Windows.Forms.Label lbl_Sprite;
        private System.Windows.Forms.Label lbl_Link;
        private System.Windows.Forms.Label lbl_Ayran;
        private System.Windows.Forms.NumericUpDown numeric_Coke;
        private System.Windows.Forms.NumericUpDown numeric_Fanta;
        private System.Windows.Forms.NumericUpDown numeric_Sprite;
        private System.Windows.Forms.NumericUpDown numeric_Link;
        private System.Windows.Forms.NumericUpDown numeric_Ayran;
        private System.Windows.Forms.TextBox txt_Coke;
        private System.Windows.Forms.TextBox txt_Fanta;
        private System.Windows.Forms.TextBox txt_Sprite;
        private System.Windows.Forms.TextBox txt_Link;
        private System.Windows.Forms.TextBox txt_Ayran;
        private System.Windows.Forms.TextBox txt_totalResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Clear;
    }
}


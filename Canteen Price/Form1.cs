using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCanteenPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_toast.Text = "Toast 3.50$";
            lbl_Sandwich.Text = "Sandwich 4.25$";
            lbl_HotDog.Text = "Hot Dog 4.00$";
            lbl_FrenchFries.Text = "French Fries 3.50";
            lbl_Doner.Text = "Doner 4.50$";
            lbl_Nuggets.Text = "Nuggets 3.75$";
            lbl_Vegan.Text = "Vegan 3.00$";
            lbl_Coke.Text = "Coke 0.85$";
            lbl_Ayran.Text = "Ayran 0.50$";
            lbl_fanta.Text = "Fanta 0.75$";
            lbl_Link.Text = "Link 0.50";
            lbl_Sprite.Text = "Sprite 1.00$";

            decimal toast = 0;
            txt_toast_result.Text= toast.ToString();
            decimal sandwich = 0;
            txt_sandwich.Text = sandwich.ToString();
            decimal hotDog = 0;
            txt_hotDog.Text = hotDog.ToString();
            decimal nuggets = 0;
            txt_nugggets.Text = nuggets.ToString();
            decimal doner = 0;
            txt_Doner.Text = doner.ToString();
            decimal frenchFries = 0;
            txt_FrechFries.Text = frenchFries.ToString();
            decimal vegan = 0;
            txt_vegan.Text = vegan.ToString();
            decimal coke = 0;
            txt_Coke.Text = coke.ToString();
            decimal fanta = 0;
            txt_Fanta.Text = fanta.ToString();
            decimal sprite = 0;
            txt_Sprite.Text = sprite.ToString();
            decimal link = 0;
            txt_Link.Text = link.ToString();
            decimal ayran = 0;
            txt_Ayran.Text = ayran.ToString();
        }
        private void numeric_toast_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_toast.Value;
            decimal result = 3.50m * val1;
            txt_toast_result.Text = result.ToString();
        }
        private void numeric_sandwich_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_sandwich.Value;
            decimal result = 4.25m * val1;
            txt_sandwich.Text = result.ToString();
        }
        private void numeric_HotDog_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_HotDog.Value;
            decimal result = 4.00m * val1;
            txt_hotDog.Text = result.ToString();
        }
        private void numeric_Nuggets_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Nuggets.Value;
            decimal result = 3.75m * val1;
            txt_nugggets.Text = result.ToString();
        }
        private void numeric_Doner_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Doner.Value;
            decimal result = 4.50m * val1;
            txt_Doner.Text = result.ToString();
        }
        private void numeric_FrenchFries_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_FrenchFries.Value;
            decimal result = 3.50m * val1;
            txt_FrechFries.Text = result.ToString();
        }
        private void numeric_Vegan_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Vegan.Value;
            decimal result = 3.00m * val1;
            txt_vegan.Text = result.ToString();

        }
         private void numeric_Coke_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Coke.Value;
            decimal result = 0.85m * val1;
            txt_Coke.Text = result.ToString();
        }
        private void numeric_Fanta_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Fanta.Value;
            decimal result = 0.75m * val1;
            txt_Fanta.Text = result.ToString();
        }
        private void numeric_Sprite_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Sprite.Value;
            decimal result = 1.00m * val1;
            txt_Sprite.Text = result.ToString();
        }
        private void numeric_Link_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Link.Value;
            decimal result = 0.50m * val1;
            txt_Link.Text = result.ToString();
        }
        private void numeric_Ayran_ValueChanged(object sender, EventArgs e)
        {
            decimal val1 = numeric_Ayran.Value;
            decimal result = 0.50m * val1;
            txt_Ayran.Text = result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal doner = decimal.Parse(txt_Doner.Text);
            decimal ayran = decimal.Parse(txt_Ayran.Text);
            decimal coke = decimal.Parse(txt_Coke.Text);
            decimal sandwich = decimal.Parse(txt_sandwich.Text);
            decimal fanta = decimal.Parse(txt_Fanta.Text);
            decimal sprite = decimal.Parse(txt_Sprite.Text);
            decimal hotdog = decimal.Parse(txt_hotDog.Text);
            decimal frenchFries = decimal.Parse(txt_FrechFries.Text);
            decimal toast = decimal.Parse(txt_toast_result.Text);
            decimal vegan = decimal.Parse(txt_vegan.Text);
            decimal nugget = decimal.Parse(txt_nugggets.Text);
            decimal link = decimal.Parse(txt_Link.Text);
            decimal result = ayran + doner + coke + sandwich + fanta + sprite + hotdog + frenchFries + toast + vegan + nugget + link;
            txt_totalResult.Text = result.ToString() + " $";
           
         }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            numeric_Ayran.Value = 0;
            numeric_Coke.Value = 0;
            numeric_Doner.Value = 0;
            numeric_Fanta.Value = 0;
            numeric_FrenchFries.Value = 0;
            numeric_HotDog.Value = 0;
            numeric_Link.Value = 0;
            numeric_Nuggets.Value = 0;
            numeric_sandwich.Value = 0;
            numeric_Sprite.Value = 0;
            numeric_toast.Value = 0;
            numeric_Vegan.Value = 0;
            txt_totalResult.Clear();
         }
    }
}

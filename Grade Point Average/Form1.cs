using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAverageOfLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            float religion = float.Parse(txt_Religion.Text);
            float physical = float.Parse(txt_Physical.Text);
            float firstLanguage = float.Parse(txt_language1.Text);
            float secondLanguage = float.Parse(txt_language2.Text);
            float turkishLanguage = float.Parse(txt_LanguageLiterature.Text);
            float revolutionHistory = float.Parse(txt_Revolution.Text);
            float musicOrArts = float.Parse(txt_MusicOrArts.Text);

            float elective1 = float.Parse(txt_elective1.Text);
            float elective2 = float.Parse(txt_elective2.Text);
            float elective3 = float.Parse(txt_elective3.Text);
            float elective4 = float.Parse(txt_elective4.Text);
            float elective5 = float.Parse(txt_elective5.Text);

            
            if (cmbbox_elective1.SelectedIndex == 0 && cmbbox_elective2.SelectedIndex ==3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
 (elective1 * 6) + (elective2 * 2) + (elective3 * 4) + (elective4 * 4) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective2.SelectedIndex == 0 && cmbbox_elective3.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 6) + (elective3 * 2) + (elective4 * 4) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            } 
            else if (cmbbox_elective1.SelectedIndex == 0 && cmbbox_elective4.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 6) + (elective2 * 4) + (elective3 * 4) + (elective4 * 2) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective1.SelectedIndex == 0 && cmbbox_elective3.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 6) + (elective2 * 4) + (elective3 * 2) + (elective4 * 4) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective1.SelectedIndex == 0 && cmbbox_elective5.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 6) + (elective2 * 4) + (elective3 * 4) + (elective4 * 4) + (elective5 * 2);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective2.SelectedIndex == 0 && cmbbox_elective4.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 6) + (elective3 * 4) + (elective4 * 2) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective2.SelectedIndex == 0 && cmbbox_elective5.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 6) + (elective3 * 4) + (elective4 * 4) + (elective5 * 2);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective3.SelectedIndex == 0 && cmbbox_elective4.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 4) + (elective3 * 6) + (elective4 * 2) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective3.SelectedIndex == 0 && cmbbox_elective5.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 4) + (elective3 * 6) + (elective4 * 4) + (elective5 * 2);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective4.SelectedIndex == 0 && cmbbox_elective5.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 4) + (elective3 * 4) + (elective4 * 6) + (elective5 * 2);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective2.SelectedIndex == 0 && cmbbox_elective1.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 2) + (elective2 * 6) + (elective3 * 4) + (elective4 * 4) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective3.SelectedIndex == 0 && cmbbox_elective1.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 2) + (elective2 * 4) + (elective3 * 6) + (elective4 * 4) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective4.SelectedIndex == 0 && cmbbox_elective1.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 2) + (elective2 * 4) + (elective3 * 4) + (elective4 * 6) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective5.SelectedIndex == 0 && cmbbox_elective1.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 2) + (elective2 * 4) + (elective3 * 4) + (elective4 * 4) + (elective5 * 6);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective3.SelectedIndex == 0 && cmbbox_elective2.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 2) + (elective3 * 6) + (elective4 * 4) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective4.SelectedIndex == 0 && cmbbox_elective2.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 2) + (elective3 * 4) + (elective4 * 6) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective5.SelectedIndex == 0 && cmbbox_elective2.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 2) + (elective3 * 4) + (elective4 * 4) + (elective5 * 6);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective4.SelectedIndex == 0 && cmbbox_elective3.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 4) + (elective3 * 2) + (elective4 * 6) + (elective5 * 4);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective5.SelectedIndex == 0 && cmbbox_elective3.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 4) + (elective3 * 2) + (elective4 * 4) + (elective5 * 6);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            else if (cmbbox_elective5.SelectedIndex == 0 && cmbbox_elective4.SelectedIndex == 3)
            {
                float result = (religion * 2) + (physical * 2) + (firstLanguage * 4) + (secondLanguage * 2) + (turkishLanguage * 5) + (revolutionHistory * 2) + (musicOrArts * 2) +
(elective1 * 4) + (elective2 * 4) + (elective3 * 4) + (elective4 * 2) + (elective5 * 6);
                float result2 = result / 39;
                txtbox_result.Text = result2.ToString();
            }
            this.BackColor = Color.Red;
        }

    }   
}

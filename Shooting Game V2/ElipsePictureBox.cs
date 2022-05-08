using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormShootingGameV2
{
    class ElipsePictureBox : PictureBox
    {
        public ElipsePictureBox()
        {
            this.BackColor = Color.Red;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using(var elipse =  new GraphicsPath())
            {
                elipse.AddEllipse(0, 0, this.Width - 1, this.Height- 1);
                this.Region  = new Region(elipse);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_list.Forms
{
    public static class CosmeticAnimations
    {
        public static void ButtonsMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
            ((Button)sender).BackColor = Color.Silver;
        }

        public static void ButtonsMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
            ((Button)sender).BackColor = Color.LightGray;
        }
    }
}

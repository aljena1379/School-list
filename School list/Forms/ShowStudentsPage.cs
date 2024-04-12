using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_list
{
    public partial class formShowStudents : Form
    {
        public formShowStudents()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void ShowButtonClick(object sender, MouseEventArgs e)
        {
            formShow form = new formShow();
            form.ShowDialog();
        }

        private void formShowStudents_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class formMain : Form
    {
        IStudentRepository repository;

        public formMain()
        {
            InitializeComponent();
            repository = new StudentRepository();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            formAddStudent form = new formAddStudent();
            form.ShowDialog();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            formShowStudents form = new formShowStudents();
            form.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            formDeleteStudent form = new formDeleteStudent();
            form.ShowDialog();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            formEditStudent form = new formEditStudent();
            form.ShowDialog();
        }

        private void ButtonsMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
            ((Button)sender).BackColor = Color.Silver;
        }

        private void ButtonsMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
            ((Button)sender).BackColor = Color.LightGray;
        }
    }
}

using School_list.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_list;

namespace School_list
{
    public partial class formShow : Form
    {
        public int mode;    // 0 for ShowAll, 1 for ShowByClass

        public formShow()
        {
            InitializeComponent();
        }
        
        private void frmShowAll_Load(object sender, EventArgs e)
        {
            StudentRepository repository = new StudentRepository();
            if (mode == 0)
            {
                dgvShowAll.DataSource = repository.GetAllStudents();
            }
            else if (mode == 1)
            {
                dgvShowAll.DataSource = repository.GetStudentsByClass(1);
                this.Text = "Show students of class: " + 1;
            }
        }
    }
}

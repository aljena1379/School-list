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
        

        public formShow()
        {
            InitializeComponent();
        }
        
        private void frmShowAll_Load(object sender, EventArgs e)
        {
            StudentRepository repository = new StudentRepository();
            if (e == null)
            {
                dgvShowAll.DataSource = repository.GetAllStudents();
            }
            else
            {
                //dgvShowAll.DataSource = repository.GetStudentsByClass(e.ToString);
            }
        }
    }
}

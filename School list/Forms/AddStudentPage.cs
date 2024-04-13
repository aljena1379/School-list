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

namespace School_list
{
    public partial class formAddStudent : Form
    {
        public formAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentRepository repository = new StudentRepository();
            Students student = new Students
            {
                First_name = txtFirstName.Text,
                Last_name = txtLastName.Text,
                Class_number = int.Parse(txtClassNumber.Text),
                Father_name = txtFatherName.Text,
                Natural_ID_number = txtNaturalIdNumber.Text
            };
            repository.Insert(student);
            txtNaturalIdNumber.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtClassNumber.Text = "";
        }
    }
}

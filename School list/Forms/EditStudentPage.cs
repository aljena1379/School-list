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
    public partial class formEditStudent : Form
    {
        public formEditStudent()
        {
            InitializeComponent();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
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
            repository.Update(student);
            txtNaturalIdNumber.Enabled = true;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtClassNumber.Enabled = false;
            txtFatherName.Enabled = false;
            btnEditStudent.Enabled = false;
            btnVerifyNaturalIdNumber.Enabled = false;
        }

        private void btnVerifyNaturalIdNumber_Click(object sender, EventArgs e)
        {
            StudentRepository repository = new StudentRepository();
            if (repository.CheckNaturalIdNumberExistence(txtNaturalIdNumber.Text)){
                Students student = new Students();
                student = repository.GetStudentById(txtNaturalIdNumber.Text);
                txtFirstName.Text = student.First_name;
                txtLastName.Text = student.Last_name;
                txtFatherName.Text = student.Father_name;
                txtClassNumber.Text = student.Class_number.ToString();
                btnVerifyNaturalIdNumber.Enabled = false;
                txtNaturalIdNumber.Enabled = false;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtFatherName.Enabled = true;
                txtClassNumber.Enabled = true;
                btnEditStudent.Enabled = true;
            }
        }

        private void txtNaturalIdNumber_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtClassNumber.Text = "";
            btnVerifyNaturalIdNumber.Enabled = true;
        }
    }
}

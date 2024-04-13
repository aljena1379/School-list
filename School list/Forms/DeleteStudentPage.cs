using School_list.Data;
using System;
using System.Windows.Forms;

namespace School_list
{
    public partial class formDeleteStudent : Form
    {
        public formDeleteStudent()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            StudentRepository repository = new StudentRepository();
            Students student = new Students
            {
                First_name = firstName.Text,
                Last_name = lastName.Text,
                Class_number = int.Parse(classNumber.Text),
                Father_name = fatherName.Text,
                Natural_ID_number = txtNaturalIdNumber.Text
            };
            repository.Delete(student);
            txtNaturalIdNumber.Enabled = true;
            firstName.Text = "";
            lastName.Text = "";
            fatherName.Text = "";
            classNumber.Text = "";
            txtNaturalIdNumber.Text = "";
            btnDelete.Enabled = false;
            btnVerifyNaturalIdNumber.Enabled = true;
        }

        private void btnVerifyNaturalIdNumber_Click(object sender, EventArgs e)
        {
            StudentRepository repository = new StudentRepository();
            if (repository.CheckNaturalIdNumberExistence(txtNaturalIdNumber.Text))
            {
                Students student = new Students();
                student = repository.GetStudentById(txtNaturalIdNumber.Text);
                firstName.Text = student.First_name;
                lastName.Text = student.Last_name;
                fatherName.Text = student.Father_name;
                classNumber.Text = student.Class_number.ToString();
                btnVerifyNaturalIdNumber.Enabled = false;
                txtNaturalIdNumber.Enabled = false;
                firstName.Enabled = true;
                lastName.Enabled = true;
                fatherName.Enabled = true;
                classNumber.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

    }
}

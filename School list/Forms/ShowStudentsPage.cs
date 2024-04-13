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
     
    public partial class formShowStudents : Form
    {
        public formShowStudents()
        {
            InitializeComponent();

        }
        public formShowStudents(int classNumber)
        {
            InitializeComponent();
            classNumber = int.Parse(txtClassNumberSearch.Text);

        }

        private void ShowButtonClick(object sender, MouseEventArgs e)
        {
            formShow form = new formShow();
            form.ShowDialog();
        }

        private void btnShowIndividual_Click(object sender, EventArgs e)
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
            }
        }

        private void btnShowByClass_Click(object sender, EventArgs e)
        {
            formShow form = new formShow();
            form.mode = 1;
            form.ShowDialog();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            formShow form = new formShow();
            form.mode = 0;
            form.ShowDialog();
        }
    }
}

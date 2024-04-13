using School_list.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_list
{
    public interface IStudentRepository
    {
        bool Insert(Students student);
        bool Update(Students student);
        bool Delete(Students student);
        bool CheckNaturalIdNumberExistence(string naturalIdNumber);
        //DataTable SelectAll();
        //DataTable SelectRow(string naturalIdNumber);
        List<Students> GetAllStudents();
        List<Students> GetStudentsByClass(int classNumber);
        Students GetStudentById(string naturalIdNumber);
    }
}

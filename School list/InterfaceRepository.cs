using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_list
{
    internal interface IStudentRepository
    {
        bool Insert(string naturalIdNumber, string firstName, string lastName, string GetFatherName, 
                    string classNumber);
        bool Update(string naturalIdNumber, string firstName, string lastName, string GetFatherName, 
                    string classNumber);
        bool Delete(string naturalIdNumber);
        DataTable SelectAll();
        DataTable SelectRow(string naturalIdNumber);
    }
}

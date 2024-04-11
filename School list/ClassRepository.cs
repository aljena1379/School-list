using School_list.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_list
{
    public class StudentRepository : IStudentRepository
    {
        private School_DBEntities db = new School_DBEntities();
        public bool Delete(Students student)
        {
            try
            {
                db.Entry(student).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Students> GetAllStudents()
        {
            return db.Students.ToList();
        }

        public Students GetStudentById(string naturalIdNumber)
        {
            return db.Students.Find(naturalIdNumber);
        }

        public List<Students> GetStudentsByClass(int classNumber)
        {
            return db.Students.Where(n => n.Equals(classNumber)).ToList();
        }

        public bool Insert(Students student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public DataTable SelectAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public DataTable SelectRow(string naturalIdNumber)
        //{
        //    throw new NotImplementedException();
        //}

        public bool Update(Students student)
        {
            try
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

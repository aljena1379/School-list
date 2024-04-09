using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_list
{
    internal class StudentRepository : IStudentRepository
    {
        private string connectionStr = "Data Source=.;Initial Catalog=School_DB;Integrated Security=true;";
        public bool Delete(string naturalIdNumber)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string naturalIdNumber, string firstName, string lastName, string GetFatherName, string classNumber)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string query = "Select * From Students";
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(string naturalIdNumber)
        {
            throw new NotImplementedException();
        }

        public bool Update(string naturalIdNumber, string firstName, string lastName, string GetFatherName, string classNumber)
        {
            throw new NotImplementedException();
        }
    }
}

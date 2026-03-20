using CRUD_operations_ADO.NET.Models;
using Microsoft.Data.SqlClient;

namespace CRUD_operations_ADO.NET.Data
{
    public class StudentRead
    {
        private readonly string _connectionString;

        public StudentRead(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<StudentInfo> GetAllStudentsDetails()
        {
            List<StudentInfo> students = new List<StudentInfo>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"SELECT Id, Name, Age, City,
                                 Father_Name, email, Mobile_Number,ImagePath
                                 FROM Student_Information";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new StudentInfo
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Age = (int)reader["Age"],
                        City = reader["City"].ToString(),
                        Fathername = reader["Father_Name"].ToString(),
                        Email = reader["email"].ToString(),
                        Number = reader["Mobile_Number"].ToString(),
                        ImagePath = reader["ImagePath"].ToString()
                    });
                }
            }
            return students;
        }
    }
}
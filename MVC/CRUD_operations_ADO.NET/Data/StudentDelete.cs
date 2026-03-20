using Microsoft.Data.SqlClient;

namespace CRUD_operations_ADO.NET.Data
{
    public class StudentDelete
    {
        private readonly string _connectionString;

        public StudentDelete(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // DELETE ALL STUDENTS
        public void DeleteAllStudents()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Student_Information";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
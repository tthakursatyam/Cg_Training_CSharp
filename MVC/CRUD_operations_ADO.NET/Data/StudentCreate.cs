using CRUD_operations_ADO.NET.Models;
using Microsoft.Data.SqlClient;

namespace CRUD_operations_ADO.NET.Data
{
    public class StudentCreate
    {
        private readonly string _connectionString;

        public StudentCreate(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void AddStudent(StudentInfo student)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Student_Information
                                (Name, Age, City, Father_Name, email, Mobile_Number,ImagePath)
                                VALUES
                                (@Name, @Age, @City, @Father_Name, @email, @Mobile_Number,@ImagePath)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@City", student.City);
                cmd.Parameters.AddWithValue("@Father_Name", student.Fathername);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@Mobile_Number", student.Number);
                cmd.Parameters.AddWithValue("@ImagePath",student.ImagePath ?? "NA"); ;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
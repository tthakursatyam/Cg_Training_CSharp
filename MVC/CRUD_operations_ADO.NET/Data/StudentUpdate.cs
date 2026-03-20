using CRUD_operations_ADO.NET.Models;
using Microsoft.Data.SqlClient;

namespace CRUD_operations_ADO.NET.Data
{
    public class StudentUpdate
    {
        private readonly string _connectionString;

        public StudentUpdate(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void UpdateStudent(StudentInfo student)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                List<string> updates = new List<string>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!string.IsNullOrWhiteSpace(student.Name))
                {
                    updates.Add("Name=@Name");
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                }

                if (student.Age != 0)
                {
                    updates.Add("Age=@Age");
                    cmd.Parameters.AddWithValue("@Age", student.Age);
                }

                if (!string.IsNullOrWhiteSpace(student.City))
                {
                    updates.Add("City=@City");
                    cmd.Parameters.AddWithValue("@City", student.City);
                }

                if (!string.IsNullOrWhiteSpace(student.Fathername))
                {
                    updates.Add("Father_Name=@Father_Name");
                    cmd.Parameters.AddWithValue("@Father_Name", student.Fathername);
                }

                if (!string.IsNullOrWhiteSpace(student.Email))
                {
                    updates.Add("email=@email");
                    cmd.Parameters.AddWithValue("@email", student.Email);
                }

                if (!string.IsNullOrWhiteSpace(student.Number))
                {
                    updates.Add("Mobile_Number=@Mobile_Number");
                    cmd.Parameters.AddWithValue("@Mobile_Number", student.Number);
                }

                if (!string.IsNullOrWhiteSpace(student.ImagePath))
                {
                    updates.Add("ImagePath=@ImagePath");
                    cmd.Parameters.AddWithValue("@ImagePath", student.ImagePath);
                }

                if (updates.Count == 0)
                    return;

                string query = $"UPDATE Student_Information SET {string.Join(",", updates)} WHERE Id=@Id";

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id", student.Id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
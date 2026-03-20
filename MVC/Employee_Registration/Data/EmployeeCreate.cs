using Microsoft.Data.SqlClient;
using Employee_Registration.Models;
namespace Employee_Registration.Data
{
    public class EmployeeCreate
    {
        private readonly string cs;

        public EmployeeCreate(IConfiguration configuration)
        {
            cs = configuration.GetConnectionString("DefaultConnection");
        }

        public void AddEmployee(EmployeeInfo emp)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "INSERT INTO Employee(Name,Address,DOB,Email,PhoneNumber) VALUES(@Name,@Address,@DOB,@Email,@PhoneNumber)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@DOB", emp.DOB);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

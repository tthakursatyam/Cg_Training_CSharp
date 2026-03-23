using Student_Management_System_MVC__EF.Models;

namespace Student_Management_System_MVC__EF.Services
{
    public interface IStudentServices
    {
        public List<Student> GetStudentDetails();
        public Student ValidateStudent(string email, string password);
        Student GetStudentById(int id);
    }
}

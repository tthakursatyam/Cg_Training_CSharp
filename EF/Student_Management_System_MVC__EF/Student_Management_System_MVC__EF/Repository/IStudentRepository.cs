using Student_Management_System_MVC__EF.Models;

namespace Student_Management_System_MVC__EF.Repository
{
    public interface IStudentRepository
    {
        public List<Student> Details();
        public Student ValidateStudent(string email, string password);
        public Student GetStudentById(int id);

    }
}

using OnetoOneEFMVC.Models;

namespace OnetoOneEFMVC.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
    }
}
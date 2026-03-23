using OnetoOneEFMVC.Models;
using OnetoOneEFMVC.Repository;

namespace OnetoOneEFMVC.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public List<Student> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }

        public void AddStudent(Student student)
        {
            _repository.AddStudent(student);
        }
    }
}
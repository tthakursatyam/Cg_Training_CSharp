using Student_Management_System_MVC__EF.Repository;
using Student_Management_System_MVC__EF.Models;
namespace Student_Management_System_MVC__EF.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _repository;
        public StudentServices(IStudentRepository repository)
        {
            _repository = repository;
        }
        public List<Student> GetStudentDetails()
        {
            return _repository.Details();
        }
        public Student ValidateStudent(string email, string password)
        {
            return _repository.ValidateStudent(email, password);
        }
        public Student GetStudentById(int id)
        {
            return _repository.GetStudentById(id);
        }
    }
}

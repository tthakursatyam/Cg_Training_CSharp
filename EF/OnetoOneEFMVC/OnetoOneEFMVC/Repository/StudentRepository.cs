using Microsoft.EntityFrameworkCore;
using OnetoOneEFMVC.Data;
using OnetoOneEFMVC.Models;

namespace OnetoOneEFMVC.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentManagementContext _context;

        public StudentRepository(StudentManagementContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.Include(s => s.AssignedRoom).ToList();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
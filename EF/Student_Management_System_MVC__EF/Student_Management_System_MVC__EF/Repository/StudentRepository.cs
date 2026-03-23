using Microsoft.EntityFrameworkCore;
using Student_Management_System_MVC__EF.Data;
using Student_Management_System_MVC__EF.Models;

namespace Student_Management_System_MVC__EF.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;
        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Student> Details()
        {
            return  _context.Students.Include(s=>s.marks).ToList();
            
        }
        public Student ValidateStudent(string email, string password)
        {
            return _context.Students
            .Include(s => s.marks)
            .FirstOrDefault(s => s.Email == email && s.Password == password);
        }
        public Student GetStudentById(int id)
        {
            return _context.Students
            .Include(s => s.marks)
            .FirstOrDefault(s => s.Id == id);
        }
    }
}

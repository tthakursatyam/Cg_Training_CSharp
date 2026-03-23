using Microsoft.EntityFrameworkCore;
using Pagination.Models;

namespace Pagination.Repository;

public class StudentRepository
{
    private readonly StudentDbContext _context;

    public StudentRepository(StudentDbContext context)
    {
        _context = context;
    }

    public List<Student> GetStudents(int pageNumber, int pageSize)
    {
        return _context.Students
            .FromSqlRaw("EXEC GetStudents @PageNumber={0}, @PageSize={1}", pageNumber, pageSize)
            .ToList();
    }
}
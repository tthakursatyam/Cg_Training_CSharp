using Microsoft.EntityFrameworkCore;
using OnetoManyEFMVC.Data;
using OnetoManyEFMVC.Models;

namespace OnetoManyEFMVC.Repository
{
    public class CollegeRepository : ICollegeRepository
    {
        private readonly CollegeContext _context;

        public CollegeRepository(CollegeContext context)
        {
            _context = context;
        }

        public List<CollegeMaster> GetAllColleges()
        {
            return _context.Colleges
                .Include(c => c.Hostels)
                .Include(c => c.Payments)
                .ToList();
        }

        public void AddCollege(CollegeMaster college)
        {
            _context.Colleges.Add(college);
            _context.SaveChanges();
        }
    }
}
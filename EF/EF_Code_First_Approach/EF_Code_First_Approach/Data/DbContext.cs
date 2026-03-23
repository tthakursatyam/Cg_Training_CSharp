using EF_Code_First_Approach.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Code_First_Approach.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
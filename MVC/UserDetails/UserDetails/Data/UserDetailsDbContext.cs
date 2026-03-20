using UserDetails.Models;
using Microsoft.EntityFrameworkCore;
namespace UserDetails.Data
{
    public class UserDetailsDbContext :DbContext
    {
        public DbSet<UserDetail> userDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost,1433;Initial Catalog = UserDetailsDB; User ID = sa; Password = Satyam@123;TrustServerCertificate=True");
        }
    }
}

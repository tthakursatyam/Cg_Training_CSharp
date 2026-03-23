using Microsoft.EntityFrameworkCore;
using Student_Management_System_MVC__EF.Models;

namespace Student_Management_System_MVC__EF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
        new Student { Id = 1, Name = "Rahul", Email = "rahul@gmail.com", Password = "123" },
        new Student { Id = 2, Name = "Aman", Email = "aman@gmail.com", Password = "456" }
    );

            modelBuilder.Entity<Mark>().HasData(
                new Mark { MarkId = 1, Subject = "Maths", Score = 90, StudentId = 1 },
                new Mark { MarkId = 2, Subject = "Physics", Score = 85, StudentId = 1 },
                new Mark { MarkId = 3, Subject = "Chemistry", Score = 80, StudentId = 2 }
            );

            modelBuilder.Entity<Student>()
                .HasMany(s => s.marks)
                .WithOne(s => s.student)
                .HasForeignKey(s => s.StudentId);
        }

    }
}

using Microsoft.EntityFrameworkCore;
using Library_Management_System.Models;

namespace Library_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
        .Property(b => b.BookName)
        .HasMaxLength(15);

            modelBuilder.Entity<Book>()
                .Property(b => b.BookPrice)
                .HasColumnType("float");

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, BookName = "CSharp", BookPrice = 500 },
                new Book { Id = 2, BookName = "DotNet", BookPrice = 650 },
                new Book { Id = 3, BookName = "MVC", BookPrice = 700 },
                new Book { Id = 4, BookName = "Java", BookPrice = 550 },
                new Book { Id = 5, BookName = "Python", BookPrice = 600 },
                new Book { Id = 6, BookName = "JavaScript", BookPrice = 450 },
                new Book { Id = 7, BookName = "Angular", BookPrice = 750 },
                new Book { Id = 8, BookName = "React", BookPrice = 800 },
                new Book { Id = 9, BookName = "NodeJS", BookPrice = 720 },
                new Book { Id = 10, BookName = "SQLServer", BookPrice = 680 }
            );
        }
    }
}
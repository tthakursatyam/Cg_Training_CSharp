using Microsoft.EntityFrameworkCore;
using OnetoManyEFMVC.Models;
using System.Reflection.Emit;

namespace OnetoManyEFMVC.Data
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options)
            : base(options)
        {
        }

        public DbSet<CollegeMaster> Colleges { get; set; }

        public DbSet<Hostel> Hostels { get; set; }

        public DbSet<PaymentDetails> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollegeMaster>()
                .HasMany(c => c.Hostels)
                .WithOne(h => h.College)
                .HasForeignKey(h => h.CollegeMasterId);

            modelBuilder.Entity<CollegeMaster>()
                .HasMany(c => c.Payments)
                .WithOne(p => p.College)
                .HasForeignKey(p => p.CollegeMasterId);
        }
    }
}
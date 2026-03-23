using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pagination.Models;

public partial class StudentDbContext : DbContext
{
    public StudentDbContext()
    {
    }

    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentInformation> StudentInformations { get; set; }

    public virtual DbSet<StudentsMaster> StudentsMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost,1433;Database=MVC_ADONET_DB;User Id=sa;Password=Satyam@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBB99C01F05D1");

            entity.ToTable("Employee");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student___3214EC079D6E2FC3");

            entity.ToTable("Student_Information");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .HasColumnName("Father_Name");
            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(15)
                .HasColumnName("Mobile_Number");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<StudentsMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3214EC07F44A5BA5");

            entity.ToTable("StudentsMaster");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

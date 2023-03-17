using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestProject;

public partial class Database1MdfContext : DbContext
{
    public Database1MdfContext()
    {
    }

    public Database1MdfContext(DbContextOptions<Database1MdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={AppDomain.CurrentDomain.BaseDirectory}Database1.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Course__3214EC0702B23F00");

            entity.ToTable("Course");

            entity.Property(e => e.Department).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Number).HasMaxLength(10);
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07A214A605");

            entity.ToTable("Instructor");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OfficeLocation)
                .HasMaxLength(50)
                .HasColumnName("Office Location");
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Registra__3214EC07D80CF4A5");

            entity.ToTable("Registration");

            entity.Property(e => e.Grade)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SectionId).HasColumnName("Section_ID");
            entity.Property(e => e.StudentId).HasColumnName("Student_ID");

            entity.HasOne(d => d.Section).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_ToSection");

            entity.HasOne(d => d.Student).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_ToStudent");
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC070D6AFA12");

            entity.ToTable("Section");

            entity.Property(e => e.CourseId).HasColumnName("Course_Id");
            entity.Property(e => e.DayTime).HasMaxLength(50);
            entity.Property(e => e.InstructorId).HasColumnName("Instructor_Id");
            entity.Property(e => e.Semester).HasMaxLength(50);

            entity.HasOne(d => d.Course).WithMany(p => p.Sections)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Section_ToCourse");

            entity.HasOne(d => d.Instructor).WithMany(p => p.Sections)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Section_ToInstructor");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC070FBBE7CC");

            entity.ToTable("Student");

            entity.Property(e => e.Major).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using EntityFramework_02.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Data
{
    internal class ITIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-OK3UQ3L ; Database = ITIMigration ; Integrated Security = True ; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(c =>
            { 
                c.Property("Description")
                .HasColumnType("varchar")
                .HasMaxLength(50);
            });

            modelBuilder.Entity<Instructor>(i => 
            {
                i.Property("Address")
                .HasDefaultValue("Alex");
            });

            modelBuilder.Entity<StudentCourse>()
                       .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<CourseInstructor>()
                       .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            // Student - Department (Many-to-One)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId);

            // Instructor - Department (One-to-One)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithOne()
                .HasForeignKey<Department>(d => d.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            // Course - Topic (Many-to-One)
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TopicId);

            // Instructor - Department (Many-to-One)
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany()
                .HasForeignKey(i => i.DepartmentId);


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public DbSet<CourseInstructor> courseInstructors { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }

    }
}

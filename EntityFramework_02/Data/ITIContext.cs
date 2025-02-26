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

            modelBuilder.Entity<CourseInstructor>().HasNoKey();

            modelBuilder.Entity<StudentCourse>().HasNoKey();


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

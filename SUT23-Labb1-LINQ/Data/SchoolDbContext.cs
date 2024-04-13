using Microsoft.EntityFrameworkCore;
using SUT23_Labb1_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb1_LINQ.Data
{
    internal class SchoolDbContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TodaysLecture> Lectures { get; set; }
        public DbSet<TblTeacherSubjects> TblTeacherSubjectsTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = TOBBE; Initial Catalog = SUT23Labb1LINQ; Integrated Security=True; TrustServerCertificate =True;");
        }
    }
}

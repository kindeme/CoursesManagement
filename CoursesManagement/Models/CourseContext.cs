using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesManagement.Models
{
    public class CourseContext:DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options):base(options)
        {

        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
            new Student { StudentID = 1, StudentName = "Carson Alexander", StudentEmail ="lois@gmail.com", StudentPhone ="111-458-36584", AdvisorName="Shou las", DateCreated = DateTime.Parse("2005-09-01"), CourseID = 3141 },
            new Student { StudentID = 2, StudentName = "Meredith Alonso", StudentEmail = "lois@gmail.com", StudentPhone = "111-458-36584", AdvisorName = "Shou las", DateCreated = DateTime.Parse("2002-09-01"), CourseID = 1045 },
            new Student { StudentID = 3, StudentName = "Arturo Anand", StudentEmail = "lois@gmail.com", StudentPhone = "111-458-36584", AdvisorName = "Shou las", DateCreated = DateTime.Parse("2003-09-01"), CourseID = 4041 },
            new Student { StudentID = 4, StudentName = "Gytis Barzdukas", StudentEmail = "lois@gmail.com", StudentPhone = "111-458-36584", AdvisorName = "Shou las", DateCreated = DateTime.Parse("2002-09-01"), CourseID = 4022 },
            new Student { StudentID = 5, StudentName = "Yan Li", StudentEmail = "lois@gmail.com", StudentPhone = "111-458-36584", AdvisorName = "Shou las", DateCreated = DateTime.Parse("2002-09-01"), CourseID = 1050 }
            );

            modelBuilder.Entity<Course>().HasData(
             new Course { CourseID = 1050, CourseName = "Chemistry", CreditUnits = 3, DateCreated = DateTime.Parse("2000-09-01"), Instructor = " John Smith", CourseDescription = "Interesting course" },
             new Course { CourseID = 4022, CourseName = "Microeconomics", CreditUnits = 3, DateCreated = DateTime.Parse("1997-09-01"), Instructor = " karen Smith", CourseDescription = "Interesting course" },
             new Course { CourseID = 4041, CourseName = "Macroeconomics", CreditUnits = 3, DateCreated = DateTime.Parse("2002-09-01"), Instructor = " David North", CourseDescription = "Interesting course" },
             new Course { CourseID = 1045, CourseName = "Calculus", CreditUnits = 4, DateCreated = DateTime.Parse("2001-09-01"), Instructor = " Ryan Reynolds", CourseDescription = "Interesting course" },
             new Course { CourseID = 3141, CourseName = "Trigonometry", CreditUnits = 4, DateCreated = DateTime.Parse("2000-09-01"), Instructor = " John Lewis", CourseDescription = "Interesting course" },
             new Course { CourseID = 2021, CourseName = "Composition", CreditUnits = 3, DateCreated = DateTime.Parse("1990-09-01"), Instructor = " West North", CourseDescription = "Interesting course" },
             new Course { CourseID = 2042, CourseName = "Literature", CreditUnits = 4, DateCreated = DateTime.Parse("2003-09-01"), Instructor = " Allice West", CourseDescription = "Interesting course" }
             );
        }

    }
}

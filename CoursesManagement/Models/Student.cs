using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesManagement.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage ="Please enter your name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage ="Please enter your email")]
        public string StudentEmail  { get; set; }

        [Required(ErrorMessage ="Please enter your phone number")]
        public string StudentPhone { get; set; }
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage ="Please enter Adivisor Name")]
        public string AdvisorName { get; set; }

        [Required(ErrorMessage ="Please enter select a course")]
        public int CourseID { get; set; }
        public Course CoursesRegistered { get; set; }
    }
}

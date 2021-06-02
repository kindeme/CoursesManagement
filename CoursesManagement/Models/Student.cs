using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Please enter your name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage ="Please enter your email")]
        public string StudentEmail  { get; set; }

        [Required(ErrorMessage ="Please enter your phone number")]
        public string StudentPhone { get; set; }
        public DateTime DateCreated { get { return DateTime.Now; } }

        [Required(ErrorMessage ="Please enter Adivisor Name")]
        public string AdvisorName { get; set; }
        public int CourseId { get; set; }
        public List<Course> CoursesRegistered { get; set; }
    }
}

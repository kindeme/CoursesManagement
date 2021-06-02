using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage="Please enter course name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage ="Please enter course description")]
        public string CourseDescription { get; set; }
        public DateTime DateCreated { get { return DateTime.Now; } }

        [Required(ErrorMessage ="Please enter instructor name")]
        public string Instructor { get; set; }

        [Required(ErrorMessage ="Please enter course credit units")]
        public int CreditUnits { get; set; }
        public string CourseSlug => CourseName.Replace(' ', '-').ToLower();
    }
}

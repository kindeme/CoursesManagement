using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesManagement.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public string Instructor { get; set; }
        public int CreditUnits { get; set; }
        public string CourseSlug => CourseName.Replace(' ', '-').ToLower();
        
    }
}

using CoursesManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesManagement.Controllers
{
    public class HomeController : Controller
    {
       private CourseContext context { get; set; }
        public HomeController(CourseContext cont)
        {
            context = cont;
        }
        public IActionResult Index()
        {
           
            return View();
        }


       
    }
}

using CoursesManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesManagement.Controllers
{
    public class StudentController : Controller
    {
        private CourseContext context { get; set; }
        public StudentController(CourseContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            return View("Edit", new Student());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var student = context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                if(student.StudentID == 0)
                {
                    context.Students.Add(student);
                }
                else
                {
                    context.Students.Update(student);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = student.StudentID == 0 ? "Add" : "Edit";
                return View(student);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw1.Models;

namespace hw1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudentName()
        {
            var student = new Student() { StudentName = "hadi" };

            return View(student);
        }
    }
}
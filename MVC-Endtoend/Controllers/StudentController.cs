using Microsoft.AspNetCore.Mvc;
using MVC_Endtoend.Data;
using MVC_Endtoend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Endtoend.Controllers
{
    public class StudentController : Controller
    {
        DataContext _db;

        public StudentController(DataContext db)
        {
            _db = db;
        }

        //http://localhost:65365/Student/Index
        public IActionResult Index()
        {
            List<Student> s = new List<Student>();
            s = _db.Student.ToList();


            string pagename = "This is from index- the time is: " + DateTime.Now;
            ViewBag.title = pagename;
            ViewBag.fname = "Yoseph Kassaye";
            return View(s);
        }

        //http://localhost:65365/Student/GetStudentById
        public IActionResult GetStudentById()
        {
            return View();
        }

    }
}

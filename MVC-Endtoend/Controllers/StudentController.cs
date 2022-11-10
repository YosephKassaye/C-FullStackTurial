using Microsoft.AspNetCore.Mvc;
using System;
namespace MVC_Endtoend.Controllers
{
    public class StudentController : Controller
    {
        //http://localhost:65365/Student/Index
        public IActionResult Index()
        {
            string pagename = "This is from index- the time is: " + DateTime.Now;
            ViewBag.title = pagename;
            ViewBag.fname = "Yoseph Kassaye";
            return View();
        }

        public IActionResult GetStudentById()
        {
            return View();
        }

    }
}

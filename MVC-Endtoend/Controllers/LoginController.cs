using Microsoft.AspNetCore.Mvc;
using MVC_Endtoend.Data;
using MVC_Endtoend.Models;
using System.Linq;

namespace MVC_Endtoend.Controllers
{
    public class LoginController : Controller
    {
        DataContext _db;

        public LoginController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        //http://localhost:65365/Login/Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
           
            IQueryable<Users> u = from us in _db.Users
                                  .Where(x=>x.UserName==userName && x.Password==password)
                                         select us;
            if (u == null)
            {
                RedirectToAction("Login");
            }

            return View();
        }


        //http://localhost:65365/Login/Logout
        public IActionResult Logout()
        {
            return View();
        }
    }
}

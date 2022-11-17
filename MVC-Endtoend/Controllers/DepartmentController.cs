using Microsoft.AspNetCore.Mvc;
using MVC_Endtoend.Data;
using MVC_Endtoend.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Endtoend.Controllers
{
    public class DepartmentController : Controller
    {
        DataContext _db;

        public DepartmentController(DataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Department> d = new List<Department>();
            d = _db.Department.ToList();
            return View(d);
        }
    }
}

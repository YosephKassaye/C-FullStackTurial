using Microsoft.AspNetCore.Mvc;

namespace MVC_Endtoend.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

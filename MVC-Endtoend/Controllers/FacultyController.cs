using Microsoft.AspNetCore.Mvc;

namespace MVC_Endtoend.Controllers
{
    public class FacultyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

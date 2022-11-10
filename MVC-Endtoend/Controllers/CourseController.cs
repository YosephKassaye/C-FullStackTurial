using Microsoft.AspNetCore.Mvc;

namespace MVC_Endtoend.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

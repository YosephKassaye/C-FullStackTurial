using Microsoft.AspNetCore.Mvc;

namespace MVC_Endtoend.Controllers
{
    public class GradeController : Controller
    {
        //http://localhost:65365/Grade/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}

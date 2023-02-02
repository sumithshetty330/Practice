using Microsoft.AspNetCore.Mvc;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

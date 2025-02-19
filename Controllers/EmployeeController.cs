using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /Employee/Index
        public IActionResult Index()
        {
            return View(); // Tương ứng Views/Employee/Index.cshtml
        }

        // GET: /Employee/Detail
        public IActionResult Detail()
        {
            return View(); // Tương ứng Views/Employee/Detail.cshtml
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        // GET: /Person/Index
        public IActionResult Index()
        {
            return View(); // Sẽ trả về file Views/Person/Index.cshtml
        }

        // GET: /Person/Detail
        public IActionResult Detail()
        {
            return View(); // Sẽ trả về file Views/Person/Detail.cshtml
        }
    }
}

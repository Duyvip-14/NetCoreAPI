using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;


namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        // GET: /Person/Index
        public IActionResult Index()
        {
            return View(); // Sẽ trả về file Views/Person/Index.cshtml
        }

        // POST: /Person/Index
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào " + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    } // Đóng class đúng chỗ
}

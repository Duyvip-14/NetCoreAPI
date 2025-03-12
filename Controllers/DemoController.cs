using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class DemoController : Controller
    {
        // GET: /Demo/Index
        [HttpGet]
        public IActionResult Index()
        {
            // Trả về View hiển thị form
            return View();
        }

        // POST: /Demo/Index
        [HttpPost]
        public IActionResult Index(string FullName, string Address)
        {
            // Ghép chuỗi để kiểm tra dữ liệu nhận được
            string strOutput = "Xin chào: " + FullName + ", địa chỉ: " + Address;

            // Gán vào ViewBag để hiển thị lại trên View
            ViewBag.Message = strOutput;

            // Trả về cùng View "Index"
            return View();
        }
    }
}

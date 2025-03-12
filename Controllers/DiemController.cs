using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class DiemController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double diemA, double diemB, double diemC)
        {
            double diemTong = (diemA * 0.3) + (diemB * 0.3) + (diemC * 0.4);
            string ketQua = diemTong >= 5 ? "Đậu" : "Trượt";

            ViewBag.ThongBao = $"Tổng điểm: {diemTong:F2} → Kết quả: {ketQua}";

            return View();
        }
    }
}

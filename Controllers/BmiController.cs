using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers  // ✅ Đúng cú pháp
{
    public class BmiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double chieuCao, double canNang)
        {
            double bmi = canNang / (chieuCao * chieuCao);
            string ketQua;
            if (bmi < 18.5) ketQua = "Thiếu cân";
            else if (bmi < 23) ketQua = "Bình thường";
            else if (bmi < 25) ketQua = "Tiền béo phì";
            else ketQua = "Béo phì";

            ViewBag.ThongBao = $"Chỉ số BMI = {bmi:F2} → {ketQua}";
            return View();
        }
    }
}  // ✅ Đóng namespace

using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoMVC061.Controllers
{
      public class FormController : Controller
    {
        // --- Chức năng 1 + 2: Nhập tên và năm sinh ---
        [HttpGet]
        public IActionResult NhapThongTin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NhapThongTin(string ten, int namSinh)
        {
            int tuoi = DateTime.Now.Year - namSinh;
            ViewBag.LoiChao = $"Xin chào {ten}, bạn {tuoi} tuổi.";
            return View();
        }

        // --- Chức năng 3: Giải phương trình bậc 2 ---
        [HttpGet]
        public IActionResult GiaiPT()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GiaiPT(double a, double b, double c)
        {
            string ketQua;

            if (a == 0)
            {
                ketQua = b == 0
                    ? (c == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.")
                    : $"Phương trình có nghiệm: x = {-c / b}";
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    ketQua = "Phương trình vô nghiệm.";
                else if (delta == 0)
                    ketQua = $"Phương trình có nghiệm kép: x = {-b / (2 * a)}";
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketQua = $"Phương trình có 2 nghiệm: x₁ = {x1}, x₂ = {x2}";
                }
            }

            ViewBag.KetQua = ketQua;
            return View();
        }
    }
}
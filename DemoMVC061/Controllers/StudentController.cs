using Microsoft.AspNetCore.Mvc;
using DemoMVC061.Models;

namespace DemoMVC061.Controllers
{
    public class StudentController : Controller
    {
        // GET: Hiển thị form nhập dữ liệu
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nhận dữ liệu từ form
        [HttpPost]
        public IActionResult Create(Student s)
        {
            // Gửi đối tượng Student sang view hiển thị
            return View("Details", s);
        }

        // View hiển thị thông tin sinh viên
        public IActionResult Details(Student s)
        {
            return View(s);
        }
    }
}

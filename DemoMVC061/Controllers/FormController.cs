using Microsoft.AspNetCore.Mvc;

namespace DemoMVC061.Controllers
{
    public class FormController : Controller
    {
        // Hiển thị form nhập dữ liệu
        public IActionResult InputForm()
        {
            return View();
        }

        // Nhận dữ liệu người dùng nhập
        [HttpPost]
        public IActionResult SubmitForm(string username, int age)
        {
            ViewBag.Result = $"Tên: {username}, Tuổi: {age}";
            return View("Result");
        }
    }
}

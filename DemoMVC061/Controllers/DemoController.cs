using Microsoft.AspNetCore.Mvc;

namespace DemoMVC061.Controllers
{
    public class DemoController : Controller
    {
        //  Trả về ViewResult
        public ActionResult Index()
        {
             ViewBag.Message = "Đây là ví dụ về ViewResult";
            return View();
        }
        //  Trả về RedirectResult
        public IActionResult GoToGoogle()
        {
            return Redirect("https://www.google.com");
        }

        //  Trả về RedirectToActionResult
        public IActionResult GoHome()
        {
            return RedirectToAction("Index", "Home");
        }

        //  Trả về JsonResult
        public IActionResult GetJson()
        {
            var data = new { Name = "MVC Demo", Lesson = 3, Author = "MSV 061" };
            return Json(data);
        }
        //FileResult — Trả về một file
           public IActionResult FileExample()
        {
            
                return StatusCode(404, "Không tìm thấy file example.pdf trong wwwroot.");
        }

        //  Trả về StatusCodeResult
        public IActionResult ShowError()
        {
            return StatusCode(404, "Trang không tồn tại!");
        }

    }
}

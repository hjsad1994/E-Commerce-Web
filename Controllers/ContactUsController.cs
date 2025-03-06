using Microsoft.AspNetCore.Mvc;
using dacs.Models;
namespace dacs.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            // Trả về trang Contact Us
            return View();
        }

        [HttpPost]
        public IActionResult SubmitContactForm(ContactForm model)
        {
            // Xử lý form liên hệ
            return RedirectToAction("ThankYou");
        }

        public IActionResult ThankYou()
        {
            // Trang cảm ơn sau khi gửi liên hệ
            return View();
        }
    }

}

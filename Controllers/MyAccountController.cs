using Microsoft.AspNetCore.Mvc;
using dacs.Models;
namespace dacs.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            // Hiển thị thông tin tài khoản người dùng
            return View();
        }

        [HttpPost]
        public IActionResult UpdateAccountInfo(UserProfile model)
        {
            // Cập nhật thông tin tài khoản
            return RedirectToAction("Index");
        }
    }

}

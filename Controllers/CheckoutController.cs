using Microsoft.AspNetCore.Mvc;
using dacs.Models;

namespace dacs.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            // Hiển thị trang thanh toán
            return View();
        }

        public IActionResult CompleteCheckout(Order model)
        {
            // Xử lý thanh toán và tạo đơn hàng
            return RedirectToAction("Confirmation");
        }

        public IActionResult Confirmation()
        {
            // Hiển thị thông báo thanh toán thành công
            return View();
        }
    }

}

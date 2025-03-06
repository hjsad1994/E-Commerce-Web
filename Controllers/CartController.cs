using Microsoft.AspNetCore.Mvc;

namespace dacs.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            // Xử lý giỏ hàng và trả về view giỏ hàng
            return View();
        }

        public IActionResult AddToCart(int productId)
        {
            // Logic để thêm sản phẩm vào giỏ hàng
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            // Logic để xóa sản phẩm khỏi giỏ hàng
            return RedirectToAction("Index");
        }
    }
}

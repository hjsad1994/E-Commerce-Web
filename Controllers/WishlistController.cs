using Microsoft.AspNetCore.Mvc;

namespace dacs.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            // Trả về trang Wishlist với danh sách các sản phẩm yêu thích
            return View();
        }

        public IActionResult AddToWishlist(int productId)
        {
            // Thêm sản phẩm vào wishlist
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromWishlist(int productId)
        {
            // Xóa sản phẩm khỏi wishlist
            return RedirectToAction("Index");
        }
    }

}

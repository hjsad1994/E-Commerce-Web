using Microsoft.AspNetCore.Mvc;

namespace dacs.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            // Hiển thị danh sách sản phẩm trong cửa hàng
            return View();
        }

        public IActionResult FilterProducts(string category, decimal? minPrice, decimal? maxPrice)
        {
            // Lọc sản phẩm theo danh mục, giá cả, vv.
            return View();
        }

        public IActionResult ProductDetail(int id)
        {
            // Xem chi tiết sản phẩm
            return View();
        }
    }

}

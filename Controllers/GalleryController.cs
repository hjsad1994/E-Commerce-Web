using Microsoft.AspNetCore.Mvc;

namespace dacs.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            // Trả về trang Gallery với danh sách hình ảnh
            return View();
        }
    }

}

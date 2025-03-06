using Microsoft.AspNetCore.Mvc;

namespace dacs.Controllers
{
	public class ShopDetailController : Controller
	{
		public IActionResult Index(int id)
		{
			// Trả về chi tiết sản phẩm cụ thể
			return View();
		}
	}

}

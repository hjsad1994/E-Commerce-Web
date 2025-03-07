using Microsoft.AspNetCore.Mvc;

public class AboutController : Controller
{
    // Hiển thị thông tin về trang web hoặc doanh nghiệp
    public IActionResult Index()
    {
        return View();
    }
}

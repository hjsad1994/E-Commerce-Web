using Microsoft.AspNetCore.Mvc;

namespace dacs.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

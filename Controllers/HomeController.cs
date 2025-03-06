using System.Diagnostics;
using dacs.Models;
using Microsoft.AspNetCore.Mvc;

namespace dacs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using dacs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ShopController : Controller
{
    private readonly ApplicationDbContext _context;

    public ShopController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị tất cả sản phẩm
    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.ToListAsync();
        return View(products);
    }

    // Hiển thị chi tiết sản phẩm
    public async Task<IActionResult> Details(string id) // Chuyển id thành string nếu ProductID là string
    {
        var product = await _context.Products
            .FirstOrDefaultAsync(p => p.ProductID == id); // So sánh với string

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }
}

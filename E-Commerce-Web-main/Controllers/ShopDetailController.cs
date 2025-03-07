using dacs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ShopDetailController : Controller
{
    private readonly ApplicationDbContext _context;

    public ShopDetailController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị chi tiết sản phẩm
    public async Task<IActionResult> Index(string id) // Thay đổi kiểu của tham số id thành string
    {
        var product = await _context.Products
            .FirstOrDefaultAsync(p => p.ProductID == id);  // So sánh với string

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }
}

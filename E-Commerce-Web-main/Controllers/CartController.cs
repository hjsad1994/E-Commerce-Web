using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dacs.Data;

public class CartController : Controller
{
    private readonly ApplicationDbContext _context;

    public CartController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị giỏ hàng của người dùng
    public async Task<IActionResult> Index()
    {
        var userId = User.Identity.Name;
        var carts = await _context.Carts
            .Where(c => c.User.UserName == userId)
            .Include(c => c.Product)
            .ToListAsync();

        return View(carts);  // Đảm bảo có view "Index.cshtml" trong thư mục Views/Cart
    }

    // Thêm sản phẩm vào giỏ hàng
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddToCart(string productId)
    {
        var userId = User.Identity.Name;
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userId);
        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == productId);

        if (product != null && user != null)
        {
            var cartItem = new Cart
            {
                UserID = user.Id,
                ProductID = productId,
                Quantity = 1,  // Mặc định thêm 1 sản phẩm vào giỏ
                AddedAt = DateTime.Now
            };

            _context.Carts.Add(cartItem);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));  // Quay lại trang giỏ hàng sau khi thêm sản phẩm
    }

    // Xóa sản phẩm khỏi giỏ hàng
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveFromCart(string productId)
    {
        var cartItem = await _context.Carts
            .FirstOrDefaultAsync(c => c.ProductID == productId);

        if (cartItem != null)
        {
            _context.Carts.Remove(cartItem);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));  // Quay lại trang giỏ hàng sau khi xóa sản phẩm
    }
}

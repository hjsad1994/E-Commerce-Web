using dacs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class WishlistController : Controller
{
    private readonly ApplicationDbContext _context;

    public WishlistController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị danh sách sản phẩm yêu thích của người dùng
    public async Task<IActionResult> Index()
    {
        var userId = User.Identity.Name; // Lấy tên đăng nhập của người dùng
        var wishlists = await _context.Wishlists
            .Where(w => w.User.UserName == userId)
            .Include(w => w.Product)
            .ToListAsync();

        return View(wishlists);
    }

    // Thêm sản phẩm vào danh sách yêu thích
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddToWishlist(string productId) // Chắc chắn rằng productId là kiểu string
    {
        var userId = User.Identity.Name; // Lấy tên đăng nhập của người dùng
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userId);
        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == productId); // Chắc chắn rằng `ProductID` là string

        if (product != null && user != null)
        {
            var wishlist = new Wishlist
            {
                UserID = user.Id, // user.Id là kiểu string
                ProductID = productId, // ProductID là kiểu string
                CreatedAt = DateTime.Now
            };

            _context.Wishlists.Add(wishlist);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    // Xóa sản phẩm khỏi danh sách yêu thích
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveFromWishlist(string productId)  // Thay đổi kiểu `productId` thành `string`
    {
        var wishlist = await _context.Wishlists
            .FirstOrDefaultAsync(w => w.ProductID == productId);  // Sửa thành `ProductID` kiểu string

        if (wishlist != null)
        {
            _context.Wishlists.Remove(wishlist);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}

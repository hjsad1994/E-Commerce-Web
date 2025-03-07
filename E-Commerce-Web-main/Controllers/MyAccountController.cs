using dacs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class MyAccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public MyAccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị thông tin tài khoản của người dùng
    public async Task<IActionResult> Index()
    {
        var userId = User.Identity.Name;
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userId);
        return View(user);
    }

    // Cập nhật thông tin tài khoản
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(User user)
    {
        if (ModelState.IsValid)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(user);
    }
}

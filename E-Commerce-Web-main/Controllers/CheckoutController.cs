using dacs.Data;
using Microsoft.AspNetCore.Mvc;

public class CheckoutController : Controller
{
    private readonly ApplicationDbContext _context;

    public CheckoutController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị trang thanh toán
    public IActionResult Index()
    {
        return View();
    }

    // Xử lý thanh toán
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ProcessPayment(int orderId)
    {
        var order = await _context.Orders.FindAsync(orderId);

        if (order != null)
        {
            // Tiến hành thanh toán (Giả sử bạn có một API thanh toán)
            order.Status = "Paid";
            _context.Update(order);
            await _context.SaveChangesAsync();

            return RedirectToAction("Success");
        }

        return RedirectToAction("Error");
    }

    public IActionResult Success()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}

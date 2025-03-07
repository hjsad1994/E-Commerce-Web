using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dacs.Data;  // Ensure you're using the correct namespace for ApplicationDbContext
using System.Threading.Tasks;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Product/Index
    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.ToListAsync();
        return View(products); // Display all products in the list
    }

    // GET: Product/Create
    public IActionResult Create()
    {
        return View(); // Show the form to create a new product
    }

    // POST: Product/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _context.Add(product);  // Add the new product to the database
            await _context.SaveChangesAsync();  // Save changes to the database
            return RedirectToAction(nameof(Index));  // Redirect to the index view to show the updated list
        }
        return View(product);
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagementNet.Data;
using ProductManagementNet.Models;

namespace ProductManagementNet.Controllers;

public class ProductsController : Controller
{
    private readonly AppDbContext _db;

    public ProductsController(AppDbContext db) => _db = db;

    public async Task<IActionResult> Index()
    {
        var products = await _db.Products.OrderByDescending(p => p.Id).ToListAsync();
        return View(products);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product product)
    {
        if (!ModelState.IsValid)
        {
            var products = await _db.Products.OrderByDescending(p => p.Id).ToListAsync();
            return View("Index", products);
        }

        _db.Products.Add(product);
        await _db.SaveChangesAsync();
        TempData["Success"] = "Product added successfully!";
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var product = await _db.Products.FindAsync(id);
        if (product is not null)
        {
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Product deleted successfully!";
        }

        return RedirectToAction(nameof(Index));
    }
}

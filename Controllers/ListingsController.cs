using Auctions.Models;
using Auctions.Services;
using Auctions.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Auctions.Controllers;

public class ListingsController(
    IWebHostEnvironment _webHostEnvironment,
    IListingsService _listingsService
    ) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    // GET: Listings/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // POST: Listings/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ListingVM listing)
    {
        if (listing.Image != null)
        {
            string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
            string fileName = listing.Image.FileName;
            string filePath = Path.Combine(uploadDir, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                listing.Image.CopyTo(fileStream);
            }

            var listObj = new Listing
            {
                Title = listing.Title,
                Description = listing.Description,
                Price = listing.Price,
                UserId = listing.UserId,
                ImagePath = fileName,
            };

            await _listingsService.Add(listObj);
            return RedirectToAction("Index");
        }
        return View(listing);
    }
}

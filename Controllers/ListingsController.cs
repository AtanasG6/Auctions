using Microsoft.AspNetCore.Mvc;

namespace Auctions.Controllers;

public class ListingsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

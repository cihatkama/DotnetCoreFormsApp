using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;

namespace FormsApp.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    public HomeController()
    {
        
    }

    public IActionResult Index(string strProductName)
    {
        var products = Repository.Products;

        if (!string.IsNullOrEmpty(strProductName)) 
        {
            ViewBag.strProductName = strProductName;
            products = products.Where(p => p.ProductName.ToLower().Contains(strProductName)).ToList();
        }
        
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}

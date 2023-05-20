using Ayla_Store_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ayla_Store_MVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AylaStoreMvcContext _context;

        public HomeController(ILogger<HomeController> logger, AylaStoreMvcContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            ViewBag.Products = _context.Products.ToList();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Categories()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Products(int id)
        {
            var products = _context.Products.Where(item => item.CategoryId == id).ToList();
            return View(products);
        }

        public IActionResult OneProduct(int id)
        {
            var product = _context.Products.Where(item => item.Id == id).ToList();
            return View(product);
        }

        public IActionResult ProductSearch(string name)
        {
            var products = _context.Products.Where(item => item.Name.Contains(name)).ToList();
            return View(products);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
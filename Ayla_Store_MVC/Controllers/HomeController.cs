using Ayla_Store_MVC.Models;
using Ayla_Store_MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            IndexViewModel result = new IndexViewModel
            {
                Categories = _context.Categories.ToList(),
                Products = _context.Products.ToList(),
            };
            return View(result);
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

        public IActionResult CurrentProduct(int id)
        {
            var product = _context.Products.Include(categ => categ.Category).Include(img => img.ProductImages).FirstOrDefault(item => item.Id == id);
            return View(product);
        }

        public IActionResult RecentlyAdding()
        {
            return View();
        }

        public IActionResult AddToCart(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductSearch(string name)
        {
            var products = new List<Product>();
            if (string.IsNullOrEmpty(name))
            {
                products = _context.Products.ToList();
                ViewBag.name = "All Items";
            }
            else
            {
                products = _context.Products.Where(item => item.Name.Contains(name)).ToList();
                ViewBag.name = name;
            }
            return View(products);
        }

        [HttpPost]
        public IActionResult SendContactUs(ContactU model)
        {
            _context.ContactUs.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReview(Review model)
        {
            _context.Reviews.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Ayla_Store_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ayla_Store_MVC.ViewComponents
{
    public class LatestProductViewComponent : ViewComponent
    {
        private readonly AylaStoreMvcContext _context;

        public LatestProductViewComponent(AylaStoreMvcContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var LatestProduct = await _context.Products.OrderByDescending(item => item.EntryDate).Take(4).ToListAsync();
            return View(LatestProduct);
        }
    }
}

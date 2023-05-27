using Ayla_Store_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ayla_Store_MVC.Areas.Admin.ViewComponents
{
    public class ProductImagesIndexViewComponent : ViewComponent
    {
        private readonly AylaStoreMvcContext _context;

        public ProductImagesIndexViewComponent(AylaStoreMvcContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var images = await _context.ProductImages.Where(img => img.ProductId == id).ToListAsync();
            return View(images);
        }
    }
}

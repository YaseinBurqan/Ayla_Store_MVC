using Ayla_Store_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ayla_Store_MVC.ViewComponents
{
    public class ReviewViewComponent : ViewComponent
    {
        private readonly AylaStoreMvcContext _context;

        public ReviewViewComponent(AylaStoreMvcContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var reviews = await _context.Reviews.OrderByDescending(item => item.EntryDate).Take(4).ToListAsync();
            return View(reviews);
        }
    }
}

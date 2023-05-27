using Ayla_Store_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ayla_Store_MVC.Areas.Admin.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AylaStoreMvcContext _context;

        public ValuesController(AylaStoreMvcContext context)
        {
            _context = context;
        }

        // GET: api/Admin/Products/GetAllProducts
        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _context.Products.Select(item => new { item.Name, item.Price, item.Quantity }).ToListAsync();
            return Ok(result);
        }

        [HttpGet("TestProducts")]
        public async Task<IActionResult> TestProducts()
        {
            var result = await _context.Products.Include(item => item.Category).ToListAsync();
            return Ok(result);
        }

    }
}

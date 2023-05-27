using Ayla_Store_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ayla_Store_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly AylaStoreMvcContext _context;

        public ContactUsController(AylaStoreMvcContext context)
        {
            _context = context;
        }

        // GET: Admin/ContactUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactUs.ToListAsync());
        }

        // GET: Admin/ContactUs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContactUs == null)
            {
                return NotFound();
            }

            var contactU = await _context.ContactUs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactU == null)
            {
                return NotFound();
            }

            return View(contactU);
        }

        // GET: Admin/ContactUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Subject,Description")] ContactU contactU)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactU);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactU);
        }

        // GET: Admin/ContactUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContactUs == null)
            {
                return NotFound();
            }

            var contactU = await _context.ContactUs.FindAsync(id);
            if (contactU == null)
            {
                return NotFound();
            }
            return View(contactU);
        }

        // POST: Admin/ContactUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Subject,Description")] ContactU contactU)
        {
            if (id != contactU.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactU);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactUExists(contactU.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contactU);
        }

        // GET: Admin/ContactUs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContactUs == null)
            {
                return NotFound();
            }

            var contactU = await _context.ContactUs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactU == null)
            {
                return NotFound();
            }

            return View(contactU);
        }

        // POST: Admin/ContactUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContactUs == null)
            {
                return Problem("Entity set 'AylaStoreMvcContext.ContactUs'  is null.");
            }
            var contactU = await _context.ContactUs.FindAsync(id);
            if (contactU != null)
            {
                _context.ContactUs.Remove(contactU);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactUExists(int id)
        {
            return _context.ContactUs.Any(e => e.Id == id);
        }
    }
}

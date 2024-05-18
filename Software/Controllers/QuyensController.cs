using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Software.Data;
using Software.Models;

namespace Software.Controllers
{
    public class QuyensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuyensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Quyens
        public async Task<IActionResult> Index()
        {
              return _context.Quyen != null ? 
                          View(await _context.Quyen.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Quyen'  is null.");
        }

        // GET: Quyens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Quyen == null)
            {
                return NotFound();
            }

            var quyen = await _context.Quyen
                .FirstOrDefaultAsync(m => m.MaQuyen == id);
            if (quyen == null)
            {
                return NotFound();
            }

            return View(quyen);
        }

        // GET: Quyens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quyens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaQuyen,TenQuyen")] Quyen quyen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quyen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quyen);
        }

        // GET: Quyens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Quyen == null)
            {
                return NotFound();
            }

            var quyen = await _context.Quyen.FindAsync(id);
            if (quyen == null)
            {
                return NotFound();
            }
            return View(quyen);
        }

        // POST: Quyens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaQuyen,TenQuyen")] Quyen quyen)
        {
            if (id != quyen.MaQuyen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quyen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuyenExists(quyen.MaQuyen))
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
            return View(quyen);
        }

        // GET: Quyens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Quyen == null)
            {
                return NotFound();
            }

            var quyen = await _context.Quyen
                .FirstOrDefaultAsync(m => m.MaQuyen == id);
            if (quyen == null)
            {
                return NotFound();
            }

            return View(quyen);
        }

        // POST: Quyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Quyen == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Quyen'  is null.");
            }
            var quyen = await _context.Quyen.FindAsync(id);
            if (quyen != null)
            {
                _context.Quyen.Remove(quyen);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuyenExists(int id)
        {
          return (_context.Quyen?.Any(e => e.MaQuyen == id)).GetValueOrDefault();
        }
    }
}

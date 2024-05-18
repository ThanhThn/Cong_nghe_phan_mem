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
    public class LienKetQuyensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LienKetQuyensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LienKetQuyens
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LienKetQuyen.Include(l => l.ChucNang).Include(l => l.Quyen);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LienKetQuyens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LienKetQuyen == null)
            {
                return NotFound();
            }

            var lienKetQuyen = await _context.LienKetQuyen
                .Include(l => l.ChucNang)
                .Include(l => l.Quyen)
                .FirstOrDefaultAsync(m => m.MaChucNang == id);
            if (lienKetQuyen == null)
            {
                return NotFound();
            }

            return View(lienKetQuyen);
        }

        // GET: LienKetQuyens/Create
        public IActionResult Create()
        {
            ViewData["MaChucNang"] = new SelectList(_context.ChucNang, "MaChucNang", "MaChucNang");
            ViewData["MaQuyen"] = new SelectList(_context.Quyen, "MaQuyen", "MaQuyen");
            return View();
        }

        // POST: LienKetQuyens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChucNang,MaQuyen")] LienKetQuyen lienKetQuyen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lienKetQuyen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaChucNang"] = new SelectList(_context.ChucNang, "MaChucNang", "MaChucNang", lienKetQuyen.MaChucNang);
            ViewData["MaQuyen"] = new SelectList(_context.Quyen, "MaQuyen", "MaQuyen", lienKetQuyen.MaQuyen);
            return View(lienKetQuyen);
        }

        // GET: LienKetQuyens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LienKetQuyen == null)
            {
                return NotFound();
            }

            var lienKetQuyen = await _context.LienKetQuyen.FindAsync(id);
            if (lienKetQuyen == null)
            {
                return NotFound();
            }
            ViewData["MaChucNang"] = new SelectList(_context.ChucNang, "MaChucNang", "MaChucNang", lienKetQuyen.MaChucNang);
            ViewData["MaQuyen"] = new SelectList(_context.Quyen, "MaQuyen", "MaQuyen", lienKetQuyen.MaQuyen);
            return View(lienKetQuyen);
        }

        // POST: LienKetQuyens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaChucNang,MaQuyen")] LienKetQuyen lienKetQuyen)
        {
            if (id != lienKetQuyen.MaChucNang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lienKetQuyen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LienKetQuyenExists(lienKetQuyen.MaChucNang))
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
            ViewData["MaChucNang"] = new SelectList(_context.ChucNang, "MaChucNang", "MaChucNang", lienKetQuyen.MaChucNang);
            ViewData["MaQuyen"] = new SelectList(_context.Quyen, "MaQuyen", "MaQuyen", lienKetQuyen.MaQuyen);
            return View(lienKetQuyen);
        }

        // GET: LienKetQuyens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LienKetQuyen == null)
            {
                return NotFound();
            }

            var lienKetQuyen = await _context.LienKetQuyen
                .Include(l => l.ChucNang)
                .Include(l => l.Quyen)
                .FirstOrDefaultAsync(m => m.MaChucNang == id);
            if (lienKetQuyen == null)
            {
                return NotFound();
            }

            return View(lienKetQuyen);
        }

        // POST: LienKetQuyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LienKetQuyen == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LienKetQuyen'  is null.");
            }
            var lienKetQuyen = await _context.LienKetQuyen.FindAsync(id);
            if (lienKetQuyen != null)
            {
                _context.LienKetQuyen.Remove(lienKetQuyen);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LienKetQuyenExists(int id)
        {
          return (_context.LienKetQuyen?.Any(e => e.MaChucNang == id)).GetValueOrDefault();
        }
    }
}

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
    public class ChucNangsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChucNangsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChucNangs
        public async Task<IActionResult> Index()
        {
              return _context.ChucNang != null ? 
                          View(await _context.ChucNang.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ChucNang'  is null.");
        }

        // GET: ChucNangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ChucNang == null)
            {
                return NotFound();
            }

            var chucNang = await _context.ChucNang
                .FirstOrDefaultAsync(m => m.MaChucNang == id);
            if (chucNang == null)
            {
                return NotFound();
            }

            return View(chucNang);
        }

        // GET: ChucNangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChucNangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChucNang,DuongDanChucNang")] ChucNang chucNang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chucNang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chucNang);
        }

        // GET: ChucNangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ChucNang == null)
            {
                return NotFound();
            }

            var chucNang = await _context.ChucNang.FindAsync(id);
            if (chucNang == null)
            {
                return NotFound();
            }
            return View(chucNang);
        }

        // POST: ChucNangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaChucNang,DuongDanChucNang")] ChucNang chucNang)
        {
            if (id != chucNang.MaChucNang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chucNang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChucNangExists(chucNang.MaChucNang))
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
            return View(chucNang);
        }

        // GET: ChucNangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ChucNang == null)
            {
                return NotFound();
            }

            var chucNang = await _context.ChucNang
                .FirstOrDefaultAsync(m => m.MaChucNang == id);
            if (chucNang == null)
            {
                return NotFound();
            }

            return View(chucNang);
        }

        // POST: ChucNangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ChucNang == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ChucNang'  is null.");
            }
            var chucNang = await _context.ChucNang.FindAsync(id);
            if (chucNang != null)
            {
                _context.ChucNang.Remove(chucNang);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChucNangExists(int id)
        {
          return (_context.ChucNang?.Any(e => e.MaChucNang == id)).GetValueOrDefault();
        }
    }
}

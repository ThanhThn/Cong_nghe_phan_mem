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
    public class ThucDonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThucDonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ThucDons
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ThucDon.Include(t => t.LoaiMon);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ThucDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ThucDon == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon
                .Include(t => t.LoaiMon)
                .FirstOrDefaultAsync(m => m.MaMon == id);
            if (thucDon == null)
            {
                return NotFound();
            }

            return View(thucDon);
        }

        // GET: ThucDons/Create
        public IActionResult Create()
        {
            ViewData["MaLoaiMon"] = new SelectList(_context.LoaiMon, "MaLoaiMon", "MaLoaiMon");
            return View();
        }

        // POST: ThucDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMon,TenMon,DonGia,AnhMon,TinhTrang,MaLoaiMon")] ThucDon thucDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thucDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoaiMon"] = new SelectList(_context.LoaiMon, "MaLoaiMon", "MaLoaiMon", thucDon.MaLoaiMon);
            return View(thucDon);
        }

        // GET: ThucDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ThucDon == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon.FindAsync(id);
            if (thucDon == null)
            {
                return NotFound();
            }
            ViewData["MaLoaiMon"] = new SelectList(_context.LoaiMon, "MaLoaiMon", "MaLoaiMon", thucDon.MaLoaiMon);
            return View(thucDon);
        }

        // POST: ThucDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaMon,TenMon,DonGia,AnhMon,TinhTrang,MaLoaiMon")] ThucDon thucDon)
        {
            if (id != thucDon.MaMon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thucDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThucDonExists(thucDon.MaMon))
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
            ViewData["MaLoaiMon"] = new SelectList(_context.LoaiMon, "MaLoaiMon", "MaLoaiMon", thucDon.MaLoaiMon);
            return View(thucDon);
        }

        // GET: ThucDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ThucDon == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon
                .Include(t => t.LoaiMon)
                .FirstOrDefaultAsync(m => m.MaMon == id);
            if (thucDon == null)
            {
                return NotFound();
            }

            return View(thucDon);
        }

        // POST: ThucDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ThucDon == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ThucDon'  is null.");
            }
            var thucDon = await _context.ThucDon.FindAsync(id);
            if (thucDon != null)
            {
                _context.ThucDon.Remove(thucDon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThucDonExists(int id)
        {
          return (_context.ThucDon?.Any(e => e.MaMon == id)).GetValueOrDefault();
        }
    }
}

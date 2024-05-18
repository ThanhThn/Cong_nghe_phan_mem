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
    public class HoaDonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HoaDonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HoaDons
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.HoaDon.Include(h => h.MayTinh);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: HoaDons/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.HoaDon == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon
                .Include(h => h.MayTinh)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: HoaDons/Create
        public IActionResult Create()
        {
            ViewData["MaMT"] = new SelectList(_context.MayTinh, "MaMT", "MaMT");
            return View();
        }

        // POST: HoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,ThoiGian,TongTien,MaMT")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaMT"] = new SelectList(_context.MayTinh, "MaMT", "MaMT", hoaDon.MaMT);
            return View(hoaDon);
        }

        // GET: HoaDons/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.HoaDon == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon.FindAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaMT"] = new SelectList(_context.MayTinh, "MaMT", "MaMT", hoaDon.MaMT);
            return View(hoaDon);
        }

        // POST: HoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHD,ThoiGian,TongTien,MaMT")] HoaDon hoaDon)
        {
            if (id != hoaDon.MaHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.MaHD))
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
            ViewData["MaMT"] = new SelectList(_context.MayTinh, "MaMT", "MaMT", hoaDon.MaMT);
            return View(hoaDon);
        }

        // GET: HoaDons/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.HoaDon == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon
                .Include(h => h.MayTinh)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // POST: HoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.HoaDon == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HoaDon'  is null.");
            }
            var hoaDon = await _context.HoaDon.FindAsync(id);
            if (hoaDon != null)
            {
                _context.HoaDon.Remove(hoaDon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonExists(string id)
        {
          return (_context.HoaDon?.Any(e => e.MaHD == id)).GetValueOrDefault();
        }
    }
}

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
    public class ChiTietHoaDonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietHoaDonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChiTietHoaDons
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChiTietHoaDon.Include(c => c.HoaDon).Include(c => c.ThucDon);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ChiTietHoaDons/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.ChiTietHoaDon == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDon
                .Include(c => c.HoaDon)
                .Include(c => c.ThucDon)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDons/Create
        public IActionResult Create()
        {
            ViewData["MaHD"] = new SelectList(_context.HoaDon, "MaHD", "MaHD");
            ViewData["MaMon"] = new SelectList(_context.ThucDon, "MaMon", "MaMon");
            return View();
        }

        // POST: ChiTietHoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,MaMon,SoLuong,TongTien,DonGia")] ChiTietHoaDon chiTietHoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaHD"] = new SelectList(_context.HoaDon, "MaHD", "MaHD", chiTietHoaDon.MaHD);
            ViewData["MaMon"] = new SelectList(_context.ThucDon, "MaMon", "MaMon", chiTietHoaDon.MaMon);
            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDons/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.ChiTietHoaDon == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDon.FindAsync(id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaHD"] = new SelectList(_context.HoaDon, "MaHD", "MaHD", chiTietHoaDon.MaHD);
            ViewData["MaMon"] = new SelectList(_context.ThucDon, "MaMon", "MaMon", chiTietHoaDon.MaMon);
            return View(chiTietHoaDon);
        }

        // POST: ChiTietHoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHD,MaMon,SoLuong,TongTien,DonGia")] ChiTietHoaDon chiTietHoaDon)
        {
            if (id != chiTietHoaDon.MaHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonExists(chiTietHoaDon.MaHD))
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
            ViewData["MaHD"] = new SelectList(_context.HoaDon, "MaHD", "MaHD", chiTietHoaDon.MaHD);
            ViewData["MaMon"] = new SelectList(_context.ThucDon, "MaMon", "MaMon", chiTietHoaDon.MaMon);
            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDons/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.ChiTietHoaDon == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDon
                .Include(c => c.HoaDon)
                .Include(c => c.ThucDon)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // POST: ChiTietHoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ChiTietHoaDon == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ChiTietHoaDon'  is null.");
            }
            var chiTietHoaDon = await _context.ChiTietHoaDon.FindAsync(id);
            if (chiTietHoaDon != null)
            {
                _context.ChiTietHoaDon.Remove(chiTietHoaDon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonExists(string id)
        {
          return (_context.ChiTietHoaDon?.Any(e => e.MaHD == id)).GetValueOrDefault();
        }
    }
}

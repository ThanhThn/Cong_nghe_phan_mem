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
    public class LoaiMonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoaiMonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LoaiMons
        public async Task<IActionResult> Index()
        {
              return _context.LoaiMon != null ? 
                          View(await _context.LoaiMon.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.LoaiMon'  is null.");
        }

        // GET: LoaiMons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LoaiMon == null)
            {
                return NotFound();
            }

            var loaiMon = await _context.LoaiMon
                .FirstOrDefaultAsync(m => m.MaLoaiMon == id);
            if (loaiMon == null)
            {
                return NotFound();
            }

            return View(loaiMon);
        }

        // GET: LoaiMons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoaiMons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLoaiMon,TenLoaiMon")] LoaiMon loaiMon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiMon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiMon);
        }

        // GET: LoaiMons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LoaiMon == null)
            {
                return NotFound();
            }

            var loaiMon = await _context.LoaiMon.FindAsync(id);
            if (loaiMon == null)
            {
                return NotFound();
            }
            return View(loaiMon);
        }

        // POST: LoaiMons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaLoaiMon,TenLoaiMon")] LoaiMon loaiMon)
        {
            if (id != loaiMon.MaLoaiMon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiMon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiMonExists(loaiMon.MaLoaiMon))
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
            return View(loaiMon);
        }

        // GET: LoaiMons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LoaiMon == null)
            {
                return NotFound();
            }

            var loaiMon = await _context.LoaiMon
                .FirstOrDefaultAsync(m => m.MaLoaiMon == id);
            if (loaiMon == null)
            {
                return NotFound();
            }

            return View(loaiMon);
        }

        // POST: LoaiMons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LoaiMon == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LoaiMon'  is null.");
            }
            var loaiMon = await _context.LoaiMon.FindAsync(id);
            if (loaiMon != null)
            {
                _context.LoaiMon.Remove(loaiMon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiMonExists(int id)
        {
          return (_context.LoaiMon?.Any(e => e.MaLoaiMon == id)).GetValueOrDefault();
        }
    }
}

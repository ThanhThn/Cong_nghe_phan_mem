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
    public class ThamSoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThamSoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ThamSoes
        public async Task<IActionResult> Index()
        {
              return _context.ThamSo != null ? 
                          View(await _context.ThamSo.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ThamSo'  is null.");
        }

        // GET: ThamSoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.ThamSo == null)
            {
                return NotFound();
            }

            var thamSo = await _context.ThamSo
                .FirstOrDefaultAsync(m => m.MaThamSo == id);
            if (thamSo == null)
            {
                return NotFound();
            }

            return View(thamSo);
        }

        // GET: ThamSoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ThamSoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaThamSo,TenThamSo,DonVi,GiaTri,TinhTrang")] ThamSo thamSo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thamSo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thamSo);
        }

        // GET: ThamSoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.ThamSo == null)
            {
                return NotFound();
            }

            var thamSo = await _context.ThamSo.FindAsync(id);
            if (thamSo == null)
            {
                return NotFound();
            }
            return View(thamSo);
        }

        // POST: ThamSoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaThamSo,TenThamSo,DonVi,GiaTri,TinhTrang")] ThamSo thamSo)
        {
            if (id != thamSo.MaThamSo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thamSo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThamSoExists(thamSo.MaThamSo))
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
            return View(thamSo);
        }

        // GET: ThamSoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.ThamSo == null)
            {
                return NotFound();
            }

            var thamSo = await _context.ThamSo
                .FirstOrDefaultAsync(m => m.MaThamSo == id);
            if (thamSo == null)
            {
                return NotFound();
            }

            return View(thamSo);
        }

        // POST: ThamSoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ThamSo == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ThamSo'  is null.");
            }
            var thamSo = await _context.ThamSo.FindAsync(id);
            if (thamSo != null)
            {
                _context.ThamSo.Remove(thamSo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThamSoExists(string id)
        {
          return (_context.ThamSo?.Any(e => e.MaThamSo == id)).GetValueOrDefault();
        }
    }
}

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
    public class MayTinhsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MayTinhsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MayTinhs
        public async Task<IActionResult> Index()
        {
              return _context.MayTinh != null ? 
                          View(await _context.MayTinh.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.MayTinh'  is null.");
        }

        // GET: MayTinhs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.MayTinh == null)
            {
                return NotFound();
            }

            var mayTinh = await _context.MayTinh
                .FirstOrDefaultAsync(m => m.MaMT == id);
            if (mayTinh == null)
            {
                return NotFound();
            }

            return View(mayTinh);
        }

        // GET: MayTinhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MayTinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMT,TinhTrang")] MayTinh mayTinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mayTinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mayTinh);
        }

        // GET: MayTinhs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.MayTinh == null)
            {
                return NotFound();
            }

            var mayTinh = await _context.MayTinh.FindAsync(id);
            if (mayTinh == null)
            {
                return NotFound();
            }
            return View(mayTinh);
        }

        // POST: MayTinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaMT,TinhTrang")] MayTinh mayTinh)
        {
            if (id != mayTinh.MaMT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mayTinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MayTinhExists(mayTinh.MaMT))
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
            return View(mayTinh);
        }

        // GET: MayTinhs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.MayTinh == null)
            {
                return NotFound();
            }

            var mayTinh = await _context.MayTinh
                .FirstOrDefaultAsync(m => m.MaMT == id);
            if (mayTinh == null)
            {
                return NotFound();
            }

            return View(mayTinh);
        }

        // POST: MayTinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.MayTinh == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MayTinh'  is null.");
            }
            var mayTinh = await _context.MayTinh.FindAsync(id);
            if (mayTinh != null)
            {
                _context.MayTinh.Remove(mayTinh);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MayTinhExists(string id)
        {
          return (_context.MayTinh?.Any(e => e.MaMT == id)).GetValueOrDefault();
        }
    }
}

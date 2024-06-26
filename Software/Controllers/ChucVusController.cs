﻿using System;
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
    public class ChucVusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChucVusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChucVus
        public async Task<IActionResult> Index()
        {
              return _context.ChucVu != null ? 
                          View(await _context.ChucVu.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ChucVu'  is null.");
        }

        // GET: ChucVus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ChucVu == null)
            {
                return NotFound();
            }

            var chucVu = await _context.ChucVu
                .FirstOrDefaultAsync(m => m.MaChucVu == id);
            if (chucVu == null)
            {
                return NotFound();
            }

            return View(chucVu);
        }

        // GET: ChucVus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChucVus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChucVu,TenChucVu")] ChucVu chucVu)
        {
            if (!ModelState.IsValid)
            {
                // Log the errors to the output or console for debugging
                return View(chucVu);
            }

            _context.Add(chucVu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // GET: ChucVus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ChucVu == null)
            {
                return NotFound();
            }

            var chucVu = await _context.ChucVu.FindAsync(id);
            if (chucVu == null)
            {
                return NotFound();
            }
            return View(chucVu);
        }

        // POST: ChucVus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaChucVu,TenChucVu")] ChucVu chucVu)
        {
            if (id != chucVu.MaChucVu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chucVu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChucVuExists(chucVu.MaChucVu))
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
            return View(chucVu);
        }

        // GET: ChucVus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ChucVu == null)
            {
                return NotFound();
            }

            var chucVu = await _context.ChucVu
                .FirstOrDefaultAsync(m => m.MaChucVu == id);
            if (chucVu == null)
            {
                return NotFound();
            }

            return View(chucVu);
        }

        // POST: ChucVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ChucVu == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ChucVu'  is null.");
            }
            var chucVu = await _context.ChucVu.FindAsync(id);
            if (chucVu != null)
            {
                _context.ChucVu.Remove(chucVu);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChucVuExists(int id)
        {
          return (_context.ChucVu?.Any(e => e.MaChucVu == id)).GetValueOrDefault();
        }
    }
}

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
    public class TaiKhoanNhanViensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaiKhoanNhanViensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TaiKhoanNhanViens
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TaiKhoanNhanVien.Include(t => t.NhanVien);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TaiKhoanNhanViens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TaiKhoanNhanVien == null)
            {
                return NotFound();
            }

            var taiKhoanNhanVien = await _context.TaiKhoanNhanVien
                .Include(t => t.NhanVien)
                .FirstOrDefaultAsync(m => m.MaTK == id);
            if (taiKhoanNhanVien == null)
            {
                return NotFound();
            }

            return View(taiKhoanNhanVien);
        }

        // GET: TaiKhoanNhanViens/Create
        public IActionResult Create(string id)
        {
            ViewData["MaNV"] = id;
            return View();
        }

        // POST: TaiKhoanNhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTK,TenTK,MaKhau,MaNV")] TaiKhoanNhanVien taiKhoanNhanVien)
        {
            bool hasNameAccount = _context.TaiKhoanNhanVien.Any(k => k.TenTK == taiKhoanNhanVien.TenTK);
            if (ModelState.IsValid && !hasNameAccount)
            {
                _context.Add(taiKhoanNhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", "TaiKhoanNhanViens", new { id = taiKhoanNhanVien.MaTK}) ;
            }
            ViewData["MaNV"] = taiKhoanNhanVien.MaNV;
            return View(taiKhoanNhanVien);
        }

        // GET: TaiKhoanNhanViens/Edit/5
        public async Task<IActionResult> Edit(int? id, string idNV)
        {
            if (id == null || _context.TaiKhoanNhanVien == null)
            {
                return NotFound();
            }

            var taiKhoanNhanVien = await _context.TaiKhoanNhanVien.FindAsync(id);
            if (taiKhoanNhanVien == null)
            {
                return NotFound();
            }
            ViewData["MaNV"] = new SelectList(_context.NhanVien, "MaNV", "MaNV", taiKhoanNhanVien.MaNV);
            return View(taiKhoanNhanVien);
        }

        // POST: TaiKhoanNhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTK,TenTK,MaKhau,MaNV")] TaiKhoanNhanVien taiKhoanNhanVien)
        {
            if (id != taiKhoanNhanVien.MaTK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiKhoanNhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanNhanVienExists(taiKhoanNhanVien.MaTK))
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
            ViewData["MaNV"] = new SelectList(_context.NhanVien, "MaNV", "MaNV", taiKhoanNhanVien.MaNV);
            return View(taiKhoanNhanVien);
        }

        // GET: TaiKhoanNhanViens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TaiKhoanNhanVien == null)
            {
                return NotFound();
            }

            var taiKhoanNhanVien = await _context.TaiKhoanNhanVien
                .Include(t => t.NhanVien)
                .FirstOrDefaultAsync(m => m.MaTK == id);
            if (taiKhoanNhanVien == null)
            {
                return NotFound();
            }

            return View(taiKhoanNhanVien);
        }

        // POST: TaiKhoanNhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TaiKhoanNhanVien == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TaiKhoanNhanVien'  is null.");
            }
            var taiKhoanNhanVien = await _context.TaiKhoanNhanVien.FindAsync(id);
            if (taiKhoanNhanVien != null)
            {
                _context.TaiKhoanNhanVien.Remove(taiKhoanNhanVien);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanNhanVienExists(int id)
        {
          return (_context.TaiKhoanNhanVien?.Any(e => e.MaTK == id)).GetValueOrDefault();
        }
    }
}

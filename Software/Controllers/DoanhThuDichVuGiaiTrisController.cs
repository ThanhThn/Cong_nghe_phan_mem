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
    public class DoanhThuDichVuGiaiTrisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoanhThuDichVuGiaiTrisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DoanhThuDichVuGiaiTris
        public async Task<IActionResult> Index()
        {
              return _context.DoanhThuDichVuGiaiTri != null ? 
                          View(await _context.DoanhThuDichVuGiaiTri.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.DoanhThuDichVuGiaiTri'  is null.");
        }

        // GET: DoanhThuDichVuGiaiTris/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DoanhThuDichVuGiaiTri == null)
            {
                return NotFound();
            }

            var doanhThuDichVuGiaiTri = await _context.DoanhThuDichVuGiaiTri
                .FirstOrDefaultAsync(m => m.MaDoanhThu == id);
            if (doanhThuDichVuGiaiTri == null)
            {
                return NotFound();
            }

            return View(doanhThuDichVuGiaiTri);
        }

        // GET: DoanhThuDichVuGiaiTris/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoanhThuDichVuGiaiTris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDoanhThu,Ngay,SoTienThu")] DoanhThuDichVuGiaiTri doanhThuDichVuGiaiTri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doanhThuDichVuGiaiTri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doanhThuDichVuGiaiTri);
        }

        // GET: DoanhThuDichVuGiaiTris/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DoanhThuDichVuGiaiTri == null)
            {
                return NotFound();
            }

            var doanhThuDichVuGiaiTri = await _context.DoanhThuDichVuGiaiTri.FindAsync(id);
            if (doanhThuDichVuGiaiTri == null)
            {
                return NotFound();
            }
            return View(doanhThuDichVuGiaiTri);
        }

        // POST: DoanhThuDichVuGiaiTris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaDoanhThu,Ngay,SoTienThu")] DoanhThuDichVuGiaiTri doanhThuDichVuGiaiTri)
        {
            if (id != doanhThuDichVuGiaiTri.MaDoanhThu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doanhThuDichVuGiaiTri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoanhThuDichVuGiaiTriExists(doanhThuDichVuGiaiTri.MaDoanhThu))
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
            return View(doanhThuDichVuGiaiTri);
        }

        // GET: DoanhThuDichVuGiaiTris/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DoanhThuDichVuGiaiTri == null)
            {
                return NotFound();
            }

            var doanhThuDichVuGiaiTri = await _context.DoanhThuDichVuGiaiTri
                .FirstOrDefaultAsync(m => m.MaDoanhThu == id);
            if (doanhThuDichVuGiaiTri == null)
            {
                return NotFound();
            }

            return View(doanhThuDichVuGiaiTri);
        }

        // POST: DoanhThuDichVuGiaiTris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DoanhThuDichVuGiaiTri == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DoanhThuDichVuGiaiTri'  is null.");
            }
            var doanhThuDichVuGiaiTri = await _context.DoanhThuDichVuGiaiTri.FindAsync(id);
            if (doanhThuDichVuGiaiTri != null)
            {
                _context.DoanhThuDichVuGiaiTri.Remove(doanhThuDichVuGiaiTri);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoanhThuDichVuGiaiTriExists(int id)
        {
          return (_context.DoanhThuDichVuGiaiTri?.Any(e => e.MaDoanhThu == id)).GetValueOrDefault();
        }
    }
}

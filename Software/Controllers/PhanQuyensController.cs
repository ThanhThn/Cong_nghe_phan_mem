using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Software.Data;
using Software.Models;

namespace Software.Controllers
{
    public class PhanQuyensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhanQuyensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PhanQuyens
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PhanQuyen.Include(p => p.Quyen).Include(p => p.TaiKhoanNhanVien);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PhanQuyens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PhanQuyen == null)
            {
                return NotFound();
            }

            var phanQuyen = await _context.PhanQuyen
                .Include(p => p.Quyen)
                .Include(p => p.TaiKhoanNhanVien)
                .FirstOrDefaultAsync(m => m.MaTK == id);
            if (phanQuyen == null)
            {
                return NotFound();
            }

            return View(phanQuyen);
        }

        // GET: PhanQuyens/Create
        public IActionResult Create()
        {
            ViewData["MaQuyen"] = new SelectList(_context.Quyen, "MaQuyen", "MaQuyen");
            ViewData["MaTK"] = new SelectList(_context.TaiKhoanNhanVien, "MaTK", "MaTK");
            return View();
        }

        // POST: PhanQuyens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaQuyen,MaTK")] PhanQuyen phanQuyen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phanQuyen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaQuyen"] = new SelectList(_context.Quyen, "MaQuyen", "MaQuyen", phanQuyen.MaQuyen);
            ViewData["MaTK"] = new SelectList(_context.TaiKhoanNhanVien, "MaTK", "MaTK", phanQuyen.MaTK);
            return View(phanQuyen);
        }

        // GET: PhanQuyens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (_context.PhanQuyen == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PhanQuyen' is null.");
            }

            string sqlQuery = "SELECT * FROM PhanQuyen WHERE MaTK = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            var phanQuyen = await _context.PhanQuyen.FromSqlRaw(sqlQuery, parameter).ToListAsync();
            ViewData["chucNang"] = _context.ChucNang.ToList();
            ViewData["MaTK"] = id;
            ViewData["MaNV"] = _context.TaiKhoanNhanVien.FirstOrDefault(k => k.MaTK == id).MaNV;
            if (phanQuyen == null || !phanQuyen.Any())
            {
                return View();
            }

            return View(phanQuyen);
        }

        // POST: PhanQuyens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaQuyen,MaTK")] PhanQuyen phanQuyen)
        {
            if (id != phanQuyen.MaTK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phanQuyen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhanQuyenExists(phanQuyen.MaTK))
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
            ViewData["MaQuyen"] = new SelectList(_context.Quyen, "MaQuyen", "MaQuyen", phanQuyen.MaQuyen);
            ViewData["MaTK"] = new SelectList(_context.TaiKhoanNhanVien, "MaTK", "MaTK", phanQuyen.MaTK);
            return View(phanQuyen);
        }

        // GET: PhanQuyens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PhanQuyen == null)
            {
                return NotFound();
            }

            var phanQuyen = await _context.PhanQuyen
                .Include(p => p.Quyen)
                .Include(p => p.TaiKhoanNhanVien)
                .FirstOrDefaultAsync(m => m.MaTK == id);
            if (phanQuyen == null)
            {
                return NotFound();
            }

            return View(phanQuyen);
        }

        // POST: PhanQuyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PhanQuyen == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PhanQuyen'  is null.");
            }
            var phanQuyen = await _context.PhanQuyen.FindAsync(id);
            if (phanQuyen != null)
            {
                _context.PhanQuyen.Remove(phanQuyen);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhanQuyenExists(int id)
        {
          return (_context.PhanQuyen?.Any(e => e.MaTK == id)).GetValueOrDefault();
        }
    }
}

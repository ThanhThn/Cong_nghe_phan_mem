using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Software.Data;
using Software.Models;

namespace Software.Controllers
{
    public class NhanViensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NhanViensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NhanViens
        public async Task<IActionResult> Index()
        {
            var phiDichVu = _context.ThamSo.ToList();
            var applicationDbContext = _context.NhanVien.Include(n => n.ChucVu);
            List<ChucVu> listChucVu = _context.ChucVu.ToList();
            ViewData["ChucVu"] = listChucVu;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: NhanViens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NhanVien == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .Include(n => n.ChucVu)
                .FirstOrDefaultAsync(m => m.MaNV == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // GET: NhanViens/Create
        public IActionResult Create()
        {
            ViewData["MaChucVu"] = new SelectList(_context.ChucVu, "MaChucVu", "MaChucVu");
            return View();
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaNV,TenNhanVien,SoDienThoai,DiaChi,GioiTinh,ChungMinhThu,MaChucVu")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["MaChucVu"] = new SelectList(_context.ChucVu, "MaChucVu", "TenChucVu", nhanVien.MaChucVu);
            return View(nhanVien);
        }



        // GET: NhanViens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NhanVien == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            bool hasAccount = _context.TaiKhoanNhanVien.Any(t => t.MaNV == id);
            int maTK;
            if (hasAccount)
            {
                maTK = _context.TaiKhoanNhanVien.FirstOrDefault(k => k.MaNV == id).MaTK;
            }
            else
            {
                maTK = _context.TaiKhoanNhanVien.Max(k => k.MaTK) + 1;
            }
            ViewData["HasAccount"] = hasAccount;
            ViewData["MaTK"] = maTK;
            ViewData["MaChucVu"] = new SelectList(_context.ChucVu, "MaChucVu", "MaChucVu", nhanVien.MaChucVu);
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaNV,TenNhanVien,SoDienThoai,DiaChi,GioiTinh,ChungMinhThu,MaChucVu")] NhanVien nhanVien)
        {
            if (id != nhanVien.MaNV)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienExists(nhanVien.MaNV))
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
            ViewData["MaChucVu"] = new SelectList(_context.ChucVu, "MaChucVu", "MaChucVu", nhanVien.MaChucVu);
            return View(nhanVien);
        }

        // GET: NhanViens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NhanVien == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .Include(n => n.ChucVu)
                .FirstOrDefaultAsync(m => m.MaNV == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NhanVien == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NhanVien'  is null.");
            }
            var nhanVien = await _context.NhanVien.FindAsync(id);
            if (nhanVien != null)
            {
                _context.NhanVien.Remove(nhanVien);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<JsonResult> Search(string textSearch, int? idSex, int? idPosition)
        {
            StringBuilder SqlQuery = new StringBuilder("SELECT nv.MaNV, nv.TenNhanVien, nv.ChungMinhThu, nv.GioiTinh, nv.SoDienThoai, nv.DiaChi, nv.MaChucVu, cv.TenChucVu FROM NhanVien as nv JOIN ChucVu as cv ON nv.MaChucVu = cv.MaChucVu WHERE 1 = 1");
            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(textSearch))
            {
                SqlQuery.Append(" AND (nv.TenNhanVien LIKE @textSearch OR nv.ChungMinhThu LIKE @textSearch OR nv.SoDienThoai LIKE @textSearch OR nv.DiaChi LIKE @textSearch)");
                parameters.Add(new SqlParameter("@textSearch", $"%{textSearch}%"));
            }
            if (idSex.HasValue)
            {
                SqlQuery.Append(" AND nv.GioiTinh = @idSex");
                parameters.Add(new SqlParameter("@idSex", idSex));
            }
            if (idPosition.HasValue && idPosition != 0)
            {
                SqlQuery.Append(" AND nv.MaChucVu = @idPosition");
                parameters.Add(new SqlParameter("@idPosition", idPosition));
            }

            var nhanVien = await _context.Set<NhanVienChucVuDTO>()
                                 .FromSqlRaw(SqlQuery.ToString(), parameters.ToArray())
                                 .ToListAsync();

            return Json(nhanVien);
        }

        private bool NhanVienExists(string id)
        {
          return (_context.NhanVien?.Any(e => e.MaNV == id)).GetValueOrDefault();
        }
    }
}

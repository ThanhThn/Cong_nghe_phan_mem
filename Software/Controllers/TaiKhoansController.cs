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
    public class TaiKhoansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaiKhoansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TaiKhoans1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TaiKhoan;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TaiKhoans1/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TaiKhoan == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .FirstOrDefaultAsync(m => m.MaTK == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            return View(taiKhoan);
        }
        [HttpGet]
        public IActionResult CheckUsernameAvailability(string username)
        {
            var taikhoan = _context.TaiKhoan.FirstOrDefault(t => t.TenTK == username);
            if (taikhoan == null)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
        [HttpGet]

        // GET: TaiKhoans1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaiKhoans1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTK,TenTK,MatKhau,SoDu,TenKhachHang,SoDT")] TaiKhoan taiKhoan)

        {
            var lastMaTKLonNhat = _context.TaiKhoan.OrderByDescending(t => t.MaTK).Select(t => t.MaTK).FirstOrDefault();

            int getID;
            if (lastMaTKLonNhat == null)
            {
                getID = 1;
            }
            else
            {
                getID = int.Parse(lastMaTKLonNhat.Substring(2)) + 1;
            }
            taiKhoan.MaTK = "KH0" + getID;

            ModelState.Remove("MaTK");
            ModelState.Remove("TrangThai");
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoan);
                await _context.SaveChangesAsync();
                // RedirectToAction(nameof(Index));
                return View(taiKhoan);
            }
            return View(taiKhoan);
        }

        // GET: TaiKhoans1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TaiKhoan == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoan == null)
            {
                return NotFound();
            }
            return View(taiKhoan);
        }

        // POST: TaiKhoans1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaTK,TenTK,MatKhau,SoDu,TenKhachHang,SoDT")] TaiKhoan taiKhoan)
        {
            if (id != taiKhoan.MaTK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiKhoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanExists(taiKhoan.MaTK))
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
            return View(taiKhoan);
        }

        // GET: TaiKhoans1/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TaiKhoan == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .FirstOrDefaultAsync(m => m.MaTK == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            return View(taiKhoan);
        }

        

        [HttpPost]
        public JsonResult LogoutAccount(string id, double tienDu)
        {
            TaiKhoan taiKhoan = _context.TaiKhoan.FirstOrDefault(k => k.MaTK == id);
            if (taiKhoan == null)
            {
                return Json(new
                {
                    success = false,
                    msg = "Tài khoản không tồn tại"
                });
            }
            else
            {
                taiKhoan.SoDu = (decimal)tienDu;
                taiKhoan.TrangThai = false;
                _context.SaveChanges();
                return Json(new
                {
                    success = true,
                    msg = "Thoát thành công"
                });
            }
        }

        [HttpGet]
        public JsonResult LoginAccount(string username, string password)
        {
            var phiDichVu = _context.ThamSo.FirstOrDefault(k => k.MaThamSo == "TS01");
            TaiKhoan taiKhoan = _context.TaiKhoan.FirstOrDefault(k => k.TenTK == username);

            if (taiKhoan == null)
            {
                return Json(new
                {
                    success = false,
                    msg = "Tài khoản không tồn tại"
                });
            }
            else
            {
                if (taiKhoan.MatKhau != password)
                {
                    return Json(new
                    {
                        success = false,
                        msg = "Mật khẩu không chính xác"
                    });
                }
                else
                {
                    if (!taiKhoan.TrangThai)
                    {
                        taiKhoan.TrangThai = true;
                        _context.SaveChanges();
                        return Json(new
                        {
                            success = true,
                            msg = new
                            {
                                taiKhoan = taiKhoan,
                                phi = phiDichVu.GiaTri
                            }
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            success = false,
                            msg = "Tài khoản đang được đăng nhập"
                        });
                    }
                }
            }
        }


        // POST: TaiKhoans1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TaiKhoan == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TaiKhoan'  is null.");
            }
            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoan != null)
            {
                _context.TaiKhoan.Remove(taiKhoan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanExists(string id)
        {
            return (_context.TaiKhoan?.Any(e => e.MaTK == id)).GetValueOrDefault();
        }
    }
}

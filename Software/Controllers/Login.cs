using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Software.Data;
using Software.Models;

namespace Software.Controllers
{
    public class Login : Controller
    {
        private readonly ApplicationDbContext _context;
        public Login(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string password)
        {
            var taiKhoan = _context.TaiKhoanNhanVien.FirstOrDefault(tk => tk.TenTK == name && tk.MaKhau == password);
            if (taiKhoan != null)
            {
                HttpContext.Session.SetString("Username", name);
                List<string> quyens = _context.PhanQuyen
                                    .Where(keyValues => keyValues.MaTK == taiKhoan.MaTK)
                                    .SelectMany(item => _context.LienKetQuyen
                                                            .Where(k => k.MaQuyen == item.MaQuyen)
                                                            .Select(lkq => lkq.MaChucNang))
                                    .Select(mcn => _context.ChucNang
                                                            .Where(k => k.MaChucNang == mcn)
                                                            .Select(c => c.DuongDanChucNang)
                                                            .FirstOrDefault())
                                    .ToList();

                HttpContext.Session.SetObject("DanhSachDuongDan", quyens);

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Software.Data;
using System;
using System.Linq;

namespace Software.Controllers
{
    public class DoanhThuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoanhThuController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoanhThu(DateTime startDate, DateTime endDate)
        {
            // Fetch DoanhThuDichVuGiaiTri data
            var doanhThuList = _context.DoanhThuDichVuGiaiTri
                .Where(d => d.Ngay.Date >= startDate.Date && d.Ngay.Date <= endDate.Date)
                .Select(d => new
                {
                    ThoiGian = d.Ngay.Date,
                    DoanhThu = d.SoTienThu
                })
                .ToList();

            // Fetch HoaDon data
            var hoaDonList = _context.HoaDon
                .Where(h => h.ThoiGian.Date >= startDate.Date && h.ThoiGian.Date <= endDate.Date)
                .Select(h => new
                {
                    ThoiGian = h.ThoiGian.Date,
                    DoanhThu = h.TongTien
                })
                .ToList();

            // Combine and aggregate the results
            var combinedList = doanhThuList
                .Concat(hoaDonList)
                .GroupBy(d => d.ThoiGian)
                .Select(g => new
                {
                    ThoiGian = g.Key.ToString("MM/dd/yyyy"),
                    DoanhThu = g.Sum(d => d.DoanhThu)
                })
                .OrderBy(d => d.ThoiGian)
                .ToList();

            return Json(combinedList);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Software.Data;

namespace Software.Controllers
{
    public class DoanhThu : Controller
    {

        //private readonly ApplicationDbContext _context;

        //public DoanhThu(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //[HttpGet]
        //public IActionResult GetDoanhThu(DateTime startDate, DateTime endDate)
        //{
        //    var doanhThuList = _context.DoanhThuDichVuGiaiTri
        //        .Where(d => d.Ngay >= startDate && d.Ngay <= endDate)
        //        .Select(d => new
        //        {
        //            ThoiGian = d.Ngay.ToString("M/d/yyyy h:mm:ss tt"),
        //            DoanhThu = d.SoTienThu
        //        })
        //        .ToList();

        //    return Json(doanhThuList);
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ApplicationDbContext _context;

        public DoanhThu(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoanhThu(DateTime startDate, DateTime endDate)
        {
            // Fetch DoanhThuDichVuGiaiTri data
            var doanhThuList = _context.DoanhThuDichVuGiaiTri
                .Where(d => d.Ngay >= startDate && d.Ngay <= endDate)
                .Select(d => new
                {
                    ThoiGian = d.Ngay,
                    DoanhThu = d.SoTienThu
                })
                .ToList();

            // Fetch HoaDon data
            var hoaDonList = _context.HoaDon
                .Where(h => h.ThoiGian >= startDate && h.ThoiGian <= endDate)
                .Select(h => new
                {
                    ThoiGian = h.ThoiGian,
                    DoanhThu = h.TongTien
                })
                .ToList();

            // Combine and aggregate the results
            var combinedList = doanhThuList
                .Concat(hoaDonList)
                .GroupBy(d => d.ThoiGian)
                .Select(g => new
                {
                    ThoiGian = g.Key,
                    DoanhThu = g.Sum(d => d.DoanhThu)
                })
                .OrderBy(d => d.ThoiGian)
                .Select(d => new
                {
                    ThoiGian = d.ThoiGian.ToString("M/d/yyyy h:mm:ss tt"),
                    DoanhThu = d.DoanhThu
                })
                .ToList();

            return Json(combinedList);
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Software.Data;

namespace Software.Controllers
{
    public class DoanhThu : Controller
    {

        private readonly ApplicationDbContext _context;

        public DoanhThu(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoanhThu(DateTime startDate, DateTime endDate)
        {
            var doanhThuList = _context.DoanhThuDichVuGiaiTri
                .Where(d => d.Ngay >= startDate && d.Ngay <= endDate)
                .Select(d => new {
                    ThoiGian = d.Ngay.ToString("M/d/yyyy h:mm:ss tt"), 
                    DoanhThu = d.SoTienThu
                })
                .ToList();

            return Json(doanhThuList);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

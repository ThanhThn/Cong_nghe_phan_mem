using Microsoft.EntityFrameworkCore;
using Software.Models;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace Software.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TaiKhoan>().HasKey(t => t.MaTK);
            modelBuilder.Entity<ThamSo>().HasKey(t => t.MaThamSo);

            modelBuilder.Entity<ChucVu>().HasKey(c => c.MaChucVu);

            modelBuilder.Entity<NhanVien>()
                .HasKey(n => n.MaNV);
            modelBuilder.Entity<NhanVien>()
                .HasOne(n => n.ChucVu)
                .WithMany(c => c.NhanViens)
                .HasForeignKey(n => n.MaChucVu);
            modelBuilder.Entity<NhanVien>()
                .HasCheckConstraint("CHECK_CMT", "LEN(ChungMinhThu) BETWEEN 9 AND 12");

            modelBuilder.Entity<MayTinh>().HasKey(m => m.MaMT);

            modelBuilder.Entity<LoaiMon>().HasKey(l => l.MaLoaiMon);

            modelBuilder.Entity<ThucDon>()
                .HasKey(t => t.MaMon);
            modelBuilder.Entity<ThucDon>()
                .HasOne(t => t.LoaiMon)
                .WithMany(l => l.ThucDons)
                .HasForeignKey(t => t.MaLoaiMon);

            modelBuilder.Entity<HoaDon>()
                .HasKey(h => h.MaHD);
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.MayTinh)
                .WithMany(m => m.HoaDons)
                .HasForeignKey(h => h.MaMT);

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasKey(c => new { c.MaHD, c.MaMon });
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(c => c.HoaDon)
                .WithMany(h => h.ChiTietHoaDons)
                .HasForeignKey(c => c.MaHD);
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(c => c.ThucDon)
                .WithMany(t => t.ChiTietHoaDons)
                .HasForeignKey(c => c.MaMon);

            modelBuilder.Entity<TaiKhoanNhanVien>()
                .HasKey(t => t.MaTK);
            modelBuilder.Entity<TaiKhoanNhanVien>()
                .HasOne(t => t.NhanVien)
                .WithOne(n => n.TaiKhoan)
                .HasForeignKey<TaiKhoanNhanVien>(t => t.MaNV);

            modelBuilder.Entity<ChucNang>().HasKey(c => c.MaChucNang);

            modelBuilder.Entity<Quyen>().HasKey(q => q.MaQuyen);

            modelBuilder.Entity<LienKetQuyen>()
                .HasKey(l => new { l.MaChucNang, l.MaQuyen });
            modelBuilder.Entity<LienKetQuyen>()
                .HasOne(l => l.ChucNang)
                .WithMany(c => c.LienKetQuyens)
                .HasForeignKey(l => l.MaChucNang);
            modelBuilder.Entity<LienKetQuyen>()
                .HasOne(l => l.Quyen)
                .WithMany(q => q.LienKetQuyens)
                .HasForeignKey(l => l.MaQuyen);

            modelBuilder.Entity<PhanQuyen>()
                .HasKey(p => new { p.MaTK, p.MaQuyen });
            modelBuilder.Entity<PhanQuyen>()
                .HasOne(p => p.TaiKhoanNhanVien)
                .WithMany(t => t.PhanQuyens)
                .HasForeignKey(p => p.MaTK);
            modelBuilder.Entity<PhanQuyen>()
                .HasOne(p => p.Quyen)
                .WithMany(q => q.PhanQuyens)
                .HasForeignKey(p => p.MaQuyen);

            modelBuilder.Entity<DoanhThuDichVuGiaiTri>().HasKey(d => d.MaDoanhThu);

            modelBuilder.Entity<NhanVienChucVuDTO>().HasNoKey().ToTable(nameof(NhanVienChucVuDTO));
    }

        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<MayTinh> MayTinh { get; set; }
        public DbSet<LoaiMon> LoaiMon { get; set; }
        public DbSet<ThucDon> ThucDon { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<ThamSo> ThamSo { get; set; }
        public DbSet<TaiKhoanNhanVien> TaiKhoanNhanVien { get; set; }
        public DbSet<ChucNang> ChucNang { get; set; }
        public DbSet<Quyen> Quyen { get; set; }
        public DbSet<LienKetQuyen> LienKetQuyen { get; set; }
        public DbSet<PhanQuyen> PhanQuyen { get; set; }
        public DbSet<DoanhThuDichVuGiaiTri> DoanhThuDichVuGiaiTri { get; set; }
    }
}

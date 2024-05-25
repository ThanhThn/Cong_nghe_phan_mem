using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Software.Migrations
{
    /// <inheritdoc />
    public partial class Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucNang",
                columns: table => new
                {
                    MaChucNang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucNang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuongDanChucNang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucNang", x => x.MaChucNang);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "DoanhThuDichVuGiaiTri",
                columns: table => new
                {
                    MaDoanhThu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTienThu = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanhThuDichVuGiaiTri", x => x.MaDoanhThu);
                });

            migrationBuilder.CreateTable(
                name: "LoaiMon",
                columns: table => new
                {
                    MaLoaiMon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiMon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMon", x => x.MaLoaiMon);
                });

            migrationBuilder.CreateTable(
                name: "MayTinh",
                columns: table => new
                {
                    MaMT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MayTinh", x => x.MaMT);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienChucVuDTO",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChungMinhThu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaChucVu = table.Column<int>(type: "int", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    MaTK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.MaTK);
                });

            migrationBuilder.CreateTable(
                name: "ThamSo",
                columns: table => new
                {
                    MaThamSo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenThamSo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonVi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTri = table.Column<float>(type: "real", nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThamSo", x => x.MaThamSo);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    ChungMinhThu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                    table.CheckConstraint("CHECK_CMT", "LEN(ChungMinhThu) BETWEEN 9 AND 12");
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThucDon",
                columns: table => new
                {
                    MaMon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AnhMon = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    MaLoaiMon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucDon", x => x.MaMon);
                    table.ForeignKey(
                        name: "FK_ThucDon_LoaiMon_MaLoaiMon",
                        column: x => x.MaLoaiMon,
                        principalTable: "LoaiMon",
                        principalColumn: "MaLoaiMon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaMT = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_MayTinh_MaMT",
                        column: x => x.MaMT,
                        principalTable: "MayTinh",
                        principalColumn: "MaMT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LienKetQuyen",
                columns: table => new
                {
                    MaChucNang = table.Column<int>(type: "int", nullable: false),
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienKetQuyen", x => new { x.MaChucNang, x.MaQuyen });
                    table.ForeignKey(
                        name: "FK_LienKetQuyen_ChucNang_MaChucNang",
                        column: x => x.MaChucNang,
                        principalTable: "ChucNang",
                        principalColumn: "MaChucNang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LienKetQuyen_Quyen_MaQuyen",
                        column: x => x.MaQuyen,
                        principalTable: "Quyen",
                        principalColumn: "MaQuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoanNhanVien",
                columns: table => new
                {
                    MaTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoanNhanVien", x => x.MaTK);
                    table.ForeignKey(
                        name: "FK_TaiKhoanNhanVien_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMon = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => new { x.MaHD, x.MaMon });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_ThucDon_MaMon",
                        column: x => x.MaMon,
                        principalTable: "ThucDon",
                        principalColumn: "MaMon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyen",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false),
                    MaTK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanQuyen", x => new { x.MaTK, x.MaQuyen });
                    table.ForeignKey(
                        name: "FK_PhanQuyen_Quyen_MaQuyen",
                        column: x => x.MaQuyen,
                        principalTable: "Quyen",
                        principalColumn: "MaQuyen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanQuyen_TaiKhoanNhanVien_MaTK",
                        column: x => x.MaTK,
                        principalTable: "TaiKhoanNhanVien",
                        principalColumn: "MaTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaMon",
                table: "ChiTietHoaDon",
                column: "MaMon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaMT",
                table: "HoaDon",
                column: "MaMT");

            migrationBuilder.CreateIndex(
                name: "IX_LienKetQuyen_MaQuyen",
                table: "LienKetQuyen",
                column: "MaQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_PhanQuyen_MaQuyen",
                table: "PhanQuyen",
                column: "MaQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanNhanVien_MaNV",
                table: "TaiKhoanNhanVien",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_MaLoaiMon",
                table: "ThucDon",
                column: "MaLoaiMon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "DoanhThuDichVuGiaiTri");

            migrationBuilder.DropTable(
                name: "LienKetQuyen");

            migrationBuilder.DropTable(
                name: "NhanVienChucVuDTO");

            migrationBuilder.DropTable(
                name: "PhanQuyen");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "ThamSo");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "ThucDon");

            migrationBuilder.DropTable(
                name: "ChucNang");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "TaiKhoanNhanVien");

            migrationBuilder.DropTable(
                name: "MayTinh");

            migrationBuilder.DropTable(
                name: "LoaiMon");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}

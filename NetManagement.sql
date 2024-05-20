CREATE DATABASE NetManagement

CREATE TABLE KhachHang(
	MaKH int primary key IDENTITY(1,1),
	TenKhachHang nvarchar(50) not null,
	SoDT char(10) not null,
)

CREATE TABLE TaiKhoan(
	MaTK int primary key IDENTITY(1, 1),
	TenTK varchar(max) not null,
	MatKhau varchar(max),
	SoDu money, 
	MaKH int FOREIGN KEY REFERENCES KhachHang(MaKH) not null,
)

CREATE TABLE ChucVu(
	MaChucVu int primary key IDENTITY(1, 1),
	TenChucVu nvarchar(20) not null
)

CREATE TABLE NhanVien(
	MaNV varchar(9) primary key,
	TenNhanVien nvarchar(50) not null,
	SoDienThoai varchar(10) not null,
	DiaChi nvarchar(max),
	GioiTinh bit not null,
	ChungMinhThu varchar(12) not null,
	MaChucVu int FOREIGN KEY REFERENCES ChucVu(MaChucVu) not null,
	Constraint CHECK_CMT CHECK (len(ChungMinhThu) BETWEEN 9 AND 12)
)

CREATE TABLE MayTinh(
	MaMT varchar(10) primary key,
	TinhTrang int not null
)

CREATE TABLE LoaiMon(
	MaLoaiMon int PRIMARY KEY IDENTITY(1, 1),
	TenLoaiMon nvarchar(10) not null
)

CREATE TABLE ThucDon(
	MaMon int PRIMARY KEY IDENTITY(1, 1),
	TenMon nvarchar(50) not null,
	DonGia money not null,
	AnhMon image,
	TinhTrang bit not null,
	MaLoaiMon int FOREIGN KEY REFERENCES LoaiMon(MaLoaiMon) not null
)

CREATE TABLE HoaDon(
	MaHD varchar(10) primary key, 
	ThoiGian datetime not null,
	TongTien money not null,
	MaMT varchar(10) FOREIGN KEY REFERENCES MayTinh(MaMT) not null,
)

CREATE TABLE ChiTietHoaDon(
	MaHD varchar(10) FOREIGN KEY REFERENCES HoaDon(MaHD) not null,
	MaMon int  FOREIGN KEY REFERENCES ThucDon(MaMon) not null,
	SoLuong int not null,
	TongTien money not null,
	DonGia money not null,
	primary key (MaHD, MaMon)
)

CREATE TABLE ThamSo(
	MaThamSo varchar(5) primary key,
	TenThamSo nvarchar(max) not null,
	DonVi nvarchar(15),
	GiaTri float not null,
	TinhTrang bit not null
)

CREATE TABLE TaiKhoanNhanVien(
	MaTK int PRIMARY KEY IDENTITY(1, 1),
	TenTK varchar(max) not null,
	MaKhau varchar(max),
	MaNV varchar(9) FOREIGN KEY REFERENCES NhanVien(MaNV) not null
)

CREATE TABLE ChucNang(
	MaChucNang int PRIMARY KEY IDENTITY(1, 1),
	TenChucNang nvarchar(50),
	DuongDanChucNang varchar(max) not null, 
)

CREATE TABLE Quyen (
	MaQuyen int PRIMARY KEY IDENTITY(1, 1),
	TenQuyen nvarchar(max) not null
)


CREATE TABLE LienKetQuyen(
	MaChucNang int FOREIGN KEY REFERENCES ChucNang(MaChucNang) not null,
	MaQuyen int FOREIGN KEY REFERENCES Quyen(MaQuyen) not null,
	primary key (MaChucNang, MaQuyen)
)

CREATE TABLE PhanQuyen(
	MaQuyen int FOREIGN KEY REFERENCES Quyen(MaQuyen) not null,
	MaTK int FOREIGN KEY REFERENCES TaiKhoanNhanVien(MaTK) not null,
	primary key (MaTK, MaQuyen)
);

CREATE TABLE DoanhThuDichVuGiaiTri(
	MaDoanhThu int PRIMARY KEY IDENTITY(1, 1),
    Ngay date NOT NULL,
    SoTienThu money NOT NULL,
)
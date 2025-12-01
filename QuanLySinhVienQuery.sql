CREATE DATABASE QuanLySinhVien;
GO

USE QuanLySinhVien;
GO

-- 1. Bảng Tài khoản (đăng nhập + phân quyền)
CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,
    Quyen VARCHAR(20) NOT NULL CHECK (Quyen IN (N'admin', N'giangvien', N'sinhvien'))
);
GO

-- 2. Bảng Khoa
CREATE TABLE Khoa (
    MaKhoa INT IDENTITY(1,1) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL UNIQUE
);
GO

-- 3. Bảng Nghề/Chuyên ngành (mỗi nghề thuộc 1 khoa)
CREATE TABLE Nghe (
    MaNghe INT IDENTITY(1,1) PRIMARY KEY,
    TenNghe NVARCHAR(100) NOT NULL,
    MaKhoa INT NOT NULL,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);
GO

-- 4. Bảng Lớp (mỗi lớp thuộc 1 khoa, đào tạo 1 nghề chính)
CREATE TABLE Lop (
    MaLop INT IDENTITY(1,1) PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL UNIQUE,
    MaKhoa INT NOT NULL,
    MaNghe INT NOT NULL,
    NamNhapHoc INT NOT NULL,
    HeDaoTao NVARCHAR(30) CHECK (HeDaoTao IN (N'Chính quy', N'Liên thông', N'Từ xa')),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
    FOREIGN KEY (MaNghe) REFERENCES Nghe(MaNghe)
);
GO

-- 5. Bảng Sinh viên (mỗi SV thuộc 1 lớp, có 1 tài khoản)
CREATE TABLE SinhVien (
    MaSinhVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh VARCHAR(10) CHECK (GioiTinh IN ('Nam', 'Nu', 'Khac')),
    MaLop INT NOT NULL,
    MaTaiKhoan INT UNIQUE,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop),
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
);
GO

-- 6. Bảng Môn học chuyên ngành (thuộc 1 khoa cụ thể)
CREATE TABLE MonHocChuyenNganh (
    MaMonHoc INT IDENTITY(1,1) PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL,
    MaKhoa INT NOT NULL,
    SoTinChi INT DEFAULT 3,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);
GO

-- 7. Bảng Môn học đại cương (mọi SV đều phải học)
CREATE TABLE MonHocDaiCuong (
    MaMonHoc INT IDENTITY(1,1) PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL UNIQUE,
    SoTinChi INT DEFAULT 2
);
GO

-- 8. Bảng Học kỳ / Năm học
CREATE TABLE HocKy (
    MaHocKy INT IDENTITY(1,1) PRIMARY KEY,
    TenHocKy NVARCHAR(50) NOT NULL,  -- VD: Học kỳ 1
    NamHoc INT NOT NULL
);
GO

-- 9. Bảng Điểm thi (điểm theo môn, theo lần thi, theo học kỳ)
CREATE TABLE DiemThi (
    MaDiem INT IDENTITY(1,1) PRIMARY KEY,
    MaSinhVien INT NOT NULL,
    MaHocKy INT NOT NULL,
    MaMonHocChuyenNganh INT NULL,
    MaMonHocDaiCuong INT NULL,
    LanThi VARCHAR(10) NOT NULL CHECK (LanThi IN ('GK', 'CK', 'ThiLai')),
    Diem FLOAT CHECK (Diem >= 0 AND Diem <= 10),
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien),
    FOREIGN KEY (MaHocKy) REFERENCES HocKy(MaHocKy),
    FOREIGN KEY (MaMonHocChuyenNganh) REFERENCES MonHocChuyenNganh(MaMonHoc),
    FOREIGN KEY (MaMonHocDaiCuong) REFERENCES MonHocDaiCuong(MaMonHoc)
);
GO

-- Ràng buộc: mỗi bản ghi điểm chỉ được thuộc 1 trong 2 loại môn
ALTER TABLE DiemThi
ADD CONSTRAINT CK_DiemThi_Mon CHECK (
      (MaMonHocChuyenNganh IS NOT NULL AND MaMonHocDaiCuong IS NULL)
   OR (MaMonHocChuyenNganh IS NULL AND MaMonHocDaiCuong IS NOT NULL)
);
GO

-- 10. Bảng Lịch học - phân theo lớp
CREATE TABLE LichHoc (
    MaLichHoc INT IDENTITY(1,1) PRIMARY KEY,
    MaLop INT NOT NULL,
    MaHocKy INT NOT NULL,
    MaMonHocChuyenNganh INT NULL,
    MaMonHocDaiCuong INT NULL,
    ThuTrongTuan NVARCHAR(20) CHECK (ThuTrongTuan IN (N'Thứ 2',N'Thứ 3',N'Thứ 4',N'Thứ 5',N'Thứ 6',N'Thứ 7',N'Chủ nhật')),
    CaHoc NVARCHAR(20) CHECK (CaHoc IN (N'Sáng',N'Chiều',N'Tối')),
    PhongHoc VARCHAR(20),
    GioBatDau TIME,
    GioKetThuc TIME,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop),
    FOREIGN KEY (MaHocKy) REFERENCES HocKy(MaHocKy),
    FOREIGN KEY (MaMonHocChuyenNganh) REFERENCES MonHocChuyenNganh(MaMonHoc),
    FOREIGN KEY (MaMonHocDaiCuong) REFERENCES MonHocDaiCuong(MaMonHoc)
);
GO

-- Ràng buộc: 1 lịch học chỉ thuộc chuyên ngành hoặc đại cương
ALTER TABLE LichHoc
ADD CONSTRAINT CK_LichHoc_Mon CHECK (
      (MaMonHocChuyenNganh IS NOT NULL AND MaMonHocDaiCuong IS NULL)
   OR (MaMonHocChuyenNganh IS NULL AND MaMonHocDaiCuong IS NOT NULL)
);
GO

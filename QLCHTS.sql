USE QLCHTS;

--Xoá d? li?u b?ng c? 
DELETE FROM CHITIETHOADON;
DELETE FROM HOADON;


DELETE FROM CHITIETPHIEUNHAP;
DELETE FROM PHIEUNHAP;

DELETE FROM SANPHAM;
DELETE FROM LOAISANPHAM;
DELETE FROM NGUYENLIEU;
DELETE FROM DONVITINH;
DELETE FROM CONGTHUC;

DELETE FROM NHACUNGCAP;
DELETE FROM KHACHHANG;
DELETE FROM NHANVIEN;

--
-- CHITIETHOADON
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'CHITIETHOADON' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('CHITIETHOADON', RESEED, 0);

-- HOADON
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'HOADON' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('HOADON', RESEED, 0);

-- CHITIETPHIEUNHAP
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'CHITIETPHIEUNHAP' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('CHITIETPHIEUNHAP', RESEED, 0);

-- PHIEUNHAP
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'PHIEUNHAP' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('PHIEUNHAP', RESEED, 0);

-- SANPHAM
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'SANPHAM' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('SANPHAM', RESEED, 0);

-- NGUYENLIEU
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NGUYENLIEU' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('NGUYENLIEU', RESEED, 0);

-- DONVITINH
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'DONVITINH' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('DONVITINH', RESEED, 0);

-- CONGTHUC
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'CONGTHUC' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('CONGTHUC', RESEED, 0);

-- NHACUNGCAP
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NHACUNGCAP' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('NHACUNGCAP', RESEED, 0);

-- NHANVIEN
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NHANVIEN' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('NHANVIEN', RESEED, 0);

-- KHACHHANG
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'KHACHHANG' AND last_value IS NOT NULL)
    DBCC CHECKIDENT('KHACHHANG', RESEED, 0);

-- Chèn d? li?u b?ng NHANVIEN
INSERT INTO NHANVIEN(TenNV, DiaChiNV, SDTNV, CCCD, TenDangNhap, MatKhau, VaiTro) VALUES
(N'Phan Lê Vi Thanh', 'TP HCM', '0386115115', '123456789', 'thanh01', '$2a$11$8p6wYNZiZk1KZhM0MZLThe4uO4X7ZdhPQzZP.46LNiW2CuHdSKXju', 1),
(N'Lê Thị Thu Diễm', 'Đồng Nai', '0123123123', '112233449', 'diem01', '$2a$11$pAnhlhUJK8eGXGmyksxHYupfsmSAtvLJFJgL4o3/ik3EjHu7ft.sq', 0);

INSERT INTO KHACHHANG(TenKH, DiaChiKH, SDTKH, EmailKH, SoTaiKhoanKH) VALUES
(N'Trần Khởi My', 'Đồng Nai', '0987987987', 'my@gmail.com', '111222111222'),
(N'Kelvin Khánh', 'TP HCM', '0986986986', 'khanhchongmy@gmail.com', '222111222111'),
(N'Nguyễn Kiều Cẩm Thơ', 'Đồng Tháp', '0935935935', 'puka@gmail.com', '333222333222'),
(N'Gin Tuấn Kiệt', 'TP HCM', '0124124124', 'kietchongtho@gmail.com', '444555444555');

SET IDENTITY_INSERT LoaiSanPham ON
INSERT INTO LOAISANPHAM (ID, TenLoaiSP) VALUES
(1, 'TRASUA'),
(2, 'TRATRAICAY'),
(3, 'TOPPING'),
(4, 'BANH');
SET IDENTITY_INSERT LoaiSanPham OFF

INSERT INTO DONVITINH (TenDVT) VALUES 
('THUNG'),
('CHAI'),
('KG'),
('ML');

INSERT INTO NGUYENLIEU (TenNL, DonViTinh, SoLuong, GiaNL, TrangThaiNL) VALUES 
(N'Trà đen', 1, 10, 120000, N'Còn hàng'),
(N'Sữa đặc', 1, 5, 450000, N'Còn hàng'),
(N'Trân châu đen', 3, 8, 90000, N'Còn hàng'),
(N'Syrup dâu', 2, 2000, 1500, N'Còn hàng'),
(N'Bột matcha', 3, 3, 350000, N'Còn hàng');

INSERT INTO SANPHAM(TenSP, LoaiSanPhamID, Size, SoLuong, Gia, TrangThaiSP, HinhAnh)VALUES
-- TRÀ S?A (ID = 1)
(N'Trà sữa truyền thống', 1, 'S', 5, 20000, N'Còn bán', 'trasuatruyenthong.jpg'),
(N'Trà sữa truyền thống', 1, 'M', 5, 25000, N'Còn bán', 'trasuatruyenthong.jpg'),
(N'Trà sữa truyền thống', 1, 'L', 2, 30000, N'Còn bán', 'trasuatruyenthong.jpg'),
(N'Trà sữa matcha', 1, 'S', 6, 22000, N'Còn bán', 'trasuamatcha.jpg'),
-- TRÀ TRÁI CÂY (ID = 2)
(N'Trà đào cam sả', 2, 'S', 7, 25000, N'Còn bán', 'tradaocamsa.jpg'),
(N'Trà đào cam sả', 2, 'M', 5, 30000, N'Còn bán', 'tradaocamsa.jpg'),
-- TOPPING (ID = 3)
(N'Trân châu đen', 3, NULL, 1, 5000, N'Còn bán', 'tranchauden.jpg'),
(N'Trân châu trắng', 3, NULL, 1, 5000, N'Còn bán', 'tranchautrang.jpg'),
(N'Thạch phô mai', 3, NULL, 1, 7000, N'Còn bán', 'thachphomai.jpg'),
-- BÁNH (ID = 4)
(N'Bánh su kem', 4, NULL, 1, 15000, N'Còn bán', 'banhsukem.jpg'),
(N'Bánh tiramisu', 4, NULL, 1, 25000, N'Còn bán', 'banhtiramisu.jpg');

INSERT INTO NHACUNGCAP(TenNCC, DiaChiNCC, SDTNCC, EmailNCC) VALUES
(N'Công ty Thực Phẩm AP', 'Long An', '023423424', 'apfood@gmail.com'),
(N'Shop gia dụng ShinSu', 'An Giang', '0975975975', 'shinshu@gmail.com');

INSERT INTO CONGTHUC (SanPhamID, NguyenLieuID, DinhLuong) VALUES
-- Trà sữa truyền thống
(1, 1, 10),  -- 10g trà đen
(1, 2, 20),  -- 20ml sữa đặc
(1, 3, 30),  -- 30g trân châu
-- Trà sữa matcha
(4, 5, 5),   -- 5g matcha
(4, 2, 20),  -- 20ml sữa đặc
-- Trà đào cam sả
(5, 1, 10),  -- trà đen
(5, 4, 30);  -- syrup dâu (giả lập syrup trái cây)

INSERT INTO PHIEUNHAP (NgayLap, NhanVienID, NhaCungCapID, TongTien) VALUES
('2026-03-20', 1, 1, 0),
('2026-03-23', 2, 2, 0);

INSERT INTO CHITIETPHIEUNHAP (PhieuNhapID, NguyenLieuID, SoLuong, GiaNhap, ThanhTien) VALUES
-- Phiếu nhập 1
(1, 1, 5, 120000, 600000),   -- trà đen
(1, 2, 3, 450000, 1350000),  -- sữa đặc

-- Phiếu nhập 2
(2, 3, 4, 90000, 360000),    -- trân châu
(2, 5, 2, 350000, 700000);   -- matcha

UPDATE PHIEUNHAP
SET TongTien = (
    SELECT SUM(ThanhTien)
    FROM CHITIETPHIEUNHAP
    WHERE PhieuNhapID = PHIEUNHAP.ID
);


INSERT INTO HOADON (NhanVienID, KhachHangID, NgayLap,TongTien ) VALUES 
(1, 1, '2026-03-22',0),
(2, 2, '2026-03-25',0);

INSERT INTO CHITIETHOADON (HoaDonID, SanPhamID, SoLuong, DonGia, ThanhTien) VALUES
(1, 1, 2, 20000, 40000),
(1, 2, 1, 25000, 25000),
(2, 1, 3, 20000, 60000),
(2, 3, 2, 30000, 60000);

UPDATE HOADON
SET TongTien = (
    SELECT SUM(ThanhTien)
    FROM CHITIETHOADON
    WHERE HoaDonID = HoaDon.ID
);

SELECT * FROM NHANVIEN;
SELECT * FROM SANPHAM;
SELECT * FROM LOAISANPHAM;
SELECT * FROM HOADON;
SELECT * FROM CHITIETHOADON;
SELECT * FROM NGUYENLIEU;
SELECT * FROM PHIEUNHAP;
SELECT * FROM CHITIETPHIEUNHAP;
SELECT * FROM CONGTHUC;






/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- INIT CHUC VU DATA
GO
SET IDENTITY_INSERT ChucVu OFF;
GO

MERGE INTO ChucVu AS Target
USING (VALUES
	(1, 'Admin',1)
)
AS Source (Id,TenChucVu,HoatDong )
ON Target.Id = Source.Id

When MATCHED THEN
UPDATE SET		TenChucVu = Source.TenChucVu,
				HoatDong = Source.HoatDong
WHEN NOT MATCHED BY TARGET THEN
INSERT (TenChucVu, HoatDong) 
VALUES(TenChucVu, HoatDong);
GO

SET IDENTITY_INSERT ChucVu ON;
GO

 --INIT NHAN VIEN DATA
GO
SET IDENTITY_INSERT ChucVu OFF;
GO
SET IDENTITY_INSERT NhanVien OFF;
GO

MERGE INTO NhanVien AS Target
USING (VALUES
	(1,'Admin',1,'20150621','admin','GZ7lhU0L9IY=',1,'123','123',1)
)
AS Source (Id, HoVaTen, GioiTinh, NgayThangNamSinh, TenDangNhap, MatKhau, ChucVuId, SoDienThoai, DiaChi, HoatDong)
ON Target.Id = Source.Id

WHEN MATCHED THEN
UPDATE SET	HoVaTen = Source.HoVaTen,
			GioiTinh = Source.GioiTinh,
			NgayThangNamSinh = Source.NgayThangNamSinh,
			TenDangNhap = Source.TenDangNhap,
			MatKhau = Source.MatKhau,
			ChucVuId = Source.ChucVuId,
			SoDienThoai = Source.SoDienThoai,
			DiaChi = Source.DiaChi,
			HoatDong = Source.HoatDong
WHEN NOT MATCHED BY Target THEN
INSERT(HoVaTen, GioiTinh, NgayThangNamSinh, TenDangNhap, MatKhau, ChucVuId, SoDienThoai, DiaChi, HoatDong)
VALUES(HoVaTen, GioiTinh, NgayThangNamSinh, TenDangNhap, MatKhau, ChucVuId, SoDienThoai, DiaChi, HoatDong);
GO

SET IDENTITY_INSERT NhanVien ON;
GO


Update DonHang set TrangThaiDonHang = N'Hoàn Thành' where TrangThaiDonHang = 'Hoàn Thành'
Update DonHang set TrangThaiDonHang = N'Chưa Hoàn Thành' where TrangThaiDonHang = 'Chua Hoàn Thành'
Update DonHang set TrangThaiDonHang = N'Đang Chờ' where TrangThaiDonHang = 'Ðang Ch?'
Update DonHang set TrangThaiDonHang = N'Hủy' where TrangThaiDonHang = 'H?y'

-- INIT QUYEN
GO
SET IDENTITY_INSERT Quyen OFF;
GO
SET IDENTITY_INSERT NhanVien OFF;
GO

MERGE INTO Quyen AS Target
USING (VALUES
	(1, 'Admin'),
	(2, N'Nhân Viên'),
	(3, N'Quản Lý')
)
AS Source (Id,Quyen )
ON Target.Id = Source.Id

When MATCHED THEN
UPDATE SET		Quyen = Source.Quyen
WHEN NOT MATCHED BY TARGET THEN
INSERT (Quyen) 
VALUES(Quyen);
GO

SET IDENTITY_INSERT Quyen ON;
GO

-- INIT QUYEN NHAN VIEN

GO
SET IDENTITY_INSERT QuyenNhanVien OFF;
GO
SET IDENTITY_INSERT NhanVien OFF;
GO
SET IDENTITY_INSERT Quyen OFF;
GO

MERGE INTO QuyenNhanVien AS Target
USING (VALUES
	(1, 1, 1,1)
)
AS Source (Id,QuyenId,NhanVienId,HoatDong )
ON Target.Id = Source.Id

When MATCHED THEN
UPDATE SET		QuyenId = Source.QuyenId,
				NhanVienId = Source.NhanVienId
WHEN NOT MATCHED BY TARGET THEN
INSERT (QuyenId, NhanVienId,HoatDong) 
VALUES(QuyenId, NhanVienId,HoatDong);
GO

SET IDENTITY_INSERT QuyenNhanVien ON;
GO

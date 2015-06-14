CREATE TABLE [dbo].[HoaDon]
(
	[HoaDonId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [KhachHangId] BIGINT NOT NULL, 
	[NhanVienId] BIGINT NOT NULL,
	[NgayLap] DATETIME2 NOT NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
	[HoatDong] BIT NULL DEFAULT 1,
    CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY ([KhachHangId]) REFERENCES [KhachHang]([Id]),
	CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_HoaDon_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
	
)

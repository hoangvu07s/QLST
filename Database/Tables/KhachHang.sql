CREATE TABLE [dbo].[KhachHang]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TenKhachHang] VARCHAR(255) NOT NULL, 
    [DiaChi] VARCHAR(MAX) NOT NULL, 
    [SoDienThoai] VARCHAR(50) NOT NULL, 
    [Tuoi] INT NOT NULL, 
    [Email] VARCHAR(50) NULL,
	[DiemTichLuy] INT NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1,
	CONSTRAINT [FK_KhachHang_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_KhachHang_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

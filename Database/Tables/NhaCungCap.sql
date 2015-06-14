CREATE TABLE [dbo].[NhaCungCap]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TenNhaCungCap] VARCHAR(255) NOT NULL, 
    [TenCongTy] VARCHAR(255) NOT NULL, 
    [DiaChi] VARCHAR(255) NOT NULL, 
    [SoDienThoai] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL,
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1,
	CONSTRAINT [FK_NhaCungCap_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_NhaCungCap_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

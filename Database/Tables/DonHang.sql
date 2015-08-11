CREATE TABLE [dbo].[DonHang]
(
	[DonHangId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY , 
	[NhaCungCapId] BIGINT NOT NULL,
	[TrangThaiDonHang] NVARCHAR(255) NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1,
	CONSTRAINT [FK_DonHang_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_DonHang_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_DonHang_NhaCungCap] FOREIGN KEY ([NhaCungCapId]) REFERENCES [NhaCungCap]([Id])
)

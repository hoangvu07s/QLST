CREATE TABLE [dbo].[DonHang]
(
	[DonHangId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY , 
    [NhanVienId] BIGINT NOT NULL, 
	[NhaCungCapId] BIGINT NOT NULL,
	[TrangThaiDonHang] VARCHAR(255) NULL,
	[NgayLap] DATETIME2 NOT NULL,
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
    [HoatDong] BIT NULL DEFAULT 1,
    CONSTRAINT [FK_DonHang_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_DonHang_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_DonHang_NhaCungCap] FOREIGN KEY ([NhaCungCapId]) REFERENCES [NhaCungCap]([Id])
)

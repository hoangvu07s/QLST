CREATE TABLE [dbo].[XuatKho]
(
	[PhieuXuatKhoId] uniqueidentifier NOT NULL PRIMARY KEY, 
	[KhoId] BIGINT NOT NULL, 
    [NhanVienId] BIGINT NOT NULL,
	[NgayXuat] DATETIME2 NOT NULL,
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
    [HoatDong] BIT NULL DEFAULT 1,
	CONSTRAINT [FK_XuatKho_Kho] FOREIGN KEY ([KhoId]) REFERENCES [Kho]([Id]), 
	CONSTRAINT [FK_XuatKho_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_XuatKho_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id])
)

CREATE TABLE [dbo].[QuyenNhanVien]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[QuyenId] BIGINT NOT NULL,
	[NhanVienId] BIGINT NOT NULL,
	[HoatDong] BIT

	CONSTRAINT [FK_QuyenNhanVien_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]) NOT NULL DEFAULT 0,
	CONSTRAINT [FK_QuyenNhanVien_Quyen] FOREIGN KEY ([QuyenId]) REFERENCES [Quyen]([Id])
)

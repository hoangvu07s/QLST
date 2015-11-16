CREATE TABLE [dbo].[QuyenNhanVien]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[QuyenId] BIGINT NOT NULL,
	[NhanVienId] BIGINT NOT NULL,

	CONSTRAINT [FK_QuyenNhanVien_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_QuyenNhanVien_Quyen] FOREIGN KEY ([QuyenId]) REFERENCES [Quyen]([Id])
)

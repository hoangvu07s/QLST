CREATE TABLE [dbo].[CT_XuatKho]
(
	[XuatKhoId] uniqueidentifier NOT NULL,
	[HangHoaId] BIGINT NOT NULL,
	[SoLuong] INT NOT NULL DEFAULT 0,
	[DonGia] DECIMAL(18,0) NOT NULL,
	[NhaCungCapId] BIGINT NOT NULL,
	PRIMARY KEY([XuatKhoId], [HangHoaId]),
	CONSTRAINT [FK_CTXuatKho_NhaCungCap] FOREIGN KEY ([NhaCungCapId]) REFERENCES [NhaCungCap]([Id]),
	CONSTRAINT [FK_CTXuatKho_XuatKho] FOREIGN KEY ([XuatKhoId]) REFERENCES [XuatKho]([PhieuXuatKhoId]),
	CONSTRAINT [FK_CTXuatKho_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id])
)

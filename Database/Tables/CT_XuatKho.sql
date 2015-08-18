CREATE TABLE [dbo].[CT_XuatKho]
(
	[XuatKhoId] uniqueidentifier NOT NULL,
	[HangHoaId] BIGINT NOT NULL,
	[SoLuong] INT NOT NULL DEFAULT 0,
	PRIMARY KEY([XuatKhoId], [HangHoaId]),
	CONSTRAINT [FK_CTXuatKho_XuatKho] FOREIGN KEY ([XuatKhoId]) REFERENCES [XuatKho]([PhieuXuatKhoId]),
	CONSTRAINT [FK_CTXuatKho_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id])
)

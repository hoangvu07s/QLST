CREATE TABLE [dbo].[CT_NhapKho]
(
	[NhapKhoId] uniqueidentifier NOT NULL,
	[HangHoaId] BIGINT NOT NULL,
	[KhoId] BIGINT NOT NULL,
	[SoLuong] INT NOT NULL DEFAULT 0,
	[DonGia] DECIMAL(18,0) NOT NULL,
	PRIMARY KEY([NhapKhoId], [HangHoaId]),
	CONSTRAINT [FK_CTNhapKho_NhapKho] FOREIGN KEY ([NhapKhoId]) REFERENCES [NhapKho]([PhieuNhapKhoId]),
	CONSTRAINT [FK_CTNhapKho_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id]),
	CONSTRAINT [FK_CTNhapKho_Kho] FOREIGN KEY ([KhoId]) REFERENCES [Kho]([Id])
)

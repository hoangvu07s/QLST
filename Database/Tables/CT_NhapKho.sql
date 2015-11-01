﻿CREATE TABLE [dbo].[CT_NhapKho]
(
	[NhapKhoId] uniqueidentifier NOT NULL,
	[HangHoaId] BIGINT NOT NULL,

	[SoLuong] INT NOT NULL DEFAULT 0,
	[DonGia] DECIMAL NOT NULL, 
	[NgaySanXuat] DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
	[HanSuDung] DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    PRIMARY KEY([NhapKhoId], [HangHoaId]),
	CONSTRAINT [FK_CTNhapKho_NhapKho] FOREIGN KEY ([NhapKhoId]) REFERENCES [NhapKho]([PhieuNhapKhoId]),
	CONSTRAINT [FK_CTNhapKho_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id])
)

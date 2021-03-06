﻿CREATE TABLE [dbo].[HangHoaKhuyenMai]
(
	
    [HangHoaId] BIGINT NOT NULL, 
    [KhuyenMaiId] BIGINT NOT NULL,
	[GiamGiaPhanTram] Decimal NULL,
	[TangKem] BIT NULL,
	[HangHoaTangId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1, 
	PRIMARY KEY([KhuyenMaiId], [HangHoaId]),
    CONSTRAINT [FK_HangHoaKhuyenMai_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id]),
	CONSTRAINT [FK_HangHoaKhuyenMai_KhuyenMai] FOREIGN KEY ([KhuyenMaiId]) REFERENCES [KhuyenMai]([Id]),
	CONSTRAINT [FK_HangHoaKhuyenMai_HangHoaTang] FOREIGN KEY ([HangHoaTangId]) REFERENCES [HangHoa]([Id])
)

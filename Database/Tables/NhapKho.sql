﻿CREATE TABLE [dbo].[NhapKho]
(
	[PhieuNhapKhoId] uniqueidentifier NOT NULL PRIMARY KEY, 
	[DonHangId] UNIQUEIDENTIFIER NOT NULL, 
    [KhoId] BIGINT NOT NULL, 
    [NgayNhap] DATETIME2 NOT NULL,
    [NhanVienId] BIGINT NOT NULL,
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
    [HoatDong] BIT NULL DEFAULT 1, 
	CONSTRAINT [FK_NhapKho_Kho] FOREIGN KEY ([KhoId]) REFERENCES [Kho]([Id]),
	CONSTRAINT [FK_NhapKho_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_NhapKho_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_NhapKho_DonHang] FOREIGN KEY ([DonHangId]) REFERENCES [DonHang]([DonHangId])

)

﻿CREATE TABLE [dbo].[QuayHang]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[TenQuay] VARCHAR(255) NOT NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
    [HoatDong] BIT NULL DEFAULT 1,
	CONSTRAINT [FK_QuayHang_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	 CONSTRAINT [FK_QuayHang_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

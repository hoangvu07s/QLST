﻿CREATE TABLE [dbo].[SieuThi]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TenSieuThi] VARCHAR(255) NOT NULL, 
    [DiaChi] VARCHAR(MAX) NOT NULL, 
    [SoDienThoai] VARCHAR(50) NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTao] VARCHAR(255) NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSua] VARCHAR(255) NULL, 
    [HoatDong] BIT NULL DEFAULT 1
)

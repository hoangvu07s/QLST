CREATE TABLE [dbo].[KhuyenMai]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
	[TenKhuyenMai] VARCHAR(255) NOT NULL,
    [NgayBatDau] DATETIME2 NOT NULL, 
    [NgayKetThuc] DATETIME2 NOT NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL,  
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
    [HoatDong] BIT NULL DEFAULT 1,
	 CONSTRAINT [FK_KhuyenMai_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	 CONSTRAINT [FK_KhuyenMai_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
	
)

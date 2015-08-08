CREATE TABLE [dbo].[Kho]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TenKho] NVARCHAR(255),   
    [NhanVienId] BIGINT NOT NULL, 
	[DiaChi] NVARCHAR(255),
	[SoDienThoai] NVARCHAR(50),
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL,  
    [HoatDong] BIT NULL DEFAULT 1, 
	CONSTRAINT [FK_Kho_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_Kho_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_Kho_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
	
)

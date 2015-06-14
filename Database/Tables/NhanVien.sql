CREATE TABLE [dbo].[NhanVien]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[HoVaTen] VARCHAR(255) NOT NULL, 
    [GioiTinh] BIT NOT NULL, 
    [NgayThangNamSinh] DATETIME2 NOT NULL, 
    [ChucVuId] BIGINT NOT NULL, 
    [SoDienThoai] VARCHAR(50) NOT NULL, 
    [DiaChi] VARCHAR(MAX) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL,
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
	[NguoiChinhSuaId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1, 
    CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY ([ChucVuId]) REFERENCES [ChucVu]([Id]),
    CONSTRAINT [FK_NhanVien_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_NhanVien_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
	
)

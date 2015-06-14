CREATE TABLE [dbo].[KhachHangThanThiet]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [KhachHangId] BIGINT NOT NULL,
	[DiemTichLuy] INT NOT NULL,
	[Nam] INT NOT NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL,  
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
    [HoatDong] BIT NULL DEFAULT 1, 
    CONSTRAINT [FK_KhachHangThanThiet_KhachHang] FOREIGN KEY ([KhachHangId]) REFERENCES [KhachHang]([Id]),
	CONSTRAINT [FK_KhachHangThanThiet_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_KhachHangThanThiet_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

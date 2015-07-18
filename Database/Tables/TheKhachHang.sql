CREATE TABLE [dbo].[TheKhachHang]
(
	[TheKhachHangId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY ,
	[KhachHangId] BIGINT NOT NULL,
	[DiemTichLuy] INT NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1,
	CONSTRAINT [FK_TheKhachHang_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_TheKhachHang_KhachHang] FOREIGN KEY ([KhachHangId]) REFERENCES [KhachHang]([Id])
)

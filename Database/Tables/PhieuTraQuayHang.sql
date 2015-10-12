CREATE TABLE [dbo].[PhieuTraQuayHang]
(
	[PhieuTraQuayHangId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    [NhanVienId] BIGINT NOT NULL, 
	[QuayHangId] BIGINT NOT NULL,
	[KhoId] BIGINT NOT NULL,
	[NgayLap] DATETIME2 NOT NULL,
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
	[HoatDong] BIT NULL DEFAULT 1, 
    CONSTRAINT [FK_PhieuTraQuayHang_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_PhieuTraQuayHang_Kho] FOREIGN KEY ([KhoId]) REFERENCES [Kho]([Id]),
	CONSTRAINT [FK_PhieuTraQuayHang_QuayHang] FOREIGN KEY ([QuayHangId]) REFERENCES [QuayHang]([Id]),
	CONSTRAINT [FK_PhieuTraQuayHang_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

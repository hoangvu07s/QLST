CREATE TABLE [dbo].[DoiTraHangHoa]
(
	[DoiTraHangHoaId] uniqueidentifier NOT NULL PRIMARY KEY, 
    [HoaDonId] UNIQUEIDENTIFIER NOT NULL, 
	[NhanVienId] BIGINT NOT NULL,
	[KhoId] BIGINT NOT NULL,
	[NgayLap] DATETIME2 NOT NULL,
    [TongTienTraLai] DECIMAL(18, 2) NOT NULL,
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL, 
    [HoatDong] BIT NULL DEFAULT 1, 
    CONSTRAINT [FK_DoiTraHangHoa_HoaDon] FOREIGN KEY ([HoaDonId]) REFERENCES [HoaDon]([HoaDonId]),
	CONSTRAINT [FK_DoiTraHangHoa_NhanVien] FOREIGN KEY ([NhanVienId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_DoiTraHangHoa_Kho] FOREIGN KEY ([KhoId]) REFERENCES [Kho]([Id]),
	CONSTRAINT [FK_DoiTraHangHoa_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

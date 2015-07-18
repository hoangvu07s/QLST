CREATE TABLE [dbo].[HangHoa]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TenHangHoa] VARCHAR(255) NOT NULL, 
    [LoaiHangHoaId] BIGINT NOT NULL, 
    [NhaCungCapId] BIGINT NOT NULL, 
	[QuayHangId] BIGINT NOT NULL, 
	[SoLuongTonQuay] BIGINT NULL,
    [CoTheTraLai] BIT NULL,
    [GiaNhapVao] DECIMAL NOT NULL, 
    [GiaBanRa] DECIMAL NOT NULL,
	[HinhAnh] VARCHAR(MAX),
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL, 
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1, 
    CONSTRAINT [FK_HangHoa_LoaiHangHoa] FOREIGN KEY ([LoaiHangHoaId]) REFERENCES [LoaiHangHoa]([Id]),
	CONSTRAINT [FK_HangHoa_NhaCungCap] FOREIGN KEY ([NhaCungCapId]) REFERENCES [NhaCungCap]([Id]),
	CONSTRAINT [FK_HangHoa_QuayHang] FOREIGN KEY ([QuayHangId]) REFERENCES [QuayHang]([Id]),
	CONSTRAINT [FK_HangHoa_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_HangHoa_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

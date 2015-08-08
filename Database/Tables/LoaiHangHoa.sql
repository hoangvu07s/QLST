CREATE TABLE [dbo].[LoaiHangHoa]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TenLoaiHangHoa] NVARCHAR(255) NOT NULL, 
    [ChungLoaiId] BIGINT NOT NULL,
	[NgayTao] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiTaoId] BIGINT NULL,  
    [NgayChinhSua] DATETIME2 NULL DEFAULT SYSDATETIME(), 
    [NguoiChinhSuaId] BIGINT NULL,
    [HoatDong] BIT NULL DEFAULT 1, 
    CONSTRAINT [FK_LoaiHangHoa_ChungLoai] FOREIGN KEY ([ChungLoaiId]) REFERENCES [ChungLoaiHangHoa]([Id]),
	CONSTRAINT [FK_LoaiHangHoa_NguoiTao] FOREIGN KEY ([NguoiTaoId]) REFERENCES [NhanVien]([Id]),
	CONSTRAINT [FK_LoaiHangHoa_NguoiChinhSua] FOREIGN KEY ([NguoiChinhSuaId]) REFERENCES [NhanVien]([Id])
)

CREATE TABLE [dbo].[CT_DoiTraHangHoa]
(
	[DoiTraHangHoaId] uniqueidentifier NOT NULL ,
	[HangHoaId] BIGINT NOT NULL,
	[SoLuong] INT NOT NULL,
	[DonGia] DECIMAL(18,0) NOT NULL, 
	[TinhTrang] NVARCHAR(255) NULL,
    [ChietKhauPhanTram] DECIMAL NULL,
	PRIMARY KEY([DoiTraHangHoaId], [HangHoaId]),
	CONSTRAINT [FK_CTDoiTraHangHoa_DoiTraHangHoaId] FOREIGN KEY ([DoiTraHangHoaId]) REFERENCES [DoiTraHangHoa]([DoiTraHangHoaId]),
	CONSTRAINT [FK_CTDoiTraHangHoa_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id])
)

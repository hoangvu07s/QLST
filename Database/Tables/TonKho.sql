CREATE TABLE [dbo].[TonKho]
(
	[KhoId] BIGINT NOT NULL,
	[HangHoaId] BIGINT NOT NULL,
	[SoLuongTon] BIGINT NULL,
	PRIMARY KEY([KhoId], [HangHoaId]),
	CONSTRAINT [FK_TonKho_Kho] FOREIGN KEY ([KhoId]) REFERENCES [Kho]([Id]),
	CONSTRAINT [FK_TonKho_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id]),
)

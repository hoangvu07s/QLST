CREATE TABLE [dbo].[CT_PhieuTraQuayHang]
(
	[PhieuTraQuayHangId] UNIQUEIDENTIFIER NOT NULL ,
	[HangHoaId] BIGINT NOT NULL,
	[SoLuong] INT NOT NULL DEFAULT 0,
	[LyDo] NVARCHAR(255) NULL,
	PRIMARY KEY([PhieuTraQuayHangId], [HangHoaId]),
	CONSTRAINT [FK_CTPhieuTraQuayHang_HangHoa] FOREIGN KEY ([HangHoaId]) REFERENCES [HangHoa]([Id]),
	CONSTRAINT [FK_CTPhieuTraQuayHang_PhieuTraQuayHang] FOREIGN KEY ([PhieuTraQuayHangId]) REFERENCES [PhieuTraQuayHang]([PhieuTraQuayHangId])


)

CREATE TABLE [dbo].[CT_PhieuTraQuayHang]
(
	[PhieuTraQuayHangId] UNIQUEIDENTIFIER NOT NULL ,
	[KhoId] BIGINT NOT NULL,
	[SoLuong] INT NOT NULL DEFAULT 0,
	[DonGia] DECIMAL(18,0) NOT NULL,
	[LyDo] VARCHAR(255) NULL,
	PRIMARY KEY([PhieuTraQuayHangId], [KhoId]),
	CONSTRAINT [FK_CTPhieuTraQuayHang_Kho] FOREIGN KEY ([KhoId]) REFERENCES [Kho]([Id]),
	CONSTRAINT [FK_CTPhieuTraQuayHang_PhieuTraQuayHang] FOREIGN KEY ([PhieuTraQuayHangId]) REFERENCES [PhieuTraQuayHang]([PhieuTraQuayHangId])


)

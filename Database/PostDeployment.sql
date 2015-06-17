/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
--INSERT INTO ChucVu (TenChucVu, NgayTao,NgayChinhSua,HoatDong) VALUES('Admin', SYSDATETIME(),SYSDATETIME(),1)

GO
SET IDENTITY_INSERT ChucVu OFF;
GO

MERGE INTO ChucVu AS Target
USING (VALUES
	(1, 'Admin',1)
)
AS Source (Id,TenChucVu,HoatDong )
ON Target.Id = Source.Id

When MATCHED THEN
UPDATE SET		TenChucVu = Source.TenChucVu,
				HoatDong = Source.HoatDong
WHEN NOT MATCHED BY TARGET THEN
INSERT (TenChucVu, HoatDong) 
VALUES(TenChucVu, HoatDong);
GO

SET IDENTITY_INSERT ChucVu ON;
GO
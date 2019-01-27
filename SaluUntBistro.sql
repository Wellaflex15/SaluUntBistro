CREATE DATABASE SaluUntBistro

USE SaluUntBistro
GO

CREATE TABLE dbo.[EmailAddresses] (
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[Email] varchar(320)
)

INSERT INTO dbo.[EmailAddresses](Email)
VALUES
('david.welin@gmail.com'),
('rille.fors@gmail.com'),
('tuffs.katt@gmail.com')

DELETE FROM dbo.[EmailAddresses] 
WHERE Email='david.welin@gmail.com'
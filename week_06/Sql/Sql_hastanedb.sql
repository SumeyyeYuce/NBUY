USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO
--�ST TARAF VARSA HASTANEDB Y� S�L�P YEN�DEN OLU�TURUR YOKSA ZATEN OLU�TURUR

USE HastaneDb
GO
--hastalar tabosu
CREATE TABLE Hastalar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	adres NVARCHAR(50),
	telefon CHAR(11)

)

GO
INSERT INTO Hastalar(adSoyad,cinsiyet,adres) VALUES
	('ERENCAN Germili','E','istanbul'),
	('Selin Ergen�','K','Ankara'),
	('Sadi Kuluglu','E','�ZM�R'),
	('Ne�e kalabal�k','K','istanbul'),
	('Sevda Agalar','K','�zmir'),
	('Nora Taskesen','K','Ankara'),
	('Emma cetoglu','E','istanbul'),
	('Kerem S�zc�','E','Ankara'),
	('Suat Tartar','E','�zmir')

GO
--bolumler tablosu
CREATE TABLE Bolumler(
	id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Bolumler VALUES
	('Dahiliye'),('Noroloji'),('Ortopedi'),
	('Di�'),('Periodontoloji'),('Genel cerrahi')

Go
--doktoralr tablosu
CREATE TABLE Doktorlar(
	id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50),
	bolumId INT,
	FOREIGN KEY (bolumId) REFERENCES Bolumler(id)
)

GO
INSERT INTO Doktorlar VALUES
	('Ali can','�stanbul',1),
	('Demet Evgar','bursa',2),
	('Sedat Kanar','�stanbul',3),
	('Ferhunde han�m','izmir',1),	
	('Zafer kimki','ankara',2),
	('Hale Elveren','�stanbul',3),
	('Tuna Sefer','Ankara',4),
	('Kevser Tutku','�stanbul',4),
	('Tutkum kap��mak','izmir',5),
	('isa canova','izmir',5),
	('tug�e bolumsuz','�stanbul',null)
	

GO
--yukar�daki �nsert �nto nun son sat�r�r�n�  alternatifi buras�
--INSERT INTO Doktorlar(adSoyad,adres) VALUES
--	('tug�e bolumsuz','�stanbul')

--GO
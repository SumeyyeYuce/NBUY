USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO
--ÜST TARAF VARSA HASTANEDB YÝ SÝLÝP YENÝDEN OLUÞTURUR YOKSA ZATEN OLUÞTURUR

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
	('Selin Ergenç','K','Ankara'),
	('Sadi Kuluglu','E','ÝZMÝR'),
	('Neþe kalabalýk','K','istanbul'),
	('Sevda Agalar','K','Ýzmir'),
	('Nora Taskesen','K','Ankara'),
	('Emma cetoglu','E','istanbul'),
	('Kerem Sözcü','E','Ankara'),
	('Suat Tartar','E','Ýzmir')

GO
--bolumler tablosu
CREATE TABLE Bolumler(
	id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Bolumler VALUES
	('Dahiliye'),('Noroloji'),('Ortopedi'),
	('Diþ'),('Periodontoloji'),('Genel cerrahi')

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
	('Ali can','Ýstanbul',1),
	('Demet Evgar','bursa',2),
	('Sedat Kanar','Ýstanbul',3),
	('Ferhunde haným','izmir',1),	
	('Zafer kimki','ankara',2),
	('Hale Elveren','Ýstanbul',3),
	('Tuna Sefer','Ankara',4),
	('Kevser Tutku','Ýstanbul',4),
	('Tutkum kapýþmak','izmir',5),
	('isa canova','izmir',5),
	('tugçe bolumsuz','Ýstanbul',null)
	

GO
--yukarýdaki ýnsert ýnto nun son satýrýrýný  alternatifi burasý
--INSERT INTO Doktorlar(adSoyad,adres) VALUES
--	('tugçe bolumsuz','Ýstanbul')

--GO
USE master
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb
GO

CREATE TABLE Turler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL
)

GO

INSERT INTO Turler VALUES
	('Genel'),('Roman'),('Hikaye'),('Macera'),('Polisiye')

GO

CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50),
	cinsiyet CHAR(1) NOT NULL,
	telefon CHAR(11)
)
GO

INSERT INTO Yazarlar (adSoyad,cinsiyet,adres) VALUES
	('Zülfü Livaneli','E','Ýstanbul'),
	('Kahraman Tazeoðlu','E','Ýzmir'),
	('Ayþe Duman','K','Ankara'),
	('Peyami Safa','E','Ýstanbul'),
	('Sherlock Holmes','E','Ankara')

GO

CREATE TABLE YayýnEvleri(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL

)
GO

INSERT INTO YayýnEvleri VALUES
	('Timaþ Yayýnlarý'),
	('Tomurcuk Yayýnlarý'),
	('Bilge Yayýnlarý'),
	('Öz Yayýnlarý')

GO

CREATE TABLE Uyeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50),
	cinsiyet CHAR(1) NOT NULL,
	telefon CHAR(11)
)

GO
INSERT INTO Uyeler(adSoyad,adres,cinsiyet) VALUES
	('Selin Ak','Ýstanbul','K'),
	('Ahmet Rasým','Ankara','E'),
	('Hakan Þafak','Ýstanbul','E'),
	('Melisa Öz','Ýzmir','K'),
	('Osman Tandýr','Ýstanbul','E'),
	('Yusuf TEK','Ýstanbul','E')

GO

CREATE TABLE Kitaplar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	yazarId INT FOREIGN KEY REFERENCES Yazarlar (id) ON DELETE SET NULL,
	yayýneviId INT,
	turId INT DEFAULT 1 FOREIGN KEY REFERENCES Turler (id) ON DELETE SET DEFAULT,
	FOREIGN KEY (yayýneviId) REFERENCES YayýnEvleri (id),
	
	

)

GO
INSERT INTO Kitaplar (ad,yazarId,yayýneviId,turId) VALUES
	('Balýkçý ve Oðlu',1,1,2),
	('Vazgeçtim',2,3,2),
	('Fatih Harbiye',3,4,3),
	('Kayýp Ev',3,2,4),
	('Suç ve ceza',4,1,2)

GO
CREATE TABLE OduncIslemleri(
	uyeId INT,
	kitapId INT,
	tarih Date,
	FOREIGN KEY (uyeId) REFERENCES Uyeler(id),
	FOREIGN KEY (kitapId) REFERENCES Kitaplar(id),

)
GO

INSERT INTO OduncIslemleri(uyeId,kitapId,tarih) VALUES
	(1,2,'2021-06-12'),
	(2,3,'2021-06-12'),
	(3,4,'2021-06-12'),
	(4,1,'2021-06-12'),
	(5,5,'2021-06-12')

GO


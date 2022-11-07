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
	('Z�lf� Livaneli','E','�stanbul'),
	('Kahraman Tazeo�lu','E','�zmir'),
	('Ay�e Duman','K','Ankara'),
	('Peyami Safa','E','�stanbul'),
	('Sherlock Holmes','E','Ankara')

GO

CREATE TABLE Yay�nEvleri(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL

)
GO

INSERT INTO Yay�nEvleri VALUES
	('Tima� Yay�nlar�'),
	('Tomurcuk Yay�nlar�'),
	('Bilge Yay�nlar�'),
	('�z Yay�nlar�')

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
	('Selin Ak','�stanbul','K'),
	('Ahmet Ras�m','Ankara','E'),
	('Hakan �afak','�stanbul','E'),
	('Melisa �z','�zmir','K'),
	('Osman Tand�r','�stanbul','E'),
	('Yusuf TEK','�stanbul','E')

GO

CREATE TABLE Kitaplar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	yazarId INT FOREIGN KEY REFERENCES Yazarlar (id) ON DELETE SET NULL,
	yay�neviId INT,
	turId INT DEFAULT 1 FOREIGN KEY REFERENCES Turler (id) ON DELETE SET DEFAULT,
	FOREIGN KEY (yay�neviId) REFERENCES Yay�nEvleri (id),
	
	

)

GO
INSERT INTO Kitaplar (ad,yazarId,yay�neviId,turId) VALUES
	('Bal�k�� ve O�lu',1,1,2),
	('Vazge�tim',2,3,2),
	('Fatih Harbiye',3,4,3),
	('Kay�p Ev',3,2,4),
	('Su� ve ceza',4,1,2)

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


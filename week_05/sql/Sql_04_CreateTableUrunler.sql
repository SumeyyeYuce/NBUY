USE SampleDb

/*
	�r�nler tablosu
	-id PR�MARY0
	-ad
	-stokMiktar�
	-fiyat
*/

CREATE TABLE Urunler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	stokMiktari INT NOT NULL,
	fiyat MONEY NOT NULL

)
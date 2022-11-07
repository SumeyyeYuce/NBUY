USE SampleDb

/*
	ürünler tablosu
	-id PRÝMARY0
	-ad
	-stokMiktarÝ
	-fiyat
*/

CREATE TABLE Urunler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	stokMiktari INT NOT NULL,
	fiyat MONEY NOT NULL

)
--USE HastaneDb
--SELECT *FROM Bolumler


--USE HastaneDb
--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad as 'AD SOYAD', adres as ADRES FROM Doktorlar

--F�LTRELEME
--SELECT * FROM Doktorlar WHERE id=5 id si 5 olan� getir
--SELECT * FROM Doktorlar WHERE adSoyad='Tuna Sefer' tuna sferi getir
--SELECT * FROM Doktorlar WHERE adSoyad!='Tuna Sefer' tuna sefer hari� hepsini getir
--SELECT * FROM Doktorlar WHERE id=3 OR id=6 id si 3 ve  6 olan� getir
--SELECT * FROM Doktorlar WHERE NOT adSoyad='Tuna Sefer' ADI TUNA SEFER GAR�� OLANLARI GET�R
--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='�zmir'
--SELECT * FROM Doktorlar WHERE id>=6 id si 6 dan b�y�k e�it olan� g�ster
--SELECT*FROM Doktorlar WHERE adres IN ('Ankara','�stanbul')
--SELECT *FROM Doktorlar WHERE adSoyad LIKE 't%' ilk harfi t olsun geri kalan� ne olursa olsun
--SELECT *FROM Doktorlar WHERE adSoyad LIKE 'tut%'
--SELECT *FROM Doktorlar WHERE adSoyad LIKE '%r' sonu r le bitenler 
--SELECT *FROM Doktorlar WHERE adSoyad LIKE '%Evgar'
--SELECT *FROM Doktorlar WHERE adSoyad LIKE '%s%' i�inde s harfi ge�enleri yaz
--SELECT *FROM Doktorlar WHERE adSoyad LIKE '_e%' 
--SELECT *FROM Doktorlar WHERE adSoyad LIKE 'D_m%'  

--SIRALAMA
--SELECT * FROM Doktorlar ORDER BY adSoyad
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC
--SELECT * FROM Doktorlar ORDER BY bolumId DESC
--SELECT * FROM Doktorlar ORDER BY adres DESC
--SELECT * FROM Doktorlar ORDER BY adres, adSoyad DESC

--USE HastaneDb
--SELECT COUNT(*)FROM Doktorlar
--SELECT COUNT(bolumId)FROM Doktorlar


--String i�lemleri
--USE HastaneDb
--SELECT LEN('S�MEYYE Y�CE') TOPLAM KARAKTER UZUNLUGU
--SELECT adSoyad,LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--	adSoyad, 
--	LEFT(adSoyad,3) as 'ilk 3 karakter',
--	LEN(adSoyad) as 'Uzunluk' 
--FROM Doktorlar

--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'B�y�k',
--	LOWER(adSoyad) as 'K���k'
--	FROM Doktorlar


--SELECT 
--	REPLACE('S�meyye Y�ce','m','Merhaba')

	--SELECT
	--LOWER(REPLACE('S�meyye Y�ce',' ','')) + '@benimfirmam.com'


--SELECT
--	adSoyad,
--	REPLACE(LOWER(adSoyad),' ','')+ '@firma.com' as 'Mail Adresi'
--FROM Doktorlar



--sercaan furkan ad�nda amasyada ya��yan b�l�m� 3 olan doktoru kaydedecek sorgyu yaz�n�z
--USE HastaneDb
--INSERT INTO Doktorlar (adSoyad,adres,bolumId) VALUES
--('Sercan Furkan','Amasya',3)

--G�ncellleme
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Sercan Ahmet Furkan'
--WHERE id=12

--S�LME
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id=6

USE HastaneDb
DELETE FROM Doktorlar WHERE bolumId IS NULL
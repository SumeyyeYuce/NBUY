--USE HastaneDb
--SELECT *FROM Bolumler


--USE HastaneDb
--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad as 'AD SOYAD', adres as ADRES FROM Doktorlar

--FÝLTRELEME
--SELECT * FROM Doktorlar WHERE id=5 id si 5 olaný getir
--SELECT * FROM Doktorlar WHERE adSoyad='Tuna Sefer' tuna sferi getir
--SELECT * FROM Doktorlar WHERE adSoyad!='Tuna Sefer' tuna sefer hariç hepsini getir
--SELECT * FROM Doktorlar WHERE id=3 OR id=6 id si 3 ve  6 olaný getir
--SELECT * FROM Doktorlar WHERE NOT adSoyad='Tuna Sefer' ADI TUNA SEFER GARÝÇ OLANLARI GETÝR
--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='Ýzmir'
--SELECT * FROM Doktorlar WHERE id>=6 id si 6 dan büyük eþit olaný göster
--SELECT*FROM Doktorlar WHERE adres IN ('Ankara','Ýstanbul')
--SELECT *FROM Doktorlar WHERE adSoyad LIKE 't%' ilk harfi t olsun geri kalaný ne olursa olsun
--SELECT *FROM Doktorlar WHERE adSoyad LIKE 'tut%'
--SELECT *FROM Doktorlar WHERE adSoyad LIKE '%r' sonu r le bitenler 
--SELECT *FROM Doktorlar WHERE adSoyad LIKE '%Evgar'
--SELECT *FROM Doktorlar WHERE adSoyad LIKE '%s%' içinde s harfi geçenleri yaz
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


--String iþlemleri
--USE HastaneDb
--SELECT LEN('SÜMEYYE YÜCE') TOPLAM KARAKTER UZUNLUGU
--SELECT adSoyad,LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--	adSoyad, 
--	LEFT(adSoyad,3) as 'ilk 3 karakter',
--	LEN(adSoyad) as 'Uzunluk' 
--FROM Doktorlar

--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'Büyük',
--	LOWER(adSoyad) as 'Küçük'
--	FROM Doktorlar


--SELECT 
--	REPLACE('Sümeyye Yüce','m','Merhaba')

	--SELECT
	--LOWER(REPLACE('Sümeyye Yüce',' ','')) + '@benimfirmam.com'


--SELECT
--	adSoyad,
--	REPLACE(LOWER(adSoyad),' ','')+ '@firma.com' as 'Mail Adresi'
--FROM Doktorlar



--sercaan furkan adýnda amasyada yaþýyan bölümü 3 olan doktoru kaydedecek sorgyu yazýnýz
--USE HastaneDb
--INSERT INTO Doktorlar (adSoyad,adres,bolumId) VALUES
--('Sercan Furkan','Amasya',3)

--Güncellleme
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Sercan Ahmet Furkan'
--WHERE id=12

--SÝLME
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id=6

USE HastaneDb
DELETE FROM Doktorlar WHERE bolumId IS NULL
--sayfa say�s� 300 den b�y�k e�it kitaplar� listlele

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300

--stook adeedi 90 ile 113 aras�nda olanlar

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE stok>=90 AND stok<=113
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113

--SAYFA SAYISI EN AZ OLNADAN EN �OK OLANA SIRALA
--USE KutuphaneDb
--SELECT*FROM Kitaplar ORDER BY sayfaSayisi DESC

--T�RE G�RE K���KTEN B�Y��E
--USE KutuphaneDb
--SELECT*FROM Kitaplar ORDER BY turId,sayfaSayisi DESC 
--USE KutuphaneDb
--SELECT * FROM Kitaplar 
--SELECT MIN(sayfaSayisi) as 'En az Sayfa Say�s�' FROM Kitaplar en az de�eri nulur
--SELECT MAX(sayfaSayisi) as 'En Y�ksek Sayfa Say�s�' FROM Kitaplar en y�ksek sayfa say�s�
--SELECT COUNT(*) FROM Kitaplar TOPLAM KAYIT SAYISI
--USE KutuphaneDb
--SELECT AVG(sayfaSayisi) FROM Kitaplar
--SELECT SUM(stok) FROM Kitaplar
--SELECT SUM(stok*sayfaSayisi) FROM Kitaplar

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi=sayfaSayisi * 1.2





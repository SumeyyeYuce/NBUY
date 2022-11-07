--sayfa sayýsý 300 den büyük eþit kitaplarý listlele

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300

--stook adeedi 90 ile 113 arasýnda olanlar

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE stok>=90 AND stok<=113
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113

--SAYFA SAYISI EN AZ OLNADAN EN ÇOK OLANA SIRALA
--USE KutuphaneDb
--SELECT*FROM Kitaplar ORDER BY sayfaSayisi DESC

--TÜRE GÖRE KÜÇÜKTEN BÜYÜÐE
--USE KutuphaneDb
--SELECT*FROM Kitaplar ORDER BY turId,sayfaSayisi DESC 
--USE KutuphaneDb
--SELECT * FROM Kitaplar 
--SELECT MIN(sayfaSayisi) as 'En az Sayfa Sayýsý' FROM Kitaplar en az deðeri nulur
--SELECT MAX(sayfaSayisi) as 'En Yüksek Sayfa Sayýsý' FROM Kitaplar en yüksek sayfa sayýsý
--SELECT COUNT(*) FROM Kitaplar TOPLAM KAYIT SAYISI
--USE KutuphaneDb
--SELECT AVG(sayfaSayisi) FROM Kitaplar
--SELECT SUM(stok) FROM Kitaplar
--SELECT SUM(stok*sayfaSayisi) FROM Kitaplar

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi=sayfaSayisi * 1.2





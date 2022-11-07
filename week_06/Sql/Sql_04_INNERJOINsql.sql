--PRODUT TABLOSUNU UNÝT PRÝCE KOLONUNA GÖRE BÜYÜKTEN KÜÇÜGE SIRALA
--USE Northwind
--SELECT * FROM Products ORDER BY UnitPrice DESC

--FÝYATI 100 TL NÝN ÜZERÝNDE OLANI 
--USE Northwind
--SELECT * FROM Products WHERE UnitPrice>=100

--KATEGORÝSÝ 7 VE 8 OLAN ÜRÜNLERÝ LÝSTELE (UNÝTSTOK) <=10 OLAN ÜRÜNLERÝ LÝSTELE
--USE Northwind
--SELECT * FROM Products WHERE (CategoryID=7 OR CategoryID=8)  AND UnitsInStock<=10

--KATEGORÝSÝ 7 VE 8 OLANLARDAN STOK MÝKTARI (UNÝTSTOK) <=10 OLAN ÜRÜNELRÝN SAYISI
USE Northwind
--SELECT COUNT(*) FROM Products WHERE (CategoryID=7 OR CategoryID=8)  AND UnitsInStock<=10 
--SELECT COUNT(*) FROM Products WHERE (CategoryID=9 OR CategoryID=3)  AND UnitsInStock<=50 

--INNER JOIN
 --SELECT Products.ProductName,Categories.CategoryName FROM Products INNER JOIN Categories
	--ON Products.CategoryID=Categories.CategoryID

--SELECT P.ProductName,C.CategoryName
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID

--SELECT P.ProductName, C.CategoryName,P.UnitPrice
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID = C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice<=40
--ORDER BY P.UnitPrice DESC

--PRODCTNAME VE SUPPLIERCOMPANY NAME Ý GÖSTEREN SORGU
--SELECT P.ProductName,S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID=S.SupplierID

--GERMANY DEN GELEN ÜRÜNLERÝN PRODUCTLAR GÖZÜKSÜN
--SELECT P.ProductName 
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID 
--WHERE S.Country='Germany'

--GERMANY DEN GELEN ÜRÜNLERÝN toplam tutarý PRODUCTLAR GÖZÜKSÜN
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID 
--WHERE S.Country='Sweden'

--CHAÝE SATIÞLARININ TOPLMA TUTARI
--SELECT SUM(OD.UnitPrice * OD.Quantity) 
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID =OD.ProductID
--WHERE P.ProductName='Chai'

--germany de yapýlmýþ olan CHAÝE SATIÞLARININ TOPLMA TUTARI
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID =OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'

--Ernst HANDEL MÜÞTERÝSÝNE YAPILAN SATIÞ TUTARININ TOPLAMI
SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID=O.OrderID INNER JOIN Customers C
ON O.CustomerID=C.CustomerID
WHERE C.CompanyName='Ernst Handel'

 
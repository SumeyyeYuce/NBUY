--PRODUT TABLOSUNU UN�T PR�CE KOLONUNA G�RE B�Y�KTEN K���GE SIRALA
--USE Northwind
--SELECT * FROM Products ORDER BY UnitPrice DESC

--F�YATI 100 TL N�N �ZER�NDE OLANI 
--USE Northwind
--SELECT * FROM Products WHERE UnitPrice>=100

--KATEGOR�S� 7 VE 8 OLAN �R�NLER� L�STELE (UN�TSTOK) <=10 OLAN �R�NLER� L�STELE
--USE Northwind
--SELECT * FROM Products WHERE (CategoryID=7 OR CategoryID=8)  AND UnitsInStock<=10

--KATEGOR�S� 7 VE 8 OLANLARDAN STOK M�KTARI (UN�TSTOK) <=10 OLAN �R�NELR�N SAYISI
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

--PRODCTNAME VE SUPPLIERCOMPANY NAME � G�STEREN SORGU
--SELECT P.ProductName,S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID=S.SupplierID

--GERMANY DEN GELEN �R�NLER�N PRODUCTLAR G�Z�KS�N
--SELECT P.ProductName 
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID 
--WHERE S.Country='Germany'

--GERMANY DEN GELEN �R�NLER�N toplam tutar� PRODUCTLAR G�Z�KS�N
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID 
--WHERE S.Country='Sweden'

--CHA�E SATI�LARININ TOPLMA TUTARI
--SELECT SUM(OD.UnitPrice * OD.Quantity) 
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID =OD.ProductID
--WHERE P.ProductName='Chai'

--germany de yap�lm�� olan CHA�E SATI�LARININ TOPLMA TUTARI
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID =OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'

--Ernst HANDEL M��TER�S�NE YAPILAN SATI� TUTARININ TOPLAMI
SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID=O.OrderID INNER JOIN Customers C
ON O.CustomerID=C.CustomerID
WHERE C.CompanyName='Ernst Handel'

 
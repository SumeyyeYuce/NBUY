USE Northwind

--SELECT * FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID

--SOLDAKÝ
--SELECT C.CompanyName FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL

--SAGDAKÝ TABLODU KÝ TÜM KAYITLAR GELÝR VE SOLDAKÝLELE EÞLEÞENLER
--SELECT C.CompanyName FROM Orders O RIGHT JOIN  Customers C
--SELECT P.ProductName,OD.ProductID FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL

--HENÜZ HÝÇ SATILMAMIÞ ÜRÜNLER
--SELECT P.ProductName  FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--HENÜZ SATIÞ YAPAMAMIÞ ÇALIÞANLARI LÝSTELE
SELECT E.FirstName + ' ' + E.LastName as 'AD SOYAD' FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID=O.EmployeeID
WHERE O.EmployeeID IS NULL

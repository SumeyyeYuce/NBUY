USE Northwind

--SELECT * FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID

--SOLDAK�
--SELECT C.CompanyName FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL

--SAGDAK� TABLODU K� T�M KAYITLAR GEL�R VE SOLDAK�LELE E�LE�ENLER
--SELECT C.CompanyName FROM Orders O RIGHT JOIN  Customers C
--SELECT P.ProductName,OD.ProductID FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL

--HEN�Z H�� SATILMAMI� �R�NLER
--SELECT P.ProductName  FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--HEN�Z SATI� YAPAMAMI� �ALI�ANLARI L�STELE
SELECT E.FirstName + ' ' + E.LastName as 'AD SOYAD' FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID=O.EmployeeID
WHERE O.EmployeeID IS NULL

USE Northwind
--DISTINCT PRODCT TABLOSUNDAK› DEFALARCA GE«EN ›D Y› TEKE D‹ﬁ‹RD‹
--SELECT DISTINCT CategoryId FROM Products

--sat˝˛ yap˝lan ¸lkeler
--1)BUGUNE KAFAR HANG› ‹LKERLER KARGO G÷NDERM›ﬁ›Z
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--2)HANG› ‹LKEYE NE KADAR SATIﬁ YAPMIﬁIZ
--SELECT O.ShipCountry, SUM(OD.Quantity * OD.UnitPrice) as 'Toplam tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

--3)EN «OK SATIﬁ YAPILAN 3 ‹LKE (TOP ›LE YAPTIK BUNU)
--SELECT TOP(3) O.ShipCountry, SUM(OD.Quantity * OD.UnitPrice) as 'Toplam tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

--4)EL›M›ZDE EN «OK STOGU BULUNUNAN ›LK 3 ‹R‹N
--SELECT TOP(3) P.ProductName,P.UnitsInStock FROM Products P
--ORDER BY P.UnitsInStock DESC

--5)HANG› KATEGOR›DE KA« ADET ‹R‹N‹M‹Z VAR
--SELECT C.CategoryName,COUNT(*) as 'Adet' FROM  Categories C INNER JOIN Products P
--ON C.CategoryID=P.CategoryID
--GROUP BY C.CategoryName
--HAVING COUNT(*)>10
--ORDER BY Adet DESC

--6)HANG› ‹R‹NDEN KA« TANE SATILMIﬁTIR
--SELECT P.ProductName,COUNT(*) as 'Adet' FROM Products P  INNER JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Adet DESC



--7)EN «OK KAZAANDIRAN ›LK 3 ‹R‹N HANG›S›
--SELECT TOP(3) P.ProductName,SUM(OD.Quantity*OD.UnitPrice) as 'TOTAL' FROM Products P  INNER JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY TOTAL DESC


--8)HANG› KARGO ﬁ›RKE›NE NE KADAR ÷DEME YAPILMIﬁTIR(FREE›GHT)
--SELECT  S.CompanyName,SUM(O.Freight) as 'Total' FROM Shippers S  INNER JOIN  Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total DESC

--9)
--SELECT TOP(1)  S.CompanyName,SUM(O.Freight) as 'Total' FROM Shippers S  INNER JOIN  Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total

--10) HANG› M‹ﬁTER›YE NE KADAR TUTARINDA SATIﬁ YAPILMIﬁ
--SELECT C.CompanyName,SUM(OD.Quantity*OD.UnitPrice) as 'TOTAL' 
--FROM Customers C 
--INNER JOIN Orders O ON C.CustomerID=O.CustomerID 
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC

--11)B÷LGELERE G÷RE SATIﬁ TUTARLARINI BUL
--SELECT R.RegionDescription,SUM(OD.Quantity * OD.UnitPrice) as 'TOTAL' FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON T.RegionID=R.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC

--12)HANG› B÷LGEDE, HANG› ‹R‹‹NDEN KA« PARALIK SATIﬁ YAPILMﬁTIR
SELECT R.RegionDescription,P.ProductName,SUM(OD.Quantity * OD.UnitPrice) as 'TOTAL' FROM Employees E 
INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID
INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
INNER JOIN Region R ON T.RegionID=R.RegionID
INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
INNER JOIN Products P ON OD.ProductID=P.ProductID
GROUP BY R.RegionDescription,P.ProductName
ORDER BY R.RegionDescription,P.ProductName, TOTAL DESC

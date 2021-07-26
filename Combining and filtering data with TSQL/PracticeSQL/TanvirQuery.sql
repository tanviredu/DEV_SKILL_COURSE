USE Northwind;
SELECT FirstName,LastName FROM Employees;
-- concatenation

-- CONCAT AND CONCAT_WITH_SEPARATOR WILL CONVERT NULL INTO EMPTY STRING
SELECT CONCAT_WS(' ',FirstName,LastName) as FullName FROM Employees;
SELECT CONCAT(FirstName,' ',LastName) AS FULLNAME FROM Employees;
SELECT CONCAT(NULL,FirstName) AS FULLNAME FROM Employees;


-- CONVERTING DATATYPE
-- CAST AND CONVERT

SELECT GETDATE();

SELECT CAST(GETDATE() AS varchar);
SELECT CAST(GETDATE() AS varchar(11)) AS CurrentDate;


--return null if failed to cast datatype
-- CAST IN ANSI STANDERD 
-- CONVERT IS NOT 
-- TRY TO USE CAST
SELECT TRY_CAST('HELLO WORLD' AS int);

-- FORMATTING STRING

SELECT * FROM EmployeesUppercase;
SELECT trim(FirstName),LastName FROM EmployeesUppercase;


-- MAKE THE FIRST CHARACTER UPPER CASE
-- AND THE REST IS LOWER CASE

SELECT SUBSTRING(trim(FirstName),1,1) FROM EmployeesUppercase;

SELECT 
CONCAT(
		UPPER(
			SUBSTRING(
				TRIM(FirstName),1,1)),
		LOWER(
			SUBSTRING(
				TRIM(FirstName),2,LEN(FirstName)))) 
		AS FIRSTNAME,

CONCAT(
		UPPER(
			SUBSTRING(
				TRIM(LastName),1,1)),
		LOWER(
			SUBSTRING(
				TRIM(LastName),2,LEN(LastName)))) AS LASTNAME

FROM EmployeesUppercase;


-- CASE STATEMENT

SELECT CASE WHEN 1 > 0 THEN 
		'1 is greater then 0'
	ELSE 
		'1 equals 1'
		END AS result;


SELECT GETDATE();
SELECT CAST(GETDATE() AS varchar);
SELECT FORMAT(GETDATE(),'MM/dd/yyyy');
SELECT FORMAT(GETDATE(),'M/d/y');
SELECT FORMAT(GETDATE(),'dd/MM/yyyy');



--JOIN QUERY

SELECT * FROM Orders; -- returns all the order
SELECT * FROM [Order Details]; -- returns all the details of different order

-- ORDER_ID AND ORDER_DETAILS HAS ONE TO MANY RELATIONSHIP
-- MULTIPLE PRODUCT CAN BE IN 1 ORDER
-- MULTIPLE RECORD IS POSSIBLE IN ORDERDETAILS IN ORDERDETAILS

SELECT O.CustomerID, ProductID FROM Orders O JOIN [Order Details] OD
ON O.OrderID = OD.OrderID;

SELECT OrderID,CustomerID FROM Orders;
SELECT OrderID,ProductID,Quantity FROM [Order Details];
SELECT * FROM Products;


SELECT CustomerID,P.ProductName,Quantity FROM Orders O INNER JOIN [Order Details] OD
ON O.OrderID = OD.OrderID
INNER JOIN Products P
ON P.ProductID = OD.ProductID;


SELECT O.CustomerID,OD.ProductID,P.ProductName ,O.OrderID FROM Orders O INNER JOIN [Order Details] OD 
		ON O.OrderID = OD.OrderID
		INNER JOIN
		Products P
		ON P.ProductID = OD.ProductID;


-- SELF JOIN

SELECT * FROM Employees;

-- Find the managers
-- REMEMBER IT IS A SELF JOIN BECAUSE
-- MANAGERS IS ALSO EMPLOYEES

SELECT CONCAT_WS(' ',mgrs.FirstName,mgrs.LastName) AS Managers FROM
Employees emps JOIN Employees mgrs 
On emps.ReportsTo = mgrs.EmployeeID;

SELECT * FROM Employees;

SELECT * FROM Employees WHERE Title='Sales Representative' OR City='London';

SELECT * FROM Employees WHERE City in ('London');

SELECT * FROM Employees WHERE City not in ('London');


--SUB QUERY

SELECT * FROM Orders WHERE OrderID in(SELECT OrderID FROM [Order Details]);
SELECT CustomerID FROM Orders WHERE OrderID in(SELECT OrderID FROM [Order Details]);

SELECT * FROM Orders ORDER BY OrderID;
SELECT * FROM Orders ORDER BY OrderID DESC;

SELECT * FROM Products WHERE ProductName LIKE '%c%';
SELECT * FROM Products WHERE ProductName not LIKE '%c%';


-- LIMITING THE RESULTS WITH TSQL FUNCTION
-- YOU CAN LIMIT THE RESULT WITH THE TOP FUNCTION
SELECT TOP(10) * FROM Customers;
SELECT TOP(10) * FROM Orders;

SELECT TOP(5) * FROM Customers;
SELECT TOP(5) * FROM Orders;

-- FIND THE CUSTOMER NAME AND ID WHO ACTUALLY ORDER SOMETHING
-- MEANS THE WHOSE CUSTOMER ID IS IN THE ORDER TABLE
SELECT C.CustomerID,C.ContactName,O.OrderID FROM Customers C JOIN Orders O ON
C.CustomerID=O.CustomerID;

SELECT TOP(5) * FROM Products;
SELECT TOP(10) PERCENT *  FROM Customers;


-- AGGREGATE DATA IN  A QUERY
-- SELECT NUMBER IF ROWS IN CUSTOMER AND ORDER AND CUSTOMER
SELECT COUNT(*) FROM Customers;
SELECT COUNT(*) FROM Orders;
SELECT COUNT(*) FROM Products;

SELECT COUNT(*) FROM Orders;
SELECT DISTINCT COUNT(OrderID) FROM Orders;
SELECT TOP(2) * FROM Products;


SELECT * FROM Products P LEFT JOIN [Order Details] OD 
ON P.ProductID = OD.ProductID
LEFT JOIN Orders O 
ON OD.OrderID = O.OrderID;


--UNION

SELECT TOP(3) CompanyName From Customers
UNION ALL
SELECT TOP(3) FirstName FROM Employees;

--INTERSECT

SELECt DISTINCT o.OrderID FROM Orders o JOIN [Order Details] od
ON o.OrderID = od.OrderID;

SELECT OrderID FROM Orders WHERE OrderID IN(SELECT OrderID FROM [Order Details]);

SELECT OrderID FROM Orders
INTERSECT
SELECT OrderID FROM [Order Details];


--TEMPORARY ABLE
 -- TMP IS THE TEMPORARY TABLE
 -- THAT IS CREATED FROM CUSTOMER TABLE
 -- AFTER RUNNING QUERY 
 -- WE DROP THE TABLE
SELECT COUNT(*) AS CUSTOMERCOUNT
INTO #tmp
FROM Customers;
SELECT * FROM #tmp;
DROP TABLE #tmp;

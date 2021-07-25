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

SELECT CONCAT_WS(' ',mgrs.FirstName,mgrs.LastName) AS Managers FROM
Employees emps JOIN Employees mgrs 
On emps.ReportsTo = mgrs.EmployeeID;

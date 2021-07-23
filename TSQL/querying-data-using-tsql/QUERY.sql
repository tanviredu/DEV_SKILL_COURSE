USE TSQLDemoDB;
SELECT Customer FROM Customers;
SELECT *, 'PLUIRALSIGHT' FROM Customers;
SELECT OrderID,OrderDate, Customer as CLIENT FROM Orders;
SELECT * FROM Orders;

SELECT * FROM Customers AS C
			  INNER JOIN 
			  Orders AS O
			  ON C.Customer = O.Customer;

SELECT * FROM Customers AS C
			  INNER JOIN 
			  Orders AS O
			  ON 1=1;

SELECT Country FROM Customers AS C INNER JOIN Orders AS O
ON C.Customer = O.Customer;

SELECT * FROM Customers AS C LEFT OUTER JOIN Orders AS O
ON C.Customer = O.Customer;

SELECT * FROM Customers AS C  LEFT OUTER JOIN Orders AS O
ON C.Customer = O.Customer;

SELECT * FROM Customers WHERE Country = NULL;
SELECT * FROM Customers WHERE Country is NULL;

SELECT * FROM Orders WHERE OrderDate BETWEEN '20190101' AND '20190115'

SELECT * FROM Customers WHERE Country BETWEEN 'A'AND 'Z';

SELECT * FROM Items WHERE Item Like 'A%';
SELECT * FROM Items WHERE Item Like '%n%';

SELECT Country,COUNT(Country) FROM Customers WHERE Country IS NOT NULL
GROUP BY Country;

SELECT DISTINCT Country FROM Customers;

SELECT TOP(5) WITH TIES OrderID FROM Orders Order By OrderDate DESC;


SELECT * FROM OrderItems;
SELECT OrderID,Item,Price FROM OrderItems ORDER BY Price DESC;

SELECT Item,SUM(Quantity) as NumberofItemsSold From OrderItems Group By Item
ORDER BY NumberofItemsSold Desc;
CREATE TABLE Students(
Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
Name nvarchar(250) NOT NULL,
DateOfBirth Datetime,
CGPA Decimal(18,2),
)

-- IN SQLSERVER IDENTITY(1,1)
-- IS THE AUTO_INCREMENT 
-- OF ANOTHER DATABASE

-- insert value in the Table



CREATE TABLE Customers(
	Id INT PRIMARY KEY AUTO_INCREMENT,
    Name varchar(50)
);

Create TABLE Orders(
	Id INT PRIMARY KEY AUTO_INCREMENT,
    CustomerId INT NOT NULL,
    foreign key (CustomerId) REFERENCES Customers(Id)
);

SELECT Name AS Customers 
FROM Customers LEFT JOIN Orders ON Orders.CustomerId = Customers.Id
WHERE Orders.Id is null


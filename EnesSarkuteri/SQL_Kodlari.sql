CREATE PROC SP_GetCustomerList
AS
SELECT * FROM Customers

INSERT INTO Customers 
(CustomerID, CompanyName)
VALUES
('VDT','vvvvvvvvvvv')

SELECT Country FROM Customers
WHERE Country is not null
GROUP BY Country

CREATE VIEW GetCountryList
AS
SELECT DISTINCT Country FROM Customers
WHERE Country is not null


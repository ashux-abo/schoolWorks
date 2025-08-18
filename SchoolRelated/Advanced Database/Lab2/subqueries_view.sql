CREATE VIEW Subqueries_View AS
WITH BadangPrice AS (
    SELECT I.Price
    FROM Orders O
    JOIN Customers C ON O.CustomerID = C.CustomerID
    JOIN Items I ON O.ItemID = I.ItemID
    WHERE C.Cust_Name = 'Badang'
)
SELECT 
    'Lab_' + CAST(O.OrderID AS VARCHAR) AS New_OrderID,
    C.Cust_Name,
    C.Address,
    I.ItemName,
    I.Price
FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
JOIN Items I ON O.ItemID = I.ItemID
WHERE I.Price > (SELECT Price FROM BadangPrice);
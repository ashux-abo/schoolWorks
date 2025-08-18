WITH BadangPrice AS (
    SELECT I.Price
    FROM Orders O
    JOIN Customers C ON O.CustomerID = C.CustomerID
    JOIN Items I ON O.ItemID = I.ItemID
    WHERE C.Cust_Name = 'Badang'
)
SELECT C.Cust_Name, I.ItemName, I.Price
FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID
JOIN Items I ON O.ItemID = I.ItemID
WHERE I.Price > (SELECT Price FROM BadangPrice)
ORDER BY I.Price;
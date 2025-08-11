USE LabDB;
 
CREATE TABLE Records(
Id int, 
LastName varchar(99),
FirstName varchar(99),
Age int,
Gender varchar(99),
Level varchar(99),
)
INSERT INTO Records (Id, LastName, FirstName, Age,Gender,Level)
VALUES 
(1, 'Santos', 'Mark Anthony', 17, 'Male', 'Freshman'),
(2, 'Nonat', 'Jayson', 15, 'Male', 'Sophomore'),
(3, 'Valencia', 'Nicole', 20, 'Female', 'Senior'),
(4, 'Campos', 'Jane', 19, 'Female', 'Junior'),
(5, 'Morales', 'Micah', 21, 'Female', 'Senior'),
(6, 'Atienza', 'Eldibert', 17, 'Male', 'Sopohomore'),
(7, 'Dela Cruz', 'Philip', 16, 'Male', 'Freshman'),
(8, 'Ramos', 'Loisa', 21, 'Female', 'Senior'),
(9, 'Galang', 'Orlean', 18, 'Male', 'Junior'),
(10, 'Detera', 'Chin', 16, 'Female', 'Freshman');
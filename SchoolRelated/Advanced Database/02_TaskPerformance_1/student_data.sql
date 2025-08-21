use DB_Sample
INSERT INTO Students(ID, Name, LeaderID)
VALUES
(1, 'Baldo', Null),
(2, 'Cardo', 1), --Baldo's children
(3, 'Pedro', 1),
(4, 'Luningning', 1),
(5, 'Paolo', 2), --Cardo's branch
(6, 'Bernardo', 5),
(7, 'Reginaldo', 6),
(8, 'Roberto', 3), --Pedro's branch
(9, 'Narciso', 3),
(10, 'Jopay', 4), --Luningning's branch 
(11, 'Policarpio', 10),
(12, 'Sisa', 10);

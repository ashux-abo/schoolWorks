USE LabDB;
BEGIN
	DECLARE @ReturningAge int;
	DECLARE @Level varchar(99);
	DECLARE @id int;
	DECLARE @Lastname varchar(99);
	DECLARE @Firstname varchar(99);
	DECLARE @Gender varchar(99)
	DECLARE @Number int = 1;

	WHILE @Number <= 10
	BEGIN
	    SELECT 
        @Level = Level,
        @ReturningAge = Age,
        @id = Id,
        @Lastname = LastName,
        @Firstname = FirstName,
        @Gender = Gender
		FROM Records WHERE Id = @Number;

		SET @Level = CASE
			WHEN @ReturningAge >= 14 AND @ReturningAge <= 16 THEN 'FRESHMAN'
            WHEN @ReturningAge >= 17 AND @ReturningAge <= 19 THEN 'SOPHOMORE'
            WHEN @ReturningAge >= 20 AND @ReturningAge <= 22 THEN 'JUNIOR'
            WHEN @ReturningAge >= 23 AND @ReturningAge <= 25 THEN 'SENIOR'
            ELSE 'UNKNOWN'
		END;

		UPDATE Records
        SET Level = @Level
        WHERE Id = @Number;

		PRINT 'Id: ' + CAST(@id AS VARCHAR(20)) + ' | ' + 
		'Name: ' + @Firstname + SPACE(1) + @LastName + ' | ' 
		+ 'Age: ' + CAST(@ReturningAge as VARCHAR(20)) + ' | ' 
		+ 'Gender: ' + @Gender + ' | ' + 'Level: ' + @Level;
		SET @Number = @Number + 1;
	END
END

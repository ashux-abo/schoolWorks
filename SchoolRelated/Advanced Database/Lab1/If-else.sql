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
		FROM Records
		WHERE Id = @Number;
 
		IF @ReturningAge >= 14 AND @ReturningAge <=16
			BEGIN
			 UPDATE Records
			 SET Level = LOWER ('Freshman') WHERE @id = iD;
			END
		ELSE IF @ReturningAge >=17 AND @ReturningAge <=19
			BEGIN
			UPDATE Records
			SET Level = LOWER ('Sophomore') WHERE @id = iD;
			END
		ELSE IF @ReturningAge >= 20 AND @ReturningAge <= 22
			BEGIN
			UPDATE Records
			SET Level = LOWER ('Junior') WHERE @id = iD;
			END
		ELSE IF @ReturningAge >=23 AND @ReturningAge <=25
			BEGIN
			UPDATE Records
			SET LEVEL = LOWER('Senior') WHERE @id = iD;
			END
		ELSE
			BEGIN
			UPDATE Records
			SET LEVEL = 'Unknown'WHERE @id = iD;
			END
			
		PRINT 'Id: ' + CAST(@id AS VARCHAR(20)) + ' | ' + 
		'Name: ' + @Firstname + SPACE(1) + @LastName + ' | ' 
		+ 'Age: ' + CAST(@ReturningAge as VARCHAR(20)) + ' | ' 
		+ 'Gender: ' + @Gender + ' | ' + 'Level: ' + @Level;
		SET @Number = @Number + 1;
	END
END
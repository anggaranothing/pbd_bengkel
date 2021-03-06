USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[User_SetPasswordByName]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_SetPasswordByName]
(
	-- Add the parameters for the function here
	@name varchar(32),
	@passwd varchar(64)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @name = LTRIM(@name);
	set @name = RTRIM(@name);
	set @passwd = LTRIM(@passwd);
	set @passwd = RTRIM(@passwd);

	if @name = '' set @name = null
	if @passwd = '' set @passwd = null

	IF @name is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "username" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE
	IF @passwd is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "passwd" tidak boleh kosong', 16, 1);
		RETURN;
	END

	UPDATE [dbo].[USER]
	SET 
	[passwd] = @passwd, [date_modified] = CURRENT_TIMESTAMP
	WHERE 
	[username] = @name
COMMIT TRAN
GO

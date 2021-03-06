USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[User_Insert]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_Insert]
(
	@nama varchar(32),
	@passwd varchar(64),
	@role int
)
AS
SET NOCOUNT OFF
BEGIN TRAN
	set @nama = LTRIM(@nama);
	set @nama = RTRIM(@nama);
	set @passwd = LTRIM(@passwd);
	set @passwd = RTRIM(@passwd);

	if @nama = '' set @nama = null
	if @passwd = '' set @passwd = null

	IF @nama is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "username" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @passwd is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "passwd" tidak boleh kosong', 16, 1);
		RETURN;
	END

	INSERT INTO [USER](username,passwd,role) VALUES(@nama,@passwd,@role);
COMMIT TRAN
GO

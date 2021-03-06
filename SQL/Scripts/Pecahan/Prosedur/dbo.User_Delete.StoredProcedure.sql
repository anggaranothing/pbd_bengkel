USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[User_Delete]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_Delete]
(
	@nama varchar(32)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @nama = ''  set @nama = null
	IF @nama is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "nama" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [USER] WHERE [username] = @nama
COMMIT TRAN
GO

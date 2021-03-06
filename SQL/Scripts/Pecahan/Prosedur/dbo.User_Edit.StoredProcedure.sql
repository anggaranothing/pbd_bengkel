USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[User_Edit]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_Edit]
(
	@nama_asli varchar(32),
	@nama_baru varchar(32),
	@role int
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @nama_baru = LTRIM(@nama_baru);
	set @nama_baru = RTRIM(@nama_baru);

	if @nama_baru = '' set @nama_baru = null

	IF @nama_baru is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "username" tidak boleh kosong', 16, 1);
		RETURN;
	END

	UPDATE [dbo].[USER]
	SET 
	[username] = @nama_baru, [role] = @role, [date_modified] = CURRENT_TIMESTAMP
	WHERE 
	[username] = @nama_asli
COMMIT TRAN
GO

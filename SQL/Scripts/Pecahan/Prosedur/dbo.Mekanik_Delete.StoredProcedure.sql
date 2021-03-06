USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_Delete]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mekanik_Delete]
(
	@kode char(8)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @kode = ''  set @kode = null
	IF @kode is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [dbo].[MONTIR] WHERE [kode] = @kode
COMMIT TRAN
GO

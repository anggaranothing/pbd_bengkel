USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Delete]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Trans_Delete]
(
	@no_nota char(10)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @no_nota = ''  set @no_nota = null
	IF @no_nota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [dbo].[TRANSAKSI] WHERE [no_nota] = @no_nota
COMMIT TRAN
GO

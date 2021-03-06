USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Delete]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kendaraan_Delete]
(
	@nopol varchar(12)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @nopol = LTRIM(@nopol)
	set @nopol = RTRIM(@nopol)

	if @nopol = ''  set @nopol = null

	IF @nopol is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "nopol" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [KENDARAAN] WHERE [nopol] = @nopol
COMMIT TRAN
GO

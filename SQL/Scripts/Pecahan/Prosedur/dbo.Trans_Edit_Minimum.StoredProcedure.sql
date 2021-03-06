USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Edit_Minimum]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Trans_Edit_Minimum]
(
	@no_nota char(10),
	@tgl_lunas datetime,
	@bayar_kurang money,
	@ket text
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @no_nota = LTRIM(@no_nota)
	set @no_nota = RTRIM(@no_nota)

	IF @no_nota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END

	IF @bayar_kurang > 0
		SET @tgl_lunas = NULL
	ELSE
	IF @bayar_kurang = 0
		SET @bayar_kurang = NULL

	UPDATE [dbo].[TRANSAKSI]
	SET 
		[tgl_lunas] = @tgl_lunas,
		[bayar_kurang] = @bayar_kurang,
		[ket] = @ket
	WHERE 
	[no_nota] = @no_nota
COMMIT TRAN
GO

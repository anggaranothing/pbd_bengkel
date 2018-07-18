USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Jasa_Edit]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Jasa_Edit]
(
	@kode char(8),
	@nama varchar(64),
	@harga money,
	@waktu_menit decimal(18,0)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @nama = LTRIM(@nama)
	set @nama = RTRIM(@nama)

	if @kode = ''  set @kode = null
	if @nama = '' set @nama = null
	if @waktu_menit <= 0 set @waktu_menit = null

	IF @kode is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @nama is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "nama" tidak boleh kosong', 16, 1);
		RETURN;
	END

	UPDATE [dbo].[JASA] 
	SET 
	[nama] = @nama, [harga] = @harga, [waktu_menit] = @waktu_menit
	WHERE 
	[kode] = @kode
COMMIT TRAN
GO

USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_Edit]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Mekanik_Edit]
(
	@kode char(8),
	@nama varchar(128),
	@alamat varchar(128),
	@telepon varchar(16),
	@status bit
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @nama = LTRIM(@nama)
	set @nama = RTRIM(@nama)
	set @alamat = LTRIM(@alamat)
	set @alamat = RTRIM(@alamat)
	set @telepon = LTRIM(@telepon)
	set @telepon = RTRIM(@telepon)

	if @kode = ''  set @kode = null
	if @nama = '' set @nama = null
	if @alamat = '' set @alamat = null
	if @telepon = '' set @telepon = null

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

	UPDATE [dbo].[MONTIR] 
	SET 
	[nama] = @nama, [alamat] = @alamat, [telepon] = @telepon, [status] = @status 
	WHERE 
	[kode] = @kode
COMMIT TRAN
GO

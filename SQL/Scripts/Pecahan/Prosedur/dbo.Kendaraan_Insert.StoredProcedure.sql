USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Insert]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Kendaraan_Insert]
(
	@nopol varchar(12),
	@nama varchar(64),
	@tahun char(4),
	@stnk varchar(20)
)
AS
SET NOCOUNT OFF
BEGIN TRAN
	set @nopol = LTRIM(@nopol)
	set @nopol = RTRIM(@nopol)
	set @nama = LTRIM(@nama)
	set @nama = RTRIM(@nama)
	set @tahun = LTRIM(@tahun)
	set @tahun = RTRIM(@tahun)
	set @stnk = LTRIM(@stnk)
	set @stnk = RTRIM(@stnk)

	if @nopol = ''  set @nopol = null
	if @nama = '' set @nama = null
	if @tahun = '' set @tahun = null
	if @stnk = '' set @stnk = null

	IF @nopol is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "nopol" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @nama is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "nama" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @tahun is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "tahun" tidak boleh kosong', 16, 1);
		RETURN;
	END

	INSERT INTO [KENDARAAN] VALUES (@nopol, @nama, @tahun, @stnk);
COMMIT TRAN
GO

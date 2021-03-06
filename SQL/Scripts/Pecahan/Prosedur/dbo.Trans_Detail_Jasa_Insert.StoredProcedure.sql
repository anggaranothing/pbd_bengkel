USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Jasa_Insert]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Trans_Detail_Jasa_Insert]
(
	@no_nota char(10),
	@kode_jasa char(8),
	@harga_jasa money,
	@tgl_mulai datetime,
	@tgl_selesai datetime,
	@diskon int
)
AS
SET NOCOUNT OFF
SET XACT_ABORT ON
BEGIN TRAN
	set @no_nota = LTRIM(@no_nota)
	set @no_nota = RTRIM(@no_nota)
	set @kode_jasa = LTRIM(@kode_jasa)
	set @kode_jasa = RTRIM(@kode_jasa)

	IF @no_nota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @kode_jasa is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode_jasa" tidak boleh kosong', 16, 1);
		RETURN;
	END

	-- Ubah tanggal jd null klo jasa tidak pakai batasan waktu
	DECLARE @waktuPerMenit DECIMAL;
	SELECT @waktuPerMenit = [waktu_menit] FROM [JASA] WHERE [kode] = @kode_jasa;
	IF @waktuPerMenit IS NULL OR @waktuPerMenit <= 0
	BEGIN
		SET @tgl_mulai = NULL;
		SET @tgl_selesai = NULL;
	END

	INSERT INTO [TRANSAKSI_DETAIL_JASA] VALUES (@no_nota, @kode_jasa, @harga_jasa, @tgl_mulai, @tgl_selesai, @diskon);
COMMIT TRAN
GO

USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Insert]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Trans_Insert]
(
	@no_nota char(10) = NULL,
	@kode_plg char(8),
	@kode_mk char(8) = NULL,
	@nopol varchar(12) = NULL,
	@tgl_buat datetime = NULL,
	@tgl_lunas datetime = NULL,
	@bayar_kurang money = NULL,
	@ket text = NULL
)
AS
SET NOCOUNT OFF
BEGIN TRAN
	set @no_nota = LTRIM(@no_nota)
	set @no_nota = RTRIM(@no_nota)
	set @kode_mk = LTRIM(@kode_mk)
	set @kode_mk = RTRIM(@kode_mk)
	set @nopol = LTRIM(@nopol)
	set @nopol = RTRIM(@nopol)

	if @kode_mk = ''  set @kode_mk = null
	if @nopol = '' set @nopol = null
	if @bayar_kurang <= 0 set @bayar_kurang = null

	if @no_nota IS NULL OR @no_nota = '' set @no_nota = [dbo].[KODETRANS]()
	if @tgl_buat IS NULL OR @tgl_buat = '' set @tgl_buat = GETDATE()

	IF @no_nota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @kode_plg is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode_plg" tidak boleh kosong', 16, 1);
		RETURN;
	END

	INSERT INTO [TRANSAKSI] VALUES (@no_nota, @kode_plg, @kode_mk, @nopol, @tgl_buat, @tgl_lunas, @bayar_kurang, @ket);
COMMIT TRAN
GO

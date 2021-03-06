USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Barang_Insert]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Trans_Detail_Barang_Insert]
(
	@no_nota char(10),
	@kode_brg char(8),
	@harga_brg money,
	@jumlah int,
	@diskon int
)
AS
SET NOCOUNT OFF
SET XACT_ABORT ON
BEGIN TRAN
	set @no_nota = LTRIM(@no_nota)
	set @no_nota = RTRIM(@no_nota)
	set @kode_brg = LTRIM(@kode_brg)
	set @kode_brg = RTRIM(@kode_brg)

	if @no_nota = '' set @no_nota = NULL;
	if @kode_brg = '' set @kode_brg = NULL;

	IF @no_nota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @kode_brg is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode_brg" tidak boleh kosong', 16, 1);
		RETURN;
	END

	-- Error jika stok tidak cukup
	DECLARE @stok INT, @sisa INT;
	SELECT @stok = [stok] FROM [BARANG] WHERE [kode] = @kode_brg;
	SET @sisa = @stok - @jumlah
	IF @sisa < 0
	BEGIN
		ROLLBACK;
		RAISERROR('Stok barang tidak cukup', 16, 1);
		RETURN;
	END
	-- Update stok barang
	UPDATE BARANG SET [stok]=@sisa WHERE [kode] = @kode_brg;

	INSERT INTO [TRANSAKSI_DETAIL_BARANG] VALUES (@no_nota, @kode_brg, @harga_brg, @jumlah, @diskon);
COMMIT TRAN
GO

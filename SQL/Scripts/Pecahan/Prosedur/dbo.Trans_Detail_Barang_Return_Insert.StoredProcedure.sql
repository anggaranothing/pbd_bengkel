USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Barang_Return_Insert]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Trans_Detail_Barang_Return_Insert]
	@noNota char(10),
	@noNotaRef char(10),
	@kode_brg char(8),
	@jumlahReturn int
AS
SET NOCOUNT OFF
SET XACT_ABORT ON
BEGIN TRAN
	set @noNota = LTRIM(@noNota)
	set @noNota = RTRIM(@noNota)
	set @noNotaRef = LTRIM(@noNotaRef)
	set @noNotaRef = RTRIM(@noNotaRef)
	set @kode_brg = LTRIM(@kode_brg)
	set @kode_brg = RTRIM(@kode_brg)
	set @jumlahReturn = ABS(@jumlahReturn)

	if @noNota = '' set @noNota = NULL;
	if @noNotaRef = '' set @noNotaRef = NULL;
	if @kode_brg = '' set @kode_brg = NULL;

	IF @noNota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @noNotaRef is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota_ref" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @kode_brg is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode_brg" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DECLARE @harga_brg MONEY, @diskon INT,  @kuantitas INT, @sisa INT;
	SELECT @kuantitas = [jumlah], @harga_brg = [harga_brg], @diskon = [diskon] FROM [TRANSAKSI_DETAIL_BARANG] WHERE [no_nota] = @noNotaRef AND [kode_brg] = @kode_brg;
	SET @sisa = @kuantitas - @jumlahReturn;
	-- Error jika kuantitas tidak cukup
	IF @sisa < 0
	BEGIN
		ROLLBACK;
		RAISERROR('Kuantitas return barang melebihi kuantitas barang yang telah di beli', 16, 1);
		RETURN;
	END
	-- Update kuantitas detail barang
	UPDATE [TRANSAKSI_DETAIL_BARANG] SET [jumlah]=@sisa WHERE [no_nota] = @noNotaRef AND [kode_brg] = @kode_brg;

	-- Update stok barang
	UPDATE BARANG SET [stok] += @jumlahReturn WHERE [kode] = @kode_brg;

	INSERT INTO [TRANSAKSI_DETAIL_BARANG] VALUES (@noNota, @kode_brg, @harga_brg, (@jumlahReturn * -1), @diskon);
COMMIT TRAN
GO

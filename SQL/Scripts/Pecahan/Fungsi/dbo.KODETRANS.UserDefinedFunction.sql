USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  UserDefinedFunction [dbo].[KODETRANS]    Script Date: 15/07/2018 08:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[KODETRANS]()
RETURNS CHAR(10)
AS
BEGIN
    -- Declare the return variable here
	DECLARE @kode_baru CHAR(10)
			, @kode_terakhir INT
			, @tahun CHAR(4);

	-- Ubah panjang kode disini
	-- Contoh :
	-- Format kode : 'YYYY-XXXXX'
	-- berarti panjang kode nya 5
	DECLARE @panjang_kode AS INT = 5;

	-- Harus bernilai positif
	IF @panjang_kode <= 0
	BEGIN
		RETURN CAST('Panjang kode bernilai nol atau negative.' AS BIT);
	END

	DECLARE @batas_max AS INT = CAST( REPLICATE('9',@panjang_kode) AS INT );

	SET @tahun = YEAR(GETDATE());
	SET @kode_terakhir = 1;
	-- Ambil kode terakhir berdasarkan urutan kode yang bisa di pakai
	WHILE( SELECT no_nota FROM [TRANSAKSI] WHERE LEFT(no_nota,4) = @tahun AND CAST( RIGHT( no_nota, @panjang_kode ) AS INT) = @kode_terakhir ) IS NOT NULL
	BEGIN
		SET @kode_terakhir += 1
	END

	IF @kode_terakhir >= @batas_max
	BEGIN
		RETURN CAST('Kode tabel sudah mencapai batas maksimum.' AS BIT);
	END

	-- Buat kode baru
	SET @kode_baru = UPPER( @tahun + '-' + FORMAT( @kode_terakhir, REPLICATE( '0', @panjang_kode ) ) );

	-- Return the result of the function
	RETURN @kode_baru;
END
GO

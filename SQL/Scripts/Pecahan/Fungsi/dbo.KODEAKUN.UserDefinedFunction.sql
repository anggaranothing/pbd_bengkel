USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  UserDefinedFunction [dbo].[KODEAKUN]    Script Date: 15/07/2018 08:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[KODEAKUN]
(
	@kode_tabel CHAR(2)
)
RETURNS CHAR(8)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @kode_baru CHAR(8)
			, @kode_terakhir INT;

	-- Ubah panjang kode disini
	-- Contoh :
	-- Format kode : 'AA-XXXXX'
	-- berarti panjang kode nya 5
	DECLARE @panjang_kode AS INT = 5;

	-- Harus bernilai positif
	IF @panjang_kode <= 0
		RETURN CAST('Panjang kode bernilai nol atau negative.' AS BIT);

	DECLARE @batas_max AS INT = CAST( REPLICATE('9',@panjang_kode) AS INT );

	SET @kode_terakhir = 1
	-- Ambil kode terakhir berdasarkan kode tabel
	IF @kode_tabel = 'MK'
		WHILE( SELECT kode FROM [MONTIR] WHERE CAST( RIGHT( kode, @panjang_kode ) AS INT) = @kode_terakhir ) IS NOT NULL
		BEGIN
		  SET @kode_terakhir += 1
		END
	ELSE
	IF @kode_tabel = 'PL'
		WHILE( SELECT kode FROM [PELANGGAN] WHERE CAST( RIGHT( kode, @panjang_kode ) AS INT) = @kode_terakhir ) IS NOT NULL
		BEGIN
		  SET @kode_terakhir += 1
		END
	ELSE
	IF @kode_tabel = 'JS'
		WHILE( SELECT kode FROM [JASA] WHERE CAST( RIGHT( kode, @panjang_kode ) AS INT) = @kode_terakhir ) IS NOT NULL
		BEGIN
		  SET @kode_terakhir += 1
		END
	ELSE
	IF @kode_tabel = 'BR'
		WHILE( SELECT kode FROM [BARANG] WHERE CAST( RIGHT( kode, @panjang_kode ) AS INT) = @kode_terakhir ) IS NOT NULL
		BEGIN
		  SET @kode_terakhir += 1
		END
	ELSE
		RETURN CAST('Kode tabel tidak di kenal.' AS BIT);

	IF @kode_terakhir >= @batas_max
		RETURN CAST('Kode tabel sudah mencapai batas maksimum.' AS BIT);

	-- Buat kode baru
	SET @kode_baru = UPPER( @kode_tabel + '-' + FORMAT( @kode_terakhir, REPLICATE( '0', @panjang_kode ) ) );

	-- Return the result of the function
	RETURN @kode_baru;
END
GO

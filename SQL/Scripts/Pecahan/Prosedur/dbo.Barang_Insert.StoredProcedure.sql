USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Barang_Insert]    Script Date: 15/07/2018 08:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Barang_Insert]
(
	@kode char(8),
	@nama varchar(64),
	@harga money,
	@stok int,
	@kodebar varchar(13),
	@ket nvarchar(max)
)
AS
SET NOCOUNT OFF
BEGIN TRAN
	set @nama = LTRIM(@nama)
	set @nama = RTRIM(@nama)
	set @kodebar = LTRIM(@kodebar)
	set @kodebar = RTRIM(@kodebar)
	set @ket = LTRIM(@ket)
	set @ket = RTRIM(@ket)

	if @kode = ''  set @kode = null
	if @nama = '' set @nama = null
	if @kodebar = '' set @kodebar = null
	if @ket = '' set @ket = null

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

	INSERT INTO [BARANG] VALUES (@kode, @nama, @harga, @stok, @kodebar, @ket);
COMMIT TRAN
GO

USE [FP_BENGKEL_ANGGARA]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewUserSafe'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewUserSafe'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewActiveMechanics'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewActiveMechanics'
GO
/****** Object:  StoredProcedure [dbo].[User_SetPasswordByName]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[User_SetPasswordByName]
GO
/****** Object:  StoredProcedure [dbo].[User_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[User_Insert]
GO
/****** Object:  StoredProcedure [dbo].[User_GetPasswordByName]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[User_GetPasswordByName]
GO
/****** Object:  StoredProcedure [dbo].[User_GetByName]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[User_GetByName]
GO
/****** Object:  StoredProcedure [dbo].[User_Edit]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[User_Edit]
GO
/****** Object:  StoredProcedure [dbo].[User_Delete]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[User_Delete]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Trans_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Trans_GetByNoNota]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Trans_GetByNoNota]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Edit_Minimum]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Trans_Edit_Minimum]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Jasa_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Trans_Detail_Jasa_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Barang_Return_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Trans_Detail_Barang_Return_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Barang_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Trans_Detail_Barang_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Trans_Delete]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Trans_Delete]
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Pelanggan_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_GetByKode]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Pelanggan_GetByKode]
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_Edit]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Pelanggan_Edit]
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_Delete]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Pelanggan_Delete]
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Mekanik_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_GetByKode]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Mekanik_GetByKode]
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_Edit]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Mekanik_Edit]
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_Delete]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Mekanik_Delete]
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Kendaraan_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_GetByNoPol]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Kendaraan_GetByNoPol]
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Edit]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Kendaraan_Edit]
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Delete]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Kendaraan_Delete]
GO
/****** Object:  StoredProcedure [dbo].[Jasa_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Jasa_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Jasa_Edit]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Jasa_Edit]
GO
/****** Object:  StoredProcedure [dbo].[Jasa_Delete]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Jasa_Delete]
GO
/****** Object:  StoredProcedure [dbo].[Barang_Insert]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Barang_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Barang_Edit]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Barang_Edit]
GO
/****** Object:  StoredProcedure [dbo].[Barang_Delete]    Script Date: 15/07/2018 08:12:53 ******/
DROP PROCEDURE [dbo].[Barang_Delete]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] DROP CONSTRAINT [FK_TRANSAKSI_DETAIL_JASA_TRANSAKSI]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] DROP CONSTRAINT [FK_TRANSAKSI_DETAIL_JASA_JASA]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG] DROP CONSTRAINT [FK_TRANSAKSI_DETAIL_BARANG_TRANSAKSI]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG] DROP CONSTRAINT [FK_TRANSAKSI_DETAIL_BARANG_BARANG]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [FK_TRANSAKSI_PELANGGAN]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [FK_TRANSAKSI_MONTIR]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [FK_TRANSAKSI_KENDARAAN]
GO
ALTER TABLE [dbo].[USER] DROP CONSTRAINT [DF_USER_date_creation]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] DROP CONSTRAINT [DF_TRANSAKSI_DETAIL_JASA_diskon]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] DROP CONSTRAINT [DF_TRANSAKSI_DETAIL_JASA_tgl_selesai]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] DROP CONSTRAINT [DF_TRANSAKSI_DETAIL_JASA_tgl_mulai]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG] DROP CONSTRAINT [DF_TRANSAKSI_DETAIL_BARANG_diskon]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [DF_TRANSAKSI_ket]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [DF_TRANSAKSI_bayar_kurang]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [DF_TRANSAKSI_lunas]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [DF_TRANSAKSI_tgl_buat]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [DF_TRANSAKSI_nopol]
GO
ALTER TABLE [dbo].[TRANSAKSI] DROP CONSTRAINT [DF_TRANSAKSI_kode_mk]
GO
ALTER TABLE [dbo].[MONTIR] DROP CONSTRAINT [DF_MONTIR_status]
GO
ALTER TABLE [dbo].[JASA] DROP CONSTRAINT [DF_JASA_waktu_menit]
GO
ALTER TABLE [dbo].[BARANG] DROP CONSTRAINT [DF_BARANG_ket]
GO
ALTER TABLE [dbo].[BARANG] DROP CONSTRAINT [DF_BARANG_kodebar]
GO
ALTER TABLE [dbo].[BARANG] DROP CONSTRAINT [DF_BARANG_stok]
GO
ALTER TABLE [dbo].[BARANG] DROP CONSTRAINT [DF_BARANG_harga]
GO
/****** Object:  Table [dbo].[TRANSAKSI_DETAIL_JASA]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[TRANSAKSI_DETAIL_JASA]
GO
/****** Object:  Table [dbo].[TRANSAKSI_DETAIL_BARANG]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[TRANSAKSI_DETAIL_BARANG]
GO
/****** Object:  Table [dbo].[TRANSAKSI]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[TRANSAKSI]
GO
/****** Object:  Table [dbo].[PELANGGAN]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[PELANGGAN]
GO
/****** Object:  Table [dbo].[KENDARAAN]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[KENDARAAN]
GO
/****** Object:  Table [dbo].[JASA]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[JASA]
GO
/****** Object:  Table [dbo].[BARANG]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[BARANG]
GO
/****** Object:  View [dbo].[ViewUserSafe]    Script Date: 15/07/2018 08:12:53 ******/
DROP VIEW [dbo].[ViewUserSafe]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[USER]
GO
/****** Object:  View [dbo].[ViewActiveMechanics]    Script Date: 15/07/2018 08:12:53 ******/
DROP VIEW [dbo].[ViewActiveMechanics]
GO
/****** Object:  Table [dbo].[MONTIR]    Script Date: 15/07/2018 08:12:53 ******/
DROP TABLE [dbo].[MONTIR]
GO
/****** Object:  UserDefinedFunction [dbo].[KODETRANS]    Script Date: 15/07/2018 08:12:53 ******/
DROP FUNCTION [dbo].[KODETRANS]
GO
/****** Object:  UserDefinedFunction [dbo].[KODEAKUN]    Script Date: 15/07/2018 08:12:53 ******/
DROP FUNCTION [dbo].[KODEAKUN]
GO
USE [master]
GO
/****** Object:  Database [FP_BENGKEL_ANGGARA]    Script Date: 15/07/2018 08:12:53 ******/
DROP DATABASE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  Database [FP_BENGKEL_ANGGARA]    Script Date: 15/07/2018 08:12:53 ******/
CREATE DATABASE [FP_BENGKEL_ANGGARA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FP_BENGKEL_ANGGARA', FILENAME = N'D:\Users\kuliah\MsSQL\FP\FP_BENGKEL_ANGGARA.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FP_BENGKEL_ANGGARA_log', FILENAME = N'D:\Users\kuliah\MsSQL\FP\FP_BENGKEL_ANGGARA_log.ldf' , SIZE = 2816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FP_BENGKEL_ANGGARA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET ARITHABORT OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET  MULTI_USER 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET QUERY_STORE = OFF
GO
USE [FP_BENGKEL_ANGGARA]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  UserDefinedFunction [dbo].[KODEAKUN]    Script Date: 15/07/2018 08:12:54 ******/
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
/****** Object:  UserDefinedFunction [dbo].[KODETRANS]    Script Date: 15/07/2018 08:12:54 ******/
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
/****** Object:  Table [dbo].[MONTIR]    Script Date: 15/07/2018 08:12:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONTIR](
	[kode] [char](8) NOT NULL,
	[nama] [varchar](128) NOT NULL,
	[alamat] [varchar](128) NULL,
	[telepon] [varchar](16) NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_MONTIR] PRIMARY KEY CLUSTERED 
(
	[kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewActiveMechanics]    Script Date: 15/07/2018 08:12:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewActiveMechanics]
AS
SELECT        kode, nama, alamat, telepon, status
FROM            dbo.MONTIR
WHERE        (status = 1)
GO
/****** Object:  Table [dbo].[USER]    Script Date: 15/07/2018 08:12:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[username] [varchar](32) NOT NULL,
	[passwd] [varchar](64) NOT NULL,
	[role] [int] NOT NULL,
	[date_creation] [datetime] NULL,
	[date_modified] [datetime] NULL,
 CONSTRAINT [PK_PENGGUNA] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewUserSafe]    Script Date: 15/07/2018 08:12:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewUserSafe]
AS
SELECT        username, role, date_creation, date_modified
FROM            dbo.[USER]
GO
/****** Object:  Table [dbo].[BARANG]    Script Date: 15/07/2018 08:12:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BARANG](
	[kode] [char](8) NOT NULL,
	[nama] [varchar](64) NOT NULL,
	[harga] [money] NOT NULL,
	[stok] [int] NOT NULL,
	[kodebar] [varchar](13) NULL,
	[ket] [nvarchar](max) NULL,
 CONSTRAINT [PK__BARANG__25A87493D94E446D] PRIMARY KEY CLUSTERED 
(
	[kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JASA]    Script Date: 15/07/2018 08:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JASA](
	[kode] [char](8) NOT NULL,
	[nama] [varchar](64) NOT NULL,
	[harga] [money] NOT NULL,
	[waktu_menit] [decimal](18, 0) NULL,
 CONSTRAINT [PK_JASA] PRIMARY KEY CLUSTERED 
(
	[kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KENDARAAN]    Script Date: 15/07/2018 08:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KENDARAAN](
	[nopol] [varchar](12) NOT NULL,
	[nama] [varchar](64) NOT NULL,
	[tahun] [char](4) NOT NULL,
	[stnk] [varchar](20) NULL,
 CONSTRAINT [PK_KENDARAAN] PRIMARY KEY CLUSTERED 
(
	[nopol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PELANGGAN]    Script Date: 15/07/2018 08:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PELANGGAN](
	[kode] [char](8) NOT NULL,
	[nama] [varchar](128) NOT NULL,
	[alamat] [varchar](128) NULL,
	[telepon] [varchar](16) NULL,
	[no_id] [varchar](32) NULL,
 CONSTRAINT [PK_PELANGGAN] PRIMARY KEY CLUSTERED 
(
	[kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSAKSI]    Script Date: 15/07/2018 08:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSAKSI](
	[no_nota] [char](10) NOT NULL,
	[kode_plg] [char](8) NOT NULL,
	[kode_mk] [char](8) NULL,
	[nopol] [varchar](12) NULL,
	[tgl_buat] [datetime] NULL,
	[tgl_lunas] [datetime] NULL,
	[bayar_kurang] [money] NULL,
	[ket] [text] NULL,
 CONSTRAINT [PK_TRANSAKSI] PRIMARY KEY CLUSTERED 
(
	[no_nota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSAKSI_DETAIL_BARANG]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSAKSI_DETAIL_BARANG](
	[no_nota] [char](10) NOT NULL,
	[kode_brg] [char](8) NOT NULL,
	[harga_brg] [money] NOT NULL,
	[jumlah] [int] NOT NULL,
	[diskon] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSAKSI_DETAIL_JASA]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSAKSI_DETAIL_JASA](
	[no_nota] [char](10) NOT NULL,
	[kode_jasa] [char](8) NOT NULL,
	[harga_jasa] [money] NOT NULL,
	[tgl_mulai] [datetime] NULL,
	[tgl_selesai] [datetime] NULL,
	[diskon] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BARANG] ADD  CONSTRAINT [DF_BARANG_harga]  DEFAULT ((0)) FOR [harga]
GO
ALTER TABLE [dbo].[BARANG] ADD  CONSTRAINT [DF_BARANG_stok]  DEFAULT ((0)) FOR [stok]
GO
ALTER TABLE [dbo].[BARANG] ADD  CONSTRAINT [DF_BARANG_kodebar]  DEFAULT (NULL) FOR [kodebar]
GO
ALTER TABLE [dbo].[BARANG] ADD  CONSTRAINT [DF_BARANG_ket]  DEFAULT (NULL) FOR [ket]
GO
ALTER TABLE [dbo].[JASA] ADD  CONSTRAINT [DF_JASA_waktu_menit]  DEFAULT (NULL) FOR [waktu_menit]
GO
ALTER TABLE [dbo].[MONTIR] ADD  CONSTRAINT [DF_MONTIR_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[TRANSAKSI] ADD  CONSTRAINT [DF_TRANSAKSI_kode_mk]  DEFAULT (NULL) FOR [kode_mk]
GO
ALTER TABLE [dbo].[TRANSAKSI] ADD  CONSTRAINT [DF_TRANSAKSI_nopol]  DEFAULT (NULL) FOR [nopol]
GO
ALTER TABLE [dbo].[TRANSAKSI] ADD  CONSTRAINT [DF_TRANSAKSI_tgl_buat]  DEFAULT (getdate()) FOR [tgl_buat]
GO
ALTER TABLE [dbo].[TRANSAKSI] ADD  CONSTRAINT [DF_TRANSAKSI_lunas]  DEFAULT (NULL) FOR [tgl_lunas]
GO
ALTER TABLE [dbo].[TRANSAKSI] ADD  CONSTRAINT [DF_TRANSAKSI_bayar_kurang]  DEFAULT (NULL) FOR [bayar_kurang]
GO
ALTER TABLE [dbo].[TRANSAKSI] ADD  CONSTRAINT [DF_TRANSAKSI_ket]  DEFAULT (NULL) FOR [ket]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG] ADD  CONSTRAINT [DF_TRANSAKSI_DETAIL_BARANG_diskon]  DEFAULT ((0)) FOR [diskon]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] ADD  CONSTRAINT [DF_TRANSAKSI_DETAIL_JASA_tgl_mulai]  DEFAULT (NULL) FOR [tgl_mulai]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] ADD  CONSTRAINT [DF_TRANSAKSI_DETAIL_JASA_tgl_selesai]  DEFAULT (NULL) FOR [tgl_selesai]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] ADD  CONSTRAINT [DF_TRANSAKSI_DETAIL_JASA_diskon]  DEFAULT ((0)) FOR [diskon]
GO
ALTER TABLE [dbo].[USER] ADD  CONSTRAINT [DF_USER_date_creation]  DEFAULT (getdate()) FOR [date_creation]
GO
ALTER TABLE [dbo].[TRANSAKSI]  WITH CHECK ADD  CONSTRAINT [FK_TRANSAKSI_KENDARAAN] FOREIGN KEY([nopol])
REFERENCES [dbo].[KENDARAAN] ([nopol])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[TRANSAKSI] CHECK CONSTRAINT [FK_TRANSAKSI_KENDARAAN]
GO
ALTER TABLE [dbo].[TRANSAKSI]  WITH CHECK ADD  CONSTRAINT [FK_TRANSAKSI_MONTIR] FOREIGN KEY([kode_mk])
REFERENCES [dbo].[MONTIR] ([kode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TRANSAKSI] CHECK CONSTRAINT [FK_TRANSAKSI_MONTIR]
GO
ALTER TABLE [dbo].[TRANSAKSI]  WITH CHECK ADD  CONSTRAINT [FK_TRANSAKSI_PELANGGAN] FOREIGN KEY([kode_plg])
REFERENCES [dbo].[PELANGGAN] ([kode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TRANSAKSI] CHECK CONSTRAINT [FK_TRANSAKSI_PELANGGAN]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG]  WITH CHECK ADD  CONSTRAINT [FK_TRANSAKSI_DETAIL_BARANG_BARANG] FOREIGN KEY([kode_brg])
REFERENCES [dbo].[BARANG] ([kode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG] CHECK CONSTRAINT [FK_TRANSAKSI_DETAIL_BARANG_BARANG]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG]  WITH CHECK ADD  CONSTRAINT [FK_TRANSAKSI_DETAIL_BARANG_TRANSAKSI] FOREIGN KEY([no_nota])
REFERENCES [dbo].[TRANSAKSI] ([no_nota])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_BARANG] CHECK CONSTRAINT [FK_TRANSAKSI_DETAIL_BARANG_TRANSAKSI]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA]  WITH CHECK ADD  CONSTRAINT [FK_TRANSAKSI_DETAIL_JASA_JASA] FOREIGN KEY([kode_jasa])
REFERENCES [dbo].[JASA] ([kode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] CHECK CONSTRAINT [FK_TRANSAKSI_DETAIL_JASA_JASA]
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA]  WITH CHECK ADD  CONSTRAINT [FK_TRANSAKSI_DETAIL_JASA_TRANSAKSI] FOREIGN KEY([no_nota])
REFERENCES [dbo].[TRANSAKSI] ([no_nota])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TRANSAKSI_DETAIL_JASA] CHECK CONSTRAINT [FK_TRANSAKSI_DETAIL_JASA_TRANSAKSI]
GO
/****** Object:  StoredProcedure [dbo].[Barang_Delete]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Barang_Delete]
(
	@kode char(8)
)
AS
	SET NOCOUNT OFF;
	DELETE FROM [dbo].[BARANG] WHERE [kode] = @kode
GO
/****** Object:  StoredProcedure [dbo].[Barang_Edit]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Barang_Edit]
(
	@kode char(8),
	@nama varchar(64),
	@harga money,
	@stok int,
	@kodebar varchar(13),
	@ket nvarchar(max)
)
AS
SET NOCOUNT OFF;
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

	UPDATE [dbo].[BARANG] 
	SET 
	[nama] = @nama, [harga] = @harga, [stok] = @stok, [kodebar] = @kodebar, [ket] = @ket
	WHERE 
	[kode] = @kode
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Barang_Insert]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Jasa_Delete]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jasa_Delete]
(
	@kode char(8)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @kode = ''  set @kode = null
	IF @kode is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [dbo].[JASA] WHERE [kode] = @kode
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Jasa_Edit]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Jasa_Insert]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Jasa_Insert]
(
	@kode char(8),
	@nama varchar(64),
	@harga money,
	@waktu_menit decimal(18,0)
)
AS
SET NOCOUNT OFF
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

	INSERT INTO [JASA] VALUES (@kode, @nama, @harga, @waktu_menit);
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Delete]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kendaraan_Delete]
(
	@nopol varchar(12)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @nopol = LTRIM(@nopol)
	set @nopol = RTRIM(@nopol)

	if @nopol = ''  set @nopol = null

	IF @nopol is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "nopol" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [KENDARAAN] WHERE [nopol] = @nopol
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Edit]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Kendaraan_Edit]
(
	@nopol varchar(12),
	@nama varchar(64),
	@tahun char(4),
	@stnk varchar(20)
)
AS
SET NOCOUNT OFF;
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

	UPDATE [KENDARAAN]
	SET 
		[nama]  = @nama, 
		[tahun] = @tahun, 
		[stnk]  = @stnk
	WHERE 
	[nopol] = @nopol
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_GetByNoPol]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Kendaraan_GetByNoPol]
	@nopol varchar(12)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [nopol], [nama], [tahun], [stnk] FROM [dbo].[KENDARAAN] WHERE [nopol] = @nopol;
END
GO
/****** Object:  StoredProcedure [dbo].[Kendaraan_Insert]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Mekanik_Delete]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mekanik_Delete]
(
	@kode char(8)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @kode = ''  set @kode = null
	IF @kode is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [dbo].[MONTIR] WHERE [kode] = @kode
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_Edit]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Mekanik_GetByKode]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Mekanik_GetByKode]
	@kode char(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [kode], [nama], [alamat], [telepon], [status] FROM [dbo].[MONTIR] WHERE [kode] = @kode;
END
GO
/****** Object:  StoredProcedure [dbo].[Mekanik_Insert]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Mekanik_Insert]
(
	@kode char(8),
	@nama varchar(128),
	@alamat varchar(128),
	@telepon varchar(16),
	@status bit
)
AS
SET NOCOUNT OFF
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

	INSERT INTO [MONTIR] VALUES (@kode, @nama, @alamat, @telepon, @status);
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_Delete]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pelanggan_Delete]
(
	@kode char(8)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @kode = ''  set @kode = null
	IF @kode is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "kode" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [dbo].[PELANGGAN] WHERE [kode] = @kode
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_Edit]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Pelanggan_Edit]
(
	@kode char(8),
	@nama varchar(128),
	@alamat varchar(128),
	@telepon varchar(16),
	@no_id varchar(32)
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
	set @no_id = LTRIM(@no_id)
	set @no_id = RTRIM(@no_id)

	if @kode = ''  set @kode = null
	if @nama = '' set @nama = null
	if @alamat = '' set @alamat = null
	if @telepon = '' set @telepon = null
	if @no_id = '' set @no_id = null

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

	UPDATE [dbo].[PELANGGAN] 
	SET 
	[nama] = @nama, [alamat] = @alamat, [telepon] = @telepon, [no_id] = @no_id 
	WHERE 
	[kode] = @kode
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_GetByKode]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Pelanggan_GetByKode]
	@kode char(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [kode], [nama], [alamat], [telepon], [no_id] FROM [dbo].[PELANGGAN] WHERE [kode] = @kode;
END
GO
/****** Object:  StoredProcedure [dbo].[Pelanggan_Insert]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Pelanggan_Insert]
(
	@kode char(8),
	@nama varchar(128),
	@alamat varchar(128),
	@telepon varchar(16),
	@no_id varchar(32)
)
AS
SET NOCOUNT OFF
BEGIN TRAN
	set @nama = LTRIM(@nama)
	set @nama = RTRIM(@nama)
	set @alamat = LTRIM(@alamat)
	set @alamat = RTRIM(@alamat)
	set @telepon = LTRIM(@telepon)
	set @telepon = RTRIM(@telepon)
	set @no_id = LTRIM(@no_id)
	set @no_id = RTRIM(@no_id)

	if @kode = ''  set @kode = null
	if @nama = '' set @nama = null
	if @alamat = '' set @alamat = null
	if @telepon = '' set @telepon = null
	if @no_id = '' set @no_id = null

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

	INSERT INTO [PELANGGAN] VALUES (@kode, @nama, @alamat, @telepon, @no_id);
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Trans_Delete]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Trans_Delete]
(
	@no_nota char(10)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @no_nota = ''  set @no_nota = null
	IF @no_nota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [dbo].[TRANSAKSI] WHERE [no_nota] = @no_nota
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Barang_Insert]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Barang_Return_Insert]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Trans_Detail_Jasa_Insert]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Trans_Edit_Minimum]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Trans_Edit_Minimum]
(
	@no_nota char(10),
	@tgl_lunas datetime,
	@bayar_kurang money,
	@ket text
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @no_nota = LTRIM(@no_nota)
	set @no_nota = RTRIM(@no_nota)

	IF @no_nota is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "no_nota" tidak boleh kosong', 16, 1);
		RETURN;
	END

	IF @bayar_kurang > 0
		SET @tgl_lunas = NULL
	ELSE
	IF @bayar_kurang = 0
		SET @bayar_kurang = NULL

	UPDATE [dbo].[TRANSAKSI]
	SET 
		[tgl_lunas] = @tgl_lunas,
		[bayar_kurang] = @bayar_kurang,
		[ket] = @ket
	WHERE 
	[no_nota] = @no_nota
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[Trans_GetByNoNota]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Trans_GetByNoNota]
	@no_nota CHAR(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [no_nota], [kode_plg], [kode_mk], [nopol], [tgl_buat], [tgl_lunas], [bayar_kurang], [ket] FROM [dbo].[TRANSAKSI] WHERE no_nota = @no_nota
END
GO
/****** Object:  StoredProcedure [dbo].[Trans_Insert]    Script Date: 15/07/2018 08:12:56 ******/
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
/****** Object:  StoredProcedure [dbo].[User_Delete]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_Delete]
(
	@nama varchar(32)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	if @nama = ''  set @nama = null
	IF @nama is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "nama" tidak boleh kosong', 16, 1);
		RETURN;
	END

	DELETE FROM [USER] WHERE [username] = @nama
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[User_Edit]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_Edit]
(
	@nama_asli varchar(32),
	@nama_baru varchar(32),
	@role int
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @nama_baru = LTRIM(@nama_baru);
	set @nama_baru = RTRIM(@nama_baru);

	if @nama_baru = '' set @nama_baru = null

	IF @nama_baru is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "username" tidak boleh kosong', 16, 1);
		RETURN;
	END

	UPDATE [dbo].[USER]
	SET 
	[username] = @nama_baru, [role] = @role, [date_modified] = CURRENT_TIMESTAMP
	WHERE 
	[username] = @nama_asli
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[User_GetByName]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[User_GetByName]
	-- Add the parameters for the function here
	@name varchar(32)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT username, role
	FROM [dbo].[USER]
	WHERE username = @name
END
GO
/****** Object:  StoredProcedure [dbo].[User_GetPasswordByName]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[User_GetPasswordByName]
	-- Add the parameters for the function here
	@name varchar(32)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT passwd
	FROM [dbo].[USER]
	WHERE username = @name
END
GO
/****** Object:  StoredProcedure [dbo].[User_Insert]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_Insert]
(
	@nama varchar(32),
	@passwd varchar(64),
	@role int
)
AS
SET NOCOUNT OFF
BEGIN TRAN
	set @nama = LTRIM(@nama);
	set @nama = RTRIM(@nama);
	set @passwd = LTRIM(@passwd);
	set @passwd = RTRIM(@passwd);

	if @nama = '' set @nama = null
	if @passwd = '' set @passwd = null

	IF @nama is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "username" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE IF @passwd is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "passwd" tidak boleh kosong', 16, 1);
		RETURN;
	END

	INSERT INTO [USER](username,passwd,role) VALUES(@nama,@passwd,@role);
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[User_SetPasswordByName]    Script Date: 15/07/2018 08:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_SetPasswordByName]
(
	-- Add the parameters for the function here
	@name varchar(32),
	@passwd varchar(64)
)
AS
SET NOCOUNT OFF;
BEGIN TRAN
	set @name = LTRIM(@name);
	set @name = RTRIM(@name);
	set @passwd = LTRIM(@passwd);
	set @passwd = RTRIM(@passwd);

	if @name = '' set @name = null
	if @passwd = '' set @passwd = null

	IF @name is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "username" tidak boleh kosong', 16, 1);
		RETURN;
	END
	ELSE
	IF @passwd is null
	BEGIN
		ROLLBACK;
		RAISERROR('Kolom "passwd" tidak boleh kosong', 16, 1);
		RETURN;
	END

	UPDATE [dbo].[USER]
	SET 
	[passwd] = @passwd, [date_modified] = CURRENT_TIMESTAMP
	WHERE 
	[username] = @name
COMMIT TRAN
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MONTIR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewActiveMechanics'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewActiveMechanics'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "USER"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewUserSafe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewUserSafe'
GO
USE [master]
GO
ALTER DATABASE [FP_BENGKEL_ANGGARA] SET  READ_WRITE 
GO

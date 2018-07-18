-- Tambah beberapa query
-- Anggara_Nothing
USE [FP_BENGKEL_ANGGARA]
GO -- TABEL USER
INSERT INTO [dbo].[USER] VALUES ( 'superuser', '$2a$10$73MSpZUXZyC7.0GritUkUenUYWbpiwLpnPHQSHDcCZdPKLmYZ2rr2', 1, NULL, NULL );
GO
INSERT INTO [dbo].[USER] VALUES ( 'manajer', '$2a$10$73MSpZUXZyC7.0GritUkUenUYWbpiwLpnPHQSHDcCZdPKLmYZ2rr2', 2, NULL, NULL );
GO
INSERT INTO [dbo].[USER] VALUES ( 'kasir', '$2a$10$73MSpZUXZyC7.0GritUkUenUYWbpiwLpnPHQSHDcCZdPKLmYZ2rr2', 3, NULL, NULL );
GO -- TABEL BARANG
INSERT INTO [dbo].[BARANG] VALUES ( 'BR-00001',	'Contoh Barang 001',		150000,	83,	NULL,	NULL );
GO
INSERT INTO [dbo].[BARANG] VALUES ( 'BR-00002',	'Contoh Barang 002',		10000,	29,	NULL,	NULL );
GO
INSERT INTO [dbo].[BARANG] VALUES ( 'BR-00003',	'Contoh Barang 003',		20000,	85,	NULL,	NULL );
GO
INSERT INTO [dbo].[BARANG] VALUES ( 'BR-00004',	'Contoh Barang 004',		5000,	0,	NULL,	NULL );
GO -- TABEL JASA
INSERT INTO [dbo].[JASA] VALUES ( 'JS-00002',	'Contoh Jasa Tanpa Waktu',		500,	NULL );
GO
INSERT INTO [dbo].[JASA] VALUES ( 'JS-00004',	'Contoh Jasa Per 1 Menit',		100,	1 );
GO -- TABEL PELANGGAN
INSERT INTO [dbo].[PELANGGAN] VALUES ( 'PL-00001',	'Pelanggan Umum',	NULL,	NULL,	NULL );
GO
INSERT INTO [dbo].[PELANGGAN] VALUES ( 'PL-00002',	'Paijo',	'YOGYAKARTA',	NULL,	NULL );
GO -- TABEL KENDARAAN
INSERT INTO [dbo].[KENDARAAN] VALUES ( 'XX 1234 YYY',	'Contoh Kendaraan Pelanggan',	2018,	'1234567890' );
GO -- TABEL MONTIR (Mekanik)
INSERT INTO [dbo].[MONTIR] VALUES ( 'MK-00003',	'Jajang Sukmara',	'Jl. Cimehong No 2',	'0804597497505',	0 );
GO
INSERT INTO [dbo].[MONTIR] VALUES ( 'MK-00019',	'Anggara_nothing',	'https://github.com/anggaranothing/',	NULL,	1 );
GO
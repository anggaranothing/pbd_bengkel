USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Barang_Delete]    Script Date: 15/07/2018 08:07:58 ******/
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

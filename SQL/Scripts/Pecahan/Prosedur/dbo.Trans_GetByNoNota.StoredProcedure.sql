USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  StoredProcedure [dbo].[Trans_GetByNoNota]    Script Date: 15/07/2018 08:07:58 ******/
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

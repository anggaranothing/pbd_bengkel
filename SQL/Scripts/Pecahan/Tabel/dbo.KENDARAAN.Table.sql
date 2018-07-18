USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  Table [dbo].[KENDARAAN]    Script Date: 15/07/2018 08:07:57 ******/
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

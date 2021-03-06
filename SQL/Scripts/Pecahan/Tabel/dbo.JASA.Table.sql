USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  Table [dbo].[JASA]    Script Date: 15/07/2018 08:07:57 ******/
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
ALTER TABLE [dbo].[JASA] ADD  CONSTRAINT [DF_JASA_waktu_menit]  DEFAULT (NULL) FOR [waktu_menit]
GO

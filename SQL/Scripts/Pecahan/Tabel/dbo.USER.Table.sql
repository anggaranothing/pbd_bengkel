USE [FP_BENGKEL_ANGGARA]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 15/07/2018 08:07:57 ******/
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
ALTER TABLE [dbo].[USER] ADD  CONSTRAINT [DF_USER_date_creation]  DEFAULT (getdate()) FOR [date_creation]
GO

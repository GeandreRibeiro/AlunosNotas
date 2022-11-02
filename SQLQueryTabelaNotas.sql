USE [Alunos]
GO

/****** Object:  Table [dbo].[Notas]    Script Date: 02/11/2022 14:01:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Notas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_aluno] [int] NULL,
	[nota_01] [decimal](18, 4) NULL,
	[nota_02] [decimal](18, 4) NULL,
	[nota_03] [decimal](18, 4) NULL,
	[nota_04] [decimal](18, 4) NULL,
 CONSTRAINT [PK_Notas01] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Notas]  WITH CHECK ADD  CONSTRAINT [FK_Notas_Alunos] FOREIGN KEY([id_aluno])
REFERENCES [dbo].[Alunos] ([id])
GO

ALTER TABLE [dbo].[Notas] CHECK CONSTRAINT [FK_Notas_Alunos]
GO



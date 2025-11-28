USE [ApostaEmCorridas_Banco]
GO

/****** Object:  Table [dbo].[CORRIDA]    Script Date: 27/11/2025 20:52:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CORRIDA](
	[Id_Corrida] [int] IDENTITY(1,1) NOT NULL,
	[Numero_Voltas] [int] NULL,
	[DataInicio] [datetime2](7) NULL,
	[DataFim] [datetime2](7) NULL,
	[StatusCorrida] [int] NULL,
	[Percurso] [float] NOT NULL,
	[ValorApostado] [money] NOT NULL,
 CONSTRAINT [PK_CORRIDA] PRIMARY KEY CLUSTERED 
(
	[Id_Corrida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CORRIDA] ADD  DEFAULT ((0)) FOR [ValorApostado]
GO



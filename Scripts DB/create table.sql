USE [Persona]
GO

/****** Object:  Table [dbo].[Persona]    Script Date: 26/9/2018 9:27:55 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Persona](
	[nombreCompleto] [nvarchar](50) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[edad] [smallint] NOT NULL,
	[sexo] [char](1) NOT NULL,
	[ultimaActualizacion] [datetime] NOT NULL,
	[borrado] [bit] NOT NULL
) ON [PRIMARY]
GO



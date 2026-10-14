-- Esquema de la base de datos BD_ALBAS (SQL Server).
-- Solo estructura: tablas, llaves y relaciones. No incluye datos personales.
USE [master]
GO
/****** Object:  Database [BD_ALBAS]    Script Date: 4/07/2026 10:24:43 PM ******/
CREATE DATABASE [BD_ALBAS]
GO
ALTER DATABASE [BD_ALBAS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_ALBAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_ALBAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_ALBAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_ALBAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_ALBAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_ALBAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_ALBAS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_ALBAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_ALBAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_ALBAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_ALBAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_ALBAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_ALBAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_ALBAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_ALBAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_ALBAS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD_ALBAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_ALBAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_ALBAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_ALBAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_ALBAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_ALBAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_ALBAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_ALBAS] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_ALBAS] SET  MULTI_USER 
GO
ALTER DATABASE [BD_ALBAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_ALBAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_ALBAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_ALBAS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_ALBAS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_ALBAS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BD_ALBAS', N'ON'
GO
ALTER DATABASE [BD_ALBAS] SET QUERY_STORE = ON
GO
ALTER DATABASE [BD_ALBAS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BD_ALBAS]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[idAdministrador] [int] NOT NULL,
 CONSTRAINT [PK_Administrador] PRIMARY KEY CLUSTERED 
(
	[idAdministrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[idArea] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](200) NULL,
	[costo] [decimal](10, 2) NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
(
	[idArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caso]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caso](
	[nroCaso] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[idEspecialista] [int] NOT NULL,
	[idAdministrador] [int] NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](200) NULL,
	[fechaHoraInicio] [datetime] NOT NULL,
	[fechaHoraFin] [datetime] NULL,
	[estado] [varchar](30) NOT NULL,
	[documento] [varchar](255) NULL,
	[createdBy] [int] NULL,
	[createdAt] [datetime] NOT NULL,
	[modifiedBy] [int] NULL,
	[activo] [bit] NULL,
	[modifiedAt] [datetime] NULL,
 CONSTRAINT [PK_Caso] PRIMARY KEY CLUSTERED 
(
	[nroCaso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[nroCaso] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[horaInicio] [time](7) NOT NULL,
	[horaFin] [time](7) NOT NULL,
	[estado] [varchar](15) NOT NULL,
	[observacion] [varchar](300) NULL,
	[modalidad] [varchar](15) NOT NULL,
	[confirmacionAsistencia] [bit] NOT NULL,
	[activo] [bit] NULL,
	[tiempoAnticipacion] [int] NULL,
	[createdBy] [int] NULL,
	[createdAt] [datetime] NOT NULL,
	[modifiedBy] [int] NULL,
	[modifiedAt] [datetime] NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](80) NOT NULL,
	[apellido] [varchar](80) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[correo] [varchar](100) NOT NULL,
	[telefono] [varchar](15) NOT NULL,
	[direccion] [varchar](150) NOT NULL,
	[genero] [varchar](20) NOT NULL,
	[activo] [bit] NOT NULL,
	[createdBy] [int] NULL,
	[createdAt] [datetime] NOT NULL,
	[modifiedBy] [int] NULL,
	[modifiedAt] [datetime] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialista]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialista](
	[idEspecialista] [int] NOT NULL,
	[idArea] [int] NOT NULL,
	[disponible] [bit] NOT NULL,
 CONSTRAINT [PK_Especialista] PRIMARY KEY CLUSTERED 
(
	[idEspecialista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reporte]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reporte](
	[idReporte] [int] IDENTITY(1,1) NOT NULL,
	[idAdministrador] [int] NOT NULL,
	[nombre] [varchar](300) NOT NULL,
	[tipoGrafico] [varchar](30) NOT NULL,
	[fechaGenerada] [datetime] NOT NULL,
 CONSTRAINT [PK_Reporte] PRIMARY KEY CLUSTERED 
(
	[idReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 4/07/2026 10:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](80) NOT NULL,
	[apellido] [varchar](80) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[telefono] [varchar](15) NOT NULL,
	[correo] [varchar](200) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](250) NOT NULL,
	[rol] [varchar](20) NOT NULL,
	[activo] [bit] NOT NULL,
	[direccion] [varchar](250) NOT NULL,
	[createdBy] [int] NULL,
	[createdAt] [datetime] NOT NULL,
	[modifiedBy] [int] NULL,
	[modifiedAt] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GO

GO

GO

GO
GO
GO

GO
GO

GO

GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Cliente_Dni]    Script Date: 4/07/2026 10:24:43 PM ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [UQ_Cliente_Dni] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Usuario_Dni]    Script Date: 4/07/2026 10:24:43 PM ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UQ_Usuario_Dni] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Usuario_Username]    Script Date: 4/07/2026 10:24:43 PM ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UQ_Usuario_Username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Area] ADD  CONSTRAINT [DF_Area_Activo]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[Caso] ADD  CONSTRAINT [DF_Caso_CreatedAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[Caso] ADD  CONSTRAINT [DF_Caso_Activo]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[Cita] ADD  CONSTRAINT [DF_Cita_Confirmacion]  DEFAULT ((0)) FOR [confirmacionAsistencia]
GO
ALTER TABLE [dbo].[Cita] ADD  CONSTRAINT [DF_Cita_Activo]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[Cita] ADD  CONSTRAINT [DF_Cita_CreatedAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF_Cliente_Activo]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF_Cliente_CreatedAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[Especialista] ADD  CONSTRAINT [DF_Especialista_Disponible]  DEFAULT ((1)) FOR [disponible]
GO
ALTER TABLE [dbo].[Reporte] ADD  CONSTRAINT [DF_Reporte_Fecha]  DEFAULT (getdate()) FOR [fechaGenerada]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_Activo]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_CreatedAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[Administrador]  WITH CHECK ADD  CONSTRAINT [FK_Administrador_Usuario] FOREIGN KEY([idAdministrador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Administrador] CHECK CONSTRAINT [FK_Administrador_Usuario]
GO
ALTER TABLE [dbo].[Caso]  WITH CHECK ADD  CONSTRAINT [FK_Caso_Administrador] FOREIGN KEY([idAdministrador])
REFERENCES [dbo].[Administrador] ([idAdministrador])
GO
ALTER TABLE [dbo].[Caso] CHECK CONSTRAINT [FK_Caso_Administrador]
GO
ALTER TABLE [dbo].[Caso]  WITH CHECK ADD  CONSTRAINT [FK_Caso_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Caso] CHECK CONSTRAINT [FK_Caso_Cliente]
GO
ALTER TABLE [dbo].[Caso]  WITH CHECK ADD  CONSTRAINT [FK_Caso_Especialista] FOREIGN KEY([idEspecialista])
REFERENCES [dbo].[Especialista] ([idEspecialista])
GO
ALTER TABLE [dbo].[Caso] CHECK CONSTRAINT [FK_Caso_Especialista]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Caso] FOREIGN KEY([nroCaso])
REFERENCES [dbo].[Caso] ([nroCaso])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Caso]
GO
ALTER TABLE [dbo].[Especialista]  WITH CHECK ADD  CONSTRAINT [FK_Especialista_Area] FOREIGN KEY([idArea])
REFERENCES [dbo].[Area] ([idArea])
GO
ALTER TABLE [dbo].[Especialista] CHECK CONSTRAINT [FK_Especialista_Area]
GO
ALTER TABLE [dbo].[Especialista]  WITH CHECK ADD  CONSTRAINT [FK_Especialista_Usuario] FOREIGN KEY([idEspecialista])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Especialista] CHECK CONSTRAINT [FK_Especialista_Usuario]
GO
ALTER TABLE [dbo].[Reporte]  WITH CHECK ADD  CONSTRAINT [FK_Reporte_Administrador] FOREIGN KEY([idAdministrador])
REFERENCES [dbo].[Administrador] ([idAdministrador])
GO
ALTER TABLE [dbo].[Reporte] CHECK CONSTRAINT [FK_Reporte_Administrador]
GO
USE [master]
GO
ALTER DATABASE [BD_ALBAS] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [ServicioCheques]    Script Date: 26/02/2023 03:45:29 a. m. ******/
CREATE DATABASE [ServicioCheques]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ServicioCheques', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ServicioCheques.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ServicioCheques_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ServicioCheques_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ServicioCheques] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ServicioCheques].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ServicioCheques] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ServicioCheques] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ServicioCheques] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ServicioCheques] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ServicioCheques] SET ARITHABORT OFF 
GO
ALTER DATABASE [ServicioCheques] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ServicioCheques] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ServicioCheques] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ServicioCheques] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ServicioCheques] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ServicioCheques] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ServicioCheques] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ServicioCheques] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ServicioCheques] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ServicioCheques] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ServicioCheques] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ServicioCheques] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ServicioCheques] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ServicioCheques] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ServicioCheques] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ServicioCheques] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ServicioCheques] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ServicioCheques] SET RECOVERY FULL 
GO
ALTER DATABASE [ServicioCheques] SET  MULTI_USER 
GO
ALTER DATABASE [ServicioCheques] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ServicioCheques] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ServicioCheques] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ServicioCheques] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ServicioCheques] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ServicioCheques] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ServicioCheques', N'ON'
GO
ALTER DATABASE [ServicioCheques] SET QUERY_STORE = ON
GO
ALTER DATABASE [ServicioCheques] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ServicioCheques]
GO
/****** Object:  Table [dbo].[banco]    Script Date: 26/02/2023 03:45:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banco](
	[id_banco] [nvarchar](50) NOT NULL,
	[nombreBanco] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_banco] PRIMARY KEY CLUSTERED 
(
	[id_banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[beneficiaros]    Script Date: 26/02/2023 03:45:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beneficiaros](
	[id_beneficiario] [nvarchar](50) NOT NULL,
	[NomBeneficiaro] [nvarchar](50) NOT NULL,
	[domicilio] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
	[estatus] [nvarchar](50) NOT NULL,
	[firma] [nvarchar](50) NOT NULL,
	[plata] [int] NOT NULL,
	[contraseña] [nvarchar](50) NOT NULL,
	[nombreBanco] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_beneficiaros] PRIMARY KEY CLUSTERED 
(
	[id_beneficiario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cheques]    Script Date: 26/02/2023 03:45:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cheques](
	[folio] [nvarchar](50) NOT NULL,
	[id_banco] [nvarchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_beneficiario] [nvarchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
	[firma] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_cheques] PRIMARY KEY CLUSTERED 
(
	[folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 26/02/2023 03:45:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[nivel] [int] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[banco] ([id_banco], [nombreBanco]) VALUES (N'BNMX', N'Banamex')
GO
INSERT [dbo].[banco] ([id_banco], [nombreBanco]) VALUES (N'AZT', N'Banco Azteca')
GO
INSERT [dbo].[banco] ([id_banco], [nombreBanco]) VALUES (N'BBVA', N'Bancomer')
GO
INSERT [dbo].[banco] ([id_banco], [nombreBanco]) VALUES (N'DP', N'Daft Punk')
GO
INSERT [dbo].[banco] ([id_banco], [nombreBanco]) VALUES (N'MRX', N'Morax')
GO
INSERT [dbo].[banco] ([id_banco], [nombreBanco]) VALUES (N'SAN', N'Santander')
GO
INSERT [dbo].[beneficiaros] ([id_beneficiario], [NomBeneficiaro], [domicilio], [telefono], [estatus], [firma], [plata], [contraseña], [nombreBanco]) VALUES (N'AFG000', N'Alondra Fuentes Gonzales', N'COL. EX‑NORMAL TUXTEPEC', N'789456123123', N'On', N'Alondra Fuentes', N'53000', N'123', N'Santander')
GO
INSERT [dbo].[beneficiaros] ([id_beneficiario], [NomBeneficiaro], [domicilio], [telefono], [estatus], [firma], [plata], [contraseña], [nombreBanco]) VALUES (N'ASE001', N'Albedo Santos Escobar', N'COL. CENTRO TUXTEPEC', N'252536365462', N'On', N'Albedo Santos', N'56000', N'123', N'Santander')
GO
INSERT [dbo].[beneficiaros] ([id_beneficiario], [NomBeneficiaro], [domicilio], [telefono], [estatus], [firma], [plata], [contraseña], [nombreBanco]) VALUES (N'RRG002', N'Ramiro Rodriguez Garcia', N'MONTE ALBÁN No. 403, FRACC. SAN JOSÉ LA NORIA', N'321654987321', N'On', N'Ramiro Rodriguez', N'45623', N'123', N'Santander')
GO
INSERT [dbo].[beneficiaros] ([id_beneficiario], [NomBeneficiaro], [domicilio], [telefono], [estatus], [firma], [plata], [contraseña], [nombreBanco]) VALUES (N'ADPS003', N'Ana Daniela Paredes Soto', N'CALLE DE LA REFORMA 269, BALDERRAMA', N'654987312654', N'On', N'Ana Paredes', N'98563', N'123', N'Santander')
GO
INSERT [dbo].[beneficiaros] ([id_beneficiario], [NomBeneficiaro], [domicilio], [telefono], [estatus], [firma], [plata], [contraseña], [nombreBanco]) VALUES (N'AJAP004', N'Alicia Jimena Alvarez Paredes', N'CALLE. MORTEROS 70, MARROQUIN', N'312456789456', N'On', N'Alicia Alvarez', N'45900', N'123', N'Santander')
GO
INSERT [dbo].[cheques] ([folio], [id_banco], [fecha], [id_beneficiario], [cantidad], [estado],[firma]) VALUES (N'000000000001', N'BNMX', CAST(N'2023-02-19' AS Date), N'11112222333344445555', N'10000', N'Activo', N'Ramiro Rodriguez')
GO
INSERT [dbo].[cheques] ([folio], [id_banco], [fecha], [id_beneficiario], [cantidad], [estado],[firma]) VALUES (N'000000000002', N'AZT', CAST(N'2023-02-07' AS Date), N'44445555666677778888', N'500000', N'Activo', N'Ana Paredes')
GO
INSERT [dbo].[cheques] ([folio], [id_banco], [fecha], [id_beneficiario], [cantidad], [estado],[firma]) VALUES (N'000000000003', N'MRX', CAST(N'2022-05-13' AS Date), N'55556666777788889999', N'50', N'Activo', N'Alicia Alvarez')
GO

SET IDENTITY_INSERT [dbo].[usuarios] ON 
GO
INSERT [dbo].[usuarios] ([id_usuario], [usuario], [password], [NombreUsuario], [nivel]) VALUES (1, N'rjimenez', N'admin1', N'Raul Jimenez Martinez', 0)
GO
INSERT [dbo].[usuarios] ([id_usuario], [usuario], [password], [NombreUsuario], [nivel]) VALUES (2, N'HPerez', N'admin2', N'Hannia Perez Luna', 0)
GO
INSERT [dbo].[usuarios] ([id_usuario], [usuario], [password], [NombreUsuario], [nivel]) VALUES (4, N'CMarquez', N'caja1', N'Cristobal Marquez Soto', 1)
GO
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_banco]    Script Date: 26/02/2023 03:45:30 a. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_banco] ON [dbo].[banco]
(
	[nombreBanco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_firma]    Script Date: 26/02/2023 03:45:30 a. m. ******/
ALTER TABLE [dbo].[beneficiaros] ADD  CONSTRAINT [IX_firma] UNIQUE NONCLUSTERED 
(
	[firma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[beneficiaros]  WITH CHECK ADD  CONSTRAINT [FK_beneficiaros_banco] FOREIGN KEY([nombreBanco])
REFERENCES [dbo].[banco] ([nombreBanco])
GO
ALTER TABLE [dbo].[beneficiaros] CHECK CONSTRAINT [FK_beneficiaros_banco]
GO
ALTER TABLE [dbo].[cheques]  WITH CHECK ADD  CONSTRAINT [FK_cheques_banco] FOREIGN KEY([id_banco])
REFERENCES [dbo].[banco] ([id_banco])
GO
ALTER TABLE [dbo].[cheques] CHECK CONSTRAINT [FK_cheques_banco]
GO
ALTER TABLE [dbo].[cheques]  WITH CHECK ADD  CONSTRAINT [FK_cheques_beneficiaros] FOREIGN KEY([id_beneficiario])
REFERENCES [dbo].[beneficiaros] ([id_beneficiario])
GO
ALTER TABLE [dbo].[cheques] CHECK CONSTRAINT [FK_cheques_beneficiaros]
GO
USE [master]
GO
ALTER DATABASE [ServicioCheques] SET  READ_WRITE 
GO

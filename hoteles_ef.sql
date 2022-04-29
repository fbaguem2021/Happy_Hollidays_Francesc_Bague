DROP DATABASE IF EXISTS [hoteles_ef]
GO
CREATE DATABASE [hoteles_ef]
GO
/****** Object:  Database [hoteles_ef]    Script Date: 29/04/2022 11:27:11 ******/
CREATE DATABASE [hoteles_ef]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hoteles_ef', FILENAME = N'/var/opt/mssql/data/hoteles_ef.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'hoteles_ef_log', FILENAME = N'/var/opt/mssql/data/hoteles_ef_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [hoteles_ef] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hoteles_ef].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hoteles_ef] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hoteles_ef] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hoteles_ef] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hoteles_ef] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hoteles_ef] SET ARITHABORT OFF 
GO
ALTER DATABASE [hoteles_ef] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hoteles_ef] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hoteles_ef] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hoteles_ef] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hoteles_ef] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hoteles_ef] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hoteles_ef] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hoteles_ef] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hoteles_ef] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hoteles_ef] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hoteles_ef] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hoteles_ef] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hoteles_ef] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hoteles_ef] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hoteles_ef] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hoteles_ef] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hoteles_ef] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hoteles_ef] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hoteles_ef] SET  MULTI_USER 
GO
ALTER DATABASE [hoteles_ef] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hoteles_ef] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hoteles_ef] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hoteles_ef] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [hoteles_ef] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [hoteles_ef] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [hoteles_ef] SET QUERY_STORE = OFF
GO
USE [hoteles_ef]
GO
/****** Object:  Table [dbo].[act_hotel]    Script Date: 29/04/2022 11:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[act_hotel](
	[id_ciudad] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[id_act] [int] NOT NULL,
	[grado] [int] NULL,
 CONSTRAINT [PK_ACT_HOTEL_GRADO] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC,
	[nombre] ASC,
	[id_act] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[actividades]    Script Date: 29/04/2022 11:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actividades](
	[id_act] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ACTIVIDADES] PRIMARY KEY CLUSTERED 
(
	[id_act] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cadenas]    Script Date: 29/04/2022 11:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cadenas](
	[cif] [varchar](9) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[dir_fis] [varchar](50) NOT NULL,
 CONSTRAINT [pk_cadenas] PRIMARY KEY CLUSTERED 
(
	[cif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ciudades]    Script Date: 29/04/2022 11:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ciudades](
	[id_ciudad] [int] IDENTITY(200,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
 CONSTRAINT [pk_ciudades] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoteles]    Script Date: 29/04/2022 11:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoteles](
	[id_ciudad] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[categoria] [int] NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[tipo] [varchar](15) NOT NULL,
	[cif] [varchar](9) NOT NULL,
	[id] [int] NULL,
 CONSTRAINT [pk_hoteles] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC,
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Alexandra', 10, 6)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Alexandra', 11, 5)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Barcelona', 9, 10)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Barcelona', 11, 33)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Barcelona', 13, 23)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Madanis', 9, 89)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Madanis', 10, 100)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Madanis', 12, 12)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (1, N'Madanis', 14, 33)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Covadonga', 11, 45)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Juan Carlos I', 10, 65)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Juan Carlos I', 11, 85)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Juan Carlos I', 13, 15)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Juan Carlos I', 14, 12)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Madrid', 10, 42)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Madrid', 13, 25)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Oriente', 10, 14)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (2, N'Oriente', 14, 36)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (3, N'Pepe', 10, 12)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (3, N'Valencia', 9, 98)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (3, N'Valencia', 10, 10)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (3, N'Valencia', 11, 25)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (3, N'Valencia', 12, 36)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (3, N'Valencia', 13, 14)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (3, N'Valencia', 14, 27)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (4, N'Irte', 10, 12)
GO
INSERT [dbo].[act_hotel] ([id_ciudad], [nombre], [id_act], [grado]) VALUES (4, N'Xuriurdín', 12, 56)
GO
INSERT [dbo].[actividades] ([id_act], [descripcion]) VALUES (9, N'Mountainbike')
GO
INSERT [dbo].[actividades] ([id_act], [descripcion]) VALUES (10, N'Montar a caballo')
GO
INSERT [dbo].[actividades] ([id_act], [descripcion]) VALUES (11, N'Motos')
GO
INSERT [dbo].[actividades] ([id_act], [descripcion]) VALUES (12, N'Montar en globo')
GO
INSERT [dbo].[actividades] ([id_act], [descripcion]) VALUES (13, N'Tiro con arco')
GO
INSERT [dbo].[actividades] ([id_act], [descripcion]) VALUES (14, N'Tirolina')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A21394990', N'Intercontinental', N'Paseo de Gracia 120')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A23545451', N'NH', N'Av. Diagonal 230')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473819', N'Catalonia', N'Paseo de Gracia 120')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473820', N'H10', N'Av. Diagonal 230')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473821', N'Sol Meliá', N'C. Rosellón 123')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473822', N'HUSA', N'C. Urgel 45')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473823', N'Hilton', N'Pase de San Juan 123')
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473824', N'Tryp', N'Av. Diagonal 130')
GO
SET IDENTITY_INSERT [dbo].[ciudades] ON 
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (1, N'Barcelona')
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (4, N'Bilbao')
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (5, N'Córdoba')
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (203, N'Girona')
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (2, N'Madrid')
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (200, N'Santander')
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (3, N'Valencia')
GO
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (100, N'Vigo')
GO
SET IDENTITY_INSERT [dbo].[ciudades] OFF
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Alexandra', 4, N'Pau Clarís, 34', 343111124, N'PLAYA', N'A65473819', 1)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Barcelona', 4, N'Santa Ana 33', 934453812, N'PLAYA', N'A65473823', 2)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Calderon', 4, N'werewrew', 343111124, N'PLAYA', N'A65473819', 3)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Fernandez', 5, N'Regent Medieta 14', 934453812, N'PLAYA', N'A65473823', 4)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Isa', 3, N'Regente', 12345678, N'PLAYA', N'A65473820', 5)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Madanis', 4, N'Francesc Layret 12', 9322241, N'MONTAÑA', N'A65473821', 6)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Presidente', 4, N'Paseo Marítimo 1', 934446944, N'PLAYA', N'A65473824', 7)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Princesa Sofia', 4, N'Pelayo 14', 934465201, N'PLAYA', N'A65473820', 8)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Urquinaona', 4, N'Urquinaona, 9', 934445566, N'MONTAÑA', N'A65473824', 9)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (1, N'Varela''s', 5, N'Regent Medieta 14', 934453812, N'PLAYA', N'A65473823', 10)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (2, N'Cibeles', 5, N'Paseo de la Castellana 287', 917643212, N'MONTAÑA', N'A65473821', 11)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (2, N'Covadonga', 4, N'werewrew', 343111124, N'PLAYA', N'A65473819', 12)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (2, N'Imperial', 3, N'Plaza España, 2', 91222343, N'MONTAÑA', N'A65473821', 13)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (2, N'Juan Carlos I', 5, N'Lincoln 34', 914487213, N'MONTAÑA', N'A65473823', 14)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (2, N'Madrid', 5, N'Gaudí 31', 912310076, N'MONTAÑA', N'A65473823', 15)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (2, N'Olimpiadas', 4, N'Gran Vía, 324', 912223322, N'MONTAÑA', N'A65473823', 16)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (2, N'Oriente', 4, N'werewrew', 343111124, N'PLAYA', N'A65473819', 17)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (3, N'Mestalla', 4, N'Calle Mayor 124', 968444445, N'PLAYA', N'A65473822', 18)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (3, N'Moderno', 3, N'Aragón 21', 949075512, N'PLAYA', N'A65473821', 19)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (3, N'Pepe', 4, N'Calle Mayor 12', 9567543, N'PLAYA', N'A65473823', 20)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (3, N'Suizo', 4, N'werewrew', 343111124, N'PLAYA', N'A65473819', 21)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (3, N'Valencia', 4, N'Mestalla 7', 946334217, N'MONTAÑA', N'A65473823', 22)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (4, N'Chapela', 3, N'Calle Amianto 123', 98734521, N'MONTAÑA', N'A21394990', 23)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (4, N'Irte', 3, N'dfsdfds', 3423432, N'PLAYA', N'A65473820', 24)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (4, N'Xuriurdín', 4, N'Calle Sabino de Arana 12', 93442123, N'MONTAÑA', N'A65473822', 25)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (5, N'Carmen', 4, N'Calle Repetidos 21', 343111124, N'PLAYA', N'A65473819', 26)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (5, N'Colorines', 3, N'Calle Flores 12', 994839955, N'PLAYA', N'A65473820', 27)
GO
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif], [id]) VALUES (5, N'Olé', 5, N'Calle Esperanza 21', 4443543, N'PLAYA', N'A65473821', 28)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ciudades]    Script Date: 29/04/2022 11:27:12 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ciudades] ON [dbo].[ciudades]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[act_hotel]  WITH CHECK ADD  CONSTRAINT [FK_act_hotel1_actividades] FOREIGN KEY([id_act])
REFERENCES [dbo].[actividades] ([id_act])
GO
ALTER TABLE [dbo].[act_hotel] CHECK CONSTRAINT [FK_act_hotel1_actividades]
GO
ALTER TABLE [dbo].[act_hotel]  WITH CHECK ADD  CONSTRAINT [FK_act_hotel1_hoteles] FOREIGN KEY([id_ciudad], [nombre])
REFERENCES [dbo].[hoteles] ([id_ciudad], [nombre])
GO
ALTER TABLE [dbo].[act_hotel] CHECK CONSTRAINT [FK_act_hotel1_hoteles]
GO
ALTER TABLE [dbo].[hoteles]  WITH CHECK ADD  CONSTRAINT [fk_hoteles_cadenas] FOREIGN KEY([cif])
REFERENCES [dbo].[cadenas] ([cif])
GO
ALTER TABLE [dbo].[hoteles] CHECK CONSTRAINT [fk_hoteles_cadenas]
GO
ALTER TABLE [dbo].[hoteles]  WITH CHECK ADD  CONSTRAINT [fk_hoteles_ciudades] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[ciudades] ([id_ciudad])
GO
ALTER TABLE [dbo].[hoteles] CHECK CONSTRAINT [fk_hoteles_ciudades]
GO
ALTER DATABASE [hoteles_ef] SET  READ_WRITE 
GO

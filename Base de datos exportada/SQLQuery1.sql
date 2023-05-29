USE [master]
GO
/****** Object:  Database [APKProin]    Script Date: 17/11/2022 2:44:23 p. m. ******/
CREATE DATABASE [APKProin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'APKProin', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\APKProin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'APKProin_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\APKProin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [APKProin] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [APKProin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [APKProin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [APKProin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [APKProin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [APKProin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [APKProin] SET ARITHABORT OFF 
GO
ALTER DATABASE [APKProin] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [APKProin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [APKProin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [APKProin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [APKProin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [APKProin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [APKProin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [APKProin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [APKProin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [APKProin] SET  ENABLE_BROKER 
GO
ALTER DATABASE [APKProin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [APKProin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [APKProin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [APKProin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [APKProin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [APKProin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [APKProin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [APKProin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [APKProin] SET  MULTI_USER 
GO
ALTER DATABASE [APKProin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [APKProin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [APKProin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [APKProin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [APKProin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [APKProin] SET QUERY_STORE = OFF
GO
USE [APKProin]
GO
/****** Object:  Table [dbo].[tblEpleado]    Script Date: 17/11/2022 2:44:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEpleado](
	[codigo] [varchar](10) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[area] [varchar](30) NOT NULL,
	[cargo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblIngresoLogin]    Script Date: 17/11/2022 2:44:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIngresoLogin](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[clave] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblEpleado] ([codigo], [nombre], [apellido], [area], [cargo]) VALUES (N'i115', N'viviana farley', N'aristizabal', N'confeccion', N'confecionista')
GO
INSERT [dbo].[tblEpleado] ([codigo], [nombre], [apellido], [area], [cargo]) VALUES (N'i130', N'andres', N'villada', N'sistemas', N'analista')
GO
INSERT [dbo].[tblEpleado] ([codigo], [nombre], [apellido], [area], [cargo]) VALUES (N'i131', N'juan camilo', N'vargas', N'comercio', N'analista')
GO
INSERT [dbo].[tblEpleado] ([codigo], [nombre], [apellido], [area], [cargo]) VALUES (N'i140', N'juan david', N'palacio', N'confeccion', N'comercial')
GO
SET IDENTITY_INSERT [dbo].[tblIngresoLogin] ON 
GO
INSERT [dbo].[tblIngresoLogin] ([codigo], [usuario], [clave]) VALUES (1, N'andres', N'123')
GO
SET IDENTITY_INSERT [dbo].[tblIngresoLogin] OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_Ingresologin]    Script Date: 17/11/2022 2:44:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  CREATE PROCEDURE [dbo].[SP_Ingresologin] 
  @usuario varchar (30),
  @clave varchar (30) 
  as 
  begin 
  select * from tblIngresoLogin
  where tblIngresoLogin.usuario=@usuario and tblIngresoLogin.clave=@clave

  end
GO
USE [master]
GO
ALTER DATABASE [APKProin] SET  READ_WRITE 
GO

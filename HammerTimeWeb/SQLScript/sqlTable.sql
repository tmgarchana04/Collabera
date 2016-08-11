USE [master]
GO
/****** Object:  Database [HammerTime]    Script Date: 08/05/2016 23:58:12 ******/
CREATE DATABASE [HammerTime] ON  PRIMARY 
( NAME = N'HammerTime', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\HammerTime.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HammerTime_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\HammerTime_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HammerTime] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HammerTime].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HammerTime] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [HammerTime] SET ANSI_NULLS OFF
GO
ALTER DATABASE [HammerTime] SET ANSI_PADDING OFF
GO
ALTER DATABASE [HammerTime] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [HammerTime] SET ARITHABORT OFF
GO
ALTER DATABASE [HammerTime] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [HammerTime] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [HammerTime] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [HammerTime] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [HammerTime] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [HammerTime] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [HammerTime] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [HammerTime] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [HammerTime] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [HammerTime] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [HammerTime] SET  DISABLE_BROKER
GO
ALTER DATABASE [HammerTime] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [HammerTime] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [HammerTime] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [HammerTime] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [HammerTime] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [HammerTime] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [HammerTime] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [HammerTime] SET  READ_WRITE
GO
ALTER DATABASE [HammerTime] SET RECOVERY SIMPLE
GO
ALTER DATABASE [HammerTime] SET  MULTI_USER
GO
ALTER DATABASE [HammerTime] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [HammerTime] SET DB_CHAINING OFF
GO
USE [HammerTime]
GO
/****** Object:  Table [dbo].[product]    Script Date: 08/05/2016 23:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](256) NULL,
	[brand] [nvarchar](256) NULL,
	[material] [nvarchar](256) NULL,
	[setSize] [int] NULL,
	[color] [nvarchar](256) NULL,
	[weight] [nvarchar](256) NULL,
	[dimensions] [nvarchar](256) NULL,
	[packcontent] [nvarchar](256) NULL,
	[sku] [nvarchar](256) NULL,
	[description] [nvarchar](1024) NULL,
	[stockunit] [int] NULL,
	[minstockalertunit] [int] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[product] ON
INSERT [dbo].[product] ([id], [name], [brand], [material], [setSize], [color], [weight], [dimensions], [packcontent], [sku], [description], [stockunit], [minstockalertunit], [status]) VALUES (2, N'hammer 1', N'brand 1', N'material 1', 1, N'black', N'200 gms', N'100 x 100', N'content pack info', N'dfd343432232niji', N'hammer is good', 10, 2, 0)
SET IDENTITY_INSERT [dbo].[product] OFF

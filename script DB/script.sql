USE [master]
GO
/****** Object:  Database [SistemaRentaAutos]    Script Date: 04/10/2024 11:04:25 p. m. ******/
CREATE DATABASE [SistemaRentaAutos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaRentaAutos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaRentaAutos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaRentaAutos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaRentaAutos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SistemaRentaAutos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaRentaAutos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaRentaAutos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaRentaAutos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaRentaAutos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaRentaAutos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaRentaAutos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaRentaAutos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaRentaAutos] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaRentaAutos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaRentaAutos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaRentaAutos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaRentaAutos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaRentaAutos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaRentaAutos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaRentaAutos] SET QUERY_STORE = ON
GO
ALTER DATABASE [SistemaRentaAutos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SistemaRentaAutos]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 04/10/2024 11:04:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentas]    Script Date: 04/10/2024 11:04:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentas](
	[RentaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NULL,
	[VehiculoID] [int] NULL,
	[FechaRenta] [datetime] NOT NULL,
	[FechaDevolucion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 04/10/2024 11:04:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[VehiculoID] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](50) NULL,
	[Modelo] [nvarchar](50) NULL,
	[Año] [int] NULL,
	[Disponibilidad] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VehiculoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rentas]  WITH CHECK ADD FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([ClienteID])
GO
ALTER TABLE [dbo].[Rentas]  WITH CHECK ADD FOREIGN KEY([VehiculoID])
REFERENCES [dbo].[Vehiculos] ([VehiculoID])
GO
USE [master]
GO
ALTER DATABASE [SistemaRentaAutos] SET  READ_WRITE 
GO

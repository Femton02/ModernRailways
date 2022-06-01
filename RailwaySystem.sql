USE [master]
GO

/****** Object:  Database [RailWayStation]    Script Date: 1/10/2022 8:49:23 AM ******/
CREATE DATABASE [RailWayStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RailWayStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RailWayStation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RailWayStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RailWayStation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RailWayStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [RailWayStation] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [RailWayStation] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [RailWayStation] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [RailWayStation] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [RailWayStation] SET ARITHABORT OFF 
GO

ALTER DATABASE [RailWayStation] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [RailWayStation] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [RailWayStation] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [RailWayStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [RailWayStation] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [RailWayStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [RailWayStation] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [RailWayStation] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [RailWayStation] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [RailWayStation] SET  DISABLE_BROKER 
GO

ALTER DATABASE [RailWayStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [RailWayStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [RailWayStation] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [RailWayStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [RailWayStation] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [RailWayStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [RailWayStation] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [RailWayStation] SET RECOVERY FULL 
GO

ALTER DATABASE [RailWayStation] SET  MULTI_USER 
GO

ALTER DATABASE [RailWayStation] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [RailWayStation] SET DB_CHAINING OFF 
GO

ALTER DATABASE [RailWayStation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [RailWayStation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [RailWayStation] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [RailWayStation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [RailWayStation] SET QUERY_STORE = OFF
GO

ALTER DATABASE [RailWayStation] SET  READ_WRITE 
GO

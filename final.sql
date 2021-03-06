USE [master]
GO
/****** Object:  Database [RailWayStation]    Script Date: 1/10/2022 3:05:38 AM ******/
CREATE DATABASE [RailWayStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RailWayStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RailWayStation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RailWayStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RailWayStation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RailWayStation] SET COMPATIBILITY_LEVEL = 150
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
EXEC sys.sp_db_vardecimal_storage_format N'RailWayStation', N'ON'
GO
ALTER DATABASE [RailWayStation] SET QUERY_STORE = OFF
GO
USE [RailWayStation]
GO
/****** Object:  Table [dbo].[Coach]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coach](
	[Coach_ID] [int] NOT NULL,
	[Passengers_Number] [int] NOT NULL,
	[Max_Capacity] [int] NOT NULL,
 CONSTRAINT [PK_Coach] PRIMARY KEY CLUSTERED 
(
	[Coach_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintenanceTracks]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintenanceTracks](
	[MaaintenanceWorker_Email] [varchar](50) NOT NULL,
	[Track_ID] [int] NOT NULL,
 CONSTRAINT [PK_MaintenanceTracks] PRIMARY KEY CLUSTERED 
(
	[MaaintenanceWorker_Email] ASC,
	[Track_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintenanceTrainsInService]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintenanceTrainsInService](
	[MaintenaceWorkers_Email] [varchar](50) NOT NULL,
	[TrainsInService_ID] [int] NOT NULL,
 CONSTRAINT [PK_MaintenanceTrainsInService] PRIMARY KEY CLUSTERED 
(
	[MaintenaceWorkers_Email] ASC,
	[TrainsInService_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintenanceTrainsOutOfService]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintenanceTrainsOutOfService](
	[MaintenanceWorker_Email] [varchar](50) NOT NULL,
	[TrainOutOfService_ID] [int] NOT NULL,
 CONSTRAINT [PK_ManageMaintenance] PRIMARY KEY CLUSTERED 
(
	[MaintenanceWorker_Email] ASC,
	[TrainOutOfService_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintenanceWorker]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintenanceWorker](
	[MaintenanceWorker_Email] [varchar](50) NOT NULL,
	[MaintenanceFName] [varchar](50) NOT NULL,
	[MaintenanceLname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[MaintenanceWorker_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manage_Subscriptions]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manage_Subscriptions](
	[Manager_Email] [varchar](50) NOT NULL,
	[Subscription_ID] [int] NOT NULL,
 CONSTRAINT [PK_Manage_Subscriptions] PRIMARY KEY CLUSTERED 
(
	[Manager_Email] ASC,
	[Subscription_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manage_Tracks]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manage_Tracks](
	[Manager_Email] [varchar](50) NOT NULL,
	[Tracks_ID] [int] NOT NULL,
 CONSTRAINT [PK_Manage_Tracks] PRIMARY KEY CLUSTERED 
(
	[Manager_Email] ASC,
	[Tracks_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manage_Trains]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manage_Trains](
	[Manager_Email] [varchar](50) NOT NULL,
	[Train_ID] [int] NOT NULL,
 CONSTRAINT [PK_Manage_Trains] PRIMARY KEY CLUSTERED 
(
	[Manager_Email] ASC,
	[Train_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manage_Users]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manage_Users](
	[Manager_Email] [varchar](50) NOT NULL,
	[USERR_Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Manage_Users] PRIMARY KEY CLUSTERED 
(
	[Manager_Email] ASC,
	[USERR_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManageMaintenance]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManageMaintenance](
	[Manager_Email] [varchar](50) NOT NULL,
	[MantainanceWorker_Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ManageMaintenance_1] PRIMARY KEY CLUSTERED 
(
	[Manager_Email] ASC,
	[MantainanceWorker_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[Manager_Email] [varchar](50) NOT NULL,
	[Manager_Fname] [varchar](50) NOT NULL,
	[Manager_Lname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[Manager_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OnlineCustomer]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OnlineCustomer](
	[OnlineCustomer_Email] [varchar](50) NOT NULL,
	[OnlineCustomer_Fname] [varchar](50) NOT NULL,
	[OnlineCustomer_Lname] [varchar](50) NOT NULL,
	[Subscription_StartDate] [date] NULL,
	[Subscription_EndDate] [date] NULL,
	[Subscription_ID] [int] NULL,
 CONSTRAINT [PK_OnlineCustomer] PRIMARY KEY CLUSTERED 
(
	[OnlineCustomer_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[Passenger_NationalID] [int] NOT NULL,
	[Passenger_NumberOfWarnings] [int] NOT NULL,
 CONSTRAINT [PK_Passenger_1] PRIMARY KEY CLUSTERED 
(
	[Passenger_NationalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger_ISON_Trip]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger_ISON_Trip](
	[Trip_ID] [int] NOT NULL,
	[Passenger_SSN] [int] NOT NULL,
 CONSTRAINT [PK_Passenger_ISON_Trip] PRIMARY KEY CLUSTERED 
(
	[Trip_ID] ASC,
	[Passenger_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[Station_Name] [varchar](50) NOT NULL,
	[Number_Of_Trains] [int] NOT NULL,
	[Trains_In_Station] [int] NOT NULL,
 CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED 
(
	[Station_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscription]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscription](
	[Subscription_ID] [int] NOT NULL,
	[Subscription_Type] [varchar](50) NULL,
 CONSTRAINT [PK_Subscription] PRIMARY KEY CLUSTERED 
(
	[Subscription_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Train_ID] [int] NOT NULL,
	[Trip_ID] [int] NOT NULL,
	[Seat] [int] NOT NULL,
	[CoachID] [int] NOT NULL,
	[OnlineCustomer_Email] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Train_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketOfficeWorker]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketOfficeWorker](
	[Ticket_Office_Email] [varchar](50) NOT NULL,
	[Ticket_Office_FName] [varchar](50) NOT NULL,
	[Ticket_Office_LName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TicketOfficeWorker] PRIMARY KEY CLUSTERED 
(
	[Ticket_Office_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Track]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Track](
	[TrackSource] [varchar](50) NOT NULL,
	[TrackDest] [varchar](50) NOT NULL,
	[Track_ID] [int] NOT NULL,
 CONSTRAINT [PK_Track] PRIMARY KEY CLUSTERED 
(
	[Track_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracks_IN_Service]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracks_IN_Service](
	[Track_ID] [int] NOT NULL,
	[Period] [datetime] NOT NULL,
	[TripID] [int] NOT NULL,
 CONSTRAINT [PK_Tracks_IN_Service] PRIMARY KEY CLUSTERED 
(
	[Track_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracks_OUT_OfService]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracks_OUT_OfService](
	[Track_ID] [int] NOT NULL,
	[Malfunction_Date] [datetime] NOT NULL,
	[Return_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Tracks_OUT_OfService] PRIMARY KEY CLUSTERED 
(
	[Track_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Train_Coaches]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Train_Coaches](
	[Train_ID] [int] NOT NULL,
	[Coach_ID] [int] NOT NULL,
 CONSTRAINT [PK_Train_Coaches_1] PRIMARY KEY CLUSTERED 
(
	[Coach_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrainEmployee]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrainEmployee](
	[Train_Employee_Email] [varchar](50) NOT NULL,
	[Train_Employee_FName] [varchar](50) NOT NULL,
	[Train_Employee_LName] [varchar](50) NOT NULL,
	[Trip_ID] [int] NULL,
 CONSTRAINT [PK_TrainEmploee] PRIMARY KEY CLUSTERED 
(
	[Train_Employee_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trainn]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainn](
	[Train_ID] [int] NOT NULL,
 CONSTRAINT [PK_Trainn] PRIMARY KEY CLUSTERED 
(
	[Train_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trains_IN_Service]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trains_IN_Service](
	[Train_ID] [int] NOT NULL,
	[Trip_ID] [int] NOT NULL,
 CONSTRAINT [PK_Trains_IN_Service_1] PRIMARY KEY CLUSTERED 
(
	[Train_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trains_Out_OfService]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trains_Out_OfService](
	[Train_ID] [int] NOT NULL,
	[Malfunction_Date] [date] NOT NULL,
	[Return_Date] [date] NOT NULL,
 CONSTRAINT [PK_Trains_Out_OfService] PRIMARY KEY CLUSTERED 
(
	[Train_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[TripID] [int] NOT NULL,
	[Source] [varchar](50) NOT NULL,
	[Destination] [varchar](50) NOT NULL,
	[Trip_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Trip] PRIMARY KEY CLUSTERED 
(
	[TripID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERR]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERR](
	[USERR_NationalID] [int] NOT NULL,
	[USERR_FName] [varchar](50) NOT NULL,
	[USERR_LName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Sex] [varchar](10) NOT NULL,
	[Date_Of_Birth] [date] NOT NULL,
 CONSTRAINT [PK_USERR] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warns]    Script Date: 1/10/2022 3:05:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warns](
	[TrainEmployee_Email] [varchar](50) NOT NULL,
	[Passenger_SSN] [int] NOT NULL,
	[Warn_Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Warns] PRIMARY KEY CLUSTERED 
(
	[TrainEmployee_Email] ASC,
	[Passenger_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MaintenanceTracks]  WITH CHECK ADD  CONSTRAINT [FK_MaintenanceWorker_MaintenanceTracks] FOREIGN KEY([MaaintenanceWorker_Email])
REFERENCES [dbo].[MaintenanceWorker] ([MaintenanceWorker_Email])
GO
ALTER TABLE [dbo].[MaintenanceTracks] CHECK CONSTRAINT [FK_MaintenanceWorker_MaintenanceTracks]
GO
ALTER TABLE [dbo].[MaintenanceTracks]  WITH CHECK ADD  CONSTRAINT [FK_Tracks_MaintenanceTracks] FOREIGN KEY([Track_ID])
REFERENCES [dbo].[Track] ([Track_ID])
GO
ALTER TABLE [dbo].[MaintenanceTracks] CHECK CONSTRAINT [FK_Tracks_MaintenanceTracks]
GO
ALTER TABLE [dbo].[MaintenanceTrainsInService]  WITH CHECK ADD  CONSTRAINT [FK_MaintenanceWorker_MaintenanceTrainsInService] FOREIGN KEY([MaintenaceWorkers_Email])
REFERENCES [dbo].[MaintenanceWorker] ([MaintenanceWorker_Email])
GO
ALTER TABLE [dbo].[MaintenanceTrainsInService] CHECK CONSTRAINT [FK_MaintenanceWorker_MaintenanceTrainsInService]
GO
ALTER TABLE [dbo].[MaintenanceTrainsInService]  WITH CHECK ADD  CONSTRAINT [FK_TrainsInService_MaintenanceTrainsInService] FOREIGN KEY([TrainsInService_ID])
REFERENCES [dbo].[Trains_IN_Service] ([Train_ID])
GO
ALTER TABLE [dbo].[MaintenanceTrainsInService] CHECK CONSTRAINT [FK_TrainsInService_MaintenanceTrainsInService]
GO
ALTER TABLE [dbo].[MaintenanceTrainsOutOfService]  WITH CHECK ADD  CONSTRAINT [FK_TrainOutOfService_ManageMaintenance] FOREIGN KEY([TrainOutOfService_ID])
REFERENCES [dbo].[Trains_Out_OfService] ([Train_ID])
GO
ALTER TABLE [dbo].[MaintenanceTrainsOutOfService] CHECK CONSTRAINT [FK_TrainOutOfService_ManageMaintenance]
GO
ALTER TABLE [dbo].[MaintenanceWorker]  WITH CHECK ADD  CONSTRAINT [FK_USERR_MaintenanceWorker] FOREIGN KEY([MaintenanceWorker_Email])
REFERENCES [dbo].[USERR] ([Email])
GO
ALTER TABLE [dbo].[MaintenanceWorker] CHECK CONSTRAINT [FK_USERR_MaintenanceWorker]
GO
ALTER TABLE [dbo].[Manage_Subscriptions]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Manage_Subscriptions] FOREIGN KEY([Manager_Email])
REFERENCES [dbo].[Manager] ([Manager_Email])
GO
ALTER TABLE [dbo].[Manage_Subscriptions] CHECK CONSTRAINT [FK_Manager_Manage_Subscriptions]
GO
ALTER TABLE [dbo].[Manage_Subscriptions]  WITH CHECK ADD  CONSTRAINT [FK_Subscriptions_Manage_Subscriptions1] FOREIGN KEY([Subscription_ID])
REFERENCES [dbo].[Subscription] ([Subscription_ID])
GO
ALTER TABLE [dbo].[Manage_Subscriptions] CHECK CONSTRAINT [FK_Subscriptions_Manage_Subscriptions1]
GO
ALTER TABLE [dbo].[Manage_Tracks]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Manage_Tracks] FOREIGN KEY([Manager_Email])
REFERENCES [dbo].[Manager] ([Manager_Email])
GO
ALTER TABLE [dbo].[Manage_Tracks] CHECK CONSTRAINT [FK_Manager_Manage_Tracks]
GO
ALTER TABLE [dbo].[Manage_Tracks]  WITH CHECK ADD  CONSTRAINT [FK_Tracks_Manage_Tracks1] FOREIGN KEY([Tracks_ID])
REFERENCES [dbo].[Track] ([Track_ID])
GO
ALTER TABLE [dbo].[Manage_Tracks] CHECK CONSTRAINT [FK_Tracks_Manage_Tracks1]
GO
ALTER TABLE [dbo].[Manage_Trains]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Manage_Trains] FOREIGN KEY([Manager_Email])
REFERENCES [dbo].[Manager] ([Manager_Email])
GO
ALTER TABLE [dbo].[Manage_Trains] CHECK CONSTRAINT [FK_Manager_Manage_Trains]
GO
ALTER TABLE [dbo].[Manage_Trains]  WITH CHECK ADD  CONSTRAINT [FK_Trains_Manage_Trains] FOREIGN KEY([Train_ID])
REFERENCES [dbo].[Trainn] ([Train_ID])
GO
ALTER TABLE [dbo].[Manage_Trains] CHECK CONSTRAINT [FK_Trains_Manage_Trains]
GO
ALTER TABLE [dbo].[Manage_Users]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Manage_Users] FOREIGN KEY([Manager_Email])
REFERENCES [dbo].[Manager] ([Manager_Email])
GO
ALTER TABLE [dbo].[Manage_Users] CHECK CONSTRAINT [FK_Manager_Manage_Users]
GO
ALTER TABLE [dbo].[Manage_Users]  WITH CHECK ADD  CONSTRAINT [FK_User_Manage_Users] FOREIGN KEY([USERR_Email])
REFERENCES [dbo].[USERR] ([Email])
GO
ALTER TABLE [dbo].[Manage_Users] CHECK CONSTRAINT [FK_User_Manage_Users]
GO
ALTER TABLE [dbo].[ManageMaintenance]  WITH CHECK ADD  CONSTRAINT [FK_MaintenanceWorker_ManageMaintenance] FOREIGN KEY([MantainanceWorker_Email])
REFERENCES [dbo].[MaintenanceWorker] ([MaintenanceWorker_Email])
GO
ALTER TABLE [dbo].[ManageMaintenance] CHECK CONSTRAINT [FK_MaintenanceWorker_ManageMaintenance]
GO
ALTER TABLE [dbo].[ManageMaintenance]  WITH CHECK ADD  CONSTRAINT [FK_Manager_ManageMaintenance] FOREIGN KEY([Manager_Email])
REFERENCES [dbo].[Manager] ([Manager_Email])
GO
ALTER TABLE [dbo].[ManageMaintenance] CHECK CONSTRAINT [FK_Manager_ManageMaintenance]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_USERR_Manager] FOREIGN KEY([Manager_Email])
REFERENCES [dbo].[USERR] ([Email])
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_USERR_Manager]
GO
ALTER TABLE [dbo].[OnlineCustomer]  WITH CHECK ADD  CONSTRAINT [FK_Subscription_OnlineCustomer] FOREIGN KEY([Subscription_ID])
REFERENCES [dbo].[Subscription] ([Subscription_ID])
GO
ALTER TABLE [dbo].[OnlineCustomer] CHECK CONSTRAINT [FK_Subscription_OnlineCustomer]
GO
ALTER TABLE [dbo].[Passenger_ISON_Trip]  WITH CHECK ADD  CONSTRAINT [FK_Passenger_Passenger_ISON_Trip] FOREIGN KEY([Passenger_SSN])
REFERENCES [dbo].[Passenger] ([Passenger_NationalID])
GO
ALTER TABLE [dbo].[Passenger_ISON_Trip] CHECK CONSTRAINT [FK_Passenger_Passenger_ISON_Trip]
GO
ALTER TABLE [dbo].[Passenger_ISON_Trip]  WITH CHECK ADD  CONSTRAINT [FK_Trip_Passenger_ISON_Trip] FOREIGN KEY([Trip_ID])
REFERENCES [dbo].[Trip] ([TripID])
GO
ALTER TABLE [dbo].[Passenger_ISON_Trip] CHECK CONSTRAINT [FK_Trip_Passenger_ISON_Trip]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_OnlineCustomer_Ticket] FOREIGN KEY([OnlineCustomer_Email])
REFERENCES [dbo].[OnlineCustomer] ([OnlineCustomer_Email])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_OnlineCustomer_Ticket]
GO
ALTER TABLE [dbo].[TicketOfficeWorker]  WITH CHECK ADD  CONSTRAINT [FK_User_TicketOfficeWorker] FOREIGN KEY([Ticket_Office_Email])
REFERENCES [dbo].[USERR] ([Email])
GO
ALTER TABLE [dbo].[TicketOfficeWorker] CHECK CONSTRAINT [FK_User_TicketOfficeWorker]
GO
ALTER TABLE [dbo].[Track]  WITH CHECK ADD  CONSTRAINT [FK_Station_Track] FOREIGN KEY([TrackSource])
REFERENCES [dbo].[Station] ([Station_Name])
GO
ALTER TABLE [dbo].[Track] CHECK CONSTRAINT [FK_Station_Track]
GO
ALTER TABLE [dbo].[Track]  WITH CHECK ADD  CONSTRAINT [FK_StationDest_Track] FOREIGN KEY([TrackDest])
REFERENCES [dbo].[Station] ([Station_Name])
GO
ALTER TABLE [dbo].[Track] CHECK CONSTRAINT [FK_StationDest_Track]
GO
ALTER TABLE [dbo].[Tracks_IN_Service]  WITH CHECK ADD  CONSTRAINT [FK_Tracks_Tracks_IN_Service] FOREIGN KEY([Track_ID])
REFERENCES [dbo].[Track] ([Track_ID])
GO
ALTER TABLE [dbo].[Tracks_IN_Service] CHECK CONSTRAINT [FK_Tracks_Tracks_IN_Service]
GO
ALTER TABLE [dbo].[Tracks_OUT_OfService]  WITH CHECK ADD  CONSTRAINT [FK_Tracks_Tracks_OUT_OfService] FOREIGN KEY([Track_ID])
REFERENCES [dbo].[Track] ([Track_ID])
GO
ALTER TABLE [dbo].[Tracks_OUT_OfService] CHECK CONSTRAINT [FK_Tracks_Tracks_OUT_OfService]
GO
ALTER TABLE [dbo].[Train_Coaches]  WITH CHECK ADD  CONSTRAINT [FK_Coaches_Train_Coaches] FOREIGN KEY([Coach_ID])
REFERENCES [dbo].[Coach] ([Coach_ID])
GO
ALTER TABLE [dbo].[Train_Coaches] CHECK CONSTRAINT [FK_Coaches_Train_Coaches]
GO
ALTER TABLE [dbo].[Train_Coaches]  WITH CHECK ADD  CONSTRAINT [FK_Train_Train_Coaches] FOREIGN KEY([Train_ID])
REFERENCES [dbo].[Trains_IN_Service] ([Train_ID])
GO
ALTER TABLE [dbo].[Train_Coaches] CHECK CONSTRAINT [FK_Train_Train_Coaches]
GO
ALTER TABLE [dbo].[TrainEmployee]  WITH CHECK ADD  CONSTRAINT [FK_Trip_TrainEmployee] FOREIGN KEY([Trip_ID])
REFERENCES [dbo].[Trip] ([TripID])
GO
ALTER TABLE [dbo].[TrainEmployee] CHECK CONSTRAINT [FK_Trip_TrainEmployee]
GO
ALTER TABLE [dbo].[TrainEmployee]  WITH CHECK ADD  CONSTRAINT [FK_User_TrainEmploee] FOREIGN KEY([Train_Employee_Email])
REFERENCES [dbo].[USERR] ([Email])
GO
ALTER TABLE [dbo].[TrainEmployee] CHECK CONSTRAINT [FK_User_TrainEmploee]
GO
ALTER TABLE [dbo].[Trains_Out_OfService]  WITH CHECK ADD  CONSTRAINT [FK_Trains_Trains_Out_OfService] FOREIGN KEY([Train_ID])
REFERENCES [dbo].[Trainn] ([Train_ID])
GO
ALTER TABLE [dbo].[Trains_Out_OfService] CHECK CONSTRAINT [FK_Trains_Trains_Out_OfService]
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD  CONSTRAINT [FK_Station_Trip] FOREIGN KEY([Source])
REFERENCES [dbo].[Station] ([Station_Name])
GO
ALTER TABLE [dbo].[Trip] CHECK CONSTRAINT [FK_Station_Trip]
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD  CONSTRAINT [FK_StationDest_Trip] FOREIGN KEY([Destination])
REFERENCES [dbo].[Station] ([Station_Name])
GO
ALTER TABLE [dbo].[Trip] CHECK CONSTRAINT [FK_StationDest_Trip]
GO
ALTER TABLE [dbo].[Warns]  WITH CHECK ADD  CONSTRAINT [FK_TrainEmployee_Warns] FOREIGN KEY([TrainEmployee_Email])
REFERENCES [dbo].[TrainEmployee] ([Train_Employee_Email])
GO
ALTER TABLE [dbo].[Warns] CHECK CONSTRAINT [FK_TrainEmployee_Warns]
GO
ALTER TABLE [dbo].[Warns]  WITH CHECK ADD  CONSTRAINT [FK_Warns_Passenger] FOREIGN KEY([Passenger_SSN])
REFERENCES [dbo].[Passenger] ([Passenger_NationalID])
GO
ALTER TABLE [dbo].[Warns] CHECK CONSTRAINT [FK_Warns_Passenger]
GO
USE [master]
GO
ALTER DATABASE [RailWayStation] SET  READ_WRITE 
GO

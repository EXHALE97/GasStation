USE [master]
GO
/****** Object:  Database [gas_station]    Script Date: 4/25/2021 4:01:24 PM ******/
CREATE DATABASE [gas_station]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gas_station', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gas_station.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gas_station_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gas_station_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gas_station] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gas_station].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gas_station] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gas_station] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gas_station] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gas_station] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gas_station] SET ARITHABORT OFF 
GO
ALTER DATABASE [gas_station] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gas_station] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gas_station] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gas_station] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gas_station] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gas_station] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gas_station] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gas_station] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gas_station] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gas_station] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gas_station] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gas_station] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gas_station] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gas_station] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gas_station] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gas_station] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gas_station] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gas_station] SET RECOVERY FULL 
GO
ALTER DATABASE [gas_station] SET  MULTI_USER 
GO
ALTER DATABASE [gas_station] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gas_station] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gas_station] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gas_station] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gas_station] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gas_station] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'gas_station', N'ON'
GO
ALTER DATABASE [gas_station] SET QUERY_STORE = OFF
GO
USE [gas_station]
GO
/****** Object:  User [Worker]    Script Date: 4/25/2021 4:01:24 PM ******/
CREATE USER [Worker] FOR LOGIN [GasStationWorker] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [User]    Script Date: 4/25/2021 4:01:24 PM ******/
CREATE USER [User] FOR LOGIN [GasStationUser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Admin]    Script Date: 4/25/2021 4:01:24 PM ******/
CREATE USER [Admin] FOR LOGIN [GasStationAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Worker]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Worker]
GO
ALTER ROLE [db_datareader] ADD MEMBER [User]
GO
ALTER ROLE [db_owner] ADD MEMBER [Admin]
GO
/****** Object:  UserDefinedFunction [dbo].[CountFinalDealPrice]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CountFinalDealPrice](@supply_amount FLOAT, @supply_type_id INT, @discount_percent INT = 0)
RETURNS FLOAT
AS
BEGIN
	DECLARE @full_price FLOAT, @supply_price FLOAT, @final_price FLOAT;
	SELECT @supply_price = price FROM SupplyType WHERE id = @supply_type_id
	SET @full_price = @supply_amount * @supply_price
	IF(@discount_percent = 0)
		SET @final_price = @full_price * (100 - @discount_percent)/100
	ELSE
		SET @final_price = @full_price
	RETURN @final_price
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetClientFullName]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetClientFullName](@id INT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @full_name NVARCHAR(MAX);
	DECLARE @first_name NVARCHAR(50), @last_name NVARCHAR(50), @middle_name NVARCHAR(50)
	SELECT @first_name = first_name, @last_name = last_name, @middle_name = middle_name FROM Client WHERE id = @id;
	IF(@middle_name = null)
		SET @full_name = @last_name + ' ' + @first_name;
	ELSE IF(@middle_name = null AND @last_name = null)
		SET @full_name = @first_name;
	ELSE IF(@middle_name = null AND @last_name = null AND @first_name = null)
		SET @full_name = NULL;
	ELSE
		SET @full_name = @last_name + ' ' + @first_name + ' ' + @middle_name;
RETURN @full_name;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetEmployeeFullName]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GetEmployeeFullName](@id INT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @full_name NVARCHAR(MAX);
	DECLARE @first_name NVARCHAR(50), @last_name NVARCHAR(50), @middle_name NVARCHAR(50)
	SELECT @first_name = first_name, @last_name = last_name, @middle_name = middle_name FROM Employee WHERE id = @id;
	IF(@middle_name = null)
		SET @full_name = @last_name + ' ' + @first_name;
	ELSE
		SET @full_name = @last_name + ' ' + @first_name + ' ' + @middle_name;
RETURN @full_name;
END;
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[middle_name] [nvarchar](50) NULL,
	[position] [nvarchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[date_of_employment] [date] NOT NULL,
	[date_of_contract_end] [date] NOT NULL,
	[salary] [float] NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[cred_id] [int] NULL,
	[is_working] [bit] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[is_working] [bit] NOT NULL,
 CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Unique_Name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplyType]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplyType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[is_selling] [bit] NOT NULL,
 CONSTRAINT [PK_SupplyType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supply]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supply](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[station_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
	[supply_type_id] [int] NOT NULL,
	[supply_amount] [float] NOT NULL,
	[date] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Supply] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[SupplyFullInfo]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SupplyFullInfo]
AS
SELECT Supply.id, Supply.station_id, Station.name AS station_name, Supply.employee_id, dbo.GetEmployeeFullName(Supply.employee_id) AS employee_name,
Supply.supply_type_id, SupplyType.name AS supply_type_name, Supply.supply_amount, Supply.date
FROM Supply 
INNER JOIN Station ON Supply.station_id = Station.id 
INNER JOIN Employee ON Supply.employee_id = Employee.id
INNER JOIN SupplyType ON Supply.supply_type_id = SupplyType.id
GO
/****** Object:  Table [dbo].[SupplyByStation]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplyByStation](
	[station_id] [int] NOT NULL,
	[supply_type_id] [int] NOT NULL,
	[supply_count] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[SupplyByStationFullInfo]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SupplyByStationFullInfo]
AS
SELECT SupplyByStation.station_id, Station.name AS station_name, SupplyByStation.supply_type_id, SupplyType.name AS supply_type_name, SupplyByStation.supply_count
FROM SupplyByStation 
INNER JOIN Station ON SupplyByStation.station_id = Station.id
INNER JOIN SupplyType ON SupplyByStation.supply_type_id = SupplyType.id
GO
/****** Object:  Table [dbo].[ClientCard]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientCard](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[discount_percent] [int] NOT NULL,
	[activation_date] [date] NULL,
 CONSTRAINT [PK_ClientCard] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[middle_name] [nvarchar](50) NULL,
	[card_id] [int] NOT NULL,
	[cred_id] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Client] UNIQUE NONCLUSTERED 
(
	[card_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Client_1] UNIQUE NONCLUSTERED 
(
	[cred_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ClientWithCardInfo]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ClientWithCardInfo]
AS
SELECT        dbo.Client.id, dbo.Client.first_name, dbo.Client.last_name, dbo.Client.middle_name, dbo.Client.card_id, dbo.ClientCard.discount_percent, dbo.ClientCard.activation_date, dbo.Client.cred_id
FROM            dbo.Client INNER JOIN
                         dbo.ClientCard ON dbo.Client.card_id = dbo.ClientCard.id
GO
/****** Object:  Table [dbo].[Deal]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NULL,
	[employee_id] [int] NOT NULL,
	[supply_type_id] [int] NOT NULL,
	[supply_type_amount] [float] NOT NULL,
	[price] [float] NOT NULL,
	[date] [smalldatetime] NULL,
	[station_id] [int] NOT NULL,
 CONSTRAINT [PK_Deal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DealFullInfo]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DealFullInfo]
AS
SELECT        dbo.Deal.id, dbo.Deal.client_id, dbo.ClientWithCardInfo.card_id, CONCAT_WS(' ', dbo.ClientWithCardInfo.first_name, dbo.ClientWithCardInfo.last_name, dbo.ClientWithCardInfo.middle_name) AS client_data, 
                         dbo.Deal.employee_id, CONCAT_WS(' ', dbo.Employee.first_name, dbo.Employee.last_name, dbo.Employee.middle_name) AS employee_data, dbo.Deal.station_id, dbo.Station.name AS station_name, dbo.Deal.supply_type_id, 
                         dbo.SupplyType.name AS supply_type, dbo.Deal.supply_type_amount, dbo.ClientWithCardInfo.discount_percent, dbo.Deal.price, dbo.Deal.date
FROM            dbo.Deal INNER JOIN
                         dbo.ClientWithCardInfo ON dbo.Deal.client_id = dbo.ClientWithCardInfo.id INNER JOIN
                         dbo.Employee ON dbo.Deal.employee_id = dbo.Employee.id INNER JOIN
                         dbo.Station ON dbo.Deal.station_id = dbo.Station.id INNER JOIN
                         dbo.SupplyType ON dbo.Deal.supply_type_id = dbo.SupplyType.id
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credentials](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Credentials] UNIQUE NONCLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[operation] [nvarchar](max) NOT NULL,
	[create_at] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [idx_cred_id_notnull]    Script Date: 4/25/2021 4:01:25 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [idx_cred_id_notnull] ON [dbo].[Employee]
(
	[cred_id] ASC
)
WHERE ([cred_id] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Deal] ADD  CONSTRAINT [DF_Deal_employee_id]  DEFAULT ((0)) FOR [employee_id]
GO
ALTER TABLE [dbo].[Deal] ADD  CONSTRAINT [DF_Deal_station_id]  DEFAULT ((0)) FOR [station_id]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_is_working]  DEFAULT ((1)) FOR [is_working]
GO
ALTER TABLE [dbo].[History] ADD  DEFAULT (getdate()) FOR [create_at]
GO
ALTER TABLE [dbo].[Station] ADD  CONSTRAINT [DF_Station_is_working]  DEFAULT ((1)) FOR [is_working]
GO
ALTER TABLE [dbo].[Supply] ADD  CONSTRAINT [DF_Supply_date]  DEFAULT (getdate()) FOR [date]
GO
ALTER TABLE [dbo].[SupplyType] ADD  CONSTRAINT [DF_SupplyType_is_selling]  DEFAULT ((1)) FOR [is_selling]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientCard] FOREIGN KEY([card_id])
REFERENCES [dbo].[ClientCard] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientCard]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Credentials] FOREIGN KEY([cred_id])
REFERENCES [dbo].[Credentials] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Credentials]
GO
ALTER TABLE [dbo].[Deal]  WITH CHECK ADD  CONSTRAINT [FK_Deal_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Deal] CHECK CONSTRAINT [FK_Deal_Employee]
GO
ALTER TABLE [dbo].[Deal]  WITH CHECK ADD  CONSTRAINT [FK_Deal_Station] FOREIGN KEY([station_id])
REFERENCES [dbo].[Station] ([id])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Deal] CHECK CONSTRAINT [FK_Deal_Station]
GO
ALTER TABLE [dbo].[Deal]  WITH CHECK ADD  CONSTRAINT [FK_Deal_SupplyType] FOREIGN KEY([supply_type_id])
REFERENCES [dbo].[SupplyType] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Deal] CHECK CONSTRAINT [FK_Deal_SupplyType]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Credentials] FOREIGN KEY([cred_id])
REFERENCES [dbo].[Credentials] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Credentials]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Credentials] FOREIGN KEY([user_id])
REFERENCES [dbo].[Credentials] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Credentials]
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_Employee]
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_Station] FOREIGN KEY([station_id])
REFERENCES [dbo].[Station] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_Station]
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_SupplyType] FOREIGN KEY([supply_type_id])
REFERENCES [dbo].[SupplyType] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_SupplyType]
GO
ALTER TABLE [dbo].[SupplyByStation]  WITH CHECK ADD  CONSTRAINT [FK_SupplyByStation_Station] FOREIGN KEY([station_id])
REFERENCES [dbo].[Station] ([id])
GO
ALTER TABLE [dbo].[SupplyByStation] CHECK CONSTRAINT [FK_SupplyByStation_Station]
GO
ALTER TABLE [dbo].[SupplyByStation]  WITH CHECK ADD  CONSTRAINT [FK_SupplyByStation_SupplyType] FOREIGN KEY([supply_type_id])
REFERENCES [dbo].[SupplyType] ([id])
GO
ALTER TABLE [dbo].[SupplyByStation] CHECK CONSTRAINT [FK_SupplyByStation_SupplyType]
GO
ALTER TABLE [dbo].[SupplyByStation]  WITH CHECK ADD  CONSTRAINT [CK_SupplyByStation] CHECK  (([supply_count]>=(0)))
GO
ALTER TABLE [dbo].[SupplyByStation] CHECK CONSTRAINT [CK_SupplyByStation]
GO
/****** Object:  StoredProcedure [dbo].[AddSupplyType]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddSupplyType] @name NVARCHAR(50), @price FLOAT, @is_selling NVARCHAR(5)
AS
INSERT INTO SupplyType VALUES(@name, @price, @is_selling)
GO
/****** Object:  StoredProcedure [dbo].[ClientsSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClientsSummary]
AS
Select * from ClientWithCardInfo
GO
/****** Object:  StoredProcedure [dbo].[DealsSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DealsSummary]
AS
Select * from DealFullInfo
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteEmployee] @id INT
AS
DELETE FROM Employee WHERE id = @id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplyType]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSupplyType] @id INT
AS
DELETE FROM SupplyType WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[EmployeesSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployeesSummary]
AS
Select * from Employee
GO
/****** Object:  StoredProcedure [dbo].[GetActivatedClientCards]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetActivatedClientCards]
AS
SELECT id FROM ClientCard WHERE activation_date IS NOT NULL
GO
/****** Object:  StoredProcedure [dbo].[GetAllStationCities]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAllStationCities]
AS
SELECT DISTINCT city FROM Station
GO
/****** Object:  StoredProcedure [dbo].[GetClientByClientCardId]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetClientByClientCardId] @card_id INT
AS
SELECT * FROM ClientWithCardInfo WHERE card_id = @card_id
GO
/****** Object:  StoredProcedure [dbo].[GetClientIdByCredId]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetClientIdByCredId] @cred_id INT
AS
SELECT id FROM Client where cred_id = @cred_id
GO
/****** Object:  StoredProcedure [dbo].[GetCredentialsById]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCredentialsById] @id INT
AS
SELECT * FROM Credentials WHERE id = @id;
GO
/****** Object:  StoredProcedure [dbo].[GetCredentialsByLogin]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCredentialsByLogin]
@login NVARCHAR(50)
AS
SELECT * FROM Credentials WHERE login = @login;
GO
/****** Object:  StoredProcedure [dbo].[GetCredentialsLogins]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCredentialsLogins]
AS
SELECT login FROM Credentials;
GO
/****** Object:  StoredProcedure [dbo].[GetCredentialsRole]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCredentialsRole]
@login NVARCHAR(50), @password NVARCHAR(50)
AS
SELECT role FROM Credentials WHERE login = @login and password = @password;
GO
/****** Object:  StoredProcedure [dbo].[GetCredIdByLogin]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCredIdByLogin]
@login NVARCHAR(50)
AS
SELECT id FROM Credentials WHERE login = @login;
GO
/****** Object:  StoredProcedure [dbo].[GetDealsByClient]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDealsByClient] @client_id INT
AS
SELECT * FROM DealFullInfo WHERE client_id = @client_id
GO
/****** Object:  StoredProcedure [dbo].[GetDealsByEmployee]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDealsByEmployee] @employee_id INT
AS
SELECT * FROM DealFullInfo WHERE employee_id = @employee_id
GO
/****** Object:  StoredProcedure [dbo].[GetDealsByStation]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDealsByStation] @station_id INT
AS
SELECT * FROM DealFullInfo WHERE station_id = @station_id
GO
/****** Object:  StoredProcedure [dbo].[GetNonActivatedClientCardId]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[GetNonActivatedClientCardId]
AS
select id from ClientCard except select card_id from client
GO
/****** Object:  StoredProcedure [dbo].[GetStationIdByName]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[GetStationIdByName] @name NVARCHAR(50)
AS
SELECT id from Station WHERE name = @name
GO
/****** Object:  StoredProcedure [dbo].[GetStationsByCity]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetStationsByCity] @city NVARCHAR(50)
AS
SELECT * FROM Station where city = @city
GO
/****** Object:  StoredProcedure [dbo].[GetSupplyAmountByStationId]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetSupplyAmountByStationId] @station_id INT
AS
SELECT * FROM SupplyByStationFullInfo WHERE station_id = @station_id
GO
/****** Object:  StoredProcedure [dbo].[GetSupplyTypeIdByName]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSupplyTypeIdByName] @name NVARCHAR(50)
AS
Select id from SupplyType WHERE name = @name;
GO
/****** Object:  StoredProcedure [dbo].[GetSupplyTypePriceByName]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSupplyTypePriceByName] @name NVARCHAR(50)
AS
SELECT price FROM SupplyType WHERE name = @name
GO
/****** Object:  StoredProcedure [dbo].[HistorySummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HistorySummary]
As
SELECT * FROm History
GO
/****** Object:  StoredProcedure [dbo].[InsertClient]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[InsertClient] @card_id INT, @name NVARCHAR(50) = null, @last_name NVARCHAR(50) = null, @middle_name NVARCHAR(50) = null, @cred_id INT = null
AS
INSERT INTO Client VALUES(@name, @last_name, @middle_name, @card_id, @cred_id)
GO
/****** Object:  StoredProcedure [dbo].[InsertCredentials]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCredentials] @login NVARCHAR(50), @password NVARCHAR(50), @role NVARCHAR(50)
AS
DECLARE @id INT;
INSERT INTO Credentials VALUES(@login, @password, @role)
GO
/****** Object:  StoredProcedure [dbo].[InsertCredentialsAndConnectToClient]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCredentialsAndConnectToClient] @client_id INT, @login NVARCHAR(50), @password NVARCHAR(50), @role NVARCHAR(50)
AS
DECLARE @cred_id INT;
BEGIN TRY
	EXEC InsertCredentials @login, @password, @role
	SELECT @cred_id = IDENT_CURRENT('dbo.Credentials')
END TRY
BEGIN CATCH
	THROW
	RETURN
END CATCH
UPDATE Client SET cred_id = @cred_id WHERE id = @client_id
GO
/****** Object:  StoredProcedure [dbo].[InsertCredentialsAndConnectToEmployee]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCredentialsAndConnectToEmployee] @employee_id INT, @login NVARCHAR(50), @password NVARCHAR(50), @role NVARCHAR(50)
AS
DECLARE @cred_id INT;
BEGIN TRY
	EXEC InsertCredentials @login, @password, @role
	SELECT @cred_id = IDENT_CURRENT('dbo.Credentials')
END TRY
BEGIN CATCH
	THROW
	RETURN
END CATCH
UPDATE Employee SET cred_id = @cred_id WHERE id = @employee_id
GO
/****** Object:  StoredProcedure [dbo].[InsertDeal]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertDeal] @card_id INT, @employee_id INT, @station_name NVARCHAR(50), @supply_type NVARCHAR(20), @supply_type_amount FLOAT, @date SMALLDATETIME = null
AS
DECLARE @client_id INT, @supply_type_id INT, @discount_percent INT, @station_id INT
DECLARE @supply_count_left INT
SELECT @station_id = id FROM Station WHERE name = @station_name
SELECT @client_id = id, @discount_percent = discount_percent FROM ClientWithCardInfo WHERE card_id = @card_id;
SELECT @supply_type_id = id FROM SupplyType WHERE name = @supply_type;
SELECT @supply_count_left = supply_count FROM SupplyByStation WHERE station_id = @station_id AND supply_type_id = @supply_type_id
IF(@date = null)
	SET @date = GETDATE()
IF(@supply_count_left >= @supply_type_amount)
	Insert into Deal VALUES(@client_id, @employee_id, @supply_type_id, @supply_type_amount, 
	dbo.CountFinalDealPrice(@supply_type_amount, @supply_type_id, @discount_percent), @date, @station_id)
ELSE
	BEGIN
		RAISERROR(N'На складе для станции %i и типа товара %s недостаточно товара. Осталось %i', 16,1,@station_id, @supply_type, @supply_count_left);
	END
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertEmployee] @first_name NVARCHAR(50), @last_name NVARCHAR(50), @position NVARCHAR(50),
@date_of_birth date, @date_of_employment date, @date_of_contract_end date, @salary float, @address NVARCHAR(MAX), @phone NVARCHAR(50),
@is_working NVARCHAR(5), @cred_id INT = null, @middle_name NVARCHAR(50) = null
AS
IF(@cred_id = null AND @middle_name = null)
	BEGIN
		INSERT INTO Employee(first_name, last_name, position, date_of_birth,date_of_employment,date_of_contract_end, salary, address, phone, is_working) VALUES
	(@first_name, @last_name, @position, @date_of_birth, @date_of_employment, @date_of_contract_end, @salary, @address, @phone, CONVERT(BIT, @is_working))
	END
ELSE IF(@cred_id != null AND @middle_name = null)
	BEGIN
		INSERT INTO Employee(first_name, last_name, position, date_of_birth,date_of_employment,date_of_contract_end, salary, address, phone, cred_id, is_working) VALUES
	(@first_name, @last_name, @position, @date_of_birth, @date_of_employment, @date_of_contract_end, @salary, @address, @phone, @cred_id, CONVERT(BIT, @is_working))
	END
ELSE IF(@cred_id = null AND @middle_name != null)
	BEGIN
		INSERT INTO Employee(first_name, last_name, middle_name, position, date_of_birth,date_of_employment,date_of_contract_end, salary, address, phone, is_working) VALUES
	(@first_name, @last_name, @middle_name, @position, @date_of_birth, @date_of_employment, @date_of_contract_end, @salary, @address, @phone, CONVERT(BIT, @is_working))
	END
ELSE
	BEGIN
		INSERT INTO Employee VALUES (@first_name, @last_name, @middle_name, @position, @date_of_birth, @date_of_employment,
		@date_of_contract_end, @salary, @address, @phone, @cred_id, CONVERT(BIT, @is_working))
	END
GO
/****** Object:  StoredProcedure [dbo].[InsertStation]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStation]
@name NVARCHAR(50), @city NVARCHAR(50), @address NVARCHAR(MAX), @is_working VARCHAR(5) = null
AS
BEGIN
	IF(@is_working != null)
		INSERT INTO Station VALUES(@name, @city, @address, CONVERT(BIT,@is_working))
	ELSE
		INSERT INTO Station(name, city, address) VALUES(@name, @city, @address)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertSupply]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertSupply] @station_id INT, @employee_id INT, @supply_type_id INT, @supply_amount FLOAT, @date SMALLDATETIME = null
AS
IF(@date = null)
	SET @date = GETDATE();
Insert into Supply VALUES(@station_id, @employee_id, @supply_type_id, @supply_amount, @date)
GO
/****** Object:  StoredProcedure [dbo].[StationsSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StationsSummary] AS
SELECT * FROM Station
GO
/****** Object:  StoredProcedure [dbo].[SuppliesSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SuppliesSummary]
AS
select * from SupplyFullInfo
GO
/****** Object:  StoredProcedure [dbo].[SuppliesSummaryByEmployee]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuppliesSummaryByEmployee] @employee_id INT
AS
select * from SupplyFullInfo WHERE employee_id = @employee_id
GO
/****** Object:  StoredProcedure [dbo].[SuppliesSummaryByStation]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuppliesSummaryByStation] @station_id INT
AS
select * from SupplyFullInfo WHERE station_id = @station_id 
GO
/****** Object:  StoredProcedure [dbo].[SupplyByStationSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SupplyByStationSummary]
AS
SELECT * FROM SupplyByStationFullInfo
GO
/****** Object:  StoredProcedure [dbo].[SupplyTypesSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SupplyTypesSummary]
AS
SELECT * FROM SupplyType
GO
/****** Object:  StoredProcedure [dbo].[UpdateDealShort]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateDealShort] @id INT, @card_id INT, @supply_type NVARCHAR(20), @supply_type_amount FLOAT, @date SMALLDATETIME
AS
DECLARE @client_id INT, @supply_type_id INT, @discount_percent INT, @station_id INT
DECLARE @supply_count_left INT
SELECT @station_id = station_id FROM Deal WHERE id = @id
SELECT @client_id = id, @discount_percent = discount_percent FROM ClientWithCardInfo WHERE card_id = @card_id;
SELECT @supply_type_id = id FROM SupplyType WHERE name = @supply_type;
SELECT @supply_count_left = supply_count FROM SupplyByStation WHERE station_id = @station_id AND supply_type_id = @supply_type_id
IF(@supply_count_left >= @supply_type_amount)
	UPDATE Deal SET client_id = @client_id, supply_type_id = @supply_type_id, supply_type_amount = @supply_type_amount, 
	price = dbo.CountFinalDealPrice(@supply_type_amount, @supply_type_id, @discount_percent), date = @date WHERE id = @id
ELSE
	BEGIN
		RAISERROR(N'На складе для станции %i и типа товара %s недостаточно товара. Осталось %i', 16,1,@station_id, @supply_type, @supply_count_left);
	END
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateEmployee] @id INT, @first_name NVARCHAR(50), @last_name NVARCHAR(50), @position NVARCHAR(50),
@date_of_birth date, @date_of_employment date, @date_of_contract_end date, @salary float, @address NVARCHAR(MAX), @phone NVARCHAR(50),
@is_working NVARCHAR(5), @cred_id INT = null, @middle_name NVARCHAR(50) = null
AS
UPDATE Employee SET first_name = @first_name, last_name = @last_name, middle_name = @middle_name, position = @position, date_of_birth = @date_of_birth,
date_of_employment = @date_of_employment, date_of_contract_end = @date_of_contract_end, salary = @salary, address = @address, phone = @phone, is_working = @is_working,
cred_id = @cred_id WHERE id = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateStation]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateStation] @id INT, @name NVARCHAR(50), @city NVARCHAR(50), @address NVARCHAR(50), @is_working NVARCHAR(5)
AS
UPDATE Station SET name = @name, city = @city, address = @address, is_working = @is_working WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplyType]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSupplyType] @id INT, @name NVARCHAR(50), @price FLOAT, @is_selling NVARCHAR(5)
AS
UPDATE SupplyType SET name = @name, price = @price, is_selling = @is_selling WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[WorkingEmployeesSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[WorkingEmployeesSummary]
AS
SELECT * FROM Employee WHERE is_working = 1
GO
/****** Object:  StoredProcedure [dbo].[WorkingStationsSummary]    Script Date: 4/25/2021 4:01:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[WorkingStationsSummary]
AS
SELECT * FROM Station WHERE is_working = 1
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Client"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ClientCard"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ClientWithCardInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ClientWithCardInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Deal"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ClientWithCardInfo"
            Begin Extent = 
               Top = 6
               Left = 275
               Bottom = 136
               Right = 455
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Employee"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 240
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Station"
            Begin Extent = 
               Top = 6
               Left = 493
               Bottom = 136
               Right = 663
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SupplyType"
            Begin Extent = 
               Top = 138
               Left = 278
               Bottom = 268
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
       ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DealFullInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'  Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DealFullInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DealFullInfo'
GO
USE [master]
GO
ALTER DATABASE [gas_station] SET  READ_WRITE 
GO

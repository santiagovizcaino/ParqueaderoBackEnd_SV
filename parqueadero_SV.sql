USE [master]
GO
/****** Object:  Database [parqueadero_SV]    Script Date: 6/23/2022 9:03:21 AM ******/
CREATE DATABASE [parqueadero_SV]

GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [parqueadero_SV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [parqueadero_SV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [parqueadero_SV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [parqueadero_SV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [parqueadero_SV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [parqueadero_SV] SET ARITHABORT OFF 
GO
ALTER DATABASE [parqueadero_SV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [parqueadero_SV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [parqueadero_SV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [parqueadero_SV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [parqueadero_SV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [parqueadero_SV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [parqueadero_SV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [parqueadero_SV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [parqueadero_SV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [parqueadero_SV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [parqueadero_SV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [parqueadero_SV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [parqueadero_SV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [parqueadero_SV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [parqueadero_SV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [parqueadero_SV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [parqueadero_SV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [parqueadero_SV] SET RECOVERY FULL 
GO
ALTER DATABASE [parqueadero_SV] SET  MULTI_USER 
GO
ALTER DATABASE [parqueadero_SV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [parqueadero_SV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [parqueadero_SV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [parqueadero_SV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [parqueadero_SV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [parqueadero_SV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'parqueadero_SV', N'ON'
GO
ALTER DATABASE [parqueadero_SV] SET QUERY_STORE = OFF
GO
USE [parqueadero_SV]
GO
/****** Object:  Table [dbo].[AUTO]    Script Date: 6/23/2022 9:03:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUTO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [varchar](50) NOT NULL,
	[hora_ingreso] [datetime] NOT NULL,
	[hora_salida] [datetime] NULL,
	[pago] [decimal](10, 2) NULL,
 CONSTRAINT [PK_tb_AUTO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 6/23/2022 9:03:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](max) NOT NULL,
	[apellido] [varchar](max) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AUTO] ON 

INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (1, N'pyt0694', CAST(N'2022-06-22T14:44:04.000' AS DateTime), CAST(N'2022-06-22T17:08:49.170' AS DateTime), CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (2, N'pyt0694', CAST(N'2022-06-22T14:44:04.000' AS DateTime), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (3, N'pyt0694', CAST(N'2022-06-22T14:44:04.000' AS DateTime), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (4, N'PYT0695', CAST(N'2022-06-23T08:21:29.647' AS DateTime), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (5, N'PYT0696', CAST(N'2022-06-23T08:21:29.647' AS DateTime), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (6, N'PYT697', CAST(N'2022-06-23T08:21:29.647' AS DateTime), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (7, N'PYT0698', CAST(N'2022-06-23T08:21:29.647' AS DateTime), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[AUTO] ([id], [placa], [hora_ingreso], [hora_salida], [pago]) VALUES (9, N'PYT0699', CAST(N'2022-06-23T08:21:29.647' AS DateTime), NULL, CAST(0.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[AUTO] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([id], [nombre], [apellido], [usuario], [password]) VALUES (1, N'Santiago', N'Vizcaino', N'santiago.v', 0x0200000000BCB415AD1EC3923FB21585269E6839DD0594B61584AFF98F5F07441697F61C)
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 6/23/2022 9:03:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[login] 

	@usuario varchar(max),
	@password varchar(max)

AS
BEGIN

declare @libre varchar(max) = (select convert(varchar(max),DECRYPTBYPASSPHRASE('santiago',password)) from usuario where usuario=@usuario)
print @libre
if @libre=@password
select * from usuario where usuario=@usuario 
else
select * from usuario where usuario='0Aqwqw' 
END
GO
USE [master]
GO
ALTER DATABASE [parqueadero_SV] SET  READ_WRITE 
GO

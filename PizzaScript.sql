
/****** Object:  Database [Доставка_Пиццы]    Script Date: 05/24/2019 03:45:36 ******/
CREATE DATABASE [Доставка_Пиццы] ON  PRIMARY 
( NAME = N'Доставка_Пиццы', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Доставка_Пиццы.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Доставка_Пиццы_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Доставка_Пиццы_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Доставка_Пиццы] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Доставка_Пиццы].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Доставка_Пиццы] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET ARITHABORT OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Доставка_Пиццы] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Доставка_Пиццы] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Доставка_Пиццы] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET  DISABLE_BROKER
GO
ALTER DATABASE [Доставка_Пиццы] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Доставка_Пиццы] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Доставка_Пиццы] SET  READ_WRITE
GO
ALTER DATABASE [Доставка_Пиццы] SET RECOVERY FULL
GO
ALTER DATABASE [Доставка_Пиццы] SET  MULTI_USER
GO
ALTER DATABASE [Доставка_Пиццы] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Доставка_Пиццы] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Доставка_Пиццы', N'ON'
GO
USE [Доставка_Пиццы]
GO
/****** Object:  Table [dbo].[Пицца]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Пицца](
	[Код_Пиццы] [int] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NOT NULL,
	[Масса] [float] NOT NULL,
	[Цена] [money] NOT NULL,
	[Доступна_к_Заказу] [bit] NOT NULL,
 CONSTRAINT [PK_ПИЦЦА] PRIMARY KEY NONCLUSTERED 
(
	[Код_Пиццы] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [AK_AK_ПИЦЦА_НАЗВАНИЕ_ПИЦЦА] UNIQUE NONCLUSTERED 
(
	[Название] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[EditPizza]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditPizza]
	@id int,
    @Name varchar(50),
    @Mass float,
    @Price money,
    @AvailOrder bit 
AS
    UPDATE Пицца
    SET Название = @Name,
     Масса = @Mass,
     Цена = @Price,
     Доступна_к_Заказу = @AvailOrder
    WHERE Код_Пиццы = @id
GO
/****** Object:  StoredProcedure [dbo].[AddPizza]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPizza]
    @Name varchar(50),
    @Mass float,
    @Price money
AS
    INSERT INTO Пицца(Название, Масса, Цена)
    values (@Name, @Mass, @Price)
GO
/****** Object:  Table [dbo].[Пицца_в_Заказе]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пицца_в_Заказе](
	[Зак_Номер] [int] NOT NULL,
	[Пиц_Код_Пиццы] [int] NOT NULL,
	[Количество] [int] NOT NULL,
 CONSTRAINT [PK_ПИЦЦА_В_ЗАКАЗЕ] PRIMARY KEY NONCLUSTERED 
(
	[Зак_Номер] ASC,
	[Пиц_Код_Пиццы] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AddOrder2]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrder2]
	@K int,
    @Pizza varchar(50),
    @Number int  
AS 
	DECLARE @IdPizza int
	SET @IdPizza = (SELECT Код_Пиццы FROM Пицца WHERE Пицца.Название = @Pizza)	
	
	INSERT INTO Пицца_в_Заказе(Зак_Номер, Пиц_Код_Пиццы, Количество)
	VALUES (@K, @IdPizza, @Number)
GO
/****** Object:  Table [dbo].[Статус_Заказа]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Статус_Заказа](
	[Код_Статуса] [int] IDENTITY(1,1) NOT NULL,
	[Вид] [varchar](50) NOT NULL,
 CONSTRAINT [PK_СТАТУС_ЗАКАЗА] PRIMARY KEY NONCLUSTERED 
(
	[Код_Статуса] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Скидка]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Скидка](
	[Код_Скидки] [int] IDENTITY(1,1) NOT NULL,
	[Вид] [varchar](50) NOT NULL,
	[Процент] [float] NOT NULL,
 CONSTRAINT [PK_СКИДКА] PRIMARY KEY NONCLUSTERED 
(
	[Код_Скидки] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Пункт]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Пункт](
	[Код_Пункта] [int] IDENTITY(1,1) NOT NULL,
	[Адрес] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ПУНКТ] PRIMARY KEY NONCLUSTERED 
(
	[Код_Пункта] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Покупатель]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Покупатель](
	[Код_Покупателя] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [varchar](50) NOT NULL,
	[Имя] [varchar](50) NOT NULL,
	[Отчество] [varchar](50) NOT NULL,
	[Телефон] [varchar](50) NULL,
	[Адрес] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ПОКУПАТЕЛЬ] PRIMARY KEY NONCLUSTERED 
(
	[Код_Покупателя] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Доставка]    Script Date: 05/24/2019 03:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Доставка](
	[Код_Доставки] [int] IDENTITY(1,1) NOT NULL,
	[Тип] [varchar](50) NOT NULL,
	[Стоимость] [money] NOT NULL,
 CONSTRAINT [PK_ДОСТАВКА] PRIMARY KEY NONCLUSTERED 
(
	[Код_Доставки] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [AK_AK_ДОСТАВКА_ТИП_ДОСТАВКА] UNIQUE NONCLUSTERED 
(
	[Тип] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[EditCustomer]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditCustomer]
	@id int,
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50),
    @Phone varchar(50),
    @Adress varchar(100)
AS 
    UPDATE Покупатель
    SET Фамилия = @Surname,
		Имя= @Name,
		Отчество = @Patron,
		Телефон = @Phone,
		Адрес = @Adress
    WHERE Код_Покупателя = @id
GO
/****** Object:  StoredProcedure [dbo].[DeletePoint]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePoint]
    @IdPoint int
AS
	DELETE Пункт
	WHERE Код_Пункта = @IdPoint
GO
/****** Object:  StoredProcedure [dbo].[AddDiscount]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddDiscount]
    @Type varchar(50),
    @Persent float
AS
    INSERT INTO Скидка(Вид, Процент)
    values (@Type, @Persent)
GO
/****** Object:  StoredProcedure [dbo].[AddCustomer]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCustomer]
    @Sur varchar(50),
    @Name varchar(50),
    @Patr varchar(50),
    @Phone varchar(50),
    @Adress varchar(100)
AS
    INSERT INTO Покупатель(Фамилия, Имя, Отчество, Телефон, Адрес)
    values (@Sur, @Name, @Patr, @Phone, @Adress)
GO
/****** Object:  StoredProcedure [dbo].[EditDiscount]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditDiscount]
	@id int,
    @DiscType varchar(50),
    @Persent float
AS 
    UPDATE Скидка
    SET Вид = @DiscType,
		Процент = @Persent
    WHERE Код_Скидки = @id
GO
/****** Object:  Table [dbo].[Курьер]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Курьер](
	[Код_Курьера] [int] IDENTITY(1,1) NOT NULL,
	[Пункт] [int] NOT NULL,
	[Фамилия] [varchar](50) NOT NULL,
	[Имя] [varchar](50) NOT NULL,
	[Отчество] [varchar](50) NOT NULL,
 CONSTRAINT [PK_КУРЬЕР] PRIMARY KEY NONCLUSTERED 
(
	[Код_Курьера] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Заказ]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заказ](
	[Номер] [int] IDENTITY(1,1) NOT NULL,
	[Сумма] [money] NOT NULL,
	[Покупатель] [int] NOT NULL,
	[Курьер] [int] NULL,
	[Доставка] [int] NOT NULL,
	[Пункт] [int] NOT NULL,
	[Статус] [int] NOT NULL,
	[Скидка] [int] NULL,
	[Дата_Заказа] [datetime] NOT NULL,
 CONSTRAINT [PK_ЗАКАЗ] PRIMARY KEY NONCLUSTERED 
(
	[Номер] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AddOrder3]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrder3]
	@K int
AS 
	DECLARE @Summ money
	SET @Summ = (SELECT SUM(Пицца.Цена) FROM Пицца INNER JOIN Пицца_в_Заказе ON Пицца.Код_Пиццы = Пицца_в_Заказе.Пиц_Код_Пиццы WHERE Пицца_в_Заказе.Зак_Номер = @K)
	UPDATE Заказ
	SET Сумма = @Summ
	WHERE Номер = @K
GO
/****** Object:  StoredProcedure [dbo].[EditDelvierman]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditDelvierman]
	@id int,
    @Point varchar(100),
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50)
AS
	DECLARE @idPoint int
	SET @idPoint = (SELECT Код_Пункта
	FROM Пункт	
	WHERE Адрес = @Point)
    
    UPDATE Курьер
    SET Пункт = @idPoint,
		Фамилия = @Surname,
		Имя = @Name,
		Отчество = @Patron
    WHERE Код_Курьера = @id
GO
/****** Object:  StoredProcedure [dbo].[AddDelvierman]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddDelvierman]
    @Point varchar(50),
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50)
AS
	DECLARE @idPoint int
	SET @idPoint = (SELECT Код_Пункта
	FROM Пункт
	WHERE Адрес = @Point)
    INSERT INTO Курьер(Пункт, Фамилия, Имя, Отчество)
    values (@idPoint, @Surname, @Name, @Patron)
GO
/****** Object:  StoredProcedure [dbo].[DeleteDelivman]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDelivman]
    @IdMan int
AS
	DELETE Курьер
	WHERE Код_Курьера = @IdMan
GO
/****** Object:  StoredProcedure [dbo].[AddOrder5]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrder5]
	@K int
AS 
	DECLARE @Delivery int
	SET @Delivery = (SELECT Доставка.Стоимость FROM Доставка INNER JOIN Заказ ON Доставка.Код_Доставки = Заказ.Доставка WHERE Заказ.Номер = @K)
	UPDATE Заказ
	SET Сумма = Сумма + @Delivery
	WHERE Номер = @K
GO
/****** Object:  StoredProcedure [dbo].[AddOrder4]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrder4]
	@K int,
	@Disc VarChar(50)
AS 
	DECLARE @PerDisc int
	SET @PerDisc = (SELECT Процент FROM Скидка WHERE Вид = @Disc)
	UPDATE Заказ
	SET Сумма = Сумма * (1-0.01*@PerDisc)
	WHERE Номер = @K
GO
/****** Object:  StoredProcedure [dbo].[AddOrder]    Script Date: 05/24/2019 03:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrder]
	@Customer varchar(50),
    @DelivMan varchar(50),
    @Delivery varchar(50),
    @Point varchar(100),
    @Disc varchar(50)   
AS 
	DECLARE @IdCust int, @IdDelivMan int, @IdDelivery int, @IdPoint int, @IdDisc int, @K int
	SET @IdCust = (SELECT Код_Покупателя FROM Покупатель WHERE Покупатель.Фамилия = @Customer)
	--SET @IdDelivMan = (SELECT Код_Курьера FROM Курьер WHERE Курьер.Фамилия = @DelivMan)	
	SET @IdDelivery = (SELECT Код_Доставки FROM Доставка WHERE Доставка.Тип = @Delivery)	
	SET @IdPoint = (SELECT Код_Пункта FROM Пункт WHERE Пункт.Адрес = @Point)	
	SET @IdDisc = (SELECT Код_Скидки FROM Скидка WHERE Скидка.Вид = @Disc)	
	
	INSERT INTO Заказ(Сумма, Покупатель, Доставка, Пункт, Статус, Скидка, Дата_Заказа)
	VALUES (0, @IdCust, @IdDelivery, @IdPoint, 1, @IdDisc, GETDATE())
	
	SET @K = @@IDENTITY	
	RETURN @K
GO
/****** Object:  Default [DF_Пицца_Доступна_к_Заказу]    Script Date: 05/24/2019 03:45:37 ******/
ALTER TABLE [dbo].[Пицца] ADD  CONSTRAINT [DF_Пицца_Доступна_к_Заказу]  DEFAULT ((1)) FOR [Доступна_к_Заказу]
GO
/****** Object:  Default [DF__Пицца_в_З__Колич__07F6335A]    Script Date: 05/24/2019 03:45:37 ******/
ALTER TABLE [dbo].[Пицца_в_Заказе] ADD  DEFAULT ((1)) FOR [Количество]
GO
/****** Object:  Check [CKC_КОЛИЧЕСТВО_ПИЦЦА_В_]    Script Date: 05/24/2019 03:45:37 ******/
ALTER TABLE [dbo].[Пицца_в_Заказе]  WITH CHECK ADD  CONSTRAINT [CKC_КОЛИЧЕСТВО_ПИЦЦА_В_] CHECK  (([Количество]>=(1)))
GO
ALTER TABLE [dbo].[Пицца_в_Заказе] CHECK CONSTRAINT [CKC_КОЛИЧЕСТВО_ПИЦЦА_В_]
GO
/****** Object:  Check [CKC_ПРОЦЕНТ_СКИДКА]    Script Date: 05/24/2019 03:45:37 ******/
ALTER TABLE [dbo].[Скидка]  WITH CHECK ADD  CONSTRAINT [CKC_ПРОЦЕНТ_СКИДКА] CHECK  (([Процент]>=(0) AND [Процент]<=(100)))
GO
ALTER TABLE [dbo].[Скидка] CHECK CONSTRAINT [CKC_ПРОЦЕНТ_СКИДКА]
GO
/****** Object:  ForeignKey [FK_ПИЦЦА_В__ВХОДИТ_ЗАКАЗ]    Script Date: 05/24/2019 03:45:37 ******/
ALTER TABLE [dbo].[Пицца_в_Заказе]  WITH CHECK ADD  CONSTRAINT [FK_ПИЦЦА_В__ВХОДИТ_ЗАКАЗ] FOREIGN KEY([Зак_Номер])
REFERENCES [dbo].[Заказ] ([Номер])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Пицца_в_Заказе] CHECK CONSTRAINT [FK_ПИЦЦА_В__ВХОДИТ_ЗАКАЗ]
GO
/****** Object:  ForeignKey [FK_ПИЦЦА_В__ВХОДИТ2_ПИЦЦА]    Script Date: 05/24/2019 03:45:37 ******/
ALTER TABLE [dbo].[Пицца_в_Заказе]  WITH CHECK ADD  CONSTRAINT [FK_ПИЦЦА_В__ВХОДИТ2_ПИЦЦА] FOREIGN KEY([Пиц_Код_Пиццы])
REFERENCES [dbo].[Пицца] ([Код_Пиццы])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Пицца_в_Заказе] CHECK CONSTRAINT [FK_ПИЦЦА_В__ВХОДИТ2_ПИЦЦА]
GO
/****** Object:  ForeignKey [FK_КУРЬЕР_ОТНОСИТСЯ_ПУНКТ]    Script Date: 05/24/2019 03:45:38 ******/
ALTER TABLE [dbo].[Курьер]  WITH CHECK ADD  CONSTRAINT [FK_КУРЬЕР_ОТНОСИТСЯ_ПУНКТ] FOREIGN KEY([Пункт])
REFERENCES [dbo].[Пункт] ([Код_Пункта])
GO
ALTER TABLE [dbo].[Курьер] CHECK CONSTRAINT [FK_КУРЬЕР_ОТНОСИТСЯ_ПУНКТ]
GO
/****** Object:  ForeignKey [FK_ЗАКАЗ_ВЫПОЛНЯЕТ_КУРЬЕР]    Script Date: 05/24/2019 03:45:38 ******/
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_ЗАКАЗ_ВЫПОЛНЯЕТ_КУРЬЕР] FOREIGN KEY([Курьер])
REFERENCES [dbo].[Курьер] ([Код_Курьера])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_ЗАКАЗ_ВЫПОЛНЯЕТ_КУРЬЕР]
GO
/****** Object:  ForeignKey [FK_ЗАКАЗ_ВЫПОЛНЯЕТ_ПУНКТ]    Script Date: 05/24/2019 03:45:38 ******/
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_ЗАКАЗ_ВЫПОЛНЯЕТ_ПУНКТ] FOREIGN KEY([Пункт])
REFERENCES [dbo].[Пункт] ([Код_Пункта])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_ЗАКАЗ_ВЫПОЛНЯЕТ_ПУНКТ]
GO
/****** Object:  ForeignKey [FK_ЗАКАЗ_ДЕЛАЕТ_ПОКУПАТЕ]    Script Date: 05/24/2019 03:45:38 ******/
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_ЗАКАЗ_ДЕЛАЕТ_ПОКУПАТЕ] FOREIGN KEY([Покупатель])
REFERENCES [dbo].[Покупатель] ([Код_Покупателя])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_ЗАКАЗ_ДЕЛАЕТ_ПОКУПАТЕ]
GO
/****** Object:  ForeignKey [FK_ЗАКАЗ_ИМЕЕТ_СКИДКА]    Script Date: 05/24/2019 03:45:38 ******/
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_ЗАКАЗ_ИМЕЕТ_СКИДКА] FOREIGN KEY([Скидка])
REFERENCES [dbo].[Скидка] ([Код_Скидки])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_ЗАКАЗ_ИМЕЕТ_СКИДКА]
GO
/****** Object:  ForeignKey [FK_ЗАКАЗ_ПРИСВАИВА_СТАТУС_З]    Script Date: 05/24/2019 03:45:38 ******/
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_ЗАКАЗ_ПРИСВАИВА_СТАТУС_З] FOREIGN KEY([Статус])
REFERENCES [dbo].[Статус_Заказа] ([Код_Статуса])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_ЗАКАЗ_ПРИСВАИВА_СТАТУС_З]
GO
/****** Object:  ForeignKey [FK_ЗАКАЗ_СОВЕРШАЕТ_ДОСТАВКА]    Script Date: 05/24/2019 03:45:38 ******/
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_ЗАКАЗ_СОВЕРШАЕТ_ДОСТАВКА] FOREIGN KEY([Доставка])
REFERENCES [dbo].[Доставка] ([Код_Доставки])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_ЗАКАЗ_СОВЕРШАЕТ_ДОСТАВКА]
GO

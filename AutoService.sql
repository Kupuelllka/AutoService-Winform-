USE [AutoService]
GO
/****** Object:  Table [dbo].[Auto]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mark] [nvarchar](80) NOT NULL,
	[Model] [nvarchar](100) NOT NULL,
	[Year_of_issue] [date] NULL,
	[Description] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Access_level] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Install_detal]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Install_detal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_order] [int] NULL,
	[Id_detal] [int] NULL,
	[Id_employee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[New_detal]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[New_detal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_auto] [int] NOT NULL,
	[Id_owner] [int] NOT NULL,
	[Receipt_date] [date] NOT NULL,
	[Description] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_service]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_service](
	[Id_order] [int] NULL,
	[Id_work] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owner]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](80) NOT NULL,
	[FirstName] [nvarchar](80) NOT NULL,
	[Mobile_number] [nvarchar](20) NULL,
	[Description] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Types_work]    Script Date: 19.12.2021 22:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Types_work](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type_work] [nvarchar](100) NOT NULL,
	[Price] [int] NOT NULL,
	[Period_of_execution] [int] NOT NULL,
	[Garantee] [int] NOT NULL,
 CONSTRAINT [PK__Types_wo__3214EC07A63EEAE5] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Install_detal]  WITH CHECK ADD FOREIGN KEY([Id_detal])
REFERENCES [dbo].[New_detal] ([Id])
GO
ALTER TABLE [dbo].[Install_detal]  WITH CHECK ADD FOREIGN KEY([Id_employee])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Install_detal]  WITH CHECK ADD FOREIGN KEY([Id_order])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([Id_auto])
REFERENCES [dbo].[Auto] ([Id])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([Id_owner])
REFERENCES [dbo].[Owner] ([Id])
GO
ALTER TABLE [dbo].[Order_service]  WITH CHECK ADD FOREIGN KEY([Id_order])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[Order_service]  WITH CHECK ADD  CONSTRAINT [FK__Order_ser__Id_wo__412EB0B6] FOREIGN KEY([Id_work])
REFERENCES [dbo].[Types_work] ([Id])
GO
ALTER TABLE [dbo].[Order_service] CHECK CONSTRAINT [FK__Order_ser__Id_wo__412EB0B6]
GO

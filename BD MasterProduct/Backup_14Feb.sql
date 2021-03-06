USE [MasterProduct]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/14/2019 7:18:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[NameProduct] [nvarchar](50) NOT NULL,
	[Properties] [nvarchar](700) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[ManufacturerEmail] [nvarchar](50) NOT NULL,
	[IdCountry] [nvarchar](50) NOT NULL,
	[Cost] [nvarchar](50) NOT NULL,
	[UnitsAvailable] [nvarchar](50) NOT NULL,
	[SoldUnits] [nvarchar](50) NOT NULL,
	[StateProduct] [bit] NOT NULL,
	[ImageProduct] [nvarchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 2/14/2019 7:18:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[NameUser] [nvarchar](50) NOT NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (1, N'Samsung', N'Al contrario del pensamiento popular, el texto de Lorem Ipsum no es simplemente texto aleatorio.', CAST(N'2018-08-22' AS Date), N'Samsung@outlook', N'AUT', N'800000', N'100', N'34', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (2, N'Xiaomy', N'Accumsan eu. Phasellus in mollis urna, lobortis finibus risus. Vivamus sit amet facilisis odio. Fusce aliquam, quam at viverra sollicitudin, erat mi convallis arcu, eget sodales dolor ante quis odio. Suspendisse interdum mauris sed sodales aliquam. ', CAST(N'2019-01-24' AS Date), N'xyaomy@hotmail.com', N'BEL', N'650000', N'500', N'421', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (3, N'Lenovo', N'Vivamus erat mauris, iaculis ac consectetur eget, sollicitudin eu velit. Ut id dignissim urna. Proin molestie neque ac pharetra tempor. Donec mi orci, pellentesque sit amet justo ut, tempus ultrices diam. Pellentesque suscipit eu velit eu tristique. Cras posuere accumsan sapien et feugiat. In sagittis efficitur libero, at aliquet orci blandit ullamcorper. Nam id massa in lorem laoreet lobortis. Ut ornare vitae ', CAST(N'2019-01-24' AS Date), N'xyaomy@hotmail.com', N'GGY', N'200000', N'700', N'350', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (4, N'Acer', N'Al contrario del pensamiento popular, el texto de Lorem Ipsum no es simplemente texto aleatorio. Tiene sus raices en una pieza cl´sica de la literatura del Latin, que data del año 45 antes de Cristo', CAST(N'2019-01-24' AS Date), N'acer@hotmail.com', N'ZWE', N'4000000', N'0', N'177', 0, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (5, N'Iphone', N'Aenean eget mi ut mi consequat egestas ac a est. Ut gravida pellentesque metus, nec consectetur orci tristique a. Suspendisse eu mollis libero, sed pulvinar enim. In vel tortor aliquam, facilisis enim non, blandit turpis. Phasellus vel quam sit amet ante sodales tincidunt ac et urna. Vestibulum egestas ipsum iaculis lacus sollicitudin, id pretium diam aliquet. Donec volutpat est tellus, eget bibendum est egestas in. Proin volutpat id est egestas feugiat.', CAST(N'2019-02-14' AS Date), N'iphone@gmail.com', N'DJI', N'5000000', N'3006', N'567', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (6, N'Lg', N'Etiam id dolor eu sapien sagittis accumsan in eget nulla.
Maecenas bibendum sapien at feugiat varius.
Aliquam luctus orci ut diam sagittis sagittis.
Sed condimentum dui et sagittis gravida.', CAST(N'2019-02-14' AS Date), N'qeqeqe', N'AUT', N'1300000', N'12212', N'12121', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (7, N'Huawei', N'"Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..."
"No hay nadie que ame el dolor mismo, que lo busque, lo encuentre y lo quiera, simplemente porque es el dolor."', CAST(N'2019-02-13' AS Date), N'huawei@outlook.com', N'AUS', N'121212', N'13600', N'1450', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (8, N'Alcatel', N'Quisque in aliquet purus. Suspendisse quis tincidunt lacus, eu finibus nibh. Aenean dignissim fringilla risus in gravida. Mauris ac nulla ac nisi vehicula scelerisque. Cras id ante id turpis eleifend commodo sed egestas quam. Aliquam erat volutpat. Fusce egestas sem nec pellentesque auctor. Ut sed malesuada turpis. Maecenas consectetur diam ut cursus faucibus.', CAST(N'2019-02-13' AS Date), N'Alcatel@hotmail.com', N'SLV', N'121212', N'13600', N'1450', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (9, N'Samsung v1', N'Donec a diam ut lectus molestie dignissim sed non nisi. Mauris dignissim ullamcorper augue nec pharetra. In placerat fermentum scelerisque. Sed rutrum condimentum ante, sit amet cursus nisi pharetra vitae. Pellentesque eleifend iaculis urna. Ut mattis justo arcu, sed interdum lorem consequat a. Proin volutpat nunc vitae ante accumsan, eu cursus elit ullamcorper. Quisque eleifend in orci non aliquet.', CAST(N'2019-02-21' AS Date), N'samsumg@outlook.com', N'COL', N'600000', N'5400', N'1300', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (10, N'Alcatel', N'Fusce vehicula turpis turpis, et efficitur justo condimentum ac. Morbi quis ex quis massa consectetur congue. Nullam venenatis commodo sapien. Nulla facilisi. Maecenas sed placerat felis, ut bibendum neque. Aliquam rutrum ex mattis ex lacinia commodo. Nam congue pellentesque tellus, non tincidunt libero facilisis et.', CAST(N'2019-02-12' AS Date), N'alcatel@gmail.com', N'ABW', N'70000', N'0', N'21', 0, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (11, N'Nokia', N'Vivamus placerat suscipit metus, consectetur varius lacus. Nullam fringilla vitae nullaasaac ', CAST(N'2019-02-12' AS Date), N'nokia@gmail.com', N'BLM', N'55666', N'2000', N'211', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (12, N'Lenovo', N'Morbi id lorem nulla. Donec dolor diam, tristique at mattis vitae, feugiat ac metus. Etiam nec pulvinar erat. Fusce tincidunt faucibus lectus ut porta. Mauris lectus lorem, mollis vitae ante ac, pulvinar egestas dolor. Phasellus varius suscipit est id sagittis. Maecenas posuere libero non dui dictum, sit amet bibendum lectus ultricies. Sed metus elit, pulvinar quis accumsan ac, consectetur ac lacus. Integer sed orci ', CAST(N'2019-02-12' AS Date), N'lenovo@hotmail.com', N'CHN', N'120000', N'987', N'453', 1, NULL)
INSERT [dbo].[Product] ([IdProduct], [NameProduct], [Properties], [ReleaseDate], [ManufacturerEmail], [IdCountry], [Cost], [UnitsAvailable], [SoldUnits], [StateProduct], [ImageProduct]) VALUES (13, N'Xiaomy 7', N'Cras nec quam ut neque pretium commodo vel ut mi. Donec vel porta ipsum, ut convallis turpis. Sed pulvinar ex quis ligula dapibus ornare.', CAST(N'2018-01-16' AS Date), N'xiamy@hotmail.com', N'HUN', N'90000', N'0', N'15666', 0, NULL)
SET IDENTITY_INSERT [dbo].[Product] OFF
USE [master]
GO
ALTER DATABASE [MasterProduct] SET  READ_WRITE 
GO

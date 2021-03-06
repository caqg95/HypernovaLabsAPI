USE [HYPERNOVALABS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Concepto]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Concepto](
	[Id_Concepto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Usuario_Registro] [nvarchar](50) NOT NULL,
	[Fecha_Actualizo] [datetime] NULL,
	[Usuario_Actualizo] [nvarchar](50) NULL,
	[Fecha_Baja] [datetime] NULL,
	[Usuario_Baja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Concepto] PRIMARY KEY CLUSTERED 
(
	[Id_Concepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[Id_Cuenta] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Usuario_Registro] [nvarchar](50) NOT NULL,
	[Fecha_Actualizo] [datetime] NULL,
	[Usuario_Actualizo] [nvarchar](50) NULL,
	[Fecha_Baja] [datetime] NULL,
	[Usuario_Baja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[Id_Cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[Id_Departamento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Usuario_Registro] [nvarchar](50) NOT NULL,
	[Fecha_Actualizo] [datetime] NULL,
	[Usuario_Actualizo] [nvarchar](50) NULL,
	[Fecha_Baja] [datetime] NULL,
	[Usuario_Baja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[Id_Departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[Apellido] [nvarchar](150) NOT NULL,
	[Id_Puesto] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Usuario_Registro] [nvarchar](50) NOT NULL,
	[Fecha_Actualizo] [datetime] NULL,
	[Usuario_Actualizo] [nvarchar](50) NULL,
	[Fecha_Baja] [datetime] NULL,
	[Usuario_Baja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gasto]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasto](
	[Id_Gasto] [int] IDENTITY(1,1) NOT NULL,
	[Id_Empleado] [int] NOT NULL,
	[Cantidad_Item] [int] NOT NULL,
	[Monto_Total] [decimal](18, 2) NOT NULL,
	[Fecha_Desde] [date] NOT NULL,
	[Fecha_Hasta] [date] NOT NULL,
	[Id_Concepto] [int] NOT NULL,
	[Id_Empleado_Aprueba] [int] NOT NULL,
	[Id_Empleado_Superviso] [int] NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Usuario_Registro] [nvarchar](50) NOT NULL,
	[Fecha_Actualizo] [datetime] NULL,
	[Usuario_Actualizo] [nvarchar](50) NULL,
	[Fecha_Baja] [datetime] NULL,
	[Usuario_Baja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Gasto] PRIMARY KEY CLUSTERED 
(
	[Id_Gasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gasto_Detalle]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasto_Detalle](
	[Id_Gasto_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[Id_Gasto] [int] NOT NULL,
	[Id_Cuenta] [int] NOT NULL,
	[Fecha_Compra] [date] NOT NULL,
	[Descripcion] [nvarchar](250) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Usuario_Registro] [nvarchar](50) NOT NULL,
	[Fecha_Actualizo] [datetime] NULL,
	[Usuario_Actualizo] [nvarchar](50) NULL,
	[Fecha_Baja] [datetime] NULL,
	[Usuario_Baja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Gasto_Detalle] PRIMARY KEY CLUSTERED 
(
	[Id_Gasto_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[Id_Puesto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Cantidad_Puesto] [int] NOT NULL,
	[Supervisor] [bit] NOT NULL,
	[Aprueba] [bit] NOT NULL,
	[Id_Departamento] [int] NOT NULL,
	[Id_Supervisor] [int] NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Usuario_Registro] [nvarchar](50) NOT NULL,
	[Fecha_Actualizo] [datetime] NULL,
	[Usuario_Actualizo] [nvarchar](50) NULL,
	[Fecha_Baja] [datetime] NULL,
	[Usuario_Baja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Puesto] PRIMARY KEY CLUSTERED 
(
	[Id_Puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210715220149_initial', N'5.0.8')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'976b3f11-f28a-4c4d-b5f9-aa3727867148', N'CQUINTEROG', N'CQUINTEROG', N'cquinterogrande@gmail.com', N'CQUINTEROGRANDE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEPMUQ/H3udpISUDzs8R0LWvBuuSudmpUUgfD7RVRFcN3iZdfO/2XxCzHKGtGiOtxiA==', N'4HDFFJL2EBTUMYAB3Z6WL27HNLB665CL', N'cf096af0-61e0-4faa-a06b-8b893b46f6a9', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c1069b7a-8ea9-4896-bf73-d541966c1fb9', N'CQUINTERO', N'CQUINTERO', N'cquinterogrande@yahoo.es', N'CQUINTEROGRANDE@YAHOO.ES', 0, N'AQAAAAEAACcQAAAAEHx+4jti7s5TxPC2LAcvRkaGS6A+gHlxq/PONqbIyBD8fgp8RfoEDEMk2ubCLXmmpg==', N'KKPL5WPSTOCRHOBR37ED2U4I4OW4TTY5', N'135a4154-e913-44d5-86a5-ce3337abf56f', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Concepto] ON 

INSERT [dbo].[Concepto] ([Id_Concepto], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (1, N'PROYECTOS', 1, CAST(N'2021-07-16T04:51:00.340' AS DateTime), N'CQUINTERO', CAST(N'2021-07-17T15:40:01.790' AS DateTime), N'CQUINTERO', NULL, NULL)
INSERT [dbo].[Concepto] ([Id_Concepto], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (3, N'SERVICIOS BASICOS', 1, CAST(N'2021-07-17T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Concepto] ([Id_Concepto], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (5, N'ADQUISION DE EQUIPOS', 1, CAST(N'2021-07-17T15:44:29.443' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Concepto] ([Id_Concepto], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (6, N'MANTENIMIENTO DE FLOTA', 1, CAST(N'2021-07-17T15:45:05.257' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Concepto] OFF
SET IDENTITY_INSERT [dbo].[Cuenta] ON 

INSERT [dbo].[Cuenta] ([Id_Cuenta], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (1, N'GASTOS OPERATIVOS', 1, CAST(N'2021-07-16T05:21:02.970' AS DateTime), N'CQUINTERO', CAST(N'2021-07-16T05:21:02.970' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Cuenta] ([Id_Cuenta], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (2, N'GASTOS  GERENCIALES', 1, CAST(N'2021-07-16T05:21:02.970' AS DateTime), N'CQUINTERO', CAST(N'2021-07-16T05:21:02.970' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Cuenta] ([Id_Cuenta], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (6, N'GASTOS JUDICIAL', 1, CAST(N'2021-07-17T15:10:52.400' AS DateTime), N'CQUINTERO', CAST(N'2021-07-17T15:11:10.247' AS DateTime), N'CQUINTERO', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Cuenta] OFF
SET IDENTITY_INSERT [dbo].[Departamento] ON 

INSERT [dbo].[Departamento] ([Id_Departamento], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (1, N'GESTION HUMANA', 1, CAST(N'2021-07-15T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Departamento] ([Id_Departamento], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (5, N'VICEGERENCIAS', 1, CAST(N'2021-07-16T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Departamento] ([Id_Departamento], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (7, N'TECNOLOGIA DE LA INFORMACION', 1, CAST(N'2021-07-17T16:17:20.163' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Departamento] ([Id_Departamento], [Descripcion], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (8, N'MERCADEO Y VENTAS', 1, CAST(N'2021-07-17T16:23:03.107' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Departamento] OFF
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre], [Apellido], [Id_Puesto], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (1, N'CARLOS', N'HERRERAS', 11, 1, CAST(N'2021-07-16T06:21:48.103' AS DateTime), N'CQUINTERO', CAST(N'2021-07-17T18:15:57.787' AS DateTime), N'CQUINTERO', NULL, NULL)
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre], [Apellido], [Id_Puesto], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (2, N'MARIA', N'QUINTANA', 3, 1, CAST(N'2021-07-16T06:21:48.103' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre], [Apellido], [Id_Puesto], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (4, N'CRISTHIAM', N'COLLADO', 6, 1, CAST(N'2021-07-16T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre], [Apellido], [Id_Puesto], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (5, N'MARIA', N'LOPEZ', 7, 1, CAST(N'2021-07-17T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre], [Apellido], [Id_Puesto], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (6, N'OLMO', N'RODRIGUEZ', 6, 1, CAST(N'2021-07-17T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre], [Apellido], [Id_Puesto], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (11, N'JUAN ', N'SEQUEIRA', 8, 1, CAST(N'2021-07-17T17:27:29.553' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre], [Apellido], [Id_Puesto], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (12, N'CRISTHIAM ', N'ALVARADO', 3, 1, CAST(N'2021-07-17T17:27:57.213' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[Gasto] ON 

INSERT [dbo].[Gasto] ([Id_Gasto], [Id_Empleado], [Cantidad_Item], [Monto_Total], [Fecha_Desde], [Fecha_Hasta], [Id_Concepto], [Id_Empleado_Aprueba], [Id_Empleado_Superviso], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (2, 5, 1, CAST(100.00 AS Decimal(18, 2)), CAST(N'2021-07-21' AS Date), CAST(N'2021-07-21' AS Date), 6, 1, 1, 1, CAST(N'2021-07-17T20:43:55.013' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Gasto] ([Id_Gasto], [Id_Empleado], [Cantidad_Item], [Monto_Total], [Fecha_Desde], [Fecha_Hasta], [Id_Concepto], [Id_Empleado_Aprueba], [Id_Empleado_Superviso], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (8, 4, 1, CAST(100.00 AS Decimal(18, 2)), CAST(N'2021-07-24' AS Date), CAST(N'2021-07-28' AS Date), 5, 5, 6, 1, CAST(N'2021-07-18T00:40:44.117' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Gasto] ([Id_Gasto], [Id_Empleado], [Cantidad_Item], [Monto_Total], [Fecha_Desde], [Fecha_Hasta], [Id_Concepto], [Id_Empleado_Aprueba], [Id_Empleado_Superviso], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (9, 6, 3, CAST(5500.00 AS Decimal(18, 2)), CAST(N'2021-07-29' AS Date), CAST(N'2021-07-30' AS Date), 6, 5, 6, 1, CAST(N'2021-07-18T03:15:57.363' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Gasto] OFF
SET IDENTITY_INSERT [dbo].[Gasto_Detalle] ON 

INSERT [dbo].[Gasto_Detalle] ([Id_Gasto_Detalle], [Id_Gasto], [Id_Cuenta], [Fecha_Compra], [Descripcion], [Cantidad], [Precio], [Total], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (3, 2, 1, CAST(N'2021-07-13' AS Date), N'PRUEBA', 1, CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 1, CAST(N'2021-07-17T20:43:55.017' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Gasto_Detalle] ([Id_Gasto_Detalle], [Id_Gasto], [Id_Cuenta], [Fecha_Compra], [Descripcion], [Cantidad], [Precio], [Total], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (10, 8, 2, CAST(N'2021-07-28' AS Date), N'PRUEBA', 1, CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 1, CAST(N'2021-07-18T00:40:44.117' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Gasto_Detalle] ([Id_Gasto_Detalle], [Id_Gasto], [Id_Cuenta], [Fecha_Compra], [Descripcion], [Cantidad], [Precio], [Total], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (11, 9, 2, CAST(N'2021-07-20' AS Date), N'PRUEBA1', 1, CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 1, CAST(N'2021-07-18T03:15:57.367' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Gasto_Detalle] ([Id_Gasto_Detalle], [Id_Gasto], [Id_Cuenta], [Fecha_Compra], [Descripcion], [Cantidad], [Precio], [Total], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (12, 9, 2, CAST(N'2021-07-12' AS Date), N'PRUEBA2', 2, CAST(200.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), 1, CAST(N'2021-07-18T03:15:57.367' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Gasto_Detalle] ([Id_Gasto_Detalle], [Id_Gasto], [Id_Cuenta], [Fecha_Compra], [Descripcion], [Cantidad], [Precio], [Total], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (13, 9, 6, CAST(N'2021-07-20' AS Date), N'PRUEBA3', 5, CAST(1000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), 1, CAST(N'2021-07-18T03:15:57.367' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Gasto_Detalle] OFF
SET IDENTITY_INSERT [dbo].[Puesto] ON 

INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (1, N'GERENTE GENERAL', 1, 1, 1, 5, NULL, 1, CAST(N'2021-07-16T05:44:04.507' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (3, N'ASISTENTE DE GERENCIA GENERAL', 1, 0, 0, 5, NULL, 1, CAST(N'2021-07-16T05:44:04.507' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (6, N'SUPERVISOR A', 15, 1, 0, 5, NULL, 1, CAST(N'2021-07-17T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (7, N'JEFE SE SUPERVISION', 5, 0, 1, 5, NULL, 1, CAST(N'2021-07-17T00:00:00.000' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (8, N'TECNICO DE HARDWARE', 5, 0, 0, 7, NULL, 1, CAST(N'2021-07-17T16:53:13.383' AS DateTime), N'CQUINTERO', CAST(N'2021-07-17T17:03:25.073' AS DateTime), N'CQUINTERO', NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (9, N'ANALISTA DBA', 10, 0, 0, 7, NULL, 1, CAST(N'2021-07-17T16:54:06.383' AS DateTime), N'CQUINTERO', CAST(N'2021-07-17T17:03:10.477' AS DateTime), N'CQUINTERO', NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (10, N'PROGRAMADOR FORNTEND', 8, 0, 0, 7, NULL, 1, CAST(N'2021-07-17T16:55:00.140' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (11, N'GERENTE DE INFORMATICA', 1, 0, 1, 7, NULL, 1, CAST(N'2021-07-17T17:04:02.303' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
INSERT [dbo].[Puesto] ([Id_Puesto], [Descripcion], [Cantidad_Puesto], [Supervisor], [Aprueba], [Id_Departamento], [Id_Supervisor], [Activo], [Fecha_Registro], [Usuario_Registro], [Fecha_Actualizo], [Usuario_Actualizo], [Fecha_Baja], [Usuario_Baja]) VALUES (12, N'JEFE DE DESARROLLO', 1, 1, 0, 7, NULL, 1, CAST(N'2021-07-17T17:04:27.140' AS DateTime), N'CQUINTERO', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Puesto] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 18/07/2021 3:25:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 18/07/2021 3:25:58 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 18/07/2021 3:25:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 18/07/2021 3:25:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 18/07/2021 3:25:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 18/07/2021 3:25:58 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 18/07/2021 3:25:58 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Puesto] FOREIGN KEY([Id_Puesto])
REFERENCES [dbo].[Puesto] ([Id_Puesto])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Puesto]
GO
ALTER TABLE [dbo].[Gasto]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Concepto] FOREIGN KEY([Id_Concepto])
REFERENCES [dbo].[Concepto] ([Id_Concepto])
GO
ALTER TABLE [dbo].[Gasto] CHECK CONSTRAINT [FK_Gasto_Concepto]
GO
ALTER TABLE [dbo].[Gasto]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Empleado] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([Id_Empleado])
GO
ALTER TABLE [dbo].[Gasto] CHECK CONSTRAINT [FK_Gasto_Empleado]
GO
ALTER TABLE [dbo].[Gasto_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Detalle_Cuenta] FOREIGN KEY([Id_Cuenta])
REFERENCES [dbo].[Cuenta] ([Id_Cuenta])
GO
ALTER TABLE [dbo].[Gasto_Detalle] CHECK CONSTRAINT [FK_Gasto_Detalle_Cuenta]
GO
ALTER TABLE [dbo].[Gasto_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Detalle_Gasto] FOREIGN KEY([Id_Gasto])
REFERENCES [dbo].[Gasto] ([Id_Gasto])
GO
ALTER TABLE [dbo].[Gasto_Detalle] CHECK CONSTRAINT [FK_Gasto_Detalle_Gasto]
GO
ALTER TABLE [dbo].[Puesto]  WITH CHECK ADD  CONSTRAINT [FK_Puesto_Departamento] FOREIGN KEY([Id_Departamento])
REFERENCES [dbo].[Departamento] ([Id_Departamento])
GO
ALTER TABLE [dbo].[Puesto] CHECK CONSTRAINT [FK_Puesto_Departamento]
GO
/****** Object:  StoredProcedure [dbo].[sp_Listado_Empleados]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Quintero
-- Create date: 16/0/2021
-- Description:	Listado de Gastos 
-- =============================================
CREATE PROCEDURE [dbo].[sp_Listado_Empleados] 
AS
BEGIN
	SELECT 
		  E.Id_Empleado,
		  E.Nombre,
		  E.Apellido,
		  P.Id_Puesto,
		  P.Descripcion Puesto,
		  P.Supervisor,
		  P.Aprueba,
		  D.Id_Departamento,
		  D.Descripcion Departamento
	FROM Empleado     E												INNER JOIN
		 Puesto	  	  P   ON E.Id_Puesto=P.Id_Puesto				INNER JOIN
		 Departamento D   ON P.Id_Departamento=D.Id_Departamento
	WHERE E.Activo=1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Listado_Gastos]    Script Date: 18/07/2021 3:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Quintero
-- Create date: 16/0/2021
-- Description:	Listado de Gastos 
-- =============================================
CREATE PROCEDURE [dbo].[sp_Listado_Gastos] 
	
AS
BEGIN
	SELECT G.Id_Gasto,
       G.Id_Empleado Id_Empleado_Gasto,
	   CONCAT(EG.Nombre,SPACE(1),EG.Apellido) Nombre_Empleado_Gasto ,
       G.Cantidad_Item,
	   G.Monto_Total,
	   G.Fecha_Desde,
	   G.Fecha_Hasta,
	   G.Id_Concepto,
	   C.Descripcion Concepto,
	   G.Id_Empleado_Aprueba,
	   CONCAT(EA.Nombre,SPACE(1),EA.Apellido) Nombre_Empleado_Aprueba,
	   G.Id_Empleado_Superviso,
	   CONCAT(ES.Nombre,SPACE(1),ES.Apellido) Nombre_Empleado_Superviso
	FROM Gasto    G                                               INNER JOIN
		 Concepto C     ON G.Id_Concepto=C.Id_Concepto            INNER JOIN
		 Empleado EG    ON G.Id_Empleado=EG.Id_Empleado           INNER JOIN
		 Empleado EA    ON G.Id_Empleado_Aprueba=EA.Id_Empleado   LEFT JOIN
		 Empleado ES    ON G.Id_Empleado_Superviso=ES.Id_Empleado
	WHERE G.Activo=1
END
GO
USE [master]
GO
ALTER DATABASE [HYPERNOVALABS] SET  READ_WRITE 
GO

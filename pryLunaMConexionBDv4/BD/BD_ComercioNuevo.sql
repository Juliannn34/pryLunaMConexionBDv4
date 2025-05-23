USE [master]
GO
/****** Object:  Database [Comercio]    Script Date: 2/5/2025 18:43:32 ******/
CREATE DATABASE [Comercio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Comercio', FILENAME = N'D:\SQL SERVER\MSSQL16.MSSQLSERVER\MSSQL\DATA\Comercio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Comercio_log', FILENAME = N'D:\SQL SERVER\MSSQL16.MSSQLSERVER\MSSQL\DATA\Comercio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Comercio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Comercio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Comercio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Comercio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Comercio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Comercio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Comercio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Comercio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Comercio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Comercio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Comercio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Comercio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Comercio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Comercio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Comercio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Comercio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Comercio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Comercio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Comercio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Comercio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Comercio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Comercio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Comercio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Comercio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Comercio] SET RECOVERY FULL 
GO
ALTER DATABASE [Comercio] SET  MULTI_USER 
GO
ALTER DATABASE [Comercio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Comercio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Comercio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Comercio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Comercio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Comercio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Comercio', N'ON'
GO
ALTER DATABASE [Comercio] SET QUERY_STORE = OFF
GO
USE [Comercio]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 2/5/2025 18:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 2/5/2025 18:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Apellido] [nvarchar](100) NULL,
	[Telefono] [nvarchar](255) NULL,
	[Correo] [varchar](30) NULL,
	[CategoriaId] [varchar](30) NULL,
 CONSTRAINT [PK__Contacto__3214EC2739D6E258] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 2/5/2025 18:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Descripcion] [nvarchar](255) NULL,
	[Precio] [decimal](10, 2) NULL,
	[Stock] [int] NULL,
	[CategoriaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 2/5/2025 18:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NULL,
	[Clave] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Id], [Nombre]) VALUES (1, N'Tecnología')
INSERT [dbo].[Categorias] ([Id], [Nombre]) VALUES (2, N'Hogar')
INSERT [dbo].[Categorias] ([Id], [Nombre]) VALUES (3, N'Ropa')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Contactos] ON 

INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (1, N'Julian', N'Luna Mariani', N'351-646-0703', N'julianlunamariani@gmail.com', N'Cliente')
INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (2, N'Azul', N'Gomez', N'987-654-3210', N'Azul.Gomez@example.com', N'Tecnología')
INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (3, N'Carlos', N'Rodríguez', N'456-789-0123', N'carlos.rodriguez@example.com', N'Proveedor')
INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (4, N'Josefina', N'González', N'321-654-9870', N'Jose.gonzalez@yahoo.com', N'1')
INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (5, N'Luis', N'Martínez', N'654-321-0987', N'luis.martinez@example.com', N'Hogar')
INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (6, N'Alex', N'Fernandez', N'485-965-3652', N'Alex@gmail.com', N'Tecnología')
INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (14, N'aaa', N'ddd', N'321-256-3562', N'wadwadwq@21322.com', N'Hogar')
INSERT [dbo].[Contactos] ([ID], [Nombre], [Apellido], [Telefono], [Correo], [CategoriaId]) VALUES (15, N'aa', N'eee', N'21234412', N'313dwad', N'Hogar')
SET IDENTITY_INSERT [dbo].[Contactos] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (1, N'Notebook Lenovo', N'Notebook i5 8GB RAM', CAST(850000.00 AS Decimal(10, 2)), 10, 1)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (2, N'Licuadora Philips', N'600W, vaso de vidrio', CAST(320000.00 AS Decimal(10, 2)), 5, 2)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (3, N'Camisa Blanca', N'Manga larga, algodón', CAST(180000.00 AS Decimal(10, 2)), 15, 3)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (11, N'Teclado Redragon', N'Mecanico de aluminio', CAST(250000.00 AS Decimal(10, 2)), 7, 1)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (12, N'Pantalon deportivo', N'de tela suave', CAST(12000.00 AS Decimal(10, 2)), 9, 3)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (1004, N'Maus Razer', N'Sensor Optico', CAST(85000.00 AS Decimal(10, 2)), 3, 1)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (1009, N'Lampara de escritorio', N'Luz tenue. Perfecta para leer ', CAST(20000.00 AS Decimal(10, 2)), 5, 2)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (1010, N'Papel qsy', N'deeescrp', CAST(255555.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Descripcion], [Precio], [Stock], [CategoriaId]) VALUES (1011, N'aaa', N'aaa', CAST(2.00 AS Decimal(10, 2)), 3, 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Usuario], [Clave]) VALUES (1, N'Julian', N'1234')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categorias] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Comercio] SET  READ_WRITE 
GO

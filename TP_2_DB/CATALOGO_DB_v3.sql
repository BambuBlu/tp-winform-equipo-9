--use master
--go
--create database CATALOGO_P3_DB
--go
--use CATALOGO_P3_DB
--go
--USE CATALOGO_P3_DB
--GO

--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--SET ANSI_PADDING ON
--GO

--CREATE TABLE [dbo].[MARCAS](
--	[Id] [int] IDENTITY(1,1) NOT NULL,
--	[Descripcion] [varchar](50) NULL,
-- CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
--(
--	[Id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]

--GO

--SET ANSI_PADDING OFF
--GO

--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--SET ANSI_PADDING ON
--GO

--CREATE TABLE [dbo].[CATEGORIAS](
--	[Id] [int] IDENTITY(1,1) NOT NULL,
--	[Descripcion] [varchar](50) NULL,
-- CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
--(
--	[Id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]

--GO

--SET ANSI_PADDING OFF
--GO

--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--SET ANSI_PADDING ON
--GO

--CREATE TABLE [dbo].[ARTICULOS](
--	[Id] [int] IDENTITY(1,1) NOT NULL,
--	[Codigo] [varchar](50) NULL,
--	[Nombre] [varchar](50) NULL,
--	[Descripcion] [varchar](150) NULL,
--	[IdMarca] [int] NULL,
--	[IdCategoria] [int] NULL,
--	[Precio] [money] NULL,
-- CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
--(
--	[Id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]

--GO

--SET ANSI_PADDING OFF
--GO

--create table IMAGENES(
--	Id int IDENTITY(1,1) not null,
--	IdArticulo int not null,
--	ImagenUrl varchar(1000) not null
--)
--go

--insert into MARCAS values ('Samsung'), ('Apple'), ('Sony'), ('Huawei'), ('Motorola')
--insert into CATEGORIAS values ('Celulares'),('Televisores'), ('Media'), ('Audio')
--insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, 69.999),
--('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 1, 5, 15699),
--('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 35000),
--('S56', 'Bravia 55', 'Alta tele', 3, 2, 49500),
--('A23', 'Apple TV', 'lindo loro', 2, 3, 7850)

--insert into imagenes values
--(1,'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542'),
--(2, 'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000'),
--(2, 'https://i.blogs.es/9da288/moto-g7-/1366_2000.jpg'),
--(3, 'https://www.euronics.cz/image/product/800x800/532620.jpg'),
--(4, 'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450'),
--(5, 'https://cnnespanol2.files.wordpress.com/2015/12/gadgets-mc3a1s-populares-apple-tv-2015-18.jpg?quality=100&strip=info&w=460&h=260&crop=1')

--select * from ARTICULOS

USE CATALOGO_P3_DB
UPDATE dbo.IMAGENES SET ImagenUrl ='https://www.multipoint.com.ar/Image/0/750_750-a124.jpg' WHERE Id = 1
UPDATE dbo.IMAGENES SET ImagenUrl ='https://jumboargentina.vtexassets.com/arquivos/ids/528615/Celular-Motorola-Moto-G7-Power-Blue-1-655410.jpg?v=636893400433830000' WHERE Id = 2
UPDATE dbo.IMAGENES SET ImagenUrl ='https://www.casadelaudio.com/Image/0/700_700-750-son-628-1.jpg' WHERE Id = 4
UPDATE dbo.IMAGENES SET ImagenUrl ='https://arsonyb2c.vtexassets.com/arquivos/ids/357168/d4f672c8c1b08401c3fb67cce747b7db.jpg?v=637620094081630000' WHERE Id = 5
UPDATE dbo.IMAGENES SET ImagenUrl ='https://www.apple.com/la/apple-tv-app/images/meta/apple-tv__za3c4sr9utu6_og.png' WHERE Id = 6

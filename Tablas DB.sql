/*

CREATE DATABASE Recetario
GO
Set Dateformat 'DMY'
USE Recetario
GO

CREATE TABLE Categoria(
	Id tinyint primary key identity(1,1),
	Nombre nvarchar (30) NOT NULL -- (Entrada, Plato Principal, Postre, Snack, Merienda, etc.) --
)

CREATE TABLE Ingrediente(
	Id int primary key identity(1,1),
	Nombre nvarchar(30) NOT NULL
)

CREATE TABLE Receta(
	Id int primary key identity(1,1),
	Nombre nvarchar(30) NOT NULL,
	UrlImagen nvarchar(300),
	IdCategoria tinyint NOT NULL foreign key references Categoria(Id), 
	Dificultad tinyint NOT NULL,
	Tiempo smallint NOT NULL,
	Porciones tinyint NOT NULL,
	Comentarios nvarchar(300),
	Puntuacion DECIMAL(4,2) NOT NULL,
	CONSTRAINT CK_Puntuacion CHECK (Puntuacion >= 0 AND Puntuacion <= 10)
)

CREATE TABLE UnidadMedida(
	Id tinyint primary key identity(1,1),
	Nombre nvarchar(30) NOT NULL,
	Abreviatura nvarchar(10) NOT NULL
)

CREATE TABLE Etiqueta(					-- rápido, económico, sin gluten, etc.
	Id int primary key identity(1,1),
	Nombre nvarchar(30) NOT NULL
)

CREATE TABLE Etiquetas_x_Receta(
	Id int primary key identity(1,1),
	IdReceta int NOT NULL foreign key references Receta (Id),
	IdEtiqueta int NOT NULL foreign key references Etiqueta (Id)
)

CREATE TABLE Ingredientes_x_Receta(
	Id int primary key identity(1,1),
	IdReceta int NOT NULL foreign key references Receta (Id),
	IdIngrediente int NOT NULL foreign key references Ingrediente (Id),
	Cantidad DECIMAL(6,2) NOT NULL,
	IdUnidad tinyint NOT NULL foreign key references UnidadMedida (Id),
	Opcional bit NOT NULL, -- Checkbox --
	CONSTRAINT UQ_IngredienteReceta UNIQUE (IdReceta, IdIngrediente)
)

CREATE TABLE Preparacion(
	Id int primary key identity(1,1),
	NroPaso tinyint NOT NULL,
	IdReceta int NOT NULL foreign key references Receta (Id),
	Descripcion nvarchar(200) NOT NULL,
	CONSTRAINT UQ_PasoReceta UNIQUE (NroPaso, IdReceta)
)

*/

CREATE INDEX IX_Receta_IdCategoria ON Receta(IdCategoria);
CREATE INDEX IX_Receta_Nombre ON Receta(Nombre);
CREATE INDEX IX_Ingrediente_Nombre ON Ingrediente(Nombre);
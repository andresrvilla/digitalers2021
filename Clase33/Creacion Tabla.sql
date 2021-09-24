CREATE DATABASE DigitalersBlog;
GO
USE DigitalersBlog;
GO

CREATE TABLE Posteos (
	Id int primary key identity,
	Titulo nvarchar(128) not null,
	Resumen nvarchar(500) not null,
	Contenido nvarchar(max) not null,
	Autor nvarchar(50) not null,
	FechaDePublicacion datetime not null,
	Destacada bit not null
)

INSERT INTO Posteos (titulo,resumen,contenido,autor,FechaDePublicacion,destacada)
VALUES
('Titulo noticia 1',
'Este es el resumen de la noticia 1',
'Este es el contenido de la noticia 1, debería ser un texto super largo',
'Autor Uno',
'2021-09-20 20:09:00',
1);

INSERT INTO Posteos (titulo,resumen,contenido,autor,FechaDePublicacion,destacada)
VALUES
('Titulo noticia 2',
'Este es el resumen de la noticia 2',
'Este es el contenido de la noticia 2, debería ser un texto super largo',
'Autor Dos',
CURRENT_TIMESTAMP,
1);

INSERT INTO Posteos (titulo,resumen,contenido,autor,FechaDePublicacion,destacada)
VALUES
('Titulo noticia 3',
'Este es el resumen de la noticia 3',
'Este es el contenido de la noticia 3, debería ser un texto super largo',
'Autor Dos',
CURRENT_TIMESTAMP,
0);

CREATE TABLE Categorias(
	Id int identity primary key,
	Descripcion nvarchar(100) not null
)
GO

ALTER TABLE Posteos ADD Categoria int null;
GO

ALTER TABLE Posteos ADD FOREIGN KEY (Categoria)
REFERENCES Categorias(Id)
GO

INSERT INTO Categorias (Descripcion) VALUES ('Noticia');
UPDATE Posteos SET Categoria = 1;

CREATE DATABASE Biblioteca
GO
USE Biblioteca
GO

CREATE TABLE Categoria(
    IDcategoria int not null identity(1, 1),
    Nombre varchar(30),
    CONSTRAINT PK_IDcategoria PRIMARY KEY(IDcategoria)
)
 
CREATE TABLE Libros(
    ISBN int not null,
    Titulo varchar(30),
    Autor varchar(30),
    Editorial varchar(30),
    Publicacion date,
    Num_Copias int,
    CONSTRAINT PK_ISBN PRIMARY KEY(ISBN),
)

CREATE TABLE Categoria_Libro(
	IDcategoria int not null,
	ISBN int not null,
	CONSTRAINT PK_Categoria_Libro UNIQUE(IDcategoria, ISBN),
	CONSTRAINT FK_IDcategoria FOREIGN KEY(IDcategoria) REFERENCES Categoria(IDcategoria) ON DELETE CASCADE,
	CONSTRAINT FK_ISBN FOREIGN KEY(ISBN) REFERENCES Libros(ISBN) ON DELETE CASCADE
)

CREATE TABLE Usuarios(
    IDusuario int not null,
    Nombre varchar(30),
    Direccion varchar(30),
    Telefono varchar(15),
    Correo_electronico varchar(50) not null,
    CONSTRAINT PK_IDusuario PRIMARY KEY(IDusuario),
	CONSTRAINT UC_Correo UNIQUE(Correo_electronico)
)

CREATE TABLE Bibliotecario(
	IDpersonal int not null,
	Nombre varchar(50),
	Direccion varchar(50),
	Telefono varchar(15),
	Correo_electronico varchar(30)
	CONSTRAINT PK_IDpersonal PRIMARY KEY(IDpersonal)
)

CREATE TABLE Prestamos(
    IDprestamo int not null,
    IDusuario int not null,
    ISBN int not null,
	IDpersonal int not null,
    FechaInicio date,
    FechaFin date,
    Renovacion bit default 0,
	IDpersonal_renovacion int default null,
    CONSTRAINT PK_IDprestamo PRIMARY KEY(IDprestamo),
    CONSTRAINT FK_IDusuario FOREIGN KEY(IDusuario) REFERENCES Usuarios(IDusuario),
    CONSTRAINT FK_ISBN_prestamo FOREIGN KEY(ISBN) REFERENCES Libros(ISBN),
	CONSTRAINT FK_IDprestamo FOREIGN KEY(IDpersonal) REFERENCES Bibliotecario(IDpersonal),
	CONSTRAINT FK_IDprestamo_renovacion FOREIGN KEY(IDpersonal_renovacion) REFERENCES Bibliotecario(IDpersonal)
)

--Este es un comentario

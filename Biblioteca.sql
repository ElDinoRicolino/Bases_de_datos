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
	Estado varchar(10) default 'disponible',
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
    IDusuario int not null identity (1000, 1),
    Nombre varchar(30),
	Primerapellido varchar(25),
	Segundoapellido varchar(25),
    Direccion varchar(30),
    Telefono varchar(15),
    Correo_electronico varchar(50) not null,
	Membresia bit default 1,
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
    IDprestamo int not null identity(1,1),
    IDusuario int not null,
    ISBN int not null,
	IDpersonal int not null,
    FechaInicio date,
    FechaFin date,
	Fecharegreso date,
    Renovacion bit default 0,
	IDpersonal_renovacion int default null,
    CONSTRAINT PK_IDprestamo PRIMARY KEY(IDprestamo),
    CONSTRAINT FK_IDusuario FOREIGN KEY(IDusuario) REFERENCES Usuarios(IDusuario),
    CONSTRAINT FK_ISBN_prestamo FOREIGN KEY(ISBN) REFERENCES Libros(ISBN),
	CONSTRAINT FK_IDprestamo FOREIGN KEY(IDpersonal) REFERENCES Bibliotecario(IDpersonal),
	CONSTRAINT FK_IDprestamo_renovacion FOREIGN KEY(IDpersonal_renovacion) REFERENCES Bibliotecario(IDpersonal)
)

Create table Reservaciones (
	IDreservacion int not null, 
	IDusuario int not null,
	ISBN int not null,
	Fechareserva date,
	Constraint PK_IDreservacion Primary Key(IDreservacion),
	Constraint FK_IDusuario_reservacion Foreign Key(IDusuario) References Usuarios(IDusuario),
	Constraint FK_ISBN_reservacion Foreign key(ISBN) References Libros(ISBN)
)

Create table Multas (
	IDmulta int not null,
	IDprestamo int not null,
	IDusuario int not null, 
	Cantidad int,
	Fechamulta date,
	Fechapago date, 
	Constraint PK_IDmulta Primary Key(IDmulta),
	Constraint FK_IDprestamo_multa Foreign Key (IDprestamo) References Prestamos(IDprestamo),
	Constraint FK_IDusuarios_multa Foreign Key (IDusuario) References Usuarios(IDusuario)
)

alter table Multas add constraint CH_Prestamo_multas check (Cantidad >= 0)
go
alter table Usuarios add constraint CH_cantidad_prestamos check (Cantprest >= 0 and Cantprest <=5)
go


--Aqui empiezan los triggers
Create Trigger Tr_ActualizarEstadoLibro 
on Prestamos
instead of insert
as 
Begin 
	Declare @ISBN int
	select @ISBN = ISBN
	from inserted

	If (Select Num_Copias From Libros Where ISBN = @ISBN ) > 0
	begin
		Update Libros set Num_Copias = Num_Copias - 1 where ISBN = @ISBN
		insert into Prestamos
		select IDusuario, ISBN, IDpersonal, FechaInicio, FechaFin
		from inserted
		if (Select Num_Copias from Libros where ISBN = @ISBN) < 1
		begin 
			Update Libros set Estado = 'No disponible' where ISBN = @ISBN
		end
	end
End
go 

--Aqui empiezan los Stored Precedures
Create procedure SP_AgregarLibros
@ISBN int, @Titulo varchar(30), @Autor varchar(30), @Editorial varchar(30),@Publicacion date, @Num_Copias int
As 
Begin
	Insert into Libros(ISBN, Titulo,Autor,Editorial,Publicacion,Num_Copias) values (@ISBN, @Titulo,@Autor,@Editorial,@Publicacion,@Num_Copias)
End
go

Create Procedure SP_PrestarLibro
@idusuario int, @ISBN int, @IDpersonal int
As 
Begin   
	Declare @FechaInicio date, @FechaFin date
	set @FechaInicio = GETDATE()
	Set @FechaFin = DATEADD(DAY,14,@FechaInicio)
	
	update Usuarios set Cantprest = Cantprest + 1 where IDusuario = @idusuario
	Insert into Prestamos (IDusuario,ISBN,IDpersonal,FechaInicio, FechaFin) Values (@Idusuario,@ISBN,@IDpersonal,@FechaInicio,@FechaFin)
End 
go 

Create Procedure SP_RegistrarUsuario 
@Nombre varchar(30),@Primerapellido varchar(25),@Segundoapellido varchar(25),@Direccion varchar(30),@Telefono varchar(15),@Correo_electronico varchar(50) 
As 
Begin 
	Insert into Usuarios (Nombre,Primerapellido,Segundoapellido,Direccion, Telefono, Correo_electronico) Values (@Nombre,@Primerapellido,@Segundoapellido,@Direccion,@Telefono,@Correo_electronico)
End
go
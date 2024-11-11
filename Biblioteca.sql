use master
if exists (select * from sysdatabases where name='Biblioteca')
	drop database Biblioteca
go
create database Biblioteca
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
	Cantprest int default 0,
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
	Fecharegreso date default null,
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
	IDprestamo int not null,
	IDusuario int not null, 
	Cantidad int,
	Fechamulta date,
	Fechapago date null, 
	Constraint PK_IDmulta Primary Key(IDprestamo, IDusuario),
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
	Declare @ISBN int, @idusuario int
	select @ISBN = ISBN
	from inserted

	select @idusuario = IDusuario
	from inserted

	If (Select Num_Copias From Libros Where ISBN = @ISBN ) > 0
	begin
		Update Libros set Num_Copias = Num_Copias - 1 where ISBN = @ISBN
		insert into Prestamos (IDusuario, ISBN, IDpersonal, FechaInicio, FechaFin)
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
<<<<<<< HEAD
End
=======
End
go

Create Procedure SP_DevolverLibro
@idprestamo int
as
begin 
	if (select FechaRegreso from Prestamos where IDprestamo = @idprestamo) = null
	begin
		Update Prestamos set Fecharegreso = GETDATE() where IDprestamo = @idprestamo
	
		declare @diasPasados int, @FechaFin date, @idusuario int

		select @FechaFin = FechaFin
		from Prestamos 
		where IDprestamo = @idprestamo

		set @diasPasados = DATEDIFF(DAY, @FechaFin, GETDATE())

		if @diasPasados > 0
		begin
			select @idusuario = IDusuario
			from Prestamos
			where IDprestamo = @idprestamo

			insert into Multas (IDprestamo, IDusuario, Cantidad, Fechamulta)
			values (@idprestamo, @idusuario, @diasPasados, GETDATE())
		end
	end
end
go

create procedure SP_RonovarPrestamo
@idprestamo int
as 
begin
	if(select Renovacion from Prestamos where IDprestamo = @idprestamo) = 0
	begin
		update Prestamos set Renovacion = 1, FechaFin = dateadd(day, 14, FechaFin) where IDprestamo = @idprestamo
	end
end
go

>>>>>>> 5227123904ab4784f9566cff70133a2089e38481

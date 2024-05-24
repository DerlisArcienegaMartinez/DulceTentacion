create database DulceSensacionOF
Use DulceSensacionOF

CREATE TABLE Usuarios (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) not null,
    ApellidoPaterno NVARCHAR(50),
    ApellidoMaterno NVARCHAR(50),
    CU NVARCHAR(20) not null UNIQUE,
	FechaNacimiento date not null,
	Edad int not null,
    Genero NVARCHAR(10) not null,
    Telefono NVARCHAR(15),
    Celular NVARCHAR(15) not null,
    DireccionDomicilio NVARCHAR(100) not null,
    CorreoElectronico NVARCHAR(50) not null,
    NombreUsuario NVARCHAR(50) not null UNIQUE,
    Contraseña NVARCHAR(50) not null
);

DECLARE @NuevoValor INT;
--SELECT @NuevoValor = MAX(IdCliente) + 1 FROM Usuarios;
--DBCC CHECKIDENT ('Usuarios', RESEED, @NuevoValor);
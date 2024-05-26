create database DulceSensacion
Use DulceSensacion

CREATE TABLE Usuarios (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) not null,
    ApellidoPaterno NVARCHAR(50),
    ApellidoMaterno NVARCHAR(50),
    CU NVARCHAR(20) not null UNIQUE,
    Genero NVARCHAR(10) not null,
	FecNacimiento NVARCHAR(50) not null,
	Edad INT not null,
    Telefono NVARCHAR(15),
	Sufijos NVARCHAR(4) not null,
    Celular NVARCHAR(15) not null,
    DireccionDomicilio NVARCHAR(200) not null,
    CorreoElectronico NVARCHAR(50) not null,
    NombreUsuario NVARCHAR(50) not null UNIQUE,
    Contraseña NVARCHAR(50) not null,
	Perfil NVARCHAR(500)
);

select* from Usuarios;
-- Tabla de CuentaUsuario
CREATE TABLE CuentaUsuario (
    IdCuenta INT PRIMARY KEY IDENTITY,
    IdCliente INT FOREIGN KEY REFERENCES Usuarios(IdCliente),
    -- Agrega aquí más columnas según sea necesario
);

drop table Usuarios;
drop table CuentaUsuario;
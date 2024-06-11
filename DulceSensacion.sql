create database DulceSensacion
Use DulceSensacion

CREATE TABLE Usuarios (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) not null,
    ApellidoPaterno NVARCHAR(50),
    ApellidoMaterno NVARCHAR(50),
    CI NVARCHAR(10) not null UNIQUE,
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
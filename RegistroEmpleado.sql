use master

create database RegistroEmpleados
use RegistroEmpleados

create table empleados(
   CI NVARCHAR(10) not null UNIQUE,
   Nombres NVARCHAR(50) not null,
   ApellidoPaterno NVARCHAR(50),
   ApellidoMaterno NVARCHAR(50),
   Celular NVARCHAR(20) not null,
   CBGenero NVARCHAR(10),
   Direccion NVARCHAR(100) not null,
   CorreoElectronico NVARCHAR(50),
   CBCorreo NVARCHAR(25),

   CBPuesto NVARCHAR(20) not null,
   HoraEntrada int not null,
   HoraSalida int not null,
   InicioContrato DATE not null,
   FinContrato DATE not null,
   Salario float not null,
   NombreUsuario NVARCHAR(20) not null unique,
   Contraseña NVARCHAR(50) not null,

   CBMovilidad NVARCHAR(2),
   CBLicencia NVARCHAR(2),
   NLicencia NVARCHAR(10),
   NMatricula NVARCHAR(10),
   Descripcion NVARCHAR(100) 
);
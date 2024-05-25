use master

create dataBase CompraProd
use CompraProd

create table Productos(
Codigo char(5) not null PRIMARY KEY,
Nombre varchar(100) not null,
UxMasa float ,
UxLitro float ,
Cantidad int ,
Precio float not null,
Descripcion varchar(200)
);

select* from Productos
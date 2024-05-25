use master

create dataBase CompraProductos
use CompraProductos

create table Productos(
Codigo varchar(50) not null,
Nombre varchar(100) not null PRIMARY KEY,
UxMasa float ,
UxLitro float ,
Cantidad int ,
Precio float not null,
Descripcion varchar(200) not null
);
Go

select* from Productos;




DROP TABLE Productos;

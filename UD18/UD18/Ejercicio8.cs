using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    class Ejercicio8
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Productos(Codigo int identity(1, 1) primary key,Nombre nvarchar(100) not null,Precio int)");
            db.Multifunction("CREATE TABLE Cajeros(Codigo int identity(1, 1) primary key,NomsApels nvarchar(255) not null)");
            db.Multifunction("CREATE TABLE Maquinas_Registradoras(Codigo int identity(1, 1) primary key,Piso int not null)");
            db.Multifunction("CREATE TABLE Suministra(Cajero int,Maquina int,Producto int,foreign key(Cajero) references Cajeros(Codigo) on update cascade,foreign key(Maquina) references Maquinas_Registradoras(Codigo) on update cascade,foreign key(Producto) references Productos(Codigo) on update cascade,CONSTRAINT PK_Suministra PRIMARY KEY (Cajero,Maquina,Producto))");
        }

        public void Insert(Database db)
        {
            db.Multifunction("Insert into Productos values ('Entrecot',13)");
            db.Multifunction("Insert into Productos values ('Solomillo',11)");
            db.Multifunction("Insert into Productos values ('Chuleton',17)");
            db.Multifunction("Insert into Productos values ('Lomo',5)");
            db.Multifunction("Insert into Productos values ('Panceta',7)");

            db.Multifunction("Insert into Cajeros values ('Daniel Carvajal')");
            db.Multifunction("Insert into Cajeros values ('Lucas Vazquez')");
            db.Multifunction("Insert into Cajeros values ('Ignacio Fernández')");
            db.Multifunction("Insert into Cajeros values ('Sergio Ramos')");
            db.Multifunction("Insert into Cajeros values ('Francisco Alarcón')");

            db.Multifunction("Insert into Maquinas_Registradoras values (1)");
            db.Multifunction("Insert into Maquinas_Registradoras values (2)");
            db.Multifunction("Insert into Maquinas_Registradoras values (3)");
            db.Multifunction("Insert into Maquinas_Registradoras values (4)");
            db.Multifunction("Insert into Maquinas_Registradoras values (5)");

            db.Multifunction("Insert into Suministra values (1,2,3)");
            db.Multifunction("Insert into Suministra values (2,3,1)");
            db.Multifunction("Insert into Suministra values (3,1,4)");
            db.Multifunction("Insert into Suministra values (4,5,5)");
            db.Multifunction("Insert into Suministra values (5,4,2)");
        }
    }
}

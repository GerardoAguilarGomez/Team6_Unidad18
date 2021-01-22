using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    class Ejercicio7
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Cientificos(DNI varchar(8) primary key,NomApels nvarchar(255) not null)");
            db.Multifunction("CREATE TABLE Proyecto(Id char(4) primary key,Nombre nvarchar(255) not null,Horas int)");
            db.Multifunction("CREATE TABLE Suministra(Cientifico varchar(8),Proyecto char(4),foreign key(Cientifico) references Cientificos(DNI) on update cascade,foreign key(Proyecto) references Proyecto(Id) on update cascade)");
        }

        public void Insert(Database db)
        {
            db.Multifunction("Insert into Cientificos values ('11111111','Perico Delgado')");
            db.Multifunction("Insert into Cientificos values ('22222222','Pau Gasol')");
            db.Multifunction("Insert into Cientificos values ('33333333','Marc Gasol')");
            db.Multifunction("Insert into Cientificos values ('44444444','Mike Tyson')");
            db.Multifunction("Insert into Cientificos values ('55555555','Mohamed Ali')");

            db.Multifunction("Insert into Proyecto values ('0000','Proyecto 0',4)");
            db.Multifunction("Insert into Proyecto values ('0001','Proyecto 1',7)");
            db.Multifunction("Insert into Proyecto values ('0002','Proyecto 2',25)");
            db.Multifunction("Insert into Proyecto values ('0003','Proyecto 3',41)");
            db.Multifunction("Insert into Proyecto values ('0004','Proyecto 4',9)");

            db.Multifunction("Insert into Suministra values ('11111111','0000')");
            db.Multifunction("Insert into Suministra values ('22222222','0001')");
            db.Multifunction("Insert into Suministra values ('33333333','0002')");
            db.Multifunction("Insert into Suministra values ('44444444','0003')");
            db.Multifunction("Insert into Suministra values ('55555555','0004')");
        }
    }
}

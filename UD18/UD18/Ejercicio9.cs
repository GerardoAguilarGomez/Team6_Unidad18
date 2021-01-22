using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    class Ejercicio9
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Facultad(codigo int PRIMARY KEY,nombre varchar(100) NOT NULL)");
            db.Multifunction("CREATE TABLE Investigadores(DNI varchar(8) PRIMARY KEY,nomApels varchar(255) NOT NULL,facultad int FOREIGN KEY REFERENCES Facultad(codigo))");
            db.Multifunction("CREATE TABLE Equipos(numSerie char(4) PRIMARY KEY,nombre varchar(100) NOT NULL,facultad int FOREIGN KEY REFERENCES Facultad(codigo))");
            db.Multifunction("CREATE TABLE Reserva(DNI varchar(8) FOREIGN KEY REFERENCES Investigadores(DNI),numSerie char(4) FOREIGN KEY REFERENCES Equipos(numSerie),comienzo datetime,fin datetime,CONSTRAINT PK_Reserva PRIMARY KEY(DNI, numSerie))");
        }

        public void Insert(Database db)
        {
            db.Multifunction("Insert into Facultad values (1,'Facultad Derecho')");
            db.Multifunction("Insert into Facultad values (2,'Facultad Matemáticas')");
            db.Multifunction("Insert into Facultad values (3,'Facultad Física')");
            db.Multifunction("Insert into Facultad values (4,'Facultad Ciencias')");
            db.Multifunction("Insert into Facultad values (5,'Facultad Medicina')");

            db.Multifunction("Insert into Investigadores values (11111111,'Ramón García',5)");
            db.Multifunction("Insert into Investigadores values (22222222,'Lucas Hernández',4)");
            db.Multifunction("Insert into Investigadores values (33333333,'Lucía Villalón',3)");
            db.Multifunction("Insert into Investigadores values (44444444,'Emilio Pérez',2)");
            db.Multifunction("Insert into Investigadores values (55555555,'Danae Boronat',1)");

            db.Multifunction("Insert into Equipos values ('0000','Equipo 0',3)");
            db.Multifunction("Insert into Equipos values ('0001','Equipo 1',3)");
            db.Multifunction("Insert into Equipos values ('0002','Equipo 2',3)");
            db.Multifunction("Insert into Equipos values ('0003','Equipo 3',3)");
            db.Multifunction("Insert into Equipos values ('0004','Equipo 4',3)");

            db.Multifunction("Insert into Reserva values ('11111111','0004','2020-01-01','2021-01-01')");
            db.Multifunction("Insert into Reserva values ('22222222','0003','2020-01-01','2021-01-01')");
            db.Multifunction("Insert into Reserva values ('33333333','0002','2020-01-01','2021-01-01')");
            db.Multifunction("Insert into Reserva values ('44444444','0001','2020-01-01','2021-01-01')");
            db.Multifunction("Insert into Reserva values ('55555555','0000','2020-01-01','2021-01-01')");
        }
    }
}

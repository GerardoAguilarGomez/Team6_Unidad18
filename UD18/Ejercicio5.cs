using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    class Ejercicio5
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Despachos(Numero int PRIMARY KEY,Capacidad int NOT NULL)");
            db.Multifunction("CREATE TABLE Directores(DNI varchar(8) PRIMARY KEY,NomApels nvarchar(255) NOT NULL," +
                "Despacho int FOREIGN KEY REFERENCES Despachos(Numero) on update cascade," +
                "DNIJefe varchar(8) FOREIGN KEY REFERENCES Directores(DNI) on update no action)");
        }

        public void InsertTableDespachos(Database db)
        {
            db.Multifunction("INSERT INTO Despachos VALUES(1,40)");
            db.Multifunction("INSERT INTO Despachos VALUES(2,200)");
            db.Multifunction("INSERT INTO Despachos VALUES(3,80)");
            db.Multifunction("INSERT INTO Despachos VALUES(4,15)");
            db.Multifunction("INSERT INTO Despachos VALUES(5,32)");
        }

        public void InsertTableDirectores(Database db)
        {
            db.Multifunction("INSERT INTO Directores VALUES('94857301','Eric Pastor', 4,'')");
            db.Multifunction("INSERT INTO Directores VALUES('74949482','Gerardo Aguilar', 5,'')");
            db.Multifunction("INSERT INTO Directores VALUES('04948373','Sergio Clavero', 3,'')");
            db.Multifunction("INSERT INTO Directores VALUES('85757324','Mariano Avispado', 4,'94857301')");
            db.Multifunction("INSERT INTO Directores VALUES('94857301','Pinado Antorcha', 5,'74949482')");
        }
    }
}

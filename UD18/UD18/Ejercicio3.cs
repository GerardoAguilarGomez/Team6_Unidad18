using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    public class Ejercicio3
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Almacenes(codigo int IDENTITY(1, 1) PRIMARY KEY,lugar varchar(100),capacidad int)");
            db.Multifunction("CREATE TABLE Cajas(numReferencia char(5) PRIMARY KEY,contenido varchar(100) NOT NULL,valor int,almacen int FOREIGN KEY REFERENCES Almacenes(codigo))");
        }

        public void InsertTableAlmacenes(Database db)
        {
            db.Multifunction("Insert into Almacenes values ('Barcelona', 4)");
            db.Multifunction("Insert into Almacenes values ('Valencia', 10)");
            db.Multifunction("Insert into Almacenes values ('Los Angeles', 30)");
            db.Multifunction("Insert into Almacenes values ('Valls', 1)");
            db.Multifunction("Insert into Almacenes values ('Gerona', 3)");
        }

        public void InsertTableCajas(Database db)
        {
            db.Multifunction("Insert into Cajas values ('45HT8','Bolsas de plastico', 40, 1)");
            db.Multifunction("Insert into Cajas values ('56TY4','Cajas de carton', 100, 2)");
            db.Multifunction("Insert into Cajas values ('67XD1','Videojuegos PS4', 5000, 3)");
            db.Multifunction("Insert into Cajas values ('43RT2','Bolsas de papel', 10, 5)");
            db.Multifunction("Insert into Cajas values ('68MD3','Playstation 5', 10000, 4)");
        }
    }
}

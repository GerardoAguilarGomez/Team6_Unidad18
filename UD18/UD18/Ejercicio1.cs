using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    public class Ejercicio1
    {

        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Fabricantes(codigo int IDENTITY(1, 1) PRIMARY KEY,nombre varchar(100) NOT NULL)");
            db.Multifunction("CREATE TABLE Articulos(codigo int IDENTITY(1, 1) PRIMARY KEY,nombre varchar(100) NOT NULL,precio int,fabricante int FOREIGN KEY REFERENCES Fabricantes(codigo))");
        }

        public void InsertTableFabricantes(Database db)
        {
            db.Multifunction("Insert into Fabricantes values ('Intel')");
            db.Multifunction("Insert into Fabricantes values ('Microsoft')");
            db.Multifunction("Insert into Fabricantes values ('HP')");
            db.Multifunction("Insert into Fabricantes values ('MSI')");
            db.Multifunction("Insert into Fabricantes values ('Asus')");
        }

        public void InsertTableArticulos(Database db)
        {
            db.Multifunction("Insert into Articulos values ('Ordenador HP', 500, 3)");
            db.Multifunction("Insert into Articulos values ('Ordenador MSI', 1100, 4)");
            db.Multifunction("Insert into Articulos values ('Procesador I7', 800, 1)");
            db.Multifunction("Insert into Articulos values ('Licencia Windows', 100, 2)");
            db.Multifunction("Insert into Articulos values ('Impresora Asus', 350, 5)");
        }
    }
}

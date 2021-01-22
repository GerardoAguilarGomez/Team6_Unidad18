using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    class Ejercicio4
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Peliculas(codigo int IDENTITY(1, 1) PRIMARY KEY," +
                "nombre varchar(100) NOT NULL,calificacionEdad int)");
            db.Multifunction("CREATE TABLE Salas(codigo int IDENTITY(1, 1) PRIMARY KEY," +
                "nombre varchar(100),pelicula int FOREIGN KEY REFERENCES Peliculas(codigo))");
        }

        public void InsertTablePeliculas(Database db)
        {
            db.Multifunction("Insert into Peliculas values('Los Vaqueros',13)");
            db.Multifunction("Insert into Peliculas values('La Matanza',18)");
            db.Multifunction("Insert into Peliculas values('Los Ositos',7)");
            db.Multifunction("Insert into Peliculas values('La Guerra',16)");
            db.Multifunction("Insert into Peliculas values('La Vida',7)");
        }
        public void InsertTableSalas(Database db)
        {
            db.Multifunction("Insert into Salas values('Pocont',2)");
            db.Multifunction("Insert into Salas values('Mandarin',4)");
            db.Multifunction("Insert into Salas values('Royality',3)");
            db.Multifunction("Insert into Salas values('Ganchode',5)");
            db.Multifunction("Insert into Salas values('Kampo',1)");
        }

    }
}

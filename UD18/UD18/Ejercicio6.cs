using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    class Ejercicio6
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Piezas(Codigo int identity(1, 1) primary key,Nombre nvarchar(100) not null)");

            db.Multifunction("CREATE TABLE Proveedores(Id char(4) primary key,Nombre nvarchar(100) not null)");

            db.Multifunction("CREATE TABLE Suministra(CodigoPieza int,IdProveedor char(4),Precio int not null," +
                "foreign key(CodigoPieza) references Piezas(Codigo)," +
                "foreign key(IdProveedor) references Proveedores(Id) on update cascade)");

        }

        public void InsertTablaPiezas(Database db)
        {
            db.Multifunction("INSERT INTO Piezas VALUES('Palot')");
            db.Multifunction("INSERT INTO Piezas VALUES('Entora')");
            db.Multifunction("INSERT INTO Piezas VALUES('Kirole')");
            db.Multifunction("INSERT INTO Piezas VALUES('Unteo')");
            db.Multifunction("INSERT INTO Piezas VALUES('Miceta')");
        }

        public void InsertTablaProveedores(Database db)
        {
            db.Multifunction("INSERT INTO Proveedores VALUES('DE23','Metaloquia')");
            db.Multifunction("INSERT INTO Proveedores VALUES('AE21','Lumanos')");
            db.Multifunction("INSERT INTO Proveedores VALUES('CE13','Kereman')");
            db.Multifunction("INSERT INTO Proveedores VALUES('BE56','Hierraco')");
            db.Multifunction("INSERT INTO Proveedores VALUES('NE32','Potencion')");
        }


        public void InsertTablaSuministra(Database db)
        {
            db.Multifunction("INSERT INTO Suministra VALUES(3,'DE23',345)");
            db.Multifunction("INSERT INTO Suministra VALUES(2,'CE13',25)");
            db.Multifunction("INSERT INTO Suministra VALUES(5,'AE21',105)");
            db.Multifunction("INSERT INTO Suministra VALUES(4,'BE56',87)");
            db.Multifunction("INSERT INTO Suministra VALUES(1,'NE32',54)");
        }
    }
}

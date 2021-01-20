using System;
using System.Collections.Generic;
using System.Text;

namespace UD18
{
    public class Ejercicio2
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Departamentos(codigo int PRIMARY KEY,nombre varchar(100) NOT NULL,presupuesto int)");
            db.Multifunction("CREATE TABLE Empleados(DNI varchar(8) PRIMARY KEY,nombre varchar(100) NOT NULL,apellidos varchar(255) NOT NULL,departamento int FOREIGN KEY REFERENCES Departamentos(codigo))");
        }

        public void InsertTableDepartamentos(Database db)
        {
            db.Multifunction("Insert into Departamentos values (1, 'Limpieza', 4000)");
            db.Multifunction("Insert into Departamentos values (2, 'I+D', 2500)");
            db.Multifunction("Insert into Departamentos values (3, 'Programacion', 3000)");
            db.Multifunction("Insert into Departamentos values (4, 'Diseño', 10000)");
            db.Multifunction("Insert into Departamentos values (5, 'Arte', 9000)");
        }

        public void InsertTableEmpleados(Database db)
        {
            db.Multifunction("Insert into Empleados values ('39927565', 'Eric', 'Pastor Castillejo', 3)");
            db.Multifunction("Insert into Empleados values ('36895475', 'Perica', 'Sanchez Rosales', 2)");
            db.Multifunction("Insert into Empleados values ('47895123', 'Robert', 'Guzman Tomas', 5)");
            db.Multifunction("Insert into Empleados values ('39874562', 'Julio', 'Talavera Ortega', 1)");
            db.Multifunction("Insert into Empleados values ('31728456', 'Esperanza', 'Angeles Valls', 4)");
        }



    }
}

using System;

namespace UD18
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            Ejercicio1 Ej1 = new Ejercicio1();
            Ejercicio2 Ej2 = new Ejercicio2();
            Ejercicio3 Ej3 = new Ejercicio3();
            Ejercicio4 Ej4 = new Ejercicio4();
            Ejercicio5 Ej5 = new Ejercicio5();
            Ejercicio6 Ej6 = new Ejercicio6();
            Ejercicio7 Ej7 = new Ejercicio7();
            Ejercicio8 Ej8 = new Ejercicio8();
            Ejercicio9 Ej9 = new Ejercicio9();



            string opcion = "";
            string opcion2 = "";

            Console.WriteLine("Escoge una opcion del 1 al 9");
            opcion = Console.ReadLine();
            Console.WriteLine("¿Desea crear la tabla? 1-Si 2-No");
            opcion2 = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    if (opcion2 == "1")
                    {
                        Ej1.CreateTable(db);
                    }
                    else
                    {
                        Console.WriteLine("¿Quieres crear fabricantes o articulos? 1- Fabricantes 2- Articulos");
                        opcion = Console.ReadLine();
                        if (opcion == "1") Ej1.InsertTableFabricantes(db);
                        else Ej1.InsertTableArticulos(db);
                    }
                    
                    break;

                case "2":
                    if (opcion2 == "1")
                    {
                        Ej2.CreateTable(db);
                    }
                    else
                    {
                        Console.WriteLine("¿Quieres crear Departamentos o Empleados? 1- Departamentos 2- Empleados");
                        opcion = Console.ReadLine();
                        if (opcion == "1") Ej2.InsertTableDepartamentos(db);
                        else Ej2.InsertTableEmpleados(db);
                    }

                    break;

                case "3":
                    if (opcion2 == "1")
                    {
                        Ej3.CreateTable(db);
                    }
                    else
                    {
                        Console.WriteLine("¿Quieres crear Almacenes o Cajas? 1- Almacenes 2- Cajas");
                        opcion = Console.ReadLine();
                        if (opcion == "1") Ej3.InsertTableAlmacenes(db);
                        else Ej3.InsertTableCajas(db);
                    }

                    break;


                case "4":

                    if (opcion2 == "1")
                    {
                        Ej4.CreateTable(db);
                    }
                    else
                    {
                        Console.WriteLine("¿Quieres crear Peliculas o Salas? 1- Peliculas 2- Salas");
                        opcion = Console.ReadLine();
                        if (opcion == "1") Ej4.InsertTablePeliculas(db);
                        else Ej4.InsertTableSalas(db);
                    }

                    break;

                case "5":

                    if (opcion2 == "1")
                    {
                        Ej5.CreateTable(db);
                    }
                    else
                    {
                        Console.WriteLine("¿Quieres crear Despachos o Directores? 1- Despachos 2- Directores");
                        opcion = Console.ReadLine();
                        if (opcion == "1") Ej5.InsertTableDespachos(db);
                        else Ej5.InsertTableDirectores(db);
                    }

                    break;


                case "6":

                    if (opcion2 == "1")
                    {
                        Ej6.CreateTable(db);
                    }
                    else
                    {
                        Console.WriteLine("¿Quieres crear Piezas, Proveedores o Suministra? 1- Piezas 2- Proveedores 3- Suministra");
                        opcion = Console.ReadLine();
                        if (opcion == "1") Ej6.InsertTablaPiezas(db);
                        else if (opcion == "2") Ej6.InsertTablaProveedores(db);
                        else Ej6.InsertTablaSuministra(db);
                    }

                    break;

                case "7":

                    if (opcion2 == "1")
                    {
                        Ej7.CreateTable(db);
                    }
                    else
                    {
                        Ej7.Insert(db);
                    }

                    break;

                case "8":

                    if (opcion2 == "1")
                    {
                        Ej8.CreateTable(db);
                    }
                    else
                    {
                        Ej8.Insert(db);
                    }

                    break;

                case "9":

                    if (opcion2 == "1")
                    {
                        Ej9.CreateTable(db);
                    }
                    else
                    {
                        Ej9.Insert(db);
                    }

                    break;

                default:
                    break;
            }
        }
    }
}

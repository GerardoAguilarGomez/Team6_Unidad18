using System;

namespace UD18
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            Ejercicio1 Ej1 = new Ejercicio1();

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
                default:
                    break;
            }
        }
    }
}

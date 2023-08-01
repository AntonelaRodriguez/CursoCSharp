using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BeerDB beerdb = new BeerDB(@"LAPTOP-4ULUA2DI\MSSQLSERVER02", "CSharpDB", "sa", "123456");
                bool again = true; // Para llevar el control si estamos todavia en el programa o si queremos terminarlo
                int op = 0; // Opcion al la operacion que vamos a hacer

                do
                {
                    ShowMenu();
                    Console.WriteLine("Elige una opción: ");
                    op= int.Parse(Console.ReadLine()); //lo que hace es tomar la opcion que escriba el user y la transforma en entero porque lo que devuelve siempre es string
                
                    switch(op)
                    {
                        case 1:
                            Show(beerdb);
                            break;
                        case 2:
                            Add(beerdb);
                            break;
                        case 3:
                            Edit(beerdb);
                            break;
                        case 4:
                            Delete(beerdb);
                            break;
                        case 5:
                            again = false;
                            break;
                    }
                }while (again); //siempre que sea true

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static void ShowMenu() 
        {
            Console.WriteLine("\n--------------Menu------------");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
        }

        public static void Show(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Cervezas de la base de datos");

            List<Beer> beers = beerDB.GetAll();

            foreach (var beer in beers)
            {
                Console.WriteLine($"Id: {beer.Id} Nombre: {beer.Name}");
            }
        }

        public static void Add(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca: ");
            int brandId = int.Parse(Console.ReadLine());
            Beer beer = new Beer(name, brandId);
            beerDB.Add(beer);
        }

        public static void Edit(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Editar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a editar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);
            if(beer != null)
            {
                Console.WriteLine("Escribe el nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de la marca:");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;
                beerDB.Edit(beer);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
        }

        public static void Delete(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Eliminar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);
            if (beer != null)
            {
                beerDB.Delete(id);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
        }
    }
}
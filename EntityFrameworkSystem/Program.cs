using BD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace EntityFrameworkSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<CsharpDbContext> optionsBuilder = new DbContextOptionsBuilder<CsharpDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-4ULUA2DI\\MSSQLSERVER02;Database=CSharpDB;Trusted_Connection=True;TrustServerCertificate=True;");

            bool again = true;
            int op = 0;
            do
            {
                ShowMenu();
                Console.WriteLine("Elige una opcion:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Edit(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
                        break;
                    case 5:
                        again = false;
                        break;
                }
            }while(again);
        }

        public static void Show(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Cervezas en la base de datos");
            using(var context = new CsharpDbContext(optionsBuilder.Options))
            {
                List<Beer> beers = (from b in context.Beers
                                     where b.BrandId == 1
                                     orderby b.Name
                                     select b).Include(b=>b.Brand).ToList();
                foreach(Beer beer in beers)
                {
                    Console.WriteLine($"{beer.Id} {beer.Name} {beer.Brand.Name}");
                }
            }
        }

        public static void Add(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder) //va a ser estatico porque lo estamos invocando dentro de un metodo estatico que no pertenece al obj sino a la clase
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre de la cerveza:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca:");
            int brandId = int.Parse(Console.ReadLine());
            using(var context = new CsharpDbContext(optionsBuilder.Options))
            {
                Beer beer = new Beer()
                {
                    Name = name,
                    BrandId = brandId
                };
                context.Add(beer);
                context.SaveChanges(); //esto guarda el elemento a la base de datos
            }
        }

        public static void Edit(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Editar cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a editar");
            int id = int.Parse(Console.ReadLine());
            using(var context = new CsharpDbContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);
                if(beer != null)
                {
                    Console.WriteLine("Escribe el nombre:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Escribe el id de la marca:");
                    int brandId =int.Parse(Console.ReadLine());
                    beer.Name = name;
                    beer.BrandId = brandId;
                    context.Entry(beer).State = EntityState.Modified; // Modifica
                    context.SaveChanges(); // Guarda la modificacion en la base de datos
                }
                else
                {
                    Console.WriteLine("Cerveza no encontrada");
                }
            }
        }

        public static void Delete(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Eliminar cerveza");
            Console.WriteLine("Escribe le id de la cerveza a eliminar:");
            int id = int.Parse(Console.ReadLine());

            using(var context = new CsharpDbContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);
                if(beer != null)
                {
                    context.Beers.Remove(beer); // para remover
                    context.SaveChanges(); // para que el eliminado se guarde en la base de datos
                }
                else
                {
                    Console.WriteLine("Cerveza no encontrada");
                }
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
    }
}
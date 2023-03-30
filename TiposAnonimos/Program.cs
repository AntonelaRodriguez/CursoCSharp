using System;

namespace TiposAnonimos
{

    class Progrma
    {
        static void Main(string[] args)
        {
            // C# te da ka posibilidad de crear obj sin necesidad de tener una clase, es decir, obj anonimos:
            var hector = new
            {
                Name= "Hector",
                Country = "Mexico"
            };

            Console.WriteLine($"{hector.Name} {hector.Country}");

            //La desventaja es que si yo quisiera cambiarle a hector el name no podria, porque es un obj solamente de lectura:
            // hector.Name = "Pepe";

            //Se puede crear arreglos de obj anonimos (los nombres de campos tienen que ser exactamente iguales sino falla, en este caso Name y Brand):
            var beers = new[]
            {
                new { Name = "Red", Brand = "Delirium"},
                new { Name = "London Porter", Brand = "Fullers"}
            };

            foreach ( var beer in beers )
            {
                Console.WriteLine($"Cerveza {beer.Name} {beer.Brand}");
            }
        }
    }
}
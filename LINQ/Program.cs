using System;
using System.Collections.Generic;
using System.Linq;
//using es la palabra reservada para agregar namespace
//un namespace es un un conjunto de clases que estan orfanizadas en un paquete

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ es una extension del lenguaje C#, la cual permite trabajar con colecciones

            List<Beer> beers = new List<Beer>()
            {
                new Beer()
                {
                    Name = "Corona", Country = "Mexico"
                },
                new Beer()
                {
                    Name = "Delirium", Country = "Belgica"
                },
                new Beer()
                {
                    Name = "Erdinger", Country = "Alemania"
                },
            };

            foreach(var beer in beers)
                Console.WriteLine(beer);

            Console.WriteLine("--------------------");

            //select = para seleccionar informacion
            //from b es el nombre o alias que le ponemos a nuestra coleccion en la representacion de la consulta
            var beersName = from b in beers
                            select new // es un tipo anonimo porque las especificaciones como Letters no existen en la clase
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                Fixed = 1
                            };
            foreach (var beer in beersName)
                Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");

            var beersNameReal = from b in beersName
                                select new
                                {
                                    Name = b.Name,
                                };
            foreach(var beer in beersNameReal)
                Console.WriteLine(beer.Name);

            Console.WriteLine("--------------------");

            // Se puede filtrar informacion:
            var beersMexico = from b in beers
                              where b.Country == "Mexico"
                              || b.Country == "Alemania"
                              select b; //Acá no creo una seleccion anonima sino que selecciono toda la coleccion (sin new)
            foreach(var beer in beersMexico)
                Console.WriteLine(beer); //beer va a invocar el toString por defecto (invoca el numero porque lo sobrescribi)

            Console.WriteLine("--------------------");

            // Ordeno alfabeticamente:
            var orderedBeers = from b in beers
                               orderby b.Country descending //si quiero ordenada saco el descending
                               select b;
            foreach(var beer in orderedBeers)
                Console.WriteLine(beer);
        }

        public class Beer
        {
            public string Name { get; set; }
            public string Country { get; set; }

            public override string ToString()
            {
                return $"Cerveza: {Name}, Brand: {Country}";
            }
        }
    }
}
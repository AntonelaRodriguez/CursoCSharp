using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Join
{

    class Program
    {
        static void Main(string[] args)
        {
            // La instruccion Join nos va a servir para unir dos colecciones de info, dos colecciones de datos o dos colecciones de lo que sea
            // Es decir, vamos a encontrar un patron comun entre dos coleccioens para hacer una union
            var beers = new List<Beer>()
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

            var countries = new List<Country>()
            {
                new Country()
                {
                    Name = "Mexico", Continent = "America"
                },
                new Country()
                {
                    Name = "Belgica", Continent = "Europa"
                },
                new Country()
                {
                    Name = "Alemania", Continent = "Europa"
                },
            };

            var beersWithContinent = from beer in beers
                                     join country in countries
                                     on beer.Country equals country.Name // Con on especificamos por cual es el valor que se unen
                                     select new
                                     {
                                         Name = beer.Name,
                                         Country = beer.Country,
                                         Continent = country.Continent
                                     };
            foreach(var beer in beersWithContinent)
                Console.WriteLine($"{beer.Name} {beer.Country} {beer.Continent}");
        }
    }
    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

    }

    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
    }

}
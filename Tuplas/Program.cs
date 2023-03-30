using System;
using System.Globalization;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Tupla:
            (int id, string name) product = (1, "cerveza stout");

            //Ahora yo puedo hacer como si la tupla fuera un obj, hacer uso de los valores que estan dentro:
            Console.WriteLine($"{product.id} {product.name}");

            // Las tuplas son editables (mutables):
            product.name = "cerveza porter";
            Console.WriteLine($"{product.id} {product.name}");

            // Forma mas rapida de crear una tupla:
            var person = (1, "Hector");

            // Como accedo a los elementos de las tuplas rapidas ?:
            Console.WriteLine($" persona {person.Item2}");

            //Arreglos de tuplas (los elementos tienen que tener los mismos tipos de datos) :
            var people = new[]
            {
                (1, "hector"),
                (2, "pedro"),
                (3, "juan")
            };
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            //Puedo especificar el tipo del arreglo:
            (int id, string name)[] people2 = new[]
            {
                (1, "hector"),
                (2, "pedro"),
                (3, "juan")
            };
            foreach (var p in people2)
            {
                Console.WriteLine($"{p.name} {p.id}");
            }

            var cityInfo = getLocationCDMX();
            Console.WriteLine($"lat: {cityInfo.lat} lng: {cityInfo.lng} nombre: {cityInfo.name}");

            //Ahora hago una variable simple para obtener solo la lng:
            var (_, lng, _) = getLocationCDMX();
            Console.WriteLine(lng);

        }

        // Las tuplas son utiles cuando requiero que se regrese mas de un valor en una funcion:
        public static (float lat, float lng, string name) getLocationCDMX() //static  porque lo creo dentro de una class static
        {
            float lat = 19.18249812f;
            float lng = -99.1284189246f;
            string name = "CDMX";

            return (lat, lng, name);
        }
    }
}
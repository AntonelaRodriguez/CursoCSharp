using System;
// para agregar listas tenemos que agregar el paquete:
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // lista: obj que ya esta preparado ocn una coleccion de metodos para trabajar
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(2);

            Console.WriteLine(numbers.Count);
            // Creacion de una lista que tenga valores desde el inicia de su creacion:
            List<int> numbers2 = new List<int>()
            {
                1,6,7,10,14
            };

            Console.WriteLine(numbers2.Count);
            numbers2.Add(55);
            Console.WriteLine(numbers2.Count);

            //Para borrar todos los elementos:
            numbers2.Clear();
            Console.WriteLine(numbers2.Count);

            List<string> countries = new List<string>()
            {
                "mexico", "argentina", "españa"
            };
            Console.WriteLine(countries.Count);
        }
    }
}
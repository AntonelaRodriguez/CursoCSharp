using System;
using System.Collections.Generic;

namespace ListCommonnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para agregar una lista, agregamos con ctrl . y elegir el using System.Collection.Generic para trabajar con listas
            List<int> numbers = new List<int>()
            {
                4,3,5,19
            };

            Show(numbers);

            //Insert me permite especificar la posicion en la cual quiero que se agregue el elemento:
            numbers.Insert(1, 6);
            Show(numbers);

            //Si quiero verificar si un elemento existe en mi lista utilizo Contains:
            if (numbers.Contains(19))
                Console.WriteLine("Existe");
            else
                Console.WriteLine("No existe");

            // El Indexof es un metodo que me dice en que posicion esta el elemento:
            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);
            pos =numbers.IndexOf(20); //si el elemento no existe devuelve un -1
            Console.WriteLine(pos);

            // el metodo Sort ordena(tiene que ser un obj mutable para que pueda cambiar):
            numbers.Sort();
            Show(numbers);

            // string inmutable, para que sea mutable tengo que hacer que name = name.ToUpper porque hace una copia con los cambios hechos convertidos a mayus:
            string name = "Hector";
            name = name.ToUpper();
            Console.WriteLine(name);

            //Add Range agrega otra lista a la lista (siendo la lista mutable):
            var numbers2 = new List<int>()
            {
                300,200,400
            };
            numbers.AddRange(numbers2);
            Show(numbers);

        }

        //Creo un metodo para ir mostrando los cambios que vamos a tener en la lista:

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numbers ---");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
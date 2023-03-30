using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] family = new string[7]{
                "Alberto",
                "Mario",
                "Soledad",
                "Carlos",
                "Nicolas",
                "Agustin",
                null
            };

            family[0] = "Beto";

            Console.WriteLine(family[0]);
            Console.WriteLine(family[1]);
            Console.WriteLine(family[2]);
            Console.WriteLine(family[3]);
            Console.WriteLine(family[4]);
            Console.WriteLine(family[5]);
            Console.WriteLine(family[6]);

        }
    }
}

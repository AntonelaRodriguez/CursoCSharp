using System;

namespace SentenciaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] family = new string[6]{
                "Alberto",
                "Mario",
                "Soledad",
                "Carlos",
                "Nicolas",
                "Agustin"
            };

            for (int i = 0; i < family.Length; i++) 
            {
                Console.WriteLine(family[i]);
            }

        }
    }
}

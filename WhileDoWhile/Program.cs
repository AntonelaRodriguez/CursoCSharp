using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("Iteracion de i " + i);
                i++;
            }

            int j = 0;
            while (j < 100) 
            {
                if (j > 10)
                    break;

                Console.WriteLine("Iteracion de j " + j);
                j++;
            }

            string[] family = new string[6]{
                "Alberto",
                "Mario",
                "Soledad",
                "Carlos",
                "Nicolas",
                "Agustin"
            };

            int index = 0;
            while (index < family.Length) 
            {
                Console.WriteLine(family[index]);
                index++;
            }

            bool run = false;
            do
            {
                Show();
            } while (run);
        }

        static void Show()
        {
            Console.WriteLine("Entro una vez y ya");
        }
    }
}
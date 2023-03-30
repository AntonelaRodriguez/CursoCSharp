using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 4;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Seleccionaste el 1");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste el 2");
                    break;
                case >3 and <10:
                    Console.WriteLine("Seleccionaste la opcion entre 2 y 10");
                    break;
                case > 100:
                    Console.WriteLine("Seleccionaste un numero mayor a 100");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}
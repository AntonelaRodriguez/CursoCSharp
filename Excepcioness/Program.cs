using System;
using System.IO; //nos ayuda a leer archivos

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Las excepciones en C# es para poder controlar situaciones inesperadas
                string content = File.ReadAllText(@"D:\\Firebase\Text.txt"); // el @ es para poder leer los \ que son especiales
                Console.WriteLine(content); // Como no existe entonces tenemos que usar el try

                //tiro una excepcion para probar:
                throw new Exception("Ocurrio algo raro");
            }
            catch (FileNotFoundException ex) // Tambien se puede poner Exception y no categorizarla con FileNotFoundException para que caiga ante cualquier excepcion
            {
                Console.WriteLine("El archivo no existe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally // Siempre se ejecuta, aunque se ejecuten los catch o no
            {
                Console.WriteLine("Aqui me he ejecutado pase lo que pase");
            }
            Console.WriteLine("Aqui se sigue ejecutando");
        }
    }
}
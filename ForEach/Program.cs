using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una forma de ahorra caracteres es escribir var en ver de List<int> al principio ya que despues especificamos el tipo de dato
            //var solo se puede utilizar dentro de metodos
            // si a List le damos ctrl + click se ven las especificaciones que hace lista (cualquier tipo de dato que tenga especificaciones IEnumerable puede utilizar foreach

            var numbers = new List<int>()
            {
                23,3,5,10,22,12
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // creo un listado de estudiantes con la class People
            var students = new List<People>()
            {
                new People(){ Name = "Hector", Country = "mexico" },
                new People(){ Name = "Roberto", Country = "argentina" },
                new People(){ Name = "Ana", Country = "estados unidos" },
            };

            //Invocamos el metodo Show():
            Show(students);

            //Remuevo estudiantes de la lista de elementos:
            students.RemoveAt(0);

            Show(students);
        }

        //Creo una funcion que se llame show y que va a recibir un tipo listado peaople:
        static void Show(List<People> students) 
        {
            Console.WriteLine("-- Personas --");
            foreach (var student in students)
            {
                Console.WriteLine($"Nombre: {student.Name}, Pais: {student.Country}");
            }
        }

    }
    //foreach con clases:
    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
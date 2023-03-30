using System;

namespace ExcepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Beer beer = new Beer()
                {
                    Name = "London Porter",
                    //Brand = "Fuller's"
                };
                Console.WriteLine(beer);
            }catch (InvalidBeerException ex) // (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        //Creo la clase cerveza
        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }

            //voy a sobrescribir el metodo toString (este metodo existe para todas las clases ya que todas las clases heredan directamente de Object):
            public override string ToString()
            {
                //si no hubiera nombre o marca quiero que tire un error:
                if (Name == null || Brand == null)
                    throw new InvalidBeerException(); //Exception(); // esto crea una excepcion general
                return $"Cerveza: {Name}, Brand: {Brand}";
            }
        }

        public class InvalidBeerException : Exception //hereda de la clse general exception
        {
            //creo el constructor
            public InvalidBeerException() : base("La cerveza no tiene nombre o marca, por lo tanto es invalida") //hago que invoque el metodo del padre
            {

            }
        }
    }
}
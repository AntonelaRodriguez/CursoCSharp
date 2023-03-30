using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args) 
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburosin", 56),
                new Shark("Jaws", 65)
            };

            IFish[] fishes = new IFish[]
            {
                new Siren(100),
                new Shark("Tiburones", 56)
            };

            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fishes);

        }

        public class Siren: IFish
        {
            public int Speed { get; set; }
            public Siren(int Speed)
            {
                this.Speed = Speed;
            }
            public string Swim()
            {
                return $"La sirena nada a {Speed}km/h";
            }
        }

        public static void ShowAnimals(IAnimal[] animals)
        {
            Console.WriteLine("- Mostramos los animales -");
            int i = 0;
            while(i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }

        public static void ShowFish(IFish[] fishes)
        {
            Console.WriteLine("- Mostrar los pescados");
            int i = 0;
            while(i < fishes.Length)
            {
                Console.WriteLine(fishes[i].Swim());
                i++;
            }
        }
    }

    public class Shark : IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }
        public string Swim()
        {
            return $"{Name} nada {Speed}km/h";
        }
    }
    public interface IAnimal
        {
            public string Name { get; set; }
        }

    public interface IFish
        {
            public int Speed { get; set; }
            public string Swim();
        }
    
}
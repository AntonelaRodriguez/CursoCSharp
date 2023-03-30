using System;

namespace SentencialElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool haveMoney = true;

            if (areYouHungry && haveMoney && isOpenRes("Lonches pepe", 7))
            {
                Console.WriteLine("Come");
            }
            else
            {
                Console.WriteLine("No comes");
            }
        }

        static bool isOpenRes(string name, int hour = 0)
        {
            if(name == "Lonches pepe" && hour > 8 && hour < 22)
            {
                return true;
            }
            else if(name == "Restaurant 24 hour")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
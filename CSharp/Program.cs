using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            if (userEnteredANumber)
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. {0} set as temperature.", numTemp);
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }
            else if (numTemp > 30)
            {
                Console.WriteLine("It's super hot!");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }
    }
}

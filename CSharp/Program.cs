using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3: {0}.", number);
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7: {0}.", number);
            }
            else
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("Odd number: {0}.", number);
                } else
                {
                    Console.WriteLine("Even number: {0}.", number);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number?");
            string inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int number);

            NestedCheck(number);

            Console.Read();
        }
    }
}

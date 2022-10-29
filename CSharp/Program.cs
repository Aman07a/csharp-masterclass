using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        public static void Check(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even: {0}", number);
            }
            else
            {
                Console.WriteLine("Odd: {0}", number);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number?");
            string inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int number);
            Check(number);

            Console.Read();
        }
    }
}

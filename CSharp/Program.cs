using System;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring mutiple variables at once
            int num3, num4, num5;

            // Declaring a variable
            int num1;

            // Assigning a value a variable
            num1 = 13;

            // Declaring and initializing a variable in one go
            int num2 = 23;
            num2 = 100;

            // Using concatination
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            double d1 = 3.1425;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1425f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 is " + dIDiv);

            Console.Read();
        }
    }
}

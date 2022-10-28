using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        // Constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        // Create a constant of type string with your birthday as its value
        // Using Birthday Generator
        const string birthday = "12.21.1996";
        const string birthday2 = "09.15.1997";
        const string birthday3 = "1997-03-17";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.ReadKey();
        }
    }
}

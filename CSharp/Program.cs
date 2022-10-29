using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int age = 25;

            // Switch Statement
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too youn to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            // If Else Statement (age)
            if (age == 15)
            {
                Console.WriteLine("Too youn to party in the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "admin";

            // If Else Statement (username)
            switch (username)
            {
                case "admin":
                    Console.WriteLine("Username is Admin");
                    break;
                case "user":
                    Console.WriteLine("Username is User");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }

            Console.Read();
        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Abe";
            string friend2 = "Jody";
            string friend3 = "Cory";

            GreetFriend(friend1, friend2, friend3);

            Console.Read();
        }

        public static void GreetFriend(string friendName, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
            Console.WriteLine("Hi " + friendName2 + ", my friend!");
            Console.WriteLine("Hi " + friendName3 + ", my friend!");
        }
    }
}

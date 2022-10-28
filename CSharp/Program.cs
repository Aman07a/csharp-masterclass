using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            // Read first input string.
            string input = Console.ReadLine();

            Console.WriteLine("Enter a Character to search: ");
            // Read the character input search.
            char searchInput = Console.ReadLine()[0];

            // Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            // Prints the Index as a search result on console.
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.Write("Enter first name: ");
            // Read the first name.
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            // Read the last name.
            string lastName = Console.ReadLine();

            // Concatinate the firstName and lastName variable and assign that to fullName variable.
            string fullNmae = string.Concat(firstName, " ", lastName);
            // Prints the full name on the console.
            Console.WriteLine("Your full name is {0}", fullNmae);

            Console.ReadKey();
        }
    }
}

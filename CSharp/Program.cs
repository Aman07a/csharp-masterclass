using System;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Admin";

            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define few variables
            int age = 22;
            string name = "Admin";
            string job = "Developer";

            // 1. String concatenation
            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");

            // 2. String formatting
            // String formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I'm a {2}.", name, age, job);

            // 3. String interpolation
            // String interpolation uses $ at the start
            // which will allow us to write our variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.");

            // 4. Verbatim strings
            // Verbatim strings start with @ and tells the compiler to take the string literally
            // and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, " +
            "consectetur adipiscing elit,\n" +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\n" +
            "Lacus laoreet non curabitur gravida arcu ac.\n" +
            "Posuere lorem ipsum dolor sit amet consectetur adipiscing elit.\n");

            Console.Read();
        }
    }
}

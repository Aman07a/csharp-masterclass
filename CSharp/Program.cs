using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;

            Console.WriteLine("Enter a value: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.WriteLine("Enter: ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    // Check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int redValue = 0;
                    // Check for integer
                    valid = int.TryParse(inputValue, out redValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool redFlag = false;
                    // Check for boolean
                    valid = bool.TryParse(inputValue, out redFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "Unknown";
                    Console.WriteLine("Not able to detect the input type, something is wrong");
                    break;
            }

            Console.WriteLine("You have entered a value: {0}", inputValue);

            if(valid)
            {
                Console.WriteLine("It is valid: {0}", inputValueType);
            } else
            {
                Console.WriteLine("It is invalid: {0}", inputValueType);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Function to check if the input string is valid string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ///
        // H3LLO W0RLD

        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

}

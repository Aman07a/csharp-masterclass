using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();

            // Example 1: Exercise: Parsing
/*            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float stringToFloat = float.Parse(stringForFloat);
            int stringToInt = int.Parse(stringForInt);

            Console.WriteLine("Float = {0}, Int = {1}", stringToFloat, stringToInt);
            Console.WriteLine(stringToFloat);
            Console.WriteLine(stringToInt);
            Console.Read();*/
        }
    }
}

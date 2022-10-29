using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // Takes input from console
            Console.WriteLine("Enter the current temperature: ");
            inputValue = Console.ReadLine();

            // Validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {
                // If is valid integer then it will check for the conditions using nested ternary operator
                temperatureMessage = inputTemperature <= 15 ?
                // True
                    "it is too cold here" :
                // False
                (inputTemperature >= 16 && inputTemperature <= 28) ?
                // True
                    "it is cold here" :
                // False
                inputTemperature > 28 ?
                // True
                    "it is hot here" :
                // False
                "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                // In case if the input value is not a valid temperature
                Console.WriteLine("Not a valid Temperature");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // [condition] ? [first expression] : [second expression]
            // Condition has to be either true or false

            // The conditional Operator is right-associative
            // That means, that a ? b : c ? d : e
            // Is evaluated as a ? b : (c ? d : e)

            // The conditional Operator cannot be overloaded.

            // In celcius
            // Play around with that Value
            int temperature = -5;

            // Our result
            string stateOfMatter;

            // Is the Temperature below 0 Degree Celsius?
            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            // Is the Temperature higher than 100 Degree Celcius?
            else if (temperature > 100)
            {
                stateOfMatter = "gas";
            }
            // In all other Cases it must be liquid.
            else
            {
                stateOfMatter = "liquid";
            }

            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            temperature += 30;

            // The same result can be achieved by this
            // The enhanced Version of the If-Else-Statement from above
            stateOfMatter = temperature > 100 ? "gas" : (temperature < 0 ? "solid" : "liquid");

            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            // To make sure the Console keeps open
            Console.Read();
        }
    }
}

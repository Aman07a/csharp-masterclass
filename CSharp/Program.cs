using System;
using System.Runtime.CompilerServices;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add: " + Add(25, 13));
            Console.WriteLine("Substract: " + Substract(25, 13));
            Console.WriteLine("Multiply: " + Multiply(25, 13));
            Console.WriteLine("Devide: " + Devide(25, 13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

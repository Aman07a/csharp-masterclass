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
        static int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("\n This is our 2D array printed using nested for loop");

            // Nested for loop
            // Outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Inner for loop
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i == j)
                        matrix[i, j] = 1;
                    else
                        Console.WriteLine(" ");
                }
                Console.WriteLine("");
            }

            foreach (int item in matrix)
            {
                Console.WriteLine(item + " ");
            }*/
        }
    }
}

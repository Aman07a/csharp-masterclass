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
            Run();
        }

        public static void GetOdd(int[] Array)
        {
            // TODO
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 !=0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            // TODO
            foreach (int value in Array)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            Console.WriteLine("---------");
            GetEven(array);

        }
    }
}

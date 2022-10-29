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
            Run();
        }

        public static void ForLoop()
        {
            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            int i = 3;
            while (i > -4)
            {
                Console.WriteLine(i--);
            }
        }

        public static void Run()
        {
            WhileLoop();
            ForLoop();

        }
    }
}

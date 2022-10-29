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
            for (int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }
            Console.Read();
        }
    }
}

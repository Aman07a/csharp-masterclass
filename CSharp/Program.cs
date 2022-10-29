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

        public static void Run()
        {
            int i = -10;

            while (true)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                    break;
                if (i % 6 == 0)
                {
                    break;
                }
                Console.WriteLine(i++);
            }
        }
    }
}

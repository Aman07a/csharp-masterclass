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
            Human sissy = new Human("Sissy", "Wagner");
            sissy.IntroduceMyself();

            Console.ReadKey();
        }
    }
}

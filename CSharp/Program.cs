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
            Human denis = new Human(29, "Denis", "Panjuta", "green");
            Human james = new Human(25, "James", "Bond", "blue");
            denis.IntroduceOnceself();
            james.IntroduceOnceself();
            Console.Read();
        }
    }
}

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
            Box box = new Box(5, 4, 10);

            Console.WriteLine("Volume is {0}", box.Volume);
            Console.WriteLine("Front surface of the box is {0}", box.FrontSurface);

            box.DisplayInfo();

            Console.Read();
        }
    }
}

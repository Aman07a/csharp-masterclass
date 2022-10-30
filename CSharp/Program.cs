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
            Box box = new Box(3, 4,5);

            Console.WriteLine("Old Box width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("New Box width is " + box.Width);
            Console.WriteLine("Box volume is " + box.Volume);

            box.DisplayInfo();

            Console.Read();
        }
    }
}

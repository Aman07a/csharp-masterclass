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
            Human denis = new Human("Denis", "Panjuta", "green", 29);
            denis.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blue");
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Human
    {
        // Member variables
        private int age;
        private string firstName;
        private string lastName;
        private string eyeColor;
        private bool isHuman = true;

        // Constructor
        public Human(int age, string firstName, string lastName, string eyeColor)
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // Member method
        public void IntroduceOnceself()
        {
            Console.WriteLine("Hi, I'm {0} {1} {2}", firstName, lastName, eyeColor);
        }
    }
}

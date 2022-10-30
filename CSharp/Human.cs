using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // This class is a blueprint for a datatype 

    // Create a public variable lastName of type string.
    // Change the IntroduceMyself method, so it tells the whole name.
    // Create two objects with full information about themself - firstName and lastName

    internal class Human
    {
        // Member variable
        public string firstName;
        public string lastName;

        // Constructor
        public Human(string myFirstName, string lastName)
        {
            firstName = myFirstName;
            this.lastName = lastName;

        }

        // Member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}

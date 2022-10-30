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
            /*int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k); counter++;
            }*/

            string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };

            foreach (string name in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend.", name);
            }

            Console.ReadKey();
        }
    }
}

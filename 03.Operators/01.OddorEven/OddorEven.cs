using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Checking a number if it is even or odd.");
            int number;
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even!");
            }
            else
            {
                Console.WriteLine("The number is odd!");
            }
            Console.WriteLine("\n\n");
        }
    }
}

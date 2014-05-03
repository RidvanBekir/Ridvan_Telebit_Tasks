using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name of the digit.");
            Console.Write("Enter a number in the interval [0,10]:");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 10: Console.WriteLine("Ten"); break;
                default: Console.WriteLine("You have entered an invalid number"); break;
            }
            Console.WriteLine("\n\n");
        }
    }
}

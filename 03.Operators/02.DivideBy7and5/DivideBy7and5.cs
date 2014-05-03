using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideBy7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.Checking a number if it can be divided by 7 and 5.");
            Console.Write("Enter a number:");
            int number1;
            bool a = true;
            bool b = false;
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Can it be divided:");
            if (number1 % 7 == 0)
            {
                if (number1 % 5 == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("\n\n");
        }
    }
}

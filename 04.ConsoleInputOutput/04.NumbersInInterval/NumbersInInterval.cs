using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersInInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers in interval that divide by 5.");
            Console.Write("Enter a number for the beginning of the interval:");
            int begin = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for the end of the interval:");
            int end = int.Parse(Console.ReadLine());
            int counter = 0;
            if (begin >= end)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = begin; i <= end; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter = counter + 1;
                    }
                }
                Console.WriteLine("The number of numerals in the interval that are divided by 5 are:{0}", counter);
            }
            Console.WriteLine("\n\n");
        }
    }
}
